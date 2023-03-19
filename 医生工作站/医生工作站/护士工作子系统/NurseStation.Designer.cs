namespace 医生工作站
{
    partial class NurseStation
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
            this.sts_bottom = new System.Windows.Forms.StatusStrip();
            this.stslbl_left = new System.Windows.Forms.ToolStripStatusLabel();
            this.stslbl_middle = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnl_center = new System.Windows.Forms.Panel();
            this.lbl_theme = new System.Windows.Forms.Label();
            this.tsl_menu = new System.Windows.Forms.ToolStrip();
            this.tlsbtn_bed_Assign = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlslbl_record_transfer = new System.Windows.Forms.ToolStripLabel();
            this.sts_bottom.SuspendLayout();
            this.pnl_center.SuspendLayout();
            this.tsl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sts_bottom
            // 
            this.sts_bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stslbl_left,
            this.stslbl_middle});
            this.sts_bottom.Location = new System.Drawing.Point(0, 457);
            this.sts_bottom.Name = "sts_bottom";
            this.sts_bottom.Size = new System.Drawing.Size(808, 22);
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
            this.stslbl_middle.Size = new System.Drawing.Size(701, 17);
            this.stslbl_middle.Spring = true;
            // 
            // pnl_center
            // 
            this.pnl_center.Controls.Add(this.lbl_theme);
            this.pnl_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_center.Location = new System.Drawing.Point(0, 0);
            this.pnl_center.Name = "pnl_center";
            this.pnl_center.Size = new System.Drawing.Size(808, 457);
            this.pnl_center.TabIndex = 2;
            // 
            // lbl_theme
            // 
            this.lbl_theme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_theme.AutoSize = true;
            this.lbl_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_theme.Font = new System.Drawing.Font("隶书", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_theme.ForeColor = System.Drawing.Color.LightPink;
            this.lbl_theme.Location = new System.Drawing.Point(314, 190);
            this.lbl_theme.Name = "lbl_theme";
            this.lbl_theme.Size = new System.Drawing.Size(195, 35);
            this.lbl_theme.TabIndex = 0;
            this.lbl_theme.Text = "护士工作站";
            // 
            // tsl_menu
            // 
            this.tsl_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtn_bed_Assign,
            this.toolStripSeparator1,
            this.tlslbl_record_transfer});
            this.tsl_menu.Location = new System.Drawing.Point(0, 0);
            this.tsl_menu.Name = "tsl_menu";
            this.tsl_menu.Size = new System.Drawing.Size(808, 25);
            this.tsl_menu.TabIndex = 1;
            this.tsl_menu.Text = "toolStrip1";
            // 
            // tlsbtn_bed_Assign
            // 
            this.tlsbtn_bed_Assign.Name = "tlsbtn_bed_Assign";
            this.tlsbtn_bed_Assign.Size = new System.Drawing.Size(56, 22);
            this.tlsbtn_bed_Assign.Text = "病房分配";
            this.tlsbtn_bed_Assign.Click += new System.EventHandler(this.tlsbtn_bed_Assign_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tlslbl_record_transfer
            // 
            this.tlslbl_record_transfer.Name = "tlslbl_record_transfer";
            this.tlslbl_record_transfer.Size = new System.Drawing.Size(56, 22);
            this.tlslbl_record_transfer.Text = "病案转抄";
            // 
            // NurseStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(808, 479);
            this.Controls.Add(this.tsl_menu);
            this.Controls.Add(this.pnl_center);
            this.Controls.Add(this.sts_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NurseStation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "护士工作站";
            this.Load += new System.EventHandler(this.NurseStation_Load);
            this.sts_bottom.ResumeLayout(false);
            this.sts_bottom.PerformLayout();
            this.pnl_center.ResumeLayout(false);
            this.pnl_center.PerformLayout();
            this.tsl_menu.ResumeLayout(false);
            this.tsl_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sts_bottom;
        private System.Windows.Forms.ToolStripStatusLabel stslbl_left;
        private System.Windows.Forms.ToolStripStatusLabel stslbl_middle;
        private System.Windows.Forms.Panel pnl_center;
        private System.Windows.Forms.Label lbl_theme;
        private System.Windows.Forms.ToolStrip tsl_menu;
        private System.Windows.Forms.ToolStripLabel tlsbtn_bed_Assign;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tlslbl_record_transfer;
    }
}