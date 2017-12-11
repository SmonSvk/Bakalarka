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
        Console con;
        Bgr redlow, greenlow, bluelow, redhigh, greenhigh, bluehigh, finallow, finalhigh;
        int tolerance;

        private void BlueTrackBarLow_Scroll(object sender, EventArgs e)
        {
            if (BlueTrackBarLow.Value > BlueTrackBarHigh.Value - tolerance)
            {
                BlueTrackBarLow.Value = BlueTrackBarHigh.Value;
            }

            bluelow.Blue = BlueTrackBarLow.Value;
            BlueLabelLow.Text = BlueTrackBarLow.Value.ToString();
        }

        private void RedTrackBarHigh_Scroll(object sender, EventArgs e)
        {

            if (RedTrackBarHigh.Value < RedTrackBarLow.Value + tolerance)
            {
                RedTrackBarHigh.Value = RedTrackBarLow.Value;
            }

            redhigh.Red = RedTrackBarHigh.Value;
            RedLabelHigh.Text = RedTrackBarHigh.Value.ToString();
        }

        private void GreenTrackBarHigh_Scroll(object sender, EventArgs e)
        {

            if (GreenTrackBarHigh.Value < GreenTrackBarLow.Value + tolerance)
            {
                GreenTrackBarHigh.Value = GreenTrackBarLow.Value;
            }

            greenhigh.Green = GreenTrackBarHigh.Value;
            GreenLabelHigh.Text = GreenTrackBarHigh.Value.ToString();
        }

        private void BlueTrackBarHigh_Scroll(object sender, EventArgs e)
        {

            if (BlueTrackBarHigh.Value < BlueTrackBarLow.Value + tolerance)
            {
                BlueTrackBarHigh.Value = BlueTrackBarLow.Value;
            }

            bluehigh.Blue = BlueTrackBarHigh.Value;
            BlueLabelHigh.Text = BlueTrackBarHigh.Value.ToString();
        }

        private void ToleranceTrackBar_Scroll(object sender, EventArgs e)
        {
            tolerance = ToleranceTrackBar.Value;
            ToleranceValueLabel.Text = tolerance.ToString();
        }

        private void GreenTrackBarLow_Scroll(object sender, EventArgs e)
        {
            if (GreenTrackBarLow.Value > GreenTrackBarHigh.Value - tolerance)
            {
                GreenTrackBarLow.Value = GreenTrackBarHigh.Value;
            }

            greenlow.Green = GreenTrackBarLow.Value;
            GreenLabelLow.Text = GreenTrackBarLow.Value.ToString();
        }

        private void RedTrackBarLow_Scroll(object sender, EventArgs e)
        {
            if (RedTrackBarLow.Value > RedTrackBarHigh.Value - tolerance)
            {
                RedTrackBarLow.Value = RedTrackBarHigh.Value;
            }

            redlow.Red = RedTrackBarLow.Value;
            RedLabelLow.Text = RedTrackBarLow.Value.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RedPanelLow.BackColor = Color.FromArgb((int)redlow.Red, 0, 0);
            GreenPanelLow.BackColor = Color.FromArgb(0, (int)greenlow.Green, 0);
            BluePanelLow.BackColor = Color.FromArgb(0, 0, (int)bluelow.Blue);

            RedPanelHigh.BackColor = Color.FromArgb((int)redhigh.Red, 0, 0);
            GreenPanelHigh.BackColor = Color.FromArgb(0, (int)greenhigh.Green, 0);
            BluePanelHigh.BackColor = Color.FromArgb(0, 0, (int)bluehigh.Blue);

            RedLabelLow.ForeColor = RedTrackBarLow.Value > 122 ? Color.Black : Color.White;
            GreenLabelLow.ForeColor = GreenTrackBarLow.Value > 122 ? Color.Black : Color.White;
            BlueLabelLow.ForeColor = BlueTrackBarLow.Value > 122 ? Color.Black : Color.White;

            RedLabelHigh.ForeColor = RedTrackBarHigh.Value > 122 ? Color.Black : Color.White;
            GreenLabelHigh.ForeColor = GreenTrackBarHigh.Value > 122 ? Color.Black : Color.White;
            BlueLabelHigh.ForeColor = BlueTrackBarHigh.Value > 122 ? Color.Black : Color.White;

            finallow = new Bgr(bluelow.Blue, greenlow.Green, redlow.Red);
            finalhigh = new Bgr(bluehigh.Blue, greenhigh.Green, redhigh.Red);
        }

        public ColorSet(ImageProcessing imageprocessing, Console con)
        {
            InitializeComponent();
            this.con = con;
            this.imageprocessing = imageprocessing;
        }
        private void ColorSet_Load(object sender, EventArgs e)
        {
            Reload();
        }
        
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColorLow = Color.FromArgb((int)finallow.Red, (int)finallow.Green, (int)finallow.Blue);
            Properties.Settings.Default.ColorHigh = Color.FromArgb((int)finalhigh.Red, (int)finalhigh.Green, (int)finalhigh.Blue);

            Properties.Settings.Default.Tolerance = tolerance;
            Properties.Settings.Default.Save();

            imageprocessing.ApplyColors();
        }
        
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public void Reload()
        {
            tolerance = Properties.Settings.Default.Tolerance;
            ToleranceValueLabel.Text = tolerance.ToString();
            ToleranceTrackBar.Value = tolerance;

            finallow = new Bgr(Properties.Settings.Default.ColorLow.B, Properties.Settings.Default.ColorLow.G, Properties.Settings.Default.ColorLow.R);
            finalhigh = new Bgr(Properties.Settings.Default.ColorHigh.B, Properties.Settings.Default.ColorHigh.G, Properties.Settings.Default.ColorHigh.R);

            RedTrackBarLow.Value = (int)finallow.Red;
            GreenTrackBarLow.Value = (int)finallow.Green;
            BlueTrackBarLow.Value = (int)finallow.Blue;

            RedTrackBarHigh.Value = (int)finalhigh.Red;
            GreenTrackBarHigh.Value = (int)finalhigh.Green;
            BlueTrackBarHigh.Value = (int)finalhigh.Blue;

            redlow = new Bgr(0, 0, finallow.Red);
            greenlow = new Bgr(0, finallow.Green, 0);
            bluelow = new Bgr(finallow.Blue, 0, 0);
            redhigh = new Bgr(0, 0, finalhigh.Red);
            greenhigh = new Bgr(0, finalhigh.Green, 0);
            bluehigh = new Bgr(finalhigh.Blue, 0, 0);

            RedLabelHigh.Text = redhigh.Red.ToString();
            GreenLabelHigh.Text = greenhigh.Green.ToString();
            BlueLabelHigh.Text = bluehigh.Blue.ToString();

            RedLabelLow.Text = redlow.Red.ToString();
            GreenLabelLow.Text = greenlow.Green.ToString();
            BlueLabelLow.Text = bluelow.Blue.ToString();
        }
        
    }
}
