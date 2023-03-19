namespace 医生工作站
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.sts_bottom = new System.Windows.Forms.StatusStrip();
            this.stslbl_left = new System.Windows.Forms.ToolStripStatusLabel();
            this.stslbl_middle = new System.Windows.Forms.ToolStripStatusLabel();
            this.stslbl_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_create = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tsb_addpatient = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_refresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_searchPat = new System.Windows.Forms.ToolStripButton();
            this.tsb_web = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mini = new System.Windows.Forms.Button();
            this.btn_maxmize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_home = new System.Windows.Forms.Panel();
            this.ptb_home = new System.Windows.Forms.PictureBox();
            this.timerRun = new System.Windows.Forms.Timer(this.components);
            this.tsbtn_medicine_research = new System.Windows.Forms.ToolStripButton();
            this.sts_bottom.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_home)).BeginInit();
            this.SuspendLayout();
            // 
            // sts_bottom
            // 
            this.sts_bottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sts_bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stslbl_left,
            this.stslbl_middle,
            this.stslbl_time});
            this.sts_bottom.Location = new System.Drawing.Point(0, 719);
            this.sts_bottom.Name = "sts_bottom";
            this.sts_bottom.Size = new System.Drawing.Size(1064, 22);
            this.sts_bottom.TabIndex = 0;
            this.sts_bottom.Text = "statusStrip1";
            // 
            // stslbl_left
            // 
            this.stslbl_left.Name = "stslbl_left";
            this.stslbl_left.Size = new System.Drawing.Size(92, 17);
            this.stslbl_left.Text = "欢迎使用本系统";
            // 
            // stslbl_middle
            // 
            this.stslbl_middle.Name = "stslbl_middle";
            this.stslbl_middle.Size = new System.Drawing.Size(957, 17);
            this.stslbl_middle.Spring = true;
            // 
            // stslbl_time
            // 
            this.stslbl_time.Name = "stslbl_time";
            this.stslbl_time.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_create,
            this.tsbtn_open,
            this.toolStripButton4,
            this.tsbtn_medicine_research,
            this.tsb_addpatient,
            this.tsbtn_refresh,
            this.tsbtn_searchPat,
            this.tsb_web});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1064, 85);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_create
            // 
            this.tsbtn_create.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_create.Image")));
            this.tsbtn_create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_create.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.tsbtn_create.Name = "tsbtn_create";
            this.tsbtn_create.Size = new System.Drawing.Size(60, 82);
            this.tsbtn_create.Text = "新建病历";
            this.tsbtn_create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtn_open
            // 
            this.tsbtn_open.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_open.Image")));
            this.tsbtn_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_open.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.tsbtn_open.Name = "tsbtn_open";
            this.tsbtn_open.Size = new System.Drawing.Size(60, 82);
            this.tsbtn_open.Text = "病历操作";
            this.tsbtn_open.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(54, 82);
            this.toolStripButton4.Text = "帮助";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsb_addpatient
            // 
            this.tsb_addpatient.Image = ((System.Drawing.Image)(resources.GetObject("tsb_addpatient.Image")));
            this.tsb_addpatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_addpatient.Name = "tsb_addpatient";
            this.tsb_addpatient.Size = new System.Drawing.Size(60, 82);
            this.tsb_addpatient.Text = "信息建档";
            this.tsb_addpatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_addpatient.Click += new System.EventHandler(this.tsb_addpatient_Click);
            // 
            // tsbtn_refresh
            // 
            this.tsbtn_refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_refresh.Image")));
            this.tsbtn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_refresh.Name = "tsbtn_refresh";
            this.tsbtn_refresh.Size = new System.Drawing.Size(54, 82);
            this.tsbtn_refresh.Text = "刷新";
            this.tsbtn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_refresh.Click += new System.EventHandler(this.tsbtn_refresh_Click);
            // 
            // tsbtn_searchPat
            // 
            this.tsbtn_searchPat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_searchPat.Image")));
            this.tsbtn_searchPat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_searchPat.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.tsbtn_searchPat.Name = "tsbtn_searchPat";
            this.tsbtn_searchPat.Size = new System.Drawing.Size(60, 82);
            this.tsbtn_searchPat.Text = "病人阅览";
            this.tsbtn_searchPat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_searchPat.Click += new System.EventHandler(this.tsbtn_searchPat_Click);
            // 
            // tsb_web
            // 
            this.tsb_web.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_web.Image = ((System.Drawing.Image)(resources.GetObject("tsb_web.Image")));
            this.tsb_web.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_web.Name = "tsb_web";
            this.tsb_web.Size = new System.Drawing.Size(60, 82);
            this.tsb_web.Text = "网页搜索";
            this.tsb_web.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_web.Click += new System.EventHandler(this.tsb_web_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1064, 113);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1064, 113);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_mini);
            this.panel1.Controls.Add(this.btn_maxmize);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 25);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_mini
            // 
            this.btn_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.Image = ((System.Drawing.Image)(resources.GetObject("btn_mini.Image")));
            this.btn_mini.Location = new System.Drawing.Point(968, 0);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(32, 25);
            this.btn_mini.TabIndex = 4;
            this.btn_mini.UseVisualStyleBackColor = true;
            this.btn_mini.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_maxmize
            // 
            this.btn_maxmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maxmize.FlatAppearance.BorderSize = 0;
            this.btn_maxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maxmize.Image = ((System.Drawing.Image)(resources.GetObject("btn_maxmize.Image")));
            this.btn_maxmize.Location = new System.Drawing.Point(1000, 0);
            this.btn_maxmize.Name = "btn_maxmize";
            this.btn_maxmize.Size = new System.Drawing.Size(32, 25);
            this.btn_maxmize.TabIndex = 3;
            this.btn_maxmize.UseVisualStyleBackColor = true;
            this.btn_maxmize.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(1032, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(32, 25);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.Location = new System.Drawing.Point(3, 2);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(87, 16);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "医生工作站";
            // 
            // pnl_home
            // 
            this.pnl_home.Controls.Add(this.ptb_home);
            this.pnl_home.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_home.Location = new System.Drawing.Point(0, 116);
            this.pnl_home.Name = "pnl_home";
            this.pnl_home.Size = new System.Drawing.Size(1064, 603);
            this.pnl_home.TabIndex = 4;
            // 
            // ptb_home
            // 
            this.ptb_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_home.Image = ((System.Drawing.Image)(resources.GetObject("ptb_home.Image")));
            this.ptb_home.Location = new System.Drawing.Point(0, 0);
            this.ptb_home.Name = "ptb_home";
            this.ptb_home.Size = new System.Drawing.Size(1064, 603);
            this.ptb_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptb_home.TabIndex = 1;
            this.ptb_home.TabStop = false;
            // 
            // timerRun
            // 
            this.timerRun.Enabled = true;
            this.timerRun.Interval = 800;
            this.timerRun.Tick += new System.EventHandler(this.timerRun_Tick);
            // 
            // tsbtn_medicine_research
            // 
            this.tsbtn_medicine_research.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_medicine_research.Image")));
            this.tsbtn_medicine_research.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_medicine_research.Name = "tsbtn_medicine_research";
            this.tsbtn_medicine_research.Size = new System.Drawing.Size(60, 82);
            this.tsbtn_medicine_research.Text = "药品查询";
            this.tsbtn_medicine_research.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbtn_medicine_research.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1064, 741);
            this.Controls.Add(this.pnl_home);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.sts_bottom);
            this.Name = "HomePage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "医生工作站";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.sts_bottom.ResumeLayout(false);
            this.sts_bottom.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sts_bottom;
        private System.Windows.Forms.ToolStripStatusLabel stslbl_left;
        private System.Windows.Forms.ToolStripStatusLabel stslbl_middle;
        private System.Windows.Forms.ToolStripStatusLabel stslbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_create;
        private System.Windows.Forms.ToolStripButton tsbtn_open;
        private System.Windows.Forms.ToolStripButton tsbtn_searchPat;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsbtn_refresh;
        private System.Windows.Forms.ToolStripButton tsb_addpatient;
        private System.Windows.Forms.ToolStripButton tsb_web;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pnl_home;
        private System.Windows.Forms.PictureBox ptb_home;
        private System.Windows.Forms.Button btn_maxmize;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Timer timerRun;
        private System.Windows.Forms.ToolStripButton tsbtn_medicine_research;
    }
}