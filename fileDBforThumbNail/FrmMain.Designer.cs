namespace fileDBforThumbNail
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlTop = new System.Windows.Forms.Panel();
            this.BtnDBLoad = new System.Windows.Forms.Button();
            this.BtnFilePath0 = new System.Windows.Forms.Button();
            this.TxtFileDBPath = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PnlTop.Controls.Add(this.BtnDBLoad);
            this.PnlTop.Controls.Add(this.BtnFilePath0);
            this.PnlTop.Controls.Add(this.TxtFileDBPath);
            this.PnlTop.Controls.Add(this.label14);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(800, 52);
            this.PnlTop.TabIndex = 0;
            // 
            // BtnDBLoad
            // 
            this.BtnDBLoad.Location = new System.Drawing.Point(723, 15);
            this.BtnDBLoad.Name = "BtnDBLoad";
            this.BtnDBLoad.Size = new System.Drawing.Size(65, 23);
            this.BtnDBLoad.TabIndex = 37;
            this.BtnDBLoad.Text = "DB로딩";
            this.BtnDBLoad.UseVisualStyleBackColor = true;
            this.BtnDBLoad.Click += new System.EventHandler(this.BtnDBLoad_Click_1);
            // 
            // BtnFilePath0
            // 
            this.BtnFilePath0.Location = new System.Drawing.Point(652, 14);
            this.BtnFilePath0.Name = "BtnFilePath0";
            this.BtnFilePath0.Size = new System.Drawing.Size(46, 23);
            this.BtnFilePath0.TabIndex = 36;
            this.BtnFilePath0.Text = "...";
            this.BtnFilePath0.UseVisualStyleBackColor = true;
            this.BtnFilePath0.Click += new System.EventHandler(this.BtnFilePath0_Click);
            // 
            // TxtFileDBPath
            // 
            this.TxtFileDBPath.Enabled = false;
            this.TxtFileDBPath.Location = new System.Drawing.Point(91, 15);
            this.TxtFileDBPath.Name = "TxtFileDBPath";
            this.TxtFileDBPath.Size = new System.Drawing.Size(555, 23);
            this.TxtFileDBPath.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "FileDB 경로 :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 398);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PnlTop);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlTop;
        private Button BtnFilePath0;
        private TextBox TxtFileDBPath;
        private Label label14;
        private Button BtnDBLoad;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}