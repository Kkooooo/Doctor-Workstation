using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 医生工作站
{
    public partial class WebSearch : Form
    {
        public WebSearch()
        {
            InitializeComponent();
        }

        private void WebSearch_Load(object sender, EventArgs e)
        {
            this.wbs_baidu.Navigate("https://www.baidu.com");
        }
    }
}
