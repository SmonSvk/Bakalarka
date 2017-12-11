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
    public partial class GameControls : Form
    {
        Server server;
        Console con;

        public GameControls(Server server, Console con)
        {
            InitializeComponent();
            this.server = server;
            this.con = con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server.Send("StartGame");
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            server.Send("StopGame");
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            server.Send("StartGame");
            server.Send("StopGame");
        }

        public void Write(string text)
        {
            if (!con.GameControlCon)
                return;

            con.Write(text);
        }
        public void WriteLine(string text)
        {
            if (!con.GameControlCon)
                return;

            con.WriteLine(text);
        }
    }
}
