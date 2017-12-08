using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Bakalarska_Práca
{
    public partial class ServerSettings : Form
    {

        public ServerSettings()
        {
            InitializeComponent();
        }
        
        private void okbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want change port number? You need change port number in game too.", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Properties.Settings.Default.Port = (int)portnumber.Value;
                Properties.Settings.Default.Save();
                if(MessageBox.Show("New port will apply after restart. Do you want restart program now?", "Restart", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Restart();
                }
                Close();
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ServerSettings_Load(object sender, EventArgs e)
        {
            portnumber.Value = Properties.Settings.Default.Port;
        }
    }
}
