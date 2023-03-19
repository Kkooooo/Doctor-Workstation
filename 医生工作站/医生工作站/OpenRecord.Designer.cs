namespace 医生工作站
{
    partial class OpenRecord
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
            this.lsb_recordlist = new System.Windows.Forms.ListBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsb_recordlist
            // 
            this.lsb_recordlist.FormattingEnabled = true;
            this.lsb_recordlist.ItemHeight = 12;
            this.lsb_recordlist.Location = new System.Drawing.Point(65, 22);
            this.lsb_recordlist.Name = "lsb_recordlist";
            this.lsb_recordlist.ScrollAlwaysVisible = true;
            this.lsb_recordlist.Size = new System.Drawing.Size(271, 184);
            this.lsb_recordlist.TabIndex = 0;
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_open.FlatAppearance.BorderSize = 0;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_open.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_open.Location = new System.Drawing.Point(65, 229);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(106, 36);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "打开";
            this.btn_open.UseVisualStyleBackColor = false;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove.Location = new System.Drawing.Point(230, 229);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(106, 36);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "移出";
            this.btn_remove.UseVisualStyleBackColor = false;
            // 
            // OpenRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(399, 298);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.lsb_recordlist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenRecord";
            this.ShowIcon = false;
            this.Text = "当前病人";
            this.Load += new System.EventHandler(this.OpenRecord_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_recordlist;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_remove;
    }
}