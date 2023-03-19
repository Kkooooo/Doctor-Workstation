namespace 医生工作站
{
    partial class NurseLogin
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_passwarn = new System.Windows.Forms.Label();
            this.lbl_idwarn = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.ForeColor = System.Drawing.Color.LightPink;
            this.lbl_title.Location = new System.Drawing.Point(110, 25);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(178, 41);
            this.lbl_title.TabIndex = 18;
            this.lbl_title.Text = "护士工作站";
            // 
            // lbl_passwarn
            // 
            this.lbl_passwarn.AutoSize = true;
            this.lbl_passwarn.ForeColor = System.Drawing.Color.Red;
            this.lbl_passwarn.Location = new System.Drawing.Point(104, 203);
            this.lbl_passwarn.Name = "lbl_passwarn";
            this.lbl_passwarn.Size = new System.Drawing.Size(53, 12);
            this.lbl_passwarn.TabIndex = 17;
            this.lbl_passwarn.Text = "password";
            // 
            // lbl_idwarn
            // 
            this.lbl_idwarn.AutoSize = true;
            this.lbl_idwarn.ForeColor = System.Drawing.Color.Red;
            this.lbl_idwarn.Location = new System.Drawing.Point(104, 132);
            this.lbl_idwarn.Name = "lbl_idwarn";
            this.lbl_idwarn.Size = new System.Drawing.Size(17, 12);
            this.lbl_idwarn.TabIndex = 16;
            this.lbl_idwarn.Text = "id";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_password.ForeColor = System.Drawing.Color.LightPink;
            this.lbl_password.Location = new System.Drawing.Point(103, 162);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(52, 14);
            this.lbl_password.TabIndex = 15;
            this.lbl_password.Text = "密钥：";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_id.ForeColor = System.Drawing.Color.LightPink;
            this.lbl_id.Location = new System.Drawing.Point(103, 91);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(52, 14);
            this.lbl_id.TabIndex = 14;
            this.lbl_id.Text = "账号：";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(104, 179);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(184, 21);
            this.txt_password.TabIndex = 13;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(104, 108);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(184, 21);
            this.txt_id.TabIndex = 12;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.LightPink;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(104, 239);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(184, 45);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // NurseLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(390, 336);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_passwarn);
            this.Controls.Add(this.lbl_idwarn);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NurseLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_passwarn;
        private System.Windows.Forms.Label lbl_idwarn;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_login;
    }
}