namespace 医生工作站
{
    partial class WebSearch
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
            this.wbs_baidu = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbs_baidu
            // 
            this.wbs_baidu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbs_baidu.Location = new System.Drawing.Point(0, 0);
            this.wbs_baidu.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbs_baidu.Name = "wbs_baidu";
            this.wbs_baidu.ScriptErrorsSuppressed = true;
            this.wbs_baidu.Size = new System.Drawing.Size(1015, 603);
            this.wbs_baidu.TabIndex = 0;
            // 
            // WebSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1015, 603);
            this.Controls.Add(this.wbs_baidu);
            this.Name = "WebSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网页搜索";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.WebSearch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbs_baidu;
    }
}