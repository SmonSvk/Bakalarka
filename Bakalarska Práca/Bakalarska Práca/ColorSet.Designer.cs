namespace Bakalarska_Práca
{
    partial class ColorSet
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
            this.BluePanel = new System.Windows.Forms.Panel();
            this.BlueTrackBar = new System.Windows.Forms.TrackBar();
            this.GreenPanel = new System.Windows.Forms.Panel();
            this.GreenTrackBar = new System.Windows.Forms.TrackBar();
            this.RedPanel = new System.Windows.Forms.Panel();
            this.RedTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BlueButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.RedLable = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.BluePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).BeginInit();
            this.GreenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).BeginInit();
            this.RedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BluePanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.GreenPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RedPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 218);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BluePanel
            // 
            this.BluePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BluePanel.Controls.Add(this.BlueLabel);
            this.BluePanel.Controls.Add(this.BlueTrackBar);
            this.BluePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BluePanel.Location = new System.Drawing.Point(3, 97);
            this.BluePanel.Name = "BluePanel";
            this.BluePanel.Size = new System.Drawing.Size(486, 41);
            this.BluePanel.TabIndex = 2;
            // 
            // BlueTrackBar
            // 
            this.BlueTrackBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BlueTrackBar.Location = new System.Drawing.Point(0, 0);
            this.BlueTrackBar.Maximum = 255;
            this.BlueTrackBar.Name = "BlueTrackBar";
            this.BlueTrackBar.Size = new System.Drawing.Size(408, 41);
            this.BlueTrackBar.TabIndex = 1;
            this.BlueTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueTrackBar.Scroll += new System.EventHandler(this.BlueTrackBar_Scroll);
            // 
            // GreenPanel
            // 
            this.GreenPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GreenPanel.Controls.Add(this.GreenLabel);
            this.GreenPanel.Controls.Add(this.GreenTrackBar);
            this.GreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GreenPanel.Location = new System.Drawing.Point(3, 50);
            this.GreenPanel.Name = "GreenPanel";
            this.GreenPanel.Size = new System.Drawing.Size(486, 41);
            this.GreenPanel.TabIndex = 1;
            // 
            // GreenTrackBar
            // 
            this.GreenTrackBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.GreenTrackBar.Location = new System.Drawing.Point(0, 0);
            this.GreenTrackBar.Maximum = 255;
            this.GreenTrackBar.Name = "GreenTrackBar";
            this.GreenTrackBar.Size = new System.Drawing.Size(408, 41);
            this.GreenTrackBar.TabIndex = 1;
            this.GreenTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenTrackBar.Scroll += new System.EventHandler(this.GreenTrackBar_Scroll);
            // 
            // RedPanel
            // 
            this.RedPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RedPanel.Controls.Add(this.RedLable);
            this.RedPanel.Controls.Add(this.RedTrackBar);
            this.RedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedPanel.Location = new System.Drawing.Point(3, 3);
            this.RedPanel.Name = "RedPanel";
            this.RedPanel.Size = new System.Drawing.Size(486, 41);
            this.RedPanel.TabIndex = 0;
            // 
            // RedTrackBar
            // 
            this.RedTrackBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.RedTrackBar.LargeChange = 255;
            this.RedTrackBar.Location = new System.Drawing.Point(0, 0);
            this.RedTrackBar.Maximum = 255;
            this.RedTrackBar.Name = "RedTrackBar";
            this.RedTrackBar.Size = new System.Drawing.Size(408, 41);
            this.RedTrackBar.SmallChange = 255;
            this.RedTrackBar.TabIndex = 0;
            this.RedTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedTrackBar.Scroll += new System.EventHandler(this.RedTrackBar_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BlueButton);
            this.groupBox1.Controls.Add(this.ApplyButton);
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.GreenButton);
            this.groupBox1.Controls.Add(this.RedButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // BlueButton
            // 
            this.BlueButton.AutoSize = true;
            this.BlueButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BlueButton.Location = new System.Drawing.Point(144, 18);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BlueButton.Size = new System.Drawing.Size(75, 50);
            this.BlueButton.TabIndex = 8;
            this.BlueButton.Text = "Blue";
            this.BlueButton.UseVisualStyleBackColor = true;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ApplyButton.Location = new System.Drawing.Point(333, 18);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 50);
            this.ApplyButton.TabIndex = 6;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelButton.Location = new System.Drawing.Point(408, 18);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 50);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.AutoSize = true;
            this.GreenButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.GreenButton.Location = new System.Drawing.Point(69, 18);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(75, 50);
            this.GreenButton.TabIndex = 1;
            this.GreenButton.Text = "Green";
            this.GreenButton.UseVisualStyleBackColor = true;
            // 
            // RedButton
            // 
            this.RedButton.AutoSize = true;
            this.RedButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RedButton.Location = new System.Drawing.Point(3, 18);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(66, 50);
            this.RedButton.TabIndex = 0;
            this.RedButton.Text = "Red";
            this.RedButton.UseVisualStyleBackColor = true;
            // 
            // RedLable
            // 
            this.RedLable.AutoSize = true;
            this.RedLable.Dock = System.Windows.Forms.DockStyle.Right;
            this.RedLable.Location = new System.Drawing.Point(440, 0);
            this.RedLable.Name = "RedLable";
            this.RedLable.Size = new System.Drawing.Size(46, 17);
            this.RedLable.TabIndex = 1;
            this.RedLable.Text = "label1";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.GreenLabel.Location = new System.Drawing.Point(440, 0);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(46, 17);
            this.GreenLabel.TabIndex = 2;
            this.GreenLabel.Text = "label2";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BlueLabel.Location = new System.Drawing.Point(440, 0);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(46, 17);
            this.BlueLabel.TabIndex = 2;
            this.BlueLabel.Text = "label3";
            // 
            // ColorSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 218);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "ColorSet";
            this.Text = "ColorSet";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ColorSet_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.BluePanel.ResumeLayout(false);
            this.BluePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).EndInit();
            this.GreenPanel.ResumeLayout(false);
            this.GreenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).EndInit();
            this.RedPanel.ResumeLayout(false);
            this.RedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel BluePanel;
        private System.Windows.Forms.TrackBar BlueTrackBar;
        private System.Windows.Forms.Panel GreenPanel;
        private System.Windows.Forms.TrackBar GreenTrackBar;
        private System.Windows.Forms.Panel RedPanel;
        private System.Windows.Forms.TrackBar RedTrackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label RedLable;
    }
}