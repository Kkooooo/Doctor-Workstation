using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 医生工作站
{
    public partial class PatientBed_Assign : Form
    {
        private string _nurseId;
        public PatientBed_Assign()
        {
            InitializeComponent();
        }
        public PatientBed_Assign(string nurseId):this()
        {
            this._nurseId = nurseId;
            this.PatientBed_Assign_Load();
        }
        private void PatientBed_Assign_Load()
        {

        }
        private void PatientBed_Assign_Load(object sender, EventArgs e)
        {

        }
    }
}
