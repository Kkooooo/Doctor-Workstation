using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 医生工作站
{
    public partial class HomePage : Form
    {
        private string _DocId;

        private UserControl _UserControl;
        public HomePage()
        {
            InitializeComponent();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        /// <summary>
        /// 重载构造函数
        /// </summary>
        /// <param name="id"></param>
        public HomePage(string id):this()
        {
            this._DocId = id;
            this.HomePage_Load();
        }
        /// <summary>
        /// （方法）显示控件界面
        /// </summary>
        /// <param name="winform"></param>
        /// <param name="panel"></param>
        private void showForm(UserControl winform, Panel panel)
        {
            panel.Controls.Clear();
            panel.Controls.Add(winform);
            winform.Dock = DockStyle.Fill;
            winform.BorderStyle = BorderStyle.None;
            winform.Show();
        }

        /// <summary>
        /// 清除容器里面某些控件的值
        /// </summary>
        /// <param name="parContainer">容器类控件</param>
        public void ClearCntrValue(Control parContainer)
        {
            for (int index = 0; index < parContainer.Controls.Count; index++)
            {
                // 如果是容器类控件，递归调用自己
                if (parContainer.Controls[index].HasChildren)
                {
                    ClearCntrValue(parContainer.Controls[index]);
                }
                else
                {
                    switch (parContainer.Controls[index].GetType().Name)
                    {
                        case "TextBox":
                            parContainer.Controls[index].Text = "";
                            break;
                        case "RadioButton":
                            ((RadioButton)(parContainer.Controls[index])).Checked = false;
                            break;
                        case "CheckBox":
                            ((CheckBox)(parContainer.Controls[index])).Checked = false;
                            break;
                        case "ComboBox":
                            ((ComboBox)(parContainer.Controls[index])).Text = "";
                            break;
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.stslbl_time.Text = "系统当前时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void HomePage_Load()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            /*sqlCommand.CommandText = $"SELECT NAME FROM DOCTOR WHERE DOC_ID='{this._DocId}'";*/
            sqlCommand.CommandText = $@"SELECT DO.NAME AS 医生,DE.NAME AS 科室 FROM DOCTOR AS DO JOIN DEPARTMENT AS DE ON DO.DOC_DEP=DE.DEP_ID WHERE DOC_ID='{this._DocId}' ";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.stslbl_middle.Text = "当前用户：" + $"{sqlDataReader["医生"].ToString()}  "+"科室："+$"{sqlDataReader["科室"]}";
            }
            sqlConnection.Close();
            this.stslbl_time.Text = "系统当前时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.timer1.Interval = 1000;
            this.timer1.Start();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }

        private void tsb_web_Click(object sender, EventArgs e)
        {
            WebSearch webSearch = new WebSearch();
            webSearch.Show();
        }

        private void tsbtn_refresh_Click(object sender, EventArgs e)
        {
            //this._UserControl.Refresh();
            showForm(this._UserControl, this.pnl_home);
            //ClearCntrValue(this._UserControl);        //清空控件内容
        }

        private void tsb_addpatient_Click(object sender, EventArgs e)
        {
            NewPatientInfo newPatientInfo = new NewPatientInfo(this._DocId);
            this._UserControl = newPatientInfo;
            showForm(newPatientInfo, this.pnl_home);
        }
        
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #region Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        private void timerRun_Tick(object sender, EventArgs e)
        {
            lbl_title.Text = lbl_title.Text.Substring(lbl_title.Text.Length - 1) + lbl_title.Text.Substring(0, lbl_title.Text.Length - 1);
        }

        private void tsbtn_searchPat_Click(object sender, EventArgs e)
        {
            PatientInfoCheck patientInfoCheck = new PatientInfoCheck();
            this._UserControl = patientInfoCheck;
            showForm(patientInfoCheck, this.pnl_home);
        }
    }
}
