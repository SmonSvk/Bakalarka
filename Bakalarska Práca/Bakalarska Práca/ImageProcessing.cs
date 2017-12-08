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

        public ImageProcessing(int CamIndex, Main main)
        {
            InitializeComponent();
            camindex = CamIndex;
            this.main = main;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ImageProcessing_Load(object sender, EventArgs e)
        {
            capture = new VideoCapture(camindex);
            if (!capture.IsOpened)
            {
                MessageBox.Show("Camera can't be find. Choose new camera.", "Error", MessageBoxButtons.OK);
                Properties.Settings.Default.SaveCamera = false;
                Properties.Settings.Default.Save();
                main.CameraPick();
                Close();

            }
            else
            {
                DrawTimer.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(WindowState != FormWindowState.Normal)
            {
                return;
            }
            frame = capture.QueryFrame().ToImage<Bgr, byte>();
            
            finalimage.Image = frame.Resize(finalimage.Width, finalimage.Height, Emgu.CV.CvEnum.Inter.Linear);
        }

        private void CameraCheck()
        {

        }
        
    }
}
