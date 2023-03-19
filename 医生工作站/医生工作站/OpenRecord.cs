using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 医生工作站
{
    public partial class OpenRecord : Form
    {
        public OpenRecord()
        {
            InitializeComponent();
        }

        private void OpenRecord_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "";
            sqlConnection.Open();
            
        }
    }
}
