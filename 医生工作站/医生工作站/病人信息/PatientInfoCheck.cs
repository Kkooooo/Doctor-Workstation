using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;
using System.Data.SqlClient;
using static System.Environment;

namespace 医生工作站
{
    public partial class PatientInfoCheck : UserControl
    {
        /// <summary>
        /// 病人数据表
        /// </summary>
        private DataTable _PatientTable;
        /// <summary>
        /// 民族表
        /// </summary>
        private DataTable _NationTable;
        /// <summary>
        /// 国籍表
        /// </summary>
        private DataTable _CountryTable;
        /// <summary>
        /// 职业表
        /// </summary>
        private DataTable _ProfessionTable;
        /// <summary>
        /// 身份表
        /// </summary>
        private DataTable _IdentityTable;
        /// <summary>
        /// 按名称排列的病人数据视图
        /// </summary>
        private DataView _PatientViewByName;
        
        public PatientInfoCheck()
        {
            InitializeComponent();
            this.dgv_patient_info.AllowUserToAddRows = false;
            this.dgv_patient_info.RowHeadersVisible = false;
            this.dgv_patient_info.DataError += delegate (object sender, DataGridViewDataErrorEventArgs e) { };//屏蔽datagridview异常消息
            this.lbl_idNo.Text = "无";
        }
        /// <summary>
        /// 打开照片文件夹
        /// </summary>
        private void btn_open_picture_Click(object sender, EventArgs e)
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
                this.ptb_Photo.Image = Image.FromFile(fileName);
            }
        }
        private void PatientInfoCheck_Load()
        {
            
        }
        private void PatientInfoCheck_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            
            /*sqlCommand.CommandText = $@"SELECT	P.PAT_ID AS 病人编号,P.NAME AS 姓名,
CASE P.SEX WHEN'0' THEN '女' ELSE '男' END AS 性别,
P.CHARGE_TYPE AS 费别,P.PHONE_NUMBER AS 电话号码,P.VIP_INDICATOR AS 重要人物,P.NAME_PY AS PY
,P.NATION AS PNATION,P.COUNTRY AS PCOUNTRY,P.PROFESSION AS PPROFESSION,P.[IDENTITY] AS PIDENTITY
FROM PAT_MASTER AS P JOIN COUNTRY AS C ON P.COUNTRY = C.COUNTRY_ID 
JOIN NATION AS N ON P.NATION = NATION_ID JOIN PROFESSION AS PRO ON PRO.PRO_ID = P.PROFESSION 
JOIN PAT_IDENTITY AS I ON P.[IDENTITY] = I.IDENTITY_ID";*/              //错误示例，查询主表内容即可，Combobox列动态添加无需在此查询

            sqlCommand.CommandText = $@"SELECT	P.PAT_ID AS 病人编号,P.NAME AS 姓名,
CASE P.SEX WHEN'0' THEN '女' ELSE '男' END AS 性别,
P.CHARGE_TYPE AS 费别,P.PHONE_NUMBER AS 电话号码,P.VIP_INDICATOR AS 重要人物,P.NAME_PY AS PY
,P.NATION AS PNATION,P.COUNTRY AS PCOUNTRY,P.PROFESSION AS PPROFESSION,P.[IDENTITY] AS PIDENTITY
FROM PAT_MASTER AS P";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            this._PatientTable = new DataTable();
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//设置SQL数据适配器在缺少架构时的动作为追加主键，从而获取数据库中定义的主键，否则无法根据编号搜索课程；

            /*填充数据表*/
            #region Fill DataTable
            /*填充民族表*/
            SqlCommand NationCommand = sqlConnection.CreateCommand();
            NationCommand.CommandText = "SELECT * FROM NATION";
            SqlDataAdapter NationAdapter = new SqlDataAdapter();
            NationAdapter.SelectCommand = NationCommand;
            this._NationTable = new DataTable();
            /*填充国家表*/
            SqlCommand CountryCommand = sqlConnection.CreateCommand();
            CountryCommand.CommandText = "SELECT * FROM COUNTRY";
            SqlDataAdapter CountryAdapter = new SqlDataAdapter();
            CountryAdapter.SelectCommand = CountryCommand;
            this._CountryTable = new DataTable();
            /*填充职业表*/
            SqlCommand ProCommand = sqlConnection.CreateCommand();
            ProCommand.CommandText = "SELECT * FROM PROFESSION";
            SqlDataAdapter ProAdapter = new SqlDataAdapter();
            ProAdapter.SelectCommand = ProCommand;
            this._ProfessionTable = new DataTable();
            /*填充身份表*/
            SqlCommand IdentityCommand = sqlConnection.CreateCommand();
            IdentityCommand.CommandText = "SELECT * FROM PAT_IDENTITY";
            SqlDataAdapter IdentityAdapter = new SqlDataAdapter();
            IdentityAdapter.SelectCommand = IdentityCommand;
            this._IdentityTable = new DataTable();
            

            sqlConnection.Open();
            sqlDataAdapter.Fill(this._PatientTable);    //填充病人表
            NationAdapter.Fill(this._NationTable);  //填充民族表
            CountryAdapter.Fill(this._CountryTable);//国家表
            ProAdapter.Fill(this._ProfessionTable);//职业表
            IdentityAdapter.Fill(this._IdentityTable);//身份表
            sqlConnection.Close();
            #endregion Fill DataTable

            this._PatientViewByName = new DataView(this._PatientTable);//实例化本窗体的课程数据视图，用于按照名称进行快速查询;设置课程数据视图对应的数据表；
            this._PatientViewByName.Sort = "姓名 ASC";//设置课程数据视图的排序条件，即查询所覆盖的列；

            /*设置网格视图*/
            #region Operate Dgv 
            this.dgv_patient_info.Columns.Clear();//数据网格视图的列集合清空；
            this.dgv_patient_info.DataSource = this._PatientTable;//将数据网格视图的数据源设为病人数据表；
            this.dgv_patient_info.Columns["病人编号"].ReadOnly = true;//设置编号为只读
            this.dgv_patient_info.Columns["性别"].ReadOnly = true;//设置性别为只读
            this.dgv_patient_info.Columns["PY"].Visible = false;
            this.dgv_patient_info.Columns["PNATION"].Visible = false;
            this.dgv_patient_info.Columns["PCOUNTRY"].Visible = false;
            this.dgv_patient_info.Columns["PPROFESSION"].Visible = false;
            this.dgv_patient_info.Columns["PIDENTITY"].Visible = false;
            #endregion operate dgv
            /*添加下拉框列*/
            #region Add ComboboxColumn
            DataGridViewComboBoxColumn nationColumn = new DataGridViewComboBoxColumn(); //声明并实例化数据网格试图下拉框列，用于设置民族
            this.dgv_patient_info.Columns.Add(nationColumn);
            nationColumn.Name = "Nation";
            nationColumn.HeaderText = "民族";
            nationColumn.DataSource = this._NationTable;    //设置民族下拉框的数据源为民族表
            nationColumn.DisplayMember = "NAME";
            nationColumn.ValueMember = "NATION_ID";
            nationColumn.DataPropertyName = "PNATION";
            nationColumn.FlatStyle = FlatStyle.Flat;

            
            DataGridViewComboBoxColumn CountryColumn = new DataGridViewComboBoxColumn(); 
            this.dgv_patient_info.Columns.Add(CountryColumn);
            CountryColumn.Name = "Country";
            CountryColumn.HeaderText = "国籍";
            CountryColumn.DataSource = this._CountryTable;
            CountryColumn.DisplayMember = "NAME";
            CountryColumn.ValueMember = "COUNTRY_ID";
            CountryColumn.DataPropertyName = "PCOUNTRY";
            CountryColumn.FlatStyle = FlatStyle.Flat;

            DataGridViewComboBoxColumn ProColumn = new DataGridViewComboBoxColumn();
            this.dgv_patient_info.Columns.Add(ProColumn);
            ProColumn.Name = "Profession";
            ProColumn.HeaderText = "职业";
            ProColumn.DataSource = this._ProfessionTable;
            ProColumn.DisplayMember = "NAME";
            ProColumn.ValueMember = "PRO_ID";
            ProColumn.DataPropertyName = "PPROFESSION";
            ProColumn.FlatStyle = FlatStyle.Flat;
            ProColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
            DataGridViewComboBoxColumn IdenColumn = new DataGridViewComboBoxColumn();
            this.dgv_patient_info.Columns.Add(IdenColumn);
            IdenColumn.Name = "Identity";
            IdenColumn.HeaderText = "身份";
            IdenColumn.DataSource = this._IdentityTable;
            IdenColumn.DisplayMember = "NAME";
            IdenColumn.ValueMember = "IDENTITY_ID";
            IdenColumn.DataPropertyName = "PIDENTITY";
            IdenColumn.FlatStyle = FlatStyle.Flat;
            #endregion

        }
        /// <summary>
        /// 修改病人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modify_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            this.ptb_Photo.Image.Save(memoryStream,ImageFormat.Bmp);
            byte[] photoBytes = new byte[memoryStream.Length];
            memoryStream.Seek(0, SeekOrigin.Begin);
            memoryStream.Read(photoBytes, 0, photoBytes.Length);

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand updateCommand = sqlConnection.CreateCommand();
            updateCommand.CommandText = $@"UPDATE PAT_MASTER
SET NAME =@NAME, CHARGE_TYPE =@CHARGE, COUNTRY =@COUNTRY, NATION =@NATION,[IDENTITY] =@IDENTITY, PROFESSION =@PRO, PHONE_NUMBER =@PHONE,PICTURE=@PICTURE
WHERE PAT_ID =@ID";
            /*updateCommand.CommandText = $@"UPDATE PAT_MASTER
SET NAME = @NAME, CHARGE_TYPE = @CHARGE, COUNTRY = @COUNTRY, NATION = @NATION,[IDENTITY] = @IDENTITY, PROFESSION = @PRO, PHONE_NUMBER = @PHONE,PICTURE=@PICTURE,
HOME_INDICATOR=@HOME_INDICATOR, MAILING_ADDRESS=@MAILING_ADDRESS, DATE_OF_BIRTH=@DATE_OF_BIRTH, BIRTH_PLACE=@BIRTH_PLACE, WORK_UNIT=@WORK_UNIT,
CONTACT_NAME=@CONTACT_NAME, CONTACT_PHONE=@CONTACT_PHONE,RELATIONSHIP=@RELATIONSHIP
WHERE PAT_ID = @ID";*/
            SqlCommand moreUpdateCommand = sqlConnection.CreateCommand();
            moreUpdateCommand.CommandText= $@"UPDATE PAT_MASTER
SET HOME_INDICATOR = @HOME_INDICATOR, MAILING_ADDRESS = @MAILING_ADDRESS, DATE_OF_BIRTH = @DATE_OF_BIRTH, BIRTH_PLACE = @BIRTH_PLACE, WORK_UNIT = @WORK_UNIT,
CONTACT_NAME = @CONTACT_NAME, CONTACT_PHONE = @CONTACT_PHONE, RELATIONSHIP = @RELATIONSHIP
WHERE ID_NO = @ID_NO";
            //！！！第四个参数应是主表查询中显示的列，即DataPropertyName的名称，而非列标题名称
            updateCommand.Parameters.Add("@NAME", SqlDbType.VarChar, 0, "姓名");
            updateCommand.Parameters.Add("@CHARGE", SqlDbType.VarChar, 0, "费别");
            updateCommand.Parameters.Add("@NATION", SqlDbType.Int, 0, "PNATION");                  
            updateCommand.Parameters.Add("@COUNTRY", SqlDbType.Int, 0, "PCOUNTRY");
            updateCommand.Parameters.Add("@PRO", SqlDbType.Int, 0, "PPROFESSION");
            updateCommand.Parameters.Add("@IDENTITY", SqlDbType.Int, 0, "PIDENTITY");
            updateCommand.Parameters.Add("@PHONE", SqlDbType.VarChar, 0, "电话号码");
            updateCommand.Parameters.Add("@ID", SqlDbType.Char, 10, "病人编号");
            updateCommand.Parameters.AddWithValue("@PICTURE", photoBytes);
            moreUpdateCommand.Parameters.AddWithValue("@HOME_INDICATOR",this.rdb_nonlocal.Checked);
            moreUpdateCommand.Parameters.AddWithValue("@MAILING_ADDRESS", this.txb_mailAddress.Text.Trim());
            moreUpdateCommand.Parameters.AddWithValue("@DATE_OF_BIRTH", this.dtp_birth.Value);
            moreUpdateCommand.Parameters.AddWithValue("@BIRTH_PLACE", this.txb_birthPlace.Text.Trim());
            moreUpdateCommand.Parameters.AddWithValue("@WORK_UNIT", this.txb_workUnit.Text.Trim());
            moreUpdateCommand.Parameters.AddWithValue("@CONTACT_NAME", this.txb_contactName.Text.Trim());
            moreUpdateCommand.Parameters.AddWithValue("@CONTACT_PHONE", this.txb_contactPhone.Text.Trim());
            moreUpdateCommand.Parameters.AddWithValue("@RELATIONSHIP", this.txb_relationship.Text.Trim());
            moreUpdateCommand.Parameters.AddWithValue("ID_NO", this.lbl_idNo.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.UpdateCommand = updateCommand;
            DataTable PatientTable = this._PatientTable;
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(PatientTable);
            int moreAffected = moreUpdateCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show($"成功更新{rowAffected+moreAffected}位病人信息。");
        }
        /// <summary>
        /// 根据编号搜索
        /// </summary>
        private void btn_noSearch_Click(object sender, EventArgs e)
        {
            DataRow searchResultRow = this._PatientTable.Rows.Find(this.txb_noSearch.Text.Trim());//借助本窗体的病人数据表的行集合的方法Find，根据主键值（即课程编号）快速查找相应课程，并返回其所在的数据行；但数据行不能作为数据源，需另行创建数据表，并导入该数据行，最后将数据表作为数据源；
            DataTable searchResultTable = this._PatientTable.Clone();//借助本窗体的病人数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
            searchResultTable.ImportRow(searchResultRow);//将（复制后的）数据行导入数据表；
            this.dgv_patient_info.DataSource=searchResultTable;
            //将数据网格视图的数据源设为搜索结果数据表；
        }
        /// <summary>
        /// 根据名称搜索
        /// </summary>
        private void btn_nameSearch_Click(object sender, EventArgs e)
        {
            DataRowView[] searchResultRowViews = this._PatientViewByName.FindRows(this.txb_nameSearch.Text.Trim());//借助本窗体的按名称排序的病人数据视图的方法FindRows，根据排序列（即病人名称）快速查找相应病人；由于该列并非主键，可能返回多行查询结果，故返回数据行视图数组；数据行视图数组不能直接作为数据源，需转为列表后方可作为数据源；
            DataTable searchResultTable = this._PatientTable.Clone();
            foreach (DataRowView view in searchResultRowViews)//遍历搜索结果所在数据行视图数组；
            {
                searchResultTable.ImportRow(view.Row);//通过每条数据行视图的属性Row获取相应的数据行，并导入数据表；
            }
            this.dgv_patient_info.DataSource = searchResultTable;

        }
        /// <summary>
        /// 单击DataGridView单元格事件
        /// </summary>
        private void dgv_patient_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
                SqlCommand sqlCommand = sqlConnection.CreateCommand(); 
                sqlCommand.CommandText = $@"SELECT P.ID_NO AS 身份证号,P.HOME_INDICATOR AS 地址标志,P.MAILING_ADDRESS AS 联系地址,P.DATE_OF_BIRTH AS 生日,
P.BIRTH_PLACE AS 出生地,P.WORK_UNIT AS 工作单位,P.CONTACT_NAME AS 联系人,P.CONTACT_PHONE AS 联系人电话,P.RELATIONSHIP AS 联系人关系,P.PICTURE 
FROM PAT_MASTER AS P WHERE P.PAT_ID='{this.dgv_patient_info.CurrentRow.Cells["病人编号"].Value}'";  //查询当前单元格病人信息
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                byte[] photoBytes = null;
                if (sqlDataReader.Read())
                {
                this.lbl_idNo.Text = sqlDataReader["身份证号"].ToString();
                this.rdb_local.Checked = !(bool)sqlDataReader["地址标志"];
                this.rdb_nonlocal.Checked = (bool)sqlDataReader["地址标志"];
                this.txb_mailAddress.Text = sqlDataReader["联系地址"].ToString();
                this.dtp_birth.Value = (DateTime)sqlDataReader["生日"];
                this.txb_birthPlace.Text = sqlDataReader["出生地"].ToString();
                this.txb_workUnit.Text = sqlDataReader["工作单位"].ToString();
                this.txb_contactName.Text = sqlDataReader["联系人"].ToString();
                this.txb_contactPhone.Text = sqlDataReader["联系人电话"].ToString();
                this.txb_relationship.Text = sqlDataReader["联系人关系"].ToString();
                photoBytes = (sqlDataReader["PICTURE"] == DBNull.Value ? null : (byte[])sqlDataReader["PICTURE"]);
                    
                }
                sqlConnection.Close();
                if(photoBytes != null)
                {
                    this.lbl_notice.Visible = false;
                    this.ptb_Photo.Visible = true;
                    MemoryStream memoryStream = new MemoryStream(photoBytes);
                    this.ptb_Photo.Image = Image.FromStream(memoryStream);
                    this.ptb_Photo.BackColor = Color.White;
                }
                else
                {
                    this.lbl_notice.Visible = true;
                    this.ptb_Photo.Visible = false;
                }
        }
        
        /// <summary>
        /// 根据拼音缩写搜索病人
        /// </summary>
        private void txb_pySearch_TextChanged(object sender, EventArgs e)
        {
            DataRow[] searchResultRows =
              this._PatientTable.Select($"PY LIKE '%{this.txb_pySearch.Text.Trim()}%'");					//借助本窗体的课程数据表的方法Select，并提供与SQL类似的谓词表达式作为查询条件，根据拼音缩写进行模糊查询（仅支持%通配符）；查询将返回数据行数组；
            DataTable searchResultTable = this._PatientTable.Clone();                                         //借助本窗体的课程数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
            foreach (DataRow row in searchResultRows)                                                       //遍历搜索结果所在数据行数组；
            {
                searchResultTable.ImportRow(row);                                                           //数据行导入数据表；
            }
            this.dgv_patient_info.DataSource = searchResultTable;                                                 //将数据网格视图的数据源设为搜索结果数据表；
        }
    }
}
