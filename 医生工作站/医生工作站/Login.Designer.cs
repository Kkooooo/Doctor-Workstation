namespace 医生工作站
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_idwarn = new System.Windows.Forms.Label();
            this.lbl_passwarn = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.btn_nurseLogin = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(104, 245);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(184, 44);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(104, 122);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(184, 21);
            this.txt_id.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(104, 193);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(184, 21);
            this.txt_password.TabIndex = 2;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_id.Location = new System.Drawing.Point(103, 105);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(52, 14);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "账号：";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_password.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_password.Location = new System.Drawing.Point(103, 176);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(52, 14);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "密钥：";
            // 
            // lbl_idwarn
            // 
            this.lbl_idwarn.AutoSize = true;
            this.lbl_idwarn.ForeColor = System.Drawing.Color.Red;
            this.lbl_idwarn.Location = new System.Drawing.Point(104, 146);
            this.lbl_idwarn.Name = "lbl_idwarn";
            this.lbl_idwarn.Size = new System.Drawing.Size(17, 12);
            this.lbl_idwarn.TabIndex = 5;
            this.lbl_idwarn.Text = "id";
            // 
            // lbl_passwarn
            // 
            this.lbl_passwarn.AutoSize = true;
            this.lbl_passwarn.ForeColor = System.Drawing.Color.Red;
            this.lbl_passwarn.Location = new System.Drawing.Point(104, 217);
            this.lbl_passwarn.Name = "lbl_passwarn";
            this.lbl_passwarn.Size = new System.Drawing.Size(53, 12);
            this.lbl_passwarn.TabIndex = 6;
            this.lbl_passwarn.Text = "password";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_title.Location = new System.Drawing.Point(110, 39);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(178, 41);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "医生工作站";
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_exit.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_exit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_exit.Location = new System.Drawing.Point(334, 0);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(50, 35);
            this.lbl_exit.TabIndex = 8;
            this.lbl_exit.Text = "×";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // btn_nurseLogin
            // 
            this.btn_nurseLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nurseLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_nurseLogin.FlatAppearance.BorderSize = 0;
            this.btn_nurseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nurseLogin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_nurseLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_nurseLogin.Location = new System.Drawing.Point(104, 305);
            this.btn_nurseLogin.Name = "btn_nurseLogin";
            this.btn_nurseLogin.Size = new System.Drawing.Size(184, 32);
            this.btn_nurseLogin.TabIndex = 9;
            this.btn_nurseLogin.Text = "👉护士工作站 ";
            this.btn_nurseLogin.UseVisualStyleBackColor = false;
            this.btn_nurseLogin.Click += new System.EventHandler(this.btn_nurseLogin_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.lbl_exit);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(384, 36);
            this.pnl_top.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(384, 363);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.btn_nurseLogin);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_passwarn);
            this.Controls.Add(this.lbl_idwarn);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_idwarn;
        private System.Windows.Forms.Label lbl_passwarn;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Button btn_nurseLogin;
        private System.Windows.Forms.Panel pnl_top;
    }
}

