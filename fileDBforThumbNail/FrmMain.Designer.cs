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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPageGo = new System.Windows.Forms.Button();
            this.LblTpage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbCpage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDBLoad = new System.Windows.Forms.Button();
            this.BtnFilePath0 = new System.Windows.Forms.Button();
            this.TxtFileDBPath = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PnlTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PnlTop.Controls.Add(this.groupBox1);
            this.PnlTop.Controls.Add(this.BtnDBLoad);
            this.PnlTop.Controls.Add(this.BtnFilePath0);
            this.PnlTop.Controls.Add(this.TxtFileDBPath);
            this.PnlTop.Controls.Add(this.label14);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(800, 94);
            this.PnlTop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPageGo);
            this.groupBox1.Controls.Add(this.LblTpage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbCpage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 44);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnPageGo
            // 
            this.BtnPageGo.Location = new System.Drawing.Point(372, 15);
            this.BtnPageGo.Name = "BtnPageGo";
            this.BtnPageGo.Size = new System.Drawing.Size(57, 23);
            this.BtnPageGo.TabIndex = 4;
            this.BtnPageGo.Text = "Go";
            this.BtnPageGo.UseVisualStyleBackColor = true;
            this.BtnPageGo.Click += new System.EventHandler(this.BtnPageGo_Click);
            // 
            // LblTpage
            // 
            this.LblTpage.AutoSize = true;
            this.LblTpage.Location = new System.Drawing.Point(163, 19);
            this.LblTpage.Name = "LblTpage";
            this.LblTpage.Size = new System.Drawing.Size(14, 15);
            this.LblTpage.TabIndex = 3;
            this.LblTpage.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "of";
            // 
            // TbCpage
            // 
            this.TbCpage.Location = new System.Drawing.Point(45, 16);
            this.TbCpage.Name = "TbCpage";
            this.TbCpage.Size = new System.Drawing.Size(86, 23);
            this.TbCpage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Page";
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 94);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 356);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PnlTop);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PnlTop;
        private Button BtnFilePath0;
        private TextBox TxtFileDBPath;
        private Label label14;
        private Button BtnDBLoad;
        private FlowLayoutPanel flowLayoutPanel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private GroupBox groupBox1;
        private Button BtnPageGo;
        private Label LblTpage;
        private Label label2;
        private TextBox TbCpage;
        private Label label1;
    }
}