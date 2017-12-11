using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Cvb;
using Emgu.Util;
using System.Diagnostics;
using Emgu.CV.Structure;

namespace Bakalarska_Práca
{
    public partial class ImageProcessing : Form
    {

        VideoCapture capture;
        int camindex;
        public Image<Bgr, byte> frame;
        Main main;
        Console con;
        CvBlobDetector detect;
        CvBlobs blops;
        ColorSet colorset;
        public Bgr ColorDetectLow, ColorDetectHigh;

        public ImageProcessing(int CamIndex, Main main, Console con)
        {
            InitializeComponent();
            camindex = CamIndex;
            this.main = main;
            this.con = con;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void ImageProcessing_Load(object sender, EventArgs e)
        {
            capture = new VideoCapture(camindex);
            detect = new CvBlobDetector();
            blops = new CvBlobs();
            colorset = new ColorSet(this, con);

            ColorDetectLow = new Bgr(Properties.Settings.Default.ColorLow.B, Properties.Settings.Default.ColorLow.G, Properties.Settings.Default.ColorLow.R);
            ColorDetectHigh = new Bgr(Properties.Settings.Default.ColorHigh.B, Properties.Settings.Default.ColorHigh.G, Properties.Settings.Default.ColorHigh.R);

            WriteLine("Load Saved Colors Low: " + ColorDetectLow.ToString() + " /High: " + ColorDetectHigh.ToString() + " Tolerance: " + Properties.Settings.Default.Tolerance);

            if (CameraCheck())
            {
                Processingtimer.Start();
                DrawTimer.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!CameraCheck())
            {
                return;
            }
                if (WindowState != FormWindowState.Normal)
            {
                return;
            }

            if (frame != null)
            {
                ImageforDetection.Image = frame.Resize(ImageforDetection.Width, ImageforDetection.Height, Emgu.CV.CvEnum.Inter.Linear);
                Image<Bgr, byte> blopsimage = detect.DrawBlobs(frame.Convert<Gray, byte>(), blops, CvBlobDetector.BlobRenderType.Color, 1);
                finalimage.Image = blopsimage.Resize(finalimage.Width, finalimage.Height, Emgu.CV.CvEnum.Inter.Linear);
            }
        }

        private bool CameraCheck()
        {
            if (!capture.IsOpened)
            {
                MessageBox.Show("Camera can't be find. Choose new camera.", "Error", MessageBoxButtons.OK);
                Properties.Settings.Default.SaveCamera = false;
                Properties.Settings.Default.Save();
                main.CameraPick();
                Close();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lowbutton_Click(object sender, EventArgs e)
        {
            DrawTimer.Interval = 500;
        }

        private void realbutton_Click(object sender, EventArgs e)
        {
            DrawTimer.Interval = 10;
        }

        private void Processingtimer_Tick(object sender, EventArgs e)
        {
            frame = capture.QueryFrame().ToImage<Bgr, byte>();
            ImageEdit();
            BlopDetect();
        }

        private void ImageEdit()
        {
            frame = frame.PyrDown().PyrUp();
        }

        private Image<Gray, byte> ColorDetect(Bgr start, Bgr stop)
        {
            return frame.InRange(start, stop);
        }

        private void BlopDetect()
        {
            detect.Detect(ColorDetect(ColorDetectLow, ColorDetectHigh), blops);
            //WriteLine("Blobs detected: " + blops.Count);
            Debug.WriteLine(blops.Count);
        }        

        private void ImageforDetection_MouseClick(object sender, MouseEventArgs e)
        {
            if (ImageforDetection.Image == null)
            {
                return;
            }
            
            Bgr pixel = frame.Resize(ImageforDetection.Width, ImageforDetection.Height, Emgu.CV.CvEnum.Inter.Linear)[e.Location.Y, e.Location.X];

            int tolerance = Properties.Settings.Default.Tolerance;

            Properties.Settings.Default.ColorLow = Color.FromArgb(
                (int)pixel.Red - tolerance >= 0 ? (int)pixel.Red - tolerance : 0,
                (int)pixel.Green - tolerance >= 0 ? (int)pixel.Green - tolerance : 0,
                (int)pixel.Blue - tolerance >= 0 ? (int)pixel.Blue - tolerance : 0
                );
            Properties.Settings.Default.ColorHigh = Color.FromArgb(
                (int)pixel.Red + tolerance <= 255 ? (int)pixel.Red + tolerance : 255, 
                (int)pixel.Green + tolerance <= 255 ? (int)pixel.Green + tolerance : 255, 
                (int)pixel.Blue + tolerance <= 255 ? (int)pixel.Blue + tolerance : 255
                );

            ColorDetectHigh = new Bgr(pixel.Blue + tolerance, pixel.Green + tolerance, pixel.Red + tolerance);
            ColorDetectLow = new Bgr(pixel.Blue - tolerance, pixel.Green - tolerance, pixel.Red - tolerance);

            WriteLine("Apply From Click on Image Low: " + ColorDetectLow.ToString() + " /High: " + ColorDetectHigh.ToString() + " Tolerance: " + Properties.Settings.Default.Tolerance);

            Properties.Settings.Default.Save();

            if (colorset.Visible)
            {
                colorset.Reload();
            }
            else
            {
                colorset.Show();
            }
        }

        private void setColorForDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorset.Show();
        }

        private void ImageProcessing_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        public void ApplyColors()
        {
            ColorDetectLow = new Bgr(Properties.Settings.Default.ColorLow.B, Properties.Settings.Default.ColorLow.G, Properties.Settings.Default.ColorLow.R);
            ColorDetectHigh = new Bgr(Properties.Settings.Default.ColorHigh.B, Properties.Settings.Default.ColorHigh.G, Properties.Settings.Default.ColorHigh.R);
            WriteLine("Apply From ColorSet Low: " + ColorDetectLow.ToString() + " /High: " + ColorDetectHigh.ToString() + " Tolerance: " + Properties.Settings.Default.Tolerance);
        }

        public void Write(string text)
        {
            if (!con.ImageProcessingCon)
                return;

            con.Write(text);
        }
        public void WriteLine(string text)
        {
            if (!con.ImageProcessingCon)
                return;

            con.WriteLine(text);
        }
    }
}
