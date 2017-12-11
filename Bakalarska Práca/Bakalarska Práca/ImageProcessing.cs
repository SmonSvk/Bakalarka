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
        CvBlobDetector detect;
        CvBlobs blops;
        ColorSet colorset;
        public Bgr colorDetect;

        public ImageProcessing(int CamIndex, Main main)
        {
            InitializeComponent();
            camindex = CamIndex;
            this.main = main;
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
            colorset = new ColorSet(this);

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
                Image<Bgr, byte> blopsimage = detect.DrawBlobs(frame.Convert<Gray, byte>(), blops, CvBlobDetector.BlobRenderType.Default, 1);
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
            BlopDetect();
        }

        private Image<Gray, byte> ColorDetect(Bgr start, Bgr stop)
        {
            return frame.InRange(start, stop);
        }

        private void BlopDetect()
        {
            detect.Detect(ColorDetect(colorDetect, new Bgr(255, 255, 255)), blops);
            Debug.WriteLine(blops.Count);
        }

        private void setColorForDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorset.Show();
        }
    }
}
