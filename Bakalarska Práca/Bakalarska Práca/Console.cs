using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakalarska_Práca
{
    public partial class Console : Form
    {
        bool scroll = false;

        public bool ServerCon = true, ImageProcessingCon = true, GameControlCon = true;

        public Console()
        {
            InitializeComponent();
        }

        public void WriteLine(string text)
        {
            consoletext.AppendText(text);
            consoletext.AppendText("\n");
        }

        public void Write(string text)
        {
            consoletext.AppendText(text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            consoletext.Clear();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void consoletext_TextChanged(object sender, EventArgs e)
        {
            if (scroll)
            {
                consoletext.ScrollToCaret();
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            scroll = !scroll;
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            consoletext.Clear();
        }

        private void ImageProcessingCheck_CheckedChanged(object sender, EventArgs e)
        {
            ImageProcessingCon = ImageProcessingCheck.Checked;
        }

        private void GameControlCheck_CheckedChanged(object sender, EventArgs e)
        {
            GameControlCon = GameControlCheck.Checked;
        }

        private void Console_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void ServerCheck_CheckedChanged(object sender, EventArgs e)
        {
            ServerCon = ServerCheck.Checked;
        }
    }
}
