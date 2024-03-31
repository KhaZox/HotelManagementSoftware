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
    public partial class Fr_Trangchu_NhanVien : Form
    {
        public Fr_Trangchu_NhanVien()
        {
            InitializeComponent();
        }
        //khai báo biến form hiện tại là form trang chủ_nhân viên
        private Form currentFrch;

        #region Các thao tác của các nút Button
        //Button phòng
        private void btn_phong_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_Phong());
            lbl_thaotac.Text = btn_phong.Text;
        }

        //Button quản lý đặt phòng
        private void btn_qldp_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyDatPhong());
            lbl_thaotac.Text = btn_qldp.Text;
        }

        //Button quản lý hóa đơn
        private void btn_QuanLyHoaDon_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyHoaDon());
            lbl_thaotac.Text = btn_QuanLyHoaDon.Text;
        }

        //Button quản lý khách hàng
        private void btn_qlkh_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyKhachHang());
            lbl_thaotac.Text = btn_qlkh.Text;
        }

        //Button quản lý phòng
        private void btn_qlp_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyPhong());
            lbl_thaotac.Text = btn_qlp.Text;
        }

        //Button quản lý loại phòng
        private void btn_qllp_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyLoaiPhong());
            lbl_thaotac.Text = btn_qllp.Text;
        }

        //button thoát
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
                this.Dispose();
            }
        }

        //Button đăng xuất
        private void btn_dx_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
                this.Dispose();
            }
        }
        #endregion
    }
}
