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
    public partial class Fr_TrangChu : Form
    {
        public Fr_TrangChu()
        {
            InitializeComponent();
        }
        //khái báo biến về form hiện tại là form trang chủ
        private Form currentFrch;

        #region Các thao tác với các nút button

        //Button phòng
        private void btn_qldp_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_Phong());
            lbl_thaotac.Text = btn_phong.Text;
        }

        //Button quant lý đặt phòng
        private void btn_qlp_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyDatPhong());
            lbl_thaotac.Text = btn_qldp.Text;
        }

        //button quản lý hóa đơn
        private void btn_QuanLyHoaDon_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyHoaDon());
            lbl_thaotac.Text = btn_QuanLyHoaDon.Text;
        }

        //button quản lý nhân viên
        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyNhanVien());
            lbl_thaotac.Text = btn_qlnv.Text;
        }

        //button quản lý khách sạn
        private void btn_qlkh_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyKhachHang());
            lbl_thaotac.Text = btn_qlkh.Text;
        }

        //button quản lý duchj vụ
        private void btn_qldv_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyDichVu());
            lbl_thaotac.Text = btn_qldv.Text;
        }

        //button quản lý phòng
        private void btn_qlp_Click_1(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyPhong());
            lbl_thaotac.Text = btn_qlp.Text;
        }
        //button quản lý loại phòng
        private void btn_qllp_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyLoaiPhong());
            lbl_thaotac.Text = btn_qllp.Text;
        }

        //button quản lý loại dịch vụ
        private void btn_qlldv_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyLoaiDichVu());
            lbl_thaotac.Text = btn_qlldv.Text;
        }

        //button quản lý tiện nghi
        private void btn_qltn_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyTienNghi());
            lbl_thaotac.Text = btn_qltn.Text;
        }

        //button quản lý chi tiết tiện nghi
        private void btn_qlltn_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyCTTienNghi());
            lbl_thaotac.Text = btn_qlltn.Text;
        }

        //button quản lý thống kê
        private void btn_qltk_Click(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyThongKe());
            lbl_thaotac.Text = btn_qlthongke.Text;
        }

        //button quản lý tài khoản
        private void btn_qltk_Click_1(object sender, EventArgs e)
        {
            QL_Dangnhap ql = new QL_Dangnhap();
            ql.OpenChildForm(currentFrch, Panel_Body, new Fr_QuanLyTaiKhoan());
            lbl_thaotac.Text = btn_qltk.Text;
        }

        //button thoát
        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
                this.Dispose();
            }
        }

        //button đăng xuất
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất khỏi chương trình?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }

        //click vào panel sẽ hiển reset panelbody và thao tác
        private void Pnel_Pic_Click(object sender, EventArgs e)
        {
            Panel_Body.Controls.Clear();
            lbl_thaotac.Text = "";
        }
        #endregion
    }
}
