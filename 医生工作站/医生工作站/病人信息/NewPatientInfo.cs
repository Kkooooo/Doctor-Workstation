using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using static System.Environment;

namespace 医生工作站
{
    public partial class NewPatientInfo : UserControl
    {
        private string _doc_id;
        public NewPatientInfo()
        {
            InitializeComponent();
            


        }
        public NewPatientInfo(string doc_Id):this()
        {
            this._doc_id = doc_Id;
            NewPatientInfo_Load();
        }

        private void NewPatientInfo_Load()
        {
            this.lbl_no_tip.Visible = false;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //连接数据库
            SqlCommand doc_name = sqlConnection.CreateCommand();
            doc_name.CommandText = $"SELECT D.NAME FROM DOCTOR AS D WHERE D.DOC_ID=@ID";      //查询医生表
            doc_name.Parameters.AddWithValue("@ID", $"{this._doc_id}");

            SqlCommand countryCommand = sqlConnection.CreateCommand();
            countryCommand.CommandText = "SELECT * FROM COUNTRY";           //查询国家表
            SqlDataAdapter countryAdapter = new SqlDataAdapter();
            countryAdapter.SelectCommand = countryCommand;
            DataTable countryTable = new DataTable();

            SqlCommand nationCommand = sqlConnection.CreateCommand();
            nationCommand.CommandText = "SELECT * FROM NATION";         //查询民族表
            SqlDataAdapter nationAdapter = new SqlDataAdapter(nationCommand);
            DataTable nationTable = new DataTable();

            SqlCommand identityCommand = sqlConnection.CreateCommand();
            identityCommand.CommandText = "SELECT * FROM PAT_IDENTITY"; //查询病人身份表
            SqlDataAdapter identityAdapter = new SqlDataAdapter(identityCommand);
            DataTable identityTable = new DataTable();

            SqlCommand professionCommand = sqlConnection.CreateCommand();
            professionCommand.CommandText = "SELECT * FROM PROFESSION"; //查询职业表
            SqlDataAdapter professionAdapter = new SqlDataAdapter(professionCommand);   
            DataTable professionTable = new DataTable();

            sqlConnection.Open();
            professionAdapter.Fill(professionTable);    //职业表绑定
            this.cmb_profession.DataSource = professionTable;
            this.cmb_profession.DisplayMember = "NAME";
            this.cmb_profession.ValueMember = "PRO_ID";

            identityAdapter.Fill(identityTable);    //身份表绑定
            this.cmb_identity.DataSource = identityTable;
            this.cmb_identity.DisplayMember = "NAME";
            this.cmb_identity.ValueMember = "IDENTITY_ID";

            nationAdapter.Fill(nationTable);    //民族表绑定
            this.cmb_nation.DataSource = nationTable;
            this.cmb_nation.DisplayMember = "NAME";
            this.cmb_nation.ValueMember = "NATION_ID";
            this.cmb_nation.SelectedIndex = 0;
            countryAdapter.Fill(countryTable);  //国家表绑定
            this.cmb_country.DataSource = countryTable;
            this.cmb_country.DisplayMember = "NAME";
            this.cmb_country.ValueMember = "COUNTRY_ID";
            this.cmb_country.SelectedIndex = 42;
            SqlDataReader doc_name_reader = doc_name.ExecuteReader();
            if (doc_name_reader.Read())
            {
                this.txb_operator.Text = doc_name_reader["NAME"].ToString();
            }           
            doc_name_reader.Close();
            this.dtp_create_time.Enabled = false;

        }
        private void NewPatientInfo_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 点击提交按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (this.txb_pat_id.Text.Length != 10)
            {
                this.lbl_no_tip.Visible = true;
            }
            else
            {
                MemoryStream memoryStream = new MemoryStream();
                this.ptb_patient.Image.Save(memoryStream, ImageFormat.Bmp);
                byte[] photoBytes = new byte[memoryStream.Length];
                memoryStream.Seek(0, SeekOrigin.Begin);
                memoryStream.Read(photoBytes, 0, photoBytes.Length);
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = @"INSERT PAT_MASTER 
    (PAT_ID, NAME, SEX, DATE_OF_BIRTH, BIRTH_PLACE, COUNTRY, NATION, ID_NO,[IDENTITY], PROFESSION, WORKING_STATUS, WORK_UNIT, CHARGE_TYPE, MAILING_ADDRESS, PHONE_NUMBER, CONTACT_NAME, RELATIONSHIP, CONTACT_PHONE, VIP_INDICATOR, CREATE_DATE, OPERATOR, HOME_INDICATOR,PICTURE)
    VALUES(@PAT_ID,@NAME,@SEX,@BIRTH_DATE,@BIRTH_PLACE,@COUNTRY,@NATION,@ID_NO,@IDENTITY,@PROFESSION,@WORKING_STATUS,@WORK_UNIT,@CHARGE_TYPE,@MAILING_ADDRESS, @PHONE_NUMBER,@CONTACT_NAME,@RELATIONSHIP,@CONTACT_PHONE,@VIP_INDICATOR,@CREATE_DATE,@OPERATOR,@HOME_INDICATOR,@PICTURE)";
                sqlCommand.Parameters.AddWithValue("@PAT_ID", this.txb_pat_id.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@NAME", this.txb_name.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@SEX", this.rdb_male.Checked);
                sqlCommand.Parameters.AddWithValue("@BIRTH_DATE", this.dtp_birthdate.Value);
                sqlCommand.Parameters.AddWithValue("@BIRTH_PLACE", this.txb_birth_place.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@COUNTRY", this.cmb_country.SelectedIndex + 1);
                sqlCommand.Parameters.AddWithValue("@NATION", this.cmb_nation.SelectedIndex + 1);
                sqlCommand.Parameters.AddWithValue("@ID_NO", this.txb_id_no.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@IDENTITY", this.cmb_identity.SelectedIndex + 1);
                sqlCommand.Parameters.AddWithValue("@PROFESSION", this.cmb_profession.SelectedIndex + 1);
                sqlCommand.Parameters.AddWithValue("@WORKING_STATUS", this.rdb_nonwork.Checked);
                sqlCommand.Parameters.AddWithValue("@WORK_UNIT", this.txb_work_unit.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@CHARGE_TYPE", this.txb_charge_type.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@MAILING_ADDRESS", this.txb_mailing_address.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@PHONE_NUMBER", this.txb_phone_number.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@CONTACT_NAME", this.txb_contact_name.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@RELATIONSHIP", this.txb_relationship.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@CONTACT_PHONE", this.txb_contact_phone.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@VIP_INDICATOR", this.rdb_vip.Checked);
                sqlCommand.Parameters.AddWithValue("@CREATE_DATE", this.dtp_create_time.Value);
                sqlCommand.Parameters.AddWithValue("@OPERATOR", this.txb_operator.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@HOME_INDICATOR", this.rdb_nonlocal.Checked);
                sqlCommand.Parameters.AddWithValue("@PICTURE", photoBytes);
                int rowAffected = 0;
                try
                {
                    sqlConnection.Open();
                    rowAffected = sqlCommand.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {
                    if (sqlEx.Number == 2627)
                    {
                        MessageBox.Show("您新建的病人已存在，请重新输入。");
                    }
                    else
                    {
                        MessageBox.Show("病人信息新建失败,请联系管理员。");
                    }
                }
                finally
                {
                    sqlConnection.Close();
                }
                if (rowAffected == 1)
                {
                    MessageBox.Show("病人信息新建成功");
                }
                else
                {
                    MessageBox.Show("病人信息新建失败");
                }
            }
            
            
        }
        /// <summary>
        /// 打开照片按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhotoDialog = new OpenFileDialog()
            {
                Title = "打开照片文件"
                ,
                Filter = "图像文件|*.bmp;*.jpg;*.png"
                ,
                InitialDirectory = GetFolderPath(SpecialFolder.MyPictures)
            };
            if (openPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openPhotoDialog.FileName;
                this.ptb_patient.Image = Image.FromFile(fileName);
            }
        }
    }
}
