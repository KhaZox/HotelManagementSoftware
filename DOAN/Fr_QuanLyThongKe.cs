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
    public partial class Fr_QuanLyThongKe : Form
    {
        public Fr_QuanLyThongKe()
        {
            InitializeComponent();
        }

        private void Fr_QuanLyThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKS.HOADON' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
