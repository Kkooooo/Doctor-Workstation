using System;
using System.Data;
using System.Configuration;     //Sql连接所需引用
using System.Data.SqlClient;        
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 医生工作站
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = this.btn_login;
            this.lbl_idwarn.Visible = false;
            this.lbl_passwarn.Visible = false;
            
        }
        private int v = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            
            if(this.txt_id.Text.Length != 10) //前端标签验证账号
            {
                v = 1;
                this.lbl_idwarn.Visible = true;
                this.lbl_idwarn.Text = "账号长度应为10位";
                return;
            }
            else
            {
                this.lbl_idwarn.Visible = false;
            }
            if (this.txt_password.Text.Length < 6) //验证密码
            {
                v = 1;
                this.lbl_passwarn.Visible =true;
                this.lbl_passwarn.Text = "密码长度不足6位";
                return;
            }
            else
            {                            
                this.lbl_passwarn.Visible =false;
            }
            if (v == 0)
            {
                SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接
                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //借助配置管理器获取连接字符串
                SqlCommand sqlCommand = sqlConnection.CreateCommand(); //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
                sqlCommand.CommandText = $"SELECT COUNT(1) FROM DOCTOR " +
                    $"WHERE DOC_ID=@DOC_ID " +
                    $"AND DOC_PASS=HASHBYTES('MD5',@Password);";//指定SQL命令的命令文本，命令包含参数
                #region 账号参数
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "DOC_ID";
                sqlParameter.Value = this.txt_id.Text.Trim();
                sqlParameter.SqlDbType = SqlDbType.Char;
                sqlParameter.Size = 10;
                sqlCommand.Parameters.Add(sqlParameter);
                #endregion
                #region 密码参数
                sqlCommand.Parameters.AddWithValue("@Password", this.txt_password.Text.Trim());
                sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
                #endregion
                sqlConnection.Open();//打开数据库连接                
                int rowCount = (int)sqlCommand.ExecuteScalar();
                sqlConnection.Close();//关闭数据库连接
                if (rowCount == 1)
                {
                    MessageBox.Show("登录成功");
                    HomePage homePage = new HomePage(this.txt_id.Text.Trim());
                    this.Hide();
                    homePage.ShowDialog();                    
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("账号/密码错误，请重新输入！");
                    this.txt_password.Focus();
                    this.txt_password.SelectAll();
                }
            }
        }
        /*#region Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion*/
        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_nurseLogin_Click(object sender, EventArgs e)
        {
            NurseLogin nurseLogin = new NurseLogin();
            nurseLogin.ShowDialog();
        }
    }
}
