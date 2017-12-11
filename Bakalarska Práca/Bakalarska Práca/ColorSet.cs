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
using Emgu.CV.Structure;

namespace Bakalarska_Práca
{
    public partial class ColorSet : Form
    {
        ImageProcessing imageprocessing;
        Bgr red, green, blue, final;

        public ColorSet(ImageProcessing imageprocessing)
        {
            InitializeComponent();
            this.imageprocessing = imageprocessing;
        }
        private void ColorSet_Load(object sender, EventArgs e)
        {
            red = new Bgr(0, 0, 0);
            green = new Bgr(0, 0, 0);
            blue = new Bgr(0, 0, 0);
        }

        private void GreenTrackBar_Scroll(object sender, EventArgs e)
        {
            green.Green = GreenTrackBar.Value;
            GreenPanel.BackColor = Color.FromArgb(0, (int)green.Green, 0);
            final = new Bgr(blue.Blue, green.Green, red.Red);
            GreenLabel.Text = GreenTrackBar.Value.ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            imageprocessing.colorDetect = final;
        }

        private void RedTrackBar_Scroll(object sender, EventArgs e)
        {
            red.Red = RedTrackBar.Value;
            RedPanel.BackColor = Color.FromArgb((int)red.Red, 0, 0);
            final = new Bgr(blue.Blue, green.Green, red.Red);
            RedLable.Text = RedTrackBar.Value.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }


        private void BlueTrackBar_Scroll(object sender, EventArgs e)
        {
            blue.Blue = BlueTrackBar.Value;
            BluePanel.BackColor = System.Drawing.Color.FromArgb(0 , 0, (int)blue.Blue);
            final = new Bgr(blue.Blue, green.Green, red.Red);
            BlueLabel.Text = BlueTrackBar.Value.ToString();
        }
    }
}
