namespace Bakalarska_Práca
{
    partial class ServerSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.portnumber = new System.Windows.Forms.NumericUpDown();
            this.ControlsGroup = new System.Windows.Forms.GroupBox();
            this.applybutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portnumber)).BeginInit();
            this.ControlsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ControlsGroup, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 171);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.portnumber);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Number";
            // 
            // portnumber
            // 
            this.portnumber.AutoSize = true;
            this.portnumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portnumber.Location = new System.Drawing.Point(3, 18);
            this.portnumber.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portnumber.Minimum = new decimal(new int[] {
            49153,
            0,
            0,
            0});
            this.portnumber.Name = "portnumber";
            this.portnumber.Size = new System.Drawing.Size(325, 22);
            this.portnumber.TabIndex = 0;
            this.portnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.portnumber.Value = new decimal(new int[] {
            49153,
            0,
            0,
            0});
            // 
            // ControlsGroup
            // 
            this.ControlsGroup.Controls.Add(this.applybutton);
            this.ControlsGroup.Controls.Add(this.cancelbutton);
            this.ControlsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsGroup.Location = new System.Drawing.Point(3, 88);
            this.ControlsGroup.Name = "ControlsGroup";
            this.ControlsGroup.Size = new System.Drawing.Size(331, 80);
            this.ControlsGroup.TabIndex = 1;
            this.ControlsGroup.TabStop = false;
            this.ControlsGroup.Text = "Controls";
            // 
            // applybutton
            // 
            this.applybutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.applybutton.Location = new System.Drawing.Point(178, 18);
            this.applybutton.Name = "applybutton";
            this.applybutton.Size = new System.Drawing.Size(75, 59);
            this.applybutton.TabIndex = 2;
            this.applybutton.Text = "Apply";
            this.applybutton.UseVisualStyleBackColor = true;
            this.applybutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelbutton.Location = new System.Drawing.Point(253, 18);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 59);
            this.cancelbutton.TabIndex = 1;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // ServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 171);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServerSettings";
            this.Text = "ServerSettings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ServerSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portnumber)).EndInit();
            this.ControlsGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown portnumber;
        private System.Windows.Forms.GroupBox ControlsGroup;
        private System.Windows.Forms.Button applybutton;
        private System.Windows.Forms.Button cancelbutton;
    }
}