using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakalarska_Práca
{
    public partial class Main : Form
    {
        Console con;
        Server server;
        GameControls gamecontrols;
        ImageProcessing imageprocessing;
        ServerSettings serversettings;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Upgrade();
            
            con = new Console();
            con.Show();

            CameraPick();

            serversettings = new ServerSettings();
            
            server = new Server(con);
            server.Show();

            gamecontrols = new GameControls(server, con);
            gamecontrols.Show();
            
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con.WindowState == FormWindowState.Minimized)
            {
                con.WindowState = FormWindowState.Normal;
                con.ShowInTaskbar = true;
            }
            else
            {
                con.Select();
            }
        }

        private void serverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (server.WindowState == FormWindowState.Minimized)
            {
                server.WindowState = FormWindowState.Normal;
                server.ShowInTaskbar = true;
            }
            else
            {

                server.Select();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gameControllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gamecontrols.WindowState == FormWindowState.Minimized)
            {
                gamecontrols.WindowState = FormWindowState.Normal;
                gamecontrols.ShowInTaskbar = true;
            }
            else
            {
                gamecontrols.Select();
            }
        }

        private void imageProccesingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(imageprocessing == null)
            {
                return;
            }
            if (imageprocessing.WindowState == FormWindowState.Minimized)
            {
                imageprocessing.WindowState = FormWindowState.Normal;
                imageprocessing.ShowInTaskbar = true;
            }
            else
            {
                imageprocessing.Select();
            }
        }

        private void serverToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            serversettings.Show();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageprocessing.WindowState = FormWindowState.Normal;
            gamecontrols.WindowState = FormWindowState.Normal;
            server.WindowState = FormWindowState.Normal;
            con.WindowState = FormWindowState.Normal;
            imageprocessing.ShowInTaskbar = true;
            gamecontrols.ShowInTaskbar = true;
            server.ShowInTaskbar = true;
            con.ShowInTaskbar = true;
            imageprocessing.Select();
            gamecontrols.Select();
            server.Select();
            con.Select();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //poslat unity sporavu o ukonceni spojenia
        }

        private void cameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(imageprocessing != null)
            {
                if(MessageBox.Show("Image Processing will stop while we choose camera.","Warning",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    imageprocessing.Close();
                }
                else
                {
                    return;
                }
            }
            CameraPick camerapick = new CameraPick(this);
            camerapick.Show();
        }

        public void CameraPick()
        {
            if (Properties.Settings.Default.SaveCamera)
            {
                ImageProccessingStart();
            }
            else
            {
                CameraPick camerapick = new CameraPick(this);
                camerapick.Show();
            }
        }

        public void ImageProccessingStart()
        {
            imageprocessing = new ImageProcessing(Properties.Settings.Default.Camera, this, con);
            imageprocessing.Show();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageprocessing.WindowState = FormWindowState.Minimized;
            gamecontrols.WindowState = FormWindowState.Minimized;
            server.WindowState = FormWindowState.Minimized;
            con.WindowState = FormWindowState.Minimized;
            imageprocessing.ShowInTaskbar = false;
            gamecontrols.ShowInTaskbar = false;
            server.ShowInTaskbar = false;
            con.ShowInTaskbar = false;
        }
    }
}
