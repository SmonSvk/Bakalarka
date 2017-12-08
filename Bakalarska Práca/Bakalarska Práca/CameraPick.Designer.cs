namespace Bakalarska_Práca
{
    partial class CameraPick
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.applybutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.preview = new Emgu.CV.UI.ImageBox();
            this.comboboxcameras = new System.Windows.Forms.ComboBox();
            this.rescanbutton = new System.Windows.Forms.Button();
            this.previewbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.savepick = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.08334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.91667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(439, 243);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.80447F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.19553F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(433, 169);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savepick);
            this.groupBox1.Controls.Add(this.rescanbutton);
            this.groupBox1.Controls.Add(this.applybutton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // applybutton
            // 
            this.applybutton.AutoSize = true;
            this.applybutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.applybutton.Location = new System.Drawing.Point(355, 18);
            this.applybutton.Name = "applybutton";
            this.applybutton.Size = new System.Drawing.Size(75, 41);
            this.applybutton.TabIndex = 0;
            this.applybutton.Text = "Apply";
            this.applybutton.UseVisualStyleBackColor = true;
            this.applybutton.Click += new System.EventHandler(this.applybutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.previewbutton);
            this.groupBox2.Controls.Add(this.comboboxcameras);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(283, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 163);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pick Camera";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.preview);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 163);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera Preview";
            // 
            // preview
            // 
            this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;
            this.preview.Location = new System.Drawing.Point(3, 18);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(268, 142);
            this.preview.TabIndex = 2;
            this.preview.TabStop = false;
            // 
            // comboboxcameras
            // 
            this.comboboxcameras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboboxcameras.FormattingEnabled = true;
            this.comboboxcameras.Location = new System.Drawing.Point(3, 18);
            this.comboboxcameras.Name = "comboboxcameras";
            this.comboboxcameras.Size = new System.Drawing.Size(141, 24);
            this.comboboxcameras.TabIndex = 0;
            // 
            // rescanbutton
            // 
            this.rescanbutton.AutoSize = true;
            this.rescanbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.rescanbutton.Location = new System.Drawing.Point(280, 18);
            this.rescanbutton.Name = "rescanbutton";
            this.rescanbutton.Size = new System.Drawing.Size(75, 41);
            this.rescanbutton.TabIndex = 1;
            this.rescanbutton.Text = "Rescan";
            this.rescanbutton.UseVisualStyleBackColor = true;
            this.rescanbutton.Click += new System.EventHandler(this.rescanbutton_Click);
            // 
            // previewbutton
            // 
            this.previewbutton.AutoSize = true;
            this.previewbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.previewbutton.Location = new System.Drawing.Point(3, 124);
            this.previewbutton.Name = "previewbutton";
            this.previewbutton.Size = new System.Drawing.Size(141, 36);
            this.previewbutton.TabIndex = 1;
            this.previewbutton.Text = "Preview";
            this.previewbutton.UseVisualStyleBackColor = true;
            this.previewbutton.Click += new System.EventHandler(this.previewbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // savepick
            // 
            this.savepick.AutoSize = true;
            this.savepick.Dock = System.Windows.Forms.DockStyle.Left;
            this.savepick.Location = new System.Drawing.Point(3, 18);
            this.savepick.Name = "savepick";
            this.savepick.Size = new System.Drawing.Size(141, 41);
            this.savepick.TabIndex = 2;
            this.savepick.Text = "Remeber Camera";
            this.savepick.UseVisualStyleBackColor = true;
            // 
            // CameraPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 243);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CameraPick";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CameraPick";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CameraPick_FormClosed);
            this.Load += new System.EventHandler(this.CameraPick_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboboxcameras;
        private System.Windows.Forms.GroupBox groupBox3;
        private Emgu.CV.UI.ImageBox preview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button rescanbutton;
        private System.Windows.Forms.Button applybutton;
        private System.Windows.Forms.Button previewbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox savepick;
    }
}