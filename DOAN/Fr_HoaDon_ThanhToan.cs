using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Fr_HoaDon_ThanhToan : Form
    {
        //Khai báo biến mã phiếu
        private int maphieu;
        public Fr_HoaDon_ThanhToan()
        {
            InitializeComponent();
        }
        public Fr_HoaDon_ThanhToan(int maphieu)
        {
            InitializeComponent();
            this.maphieu = maphieu;
        }
        //Phần Load dữ liệu
        private void Fr_HoaDon_Load(object sender, EventArgs e)
        {
            QL_HoaDon hd = new QL_HoaDon();
            hd.Load_ThanhToanHoaDon(maphieu, lbl_name, lbl_ngaylap, lbl_mahd, lbl_songuoi, lbl_name_nv, lbl_sophong, lbl_songay, lbl_thanhtien);
        }
    }
}
