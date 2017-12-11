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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ToleranceLabel = new System.Windows.Forms.Label();
            this.ToleranceTrackBar = new System.Windows.Forms.TrackBar();
            this.ToleranceValueLabel = new System.Windows.Forms.Label();
            this.BlueButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RedPanelLow = new System.Windows.Forms.Panel();
            this.RedLabelLow = new System.Windows.Forms.Label();
            this.RedTrackBarLow = new System.Windows.Forms.TrackBar();
            this.GreenPanelLow = new System.Windows.Forms.Panel();
            this.GreenLabelLow = new System.Windows.Forms.Label();
            this.GreenTrackBarLow = new System.Windows.Forms.TrackBar();
            this.BluePanelLow = new System.Windows.Forms.Panel();
            this.BlueLabelLow = new System.Windows.Forms.Label();
            this.BlueTrackBarLow = new System.Windows.Forms.TrackBar();
            this.BluePanelHigh = new System.Windows.Forms.Panel();
            this.BlueLabelHigh = new System.Windows.Forms.Label();
            this.BlueTrackBarHigh = new System.Windows.Forms.TrackBar();
            this.RedPanelHigh = new System.Windows.Forms.Panel();
            this.RedLabelHigh = new System.Windows.Forms.Label();
            this.RedTrackBarHigh = new System.Windows.Forms.TrackBar();
            this.GreenPanelHigh = new System.Windows.Forms.Panel();
            this.GreenLabelHigh = new System.Windows.Forms.Label();
            this.GreenTrackBarHigh = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToleranceTrackBar)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.RedPanelLow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBarLow)).BeginInit();
            this.GreenPanelLow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBarLow)).BeginInit();
            this.BluePanelLow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBarLow)).BeginInit();
            this.BluePanelHigh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBarHigh)).BeginInit();
            this.RedPanelHigh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBarHigh)).BeginInit();
            this.GreenPanelHigh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBarHigh)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 218);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToleranceLabel);
            this.groupBox1.Controls.Add(this.ToleranceTrackBar);
            this.groupBox1.Controls.Add(this.ToleranceValueLabel);
            this.groupBox1.Controls.Add(this.BlueButton);
            this.groupBox1.Controls.Add(this.ApplyButton);
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.GreenButton);
            this.groupBox1.Controls.Add(this.RedButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1011, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // ToleranceLabel
            // 
            this.ToleranceLabel.AutoSize = true;
            this.ToleranceLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToleranceLabel.Location = new System.Drawing.Point(617, 18);
            this.ToleranceLabel.Name = "ToleranceLabel";
            this.ToleranceLabel.Size = new System.Drawing.Size(72, 17);
            this.ToleranceLabel.TabIndex = 11;
            this.ToleranceLabel.Text = "Tolerance";
            // 
            // ToleranceTrackBar
            // 
            this.ToleranceTrackBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToleranceTrackBar.Location = new System.Drawing.Point(689, 18);
            this.ToleranceTrackBar.Maximum = 255;
            this.ToleranceTrackBar.Name = "ToleranceTrackBar";
            this.ToleranceTrackBar.Size = new System.Drawing.Size(123, 48);
            this.ToleranceTrackBar.TabIndex = 9;
            this.ToleranceTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ToleranceTrackBar.Scroll += new System.EventHandler(this.ToleranceTrackBar_Scroll);
            // 
            // ToleranceValueLabel
            // 
            this.ToleranceValueLabel.AutoSize = true;
            this.ToleranceValueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToleranceValueLabel.Location = new System.Drawing.Point(812, 18);
            this.ToleranceValueLabel.Name = "ToleranceValueLabel";
            this.ToleranceValueLabel.Size = new System.Drawing.Size(46, 17);
            this.ToleranceValueLabel.TabIndex = 10;
            this.ToleranceValueLabel.Text = "label1";
            // 
            // BlueButton
            // 
            this.BlueButton.AutoSize = true;
            this.BlueButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BlueButton.Location = new System.Drawing.Point(144, 18);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BlueButton.Size = new System.Drawing.Size(75, 48);
            this.BlueButton.TabIndex = 8;
            this.BlueButton.Text = "Blue";
            this.BlueButton.UseVisualStyleBackColor = true;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ApplyButton.Location = new System.Drawing.Point(858, 18);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 48);
            this.ApplyButton.TabIndex = 6;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelButton.Location = new System.Drawing.Point(933, 18);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 48);
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
            this.GreenButton.Size = new System.Drawing.Size(75, 48);
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
            this.RedButton.Size = new System.Drawing.Size(66, 48);
            this.RedButton.TabIndex = 0;
            this.RedButton.Text = "Red";
            this.RedButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.RedPanelLow, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.GreenPanelLow, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BluePanelLow, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BluePanelHigh, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.RedPanelHigh, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.GreenPanelHigh, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1011, 137);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // RedPanelLow
            // 
            this.RedPanelLow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RedPanelLow.Controls.Add(this.RedLabelLow);
            this.RedPanelLow.Controls.Add(this.RedTrackBarLow);
            this.RedPanelLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedPanelLow.Location = new System.Drawing.Point(3, 3);
            this.RedPanelLow.Name = "RedPanelLow";
            this.RedPanelLow.Size = new System.Drawing.Size(499, 39);
            this.RedPanelLow.TabIndex = 3;
            // 
            // RedLabelLow
            // 
            this.RedLabelLow.AutoSize = true;
            this.RedLabelLow.Dock = System.Windows.Forms.DockStyle.Right;
            this.RedLabelLow.Location = new System.Drawing.Point(453, 0);
            this.RedLabelLow.Name = "RedLabelLow";
            this.RedLabelLow.Size = new System.Drawing.Size(46, 17);
            this.RedLabelLow.TabIndex = 2;
            this.RedLabelLow.Text = "label3";
            // 
            // RedTrackBarLow
            // 
            this.RedTrackBarLow.Dock = System.Windows.Forms.DockStyle.Left;
            this.RedTrackBarLow.Location = new System.Drawing.Point(0, 0);
            this.RedTrackBarLow.Maximum = 255;
            this.RedTrackBarLow.Name = "RedTrackBarLow";
            this.RedTrackBarLow.Size = new System.Drawing.Size(408, 39);
            this.RedTrackBarLow.TabIndex = 1;
            this.RedTrackBarLow.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedTrackBarLow.Scroll += new System.EventHandler(this.RedTrackBarLow_Scroll);
            // 
            // GreenPanelLow
            // 
            this.GreenPanelLow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GreenPanelLow.Controls.Add(this.GreenLabelLow);
            this.GreenPanelLow.Controls.Add(this.GreenTrackBarLow);
            this.GreenPanelLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GreenPanelLow.Location = new System.Drawing.Point(3, 48);
            this.GreenPanelLow.Name = "GreenPanelLow";
            this.GreenPanelLow.Size = new System.Drawing.Size(499, 39);
            this.GreenPanelLow.TabIndex = 7;
            // 
            // GreenLabelLow
            // 
            this.GreenLabelLow.AutoSize = true;
            this.GreenLabelLow.Dock = System.Windows.Forms.DockStyle.Right;
            this.GreenLabelLow.Location = new System.Drawing.Point(453, 0);
            this.GreenLabelLow.Name = "GreenLabelLow";
            this.GreenLabelLow.Size = new System.Drawing.Size(46, 17);
            this.GreenLabelLow.TabIndex = 3;
            this.GreenLabelLow.Text = "label4";
            // 
            // GreenTrackBarLow
            // 
            this.GreenTrackBarLow.AutoSize = false;
            this.GreenTrackBarLow.Dock = System.Windows.Forms.DockStyle.Left;
            this.GreenTrackBarLow.Location = new System.Drawing.Point(0, 0);
            this.GreenTrackBarLow.Maximum = 255;
            this.GreenTrackBarLow.Name = "GreenTrackBarLow";
            this.GreenTrackBarLow.Size = new System.Drawing.Size(408, 39);
            this.GreenTrackBarLow.TabIndex = 2;
            this.GreenTrackBarLow.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenTrackBarLow.Scroll += new System.EventHandler(this.GreenTrackBarLow_Scroll);
            // 
            // BluePanelLow
            // 
            this.BluePanelLow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BluePanelLow.Controls.Add(this.BlueLabelLow);
            this.BluePanelLow.Controls.Add(this.BlueTrackBarLow);
            this.BluePanelLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BluePanelLow.Location = new System.Drawing.Point(3, 93);
            this.BluePanelLow.Name = "BluePanelLow";
            this.BluePanelLow.Size = new System.Drawing.Size(499, 41);
            this.BluePanelLow.TabIndex = 5;
            // 
            // BlueLabelLow
            // 
            this.BlueLabelLow.AutoSize = true;
            this.BlueLabelLow.Dock = System.Windows.Forms.DockStyle.Right;
            this.BlueLabelLow.Location = new System.Drawing.Point(453, 0);
            this.BlueLabelLow.Name = "BlueLabelLow";
            this.BlueLabelLow.Size = new System.Drawing.Size(46, 17);
            this.BlueLabelLow.TabIndex = 2;
            this.BlueLabelLow.Text = "label3";
            // 
            // BlueTrackBarLow
            // 
            this.BlueTrackBarLow.Dock = System.Windows.Forms.DockStyle.Left;
            this.BlueTrackBarLow.Location = new System.Drawing.Point(0, 0);
            this.BlueTrackBarLow.Maximum = 255;
            this.BlueTrackBarLow.Name = "BlueTrackBarLow";
            this.BlueTrackBarLow.Size = new System.Drawing.Size(408, 41);
            this.BlueTrackBarLow.TabIndex = 1;
            this.BlueTrackBarLow.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueTrackBarLow.Scroll += new System.EventHandler(this.BlueTrackBarLow_Scroll);
            // 
            // BluePanelHigh
            // 
            this.BluePanelHigh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BluePanelHigh.Controls.Add(this.BlueLabelHigh);
            this.BluePanelHigh.Controls.Add(this.BlueTrackBarHigh);
            this.BluePanelHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BluePanelHigh.Location = new System.Drawing.Point(508, 93);
            this.BluePanelHigh.Name = "BluePanelHigh";
            this.BluePanelHigh.Size = new System.Drawing.Size(500, 41);
            this.BluePanelHigh.TabIndex = 4;
            // 
            // BlueLabelHigh
            // 
            this.BlueLabelHigh.AutoSize = true;
            this.BlueLabelHigh.Dock = System.Windows.Forms.DockStyle.Left;
            this.BlueLabelHigh.Location = new System.Drawing.Point(0, 0);
            this.BlueLabelHigh.Name = "BlueLabelHigh";
            this.BlueLabelHigh.Size = new System.Drawing.Size(46, 17);
            this.BlueLabelHigh.TabIndex = 2;
            this.BlueLabelHigh.Text = "label3";
            // 
            // BlueTrackBarHigh
            // 
            this.BlueTrackBarHigh.Dock = System.Windows.Forms.DockStyle.Right;
            this.BlueTrackBarHigh.Location = new System.Drawing.Point(92, 0);
            this.BlueTrackBarHigh.Maximum = 255;
            this.BlueTrackBarHigh.Name = "BlueTrackBarHigh";
            this.BlueTrackBarHigh.Size = new System.Drawing.Size(408, 41);
            this.BlueTrackBarHigh.TabIndex = 1;
            this.BlueTrackBarHigh.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueTrackBarHigh.Value = 255;
            this.BlueTrackBarHigh.Scroll += new System.EventHandler(this.BlueTrackBarHigh_Scroll);
            // 
            // RedPanelHigh
            // 
            this.RedPanelHigh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RedPanelHigh.Controls.Add(this.RedLabelHigh);
            this.RedPanelHigh.Controls.Add(this.RedTrackBarHigh);
            this.RedPanelHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedPanelHigh.Location = new System.Drawing.Point(508, 3);
            this.RedPanelHigh.Name = "RedPanelHigh";
            this.RedPanelHigh.Size = new System.Drawing.Size(500, 39);
            this.RedPanelHigh.TabIndex = 6;
            // 
            // RedLabelHigh
            // 
            this.RedLabelHigh.AutoSize = true;
            this.RedLabelHigh.Dock = System.Windows.Forms.DockStyle.Left;
            this.RedLabelHigh.Location = new System.Drawing.Point(0, 0);
            this.RedLabelHigh.Name = "RedLabelHigh";
            this.RedLabelHigh.Size = new System.Drawing.Size(46, 17);
            this.RedLabelHigh.TabIndex = 3;
            this.RedLabelHigh.Text = "label5";
            // 
            // RedTrackBarHigh
            // 
            this.RedTrackBarHigh.Dock = System.Windows.Forms.DockStyle.Right;
            this.RedTrackBarHigh.Location = new System.Drawing.Point(92, 0);
            this.RedTrackBarHigh.Maximum = 255;
            this.RedTrackBarHigh.Name = "RedTrackBarHigh";
            this.RedTrackBarHigh.Size = new System.Drawing.Size(408, 39);
            this.RedTrackBarHigh.TabIndex = 2;
            this.RedTrackBarHigh.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedTrackBarHigh.Value = 255;
            this.RedTrackBarHigh.Scroll += new System.EventHandler(this.RedTrackBarHigh_Scroll);
            // 
            // GreenPanelHigh
            // 
            this.GreenPanelHigh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GreenPanelHigh.Controls.Add(this.GreenLabelHigh);
            this.GreenPanelHigh.Controls.Add(this.GreenTrackBarHigh);
            this.GreenPanelHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GreenPanelHigh.Location = new System.Drawing.Point(508, 48);
            this.GreenPanelHigh.Name = "GreenPanelHigh";
            this.GreenPanelHigh.Size = new System.Drawing.Size(500, 39);
            this.GreenPanelHigh.TabIndex = 8;
            // 
            // GreenLabelHigh
            // 
            this.GreenLabelHigh.AutoSize = true;
            this.GreenLabelHigh.Dock = System.Windows.Forms.DockStyle.Left;
            this.GreenLabelHigh.Location = new System.Drawing.Point(0, 0);
            this.GreenLabelHigh.Name = "GreenLabelHigh";
            this.GreenLabelHigh.Size = new System.Drawing.Size(46, 17);
            this.GreenLabelHigh.TabIndex = 3;
            this.GreenLabelHigh.Text = "label3";
            // 
            // GreenTrackBarHigh
            // 
            this.GreenTrackBarHigh.Dock = System.Windows.Forms.DockStyle.Right;
            this.GreenTrackBarHigh.Location = new System.Drawing.Point(92, 0);
            this.GreenTrackBarHigh.Maximum = 255;
            this.GreenTrackBarHigh.Name = "GreenTrackBarHigh";
            this.GreenTrackBarHigh.Size = new System.Drawing.Size(408, 39);
            this.GreenTrackBarHigh.TabIndex = 2;
            this.GreenTrackBarHigh.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenTrackBarHigh.Value = 255;
            this.GreenTrackBarHigh.Scroll += new System.EventHandler(this.GreenTrackBarHigh_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ColorSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 218);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "ColorSet";
            this.Text = "ColorSet";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ColorSet_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToleranceTrackBar)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.RedPanelLow.ResumeLayout(false);
            this.RedPanelLow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBarLow)).EndInit();
            this.GreenPanelLow.ResumeLayout(false);
            this.GreenPanelLow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBarLow)).EndInit();
            this.BluePanelLow.ResumeLayout(false);
            this.BluePanelLow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBarLow)).EndInit();
            this.BluePanelHigh.ResumeLayout(false);
            this.BluePanelHigh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBarHigh)).EndInit();
            this.RedPanelHigh.ResumeLayout(false);
            this.RedPanelHigh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBarHigh)).EndInit();
            this.GreenPanelHigh.ResumeLayout(false);
            this.GreenPanelHigh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBarHigh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel RedPanelLow;
        private System.Windows.Forms.Label RedLabelLow;
        private System.Windows.Forms.TrackBar RedTrackBarLow;
        private System.Windows.Forms.Panel GreenPanelLow;
        private System.Windows.Forms.Label GreenLabelLow;
        private System.Windows.Forms.TrackBar GreenTrackBarLow;
        private System.Windows.Forms.Panel BluePanelLow;
        private System.Windows.Forms.Label BlueLabelLow;
        private System.Windows.Forms.TrackBar BlueTrackBarLow;
        private System.Windows.Forms.Panel BluePanelHigh;
        private System.Windows.Forms.Label BlueLabelHigh;
        private System.Windows.Forms.TrackBar BlueTrackBarHigh;
        private System.Windows.Forms.Panel RedPanelHigh;
        private System.Windows.Forms.Label RedLabelHigh;
        private System.Windows.Forms.TrackBar RedTrackBarHigh;
        private System.Windows.Forms.Panel GreenPanelHigh;
        private System.Windows.Forms.Label GreenLabelHigh;
        private System.Windows.Forms.TrackBar GreenTrackBarHigh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ToleranceLabel;
        private System.Windows.Forms.TrackBar ToleranceTrackBar;
        private System.Windows.Forms.Label ToleranceValueLabel;
    }
}