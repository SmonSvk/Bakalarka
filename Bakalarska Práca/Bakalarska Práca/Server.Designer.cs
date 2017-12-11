namespace Bakalarska_Práca
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Textbox = new System.Windows.Forms.RichTextBox();
            this.ControlGroup = new System.Windows.Forms.GroupBox();
            this.Pause = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Reconnect = new System.Windows.Forms.Button();
            this.StatsGroup = new System.Windows.Forms.GroupBox();
            this.IpAdressLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.receivingTimer = new System.Windows.Forms.Timer(this.components);
            this.WaitingTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.ControlGroup.SuspendLayout();
            this.StatsGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Textbox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ControlGroup, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.StatsGroup, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.5955F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.80899F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.5955F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(639, 314);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Textbox
            // 
            this.Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Textbox.Location = new System.Drawing.Point(3, 98);
            this.Textbox.Name = "Textbox";
            this.Textbox.ReadOnly = true;
            this.Textbox.Size = new System.Drawing.Size(633, 145);
            this.Textbox.TabIndex = 0;
            this.Textbox.Text = "";
            this.Textbox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ControlGroup
            // 
            this.ControlGroup.Controls.Add(this.Pause);
            this.ControlGroup.Controls.Add(this.Closebutton);
            this.ControlGroup.Controls.Add(this.Disconnect);
            this.ControlGroup.Controls.Add(this.Reconnect);
            this.ControlGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlGroup.Location = new System.Drawing.Point(3, 249);
            this.ControlGroup.Name = "ControlGroup";
            this.ControlGroup.Size = new System.Drawing.Size(633, 62);
            this.ControlGroup.TabIndex = 1;
            this.ControlGroup.TabStop = false;
            this.ControlGroup.Text = "Controls";
            // 
            // Pause
            // 
            this.Pause.AutoSize = true;
            this.Pause.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pause.Location = new System.Drawing.Point(480, 18);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 41);
            this.Pause.TabIndex = 3;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.AutoSize = true;
            this.Closebutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Closebutton.Location = new System.Drawing.Point(555, 18);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(75, 41);
            this.Closebutton.TabIndex = 2;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Close_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.AutoSize = true;
            this.Disconnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.Disconnect.Location = new System.Drawing.Point(89, 18);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(88, 41);
            this.Disconnect.TabIndex = 1;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Reconnect
            // 
            this.Reconnect.AutoSize = true;
            this.Reconnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.Reconnect.Location = new System.Drawing.Point(3, 18);
            this.Reconnect.Name = "Reconnect";
            this.Reconnect.Size = new System.Drawing.Size(86, 41);
            this.Reconnect.TabIndex = 0;
            this.Reconnect.Text = "Reconnect";
            this.Reconnect.UseVisualStyleBackColor = true;
            this.Reconnect.Click += new System.EventHandler(this.Reconnect_Click);
            // 
            // StatsGroup
            // 
            this.StatsGroup.Controls.Add(this.IpAdressLabel);
            this.StatsGroup.Controls.Add(this.PortLabel);
            this.StatsGroup.Controls.Add(this.StatusLabel);
            this.StatsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatsGroup.Location = new System.Drawing.Point(3, 31);
            this.StatsGroup.Name = "StatsGroup";
            this.StatsGroup.Size = new System.Drawing.Size(633, 61);
            this.StatsGroup.TabIndex = 2;
            this.StatsGroup.TabStop = false;
            this.StatsGroup.Text = "Status";
            // 
            // IpAdressLabel
            // 
            this.IpAdressLabel.AutoSize = true;
            this.IpAdressLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.IpAdressLabel.Location = new System.Drawing.Point(357, 18);
            this.IpAdressLabel.Name = "IpAdressLabel";
            this.IpAdressLabel.Size = new System.Drawing.Size(132, 17);
            this.IpAdressLabel.TabIndex = 2;
            this.IpAdressLabel.Text = "IP Address: X.X.X.X";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PortLabel.Location = new System.Drawing.Point(489, 18);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(65, 17);
            this.PortLabel.TabIndex = 1;
            this.PortLabel.Text = "Port:XXX";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.StatusLabel.Location = new System.Drawing.Point(554, 18);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(76, 17);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Connected";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(21, 24);
            this.toolStripMenuItem1.Text = "‬";
            // 
            // receivingTimer
            // 
            this.receivingTimer.Interval = 50;
            this.receivingTimer.Tick += new System.EventHandler(this.receivingTimer_Tick);
            // 
            // WaitingTimer
            // 
            this.WaitingTimer.Interval = 500;
            this.WaitingTimer.Tick += new System.EventHandler(this.WaitingTimer_Tick);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 314);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Server";
            this.ShowInTaskbar = false;
            this.Text = "Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.Load += new System.EventHandler(this.Server_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ControlGroup.ResumeLayout(false);
            this.ControlGroup.PerformLayout();
            this.StatsGroup.ResumeLayout(false);
            this.StatsGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox Textbox;
        private System.Windows.Forms.GroupBox ControlGroup;
        private System.Windows.Forms.GroupBox StatsGroup;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Reconnect;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label IpAdressLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Timer receivingTimer;
        private System.Windows.Forms.Timer WaitingTimer;
    }
}