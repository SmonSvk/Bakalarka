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
using System.Net.Sockets;
using System.Threading;
using System.Net.NetworkInformation;

namespace Bakalarska_Práca
{
    public partial class Server : Form
    {
        bool scroll = true;
        Console con;

        TcpListener server;
        TcpClient client;
        string address = "localhost";
        int port = 15000, msglenght = 100;
        IPAddress ipaddress;
        byte[] bytemsg;
        StringBuilder msg;
        NetworkStream stream;
        ServerSettings settings;

        public Server(Console con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (scroll)
            {
                Textbox.ScrollToCaret();
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            scroll = !scroll;
        }

        private void Server_Load(object sender, EventArgs e)
        {
            settings = new ServerSettings();
            Init();
            Connect();
        }

        public void WriteLine(string text)
        {
            if (!con.ServerCon)
                return;

            con.WriteLine(text);
            Textbox.AppendText(text);
            Textbox.AppendText("\n"); 
        }

        private void WaitingTimer_Tick(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                WriteLine("Listening");
                receivingTimer.Start();
                WaitingTimer.Stop();
                return;
            }
            WriteLine("*-*");
        }

        private void receivingTimer_Tick(object sender, EventArgs e)
        {
            if (client == null || !client.Connected)
            {
                WriteLine("**Error: Client disconnected**");
                ReconnectFun();
                WaitingTimer.Start();
                receivingTimer.Stop();
                return;
            }

            if (stream.DataAvailable)
            {
                msg = new StringBuilder();
                bytemsg = new byte[msglenght];

                stream.Read(bytemsg, 0, msglenght);

                foreach (byte b in bytemsg)
                {
                    if (b.Equals('#'))
                    {
                        break;
                    }
                    else
                    {
                        msg.Append(Convert.ToChar(b).ToString());
                    }
                }
                WriteLine(msg.ToString());                
            }
        }

        public void Write(string text)
        {
            if (!con.ServerCon)
                return;

            con.Write(text);
            Textbox.AppendText(text);
        }

        private void Init()
        {
            port = Properties.Settings.Default.Port;
            ipaddress = Dns.GetHostEntry(address).AddressList[1];
            IpAdressLabel.Text = "Using IP address: " + ipaddress.MapToIPv4().ToString();
            WriteLine("Using IP address: " + ipaddress.MapToIPv4().ToString());

            PortLabel.Text = "Port: " + port.ToString();
            WriteLine("Using Port: " + port.ToString());

            if (!PortTest())
            {
                MessageBox.Show("Port is used. Please set another port.");
                settings.Show();
            }

            try
            {
                server = new TcpListener(ipaddress, port);
                WriteLine("Initializing Client");
                client = default(TcpClient);
                WriteLine("Server Start");
                server.Start();
            }
            catch (Exception ex)
            {
                WriteLine(ex.ToString());
                StatusLabel.Text = "Disconnected";
            }
        }

        private bool PortTest()
        {

            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
            {
                if (tcpi.LocalEndPoint.Port == port)
                {
                    return false;
                }
            }

            return true;
        }

        private void Connect()
        {
            try
            {
                WriteLine("Waiting for TCP connection from game");
                StatusLabel.Text = "Waiting for Connection";
                WaitingTimer.Start();
                BackgroundWorker connectwait = new BackgroundWorker();
                connectwait.DoWork += (object obj, DoWorkEventArgs e1) =>
                {
                    client = server.AcceptTcpClient();
                    stream = client.GetStream();
                };
                connectwait.RunWorkerCompleted += (obj, e1) =>
                {
                    WriteLine("Game Connected");
                    StatusLabel.Text = "Connected";
                };
                connectwait.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                WriteLine(ex.ToString());
                StatusLabel.Text = "Disconnected";
            }
        }

        private void Reconnect_Click(object sender, EventArgs e)
        {
            ReconnectFun();
            WriteLine("Reconnecting");
        }

        private void ReconnectFun()
        {
            DisconnectFun();
            try
            {
                WriteLine("Waiting for Game reconnect");
                StatusLabel.Text = "Waiting for Connection";
                WaitingTimer.Start();
                BackgroundWorker connectwait = new BackgroundWorker();
                connectwait.DoWork += (object obj, DoWorkEventArgs e1) =>
                {
                    client = server.AcceptTcpClient();
                    stream = client.GetStream();
                };
                connectwait.RunWorkerCompleted += (obj, e1) =>
                {
                    WriteLine("Game reconnected");
                    StatusLabel.Text = "Connected";
                };
                connectwait.RunWorkerAsync();
            }
            catch(Exception ex)
            {
                WriteLine(ex.ToString());
                StatusLabel.Text = "Disconnected";
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            DisconnectFun();
        }

        private void DisconnectFun()
        {
            if (client !=null && client.Connected)
            {
                stream.Close();
                client.Close();
                WriteLine("Disconnected");
            }
        }

        public bool Send(string text)
        {
            if(client==null || !client.Connected)
            {
                return false;
            }
            else
            {
                int lenght = Encoding.ASCII.GetByteCount(text + "#");

                bytemsg = new byte[lenght];

                bytemsg = Encoding.ASCII.GetBytes(text + "#");

                stream.Write(bytemsg, 0, lenght);

                WriteLine(text);
            }
            return true;
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            settings.Show();
        }        
    }
}
