using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Fr_Phong : Form
    {
        public Fr_Phong()
        {
            InitializeComponent();
        }
        
        //Load dữ liệu
        private void Fr_Phong_Load(object sender, EventArgs e)
        {
            QL_Phong ql = new QL_Phong();
            ql.Load_Phong(flowLayoutPanel1);

        }
    }
}
