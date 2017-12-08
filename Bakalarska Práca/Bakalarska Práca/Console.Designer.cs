namespace Bakalarska_Práca
{
    partial class Console
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ControlsGroup = new System.Windows.Forms.GroupBox();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.consoletext = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.ControlsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ControlsGroup, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.consoletext, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.39189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.60811F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 296);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ControlsGroup
            // 
            this.ControlsGroup.Controls.Add(this.Closebutton);
            this.ControlsGroup.Controls.Add(this.Pause);
            this.ControlsGroup.Controls.Add(this.Clear);
            this.ControlsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsGroup.Location = new System.Drawing.Point(3, 237);
            this.ControlsGroup.Name = "ControlsGroup";
            this.ControlsGroup.Size = new System.Drawing.Size(524, 56);
            this.ControlsGroup.TabIndex = 0;
            this.ControlsGroup.TabStop = false;
            this.ControlsGroup.Text = "Controls";
            // 
            // Closebutton
            // 
            this.Closebutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Closebutton.Location = new System.Drawing.Point(446, 18);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(75, 35);
            this.Closebutton.TabIndex = 2;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Close_Click);
            // 
            // Pause
            // 
            this.Pause.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pause.Location = new System.Drawing.Point(78, 18);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 35);
            this.Pause.TabIndex = 1;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Clear
            // 
            this.Clear.Dock = System.Windows.Forms.DockStyle.Left;
            this.Clear.Location = new System.Drawing.Point(3, 18);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 35);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // consoletext
            // 
            this.consoletext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoletext.Location = new System.Drawing.Point(3, 3);
            this.consoletext.Name = "consoletext";
            this.consoletext.ReadOnly = true;
            this.consoletext.Size = new System.Drawing.Size(524, 228);
            this.consoletext.TabIndex = 1;
            this.consoletext.Text = "";
            this.consoletext.TextChanged += new System.EventHandler(this.consoletext_TextChanged);
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(530, 296);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Console";
            this.ShowInTaskbar = false;
            this.Text = "Console";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ControlsGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox ControlsGroup;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.RichTextBox consoletext;
        private System.Windows.Forms.Button Closebutton;
    }
}