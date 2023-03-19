using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace 医生工作站
{
    public partial class NurseStation : Form
    {
        private string _NurseId;    //护士编号
        private Form currentChildForm; //子窗体
        public NurseStation()
        {
            InitializeComponent();
        }
        public NurseStation(string nurseId):this()
        {
            this._NurseId = nurseId;
            this.NurseStation_Load();
        }
        private void NurseStation_Load()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT N.NAME AS 姓名,D.NAME AS 科室 FROM NURSE AS N JOIN DEPARTMENT AS D ON D.DEP_ID=N.NUR_DEP WHERE N.NUR_ID='{this._NurseId}' ";
            sqlConnection.Open();
            SqlDataReader sqlDataReader= sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.stslbl_middle.Text = "当前用户：" + $"{sqlDataReader["姓名"]}  " + "科室：" + $"{sqlDataReader["科室"]}";
            }
            
            sqlConnection.Close();
        }
        //打开子窗体
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_center.Controls.Add(childForm);
            pnl_center.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void NurseStation_Load(object sender, EventArgs e)
        {

        }

        private void tlsbtn_bed_Assign_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PatientBed_Assign());
        }
    }
}
