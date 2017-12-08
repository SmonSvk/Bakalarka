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
    public partial class CameraPick : Form
    {
        VideoCapture previewcapture;
        Main main;

        public CameraPick(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void CameraPick_Load(object sender, EventArgs e)
        {
            savepick.Checked = Properties.Settings.Default.SaveCamera;
            Scan();
        }

        private void previewbutton_Click(object sender, EventArgs e)
        {
            if(comboboxcameras.SelectedItem == null)
            {
                return;
            }

            if (previewcapture != null && previewcapture.IsOpened)
            {
                previewcapture.Dispose();
            }

            previewcapture = new VideoCapture(Int32.Parse(comboboxcameras.SelectedItem.ToString()));

            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image<Bgr, byte> image = previewcapture.QueryFrame().ToImage<Bgr, byte>();
            
            preview.Image = image.Resize(preview.Width, preview.Height, Emgu.CV.CvEnum.Inter.Linear);
        }

        private void Scan()
        {
            for (int x = 0; x < 100; x++)
            {
                VideoCapture capture = new VideoCapture(x);
                if (!capture.IsOpened)
                {
                    capture.Dispose();
                    comboboxcameras.SelectedIndex = 0;
                    break;
                }
                Debug.WriteLine(x + " works");
                capture.Dispose();
                comboboxcameras.Items.Add(x.ToString());
                
            }
        }

        private void rescanbutton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            preview.Image = null;
            Scan();
        }

        private void applybutton_Click(object sender, EventArgs e)
        {
            if (savepick.Checked)
            {
                if(MessageBox.Show("This camera will be used always you start this program. You can change camera in Setting -> Camera", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Properties.Settings.Default.Camera = Int32.Parse(comboboxcameras.SelectedItem.ToString());
                    Properties.Settings.Default.SaveCamera = true;
                    Properties.Settings.Default.Save();
                    Close();
                }
            }
            else
            {
                if (MessageBox.Show("You can change camera in Setting -> Camera", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Properties.Settings.Default.Camera = Int32.Parse(comboboxcameras.SelectedItem.ToString());
                    Properties.Settings.Default.SaveCamera = false;
                    Properties.Settings.Default.Save();
                    Close();
                }
            }

        }

        private void CameraPick_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previewcapture != null && previewcapture.IsOpened)
                previewcapture.Dispose();

            main.ImageProccessingStart();
            
        }
    }
}
