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
    public partial class Fr_DatPhong : Form
    {
        public Fr_DatPhong()
        {
            InitializeComponent();
        }
        public Fr_DatPhong(string name)
        {
            InitializeComponent();
        }

        #region//Load Dữ liệu
        private void Fr_DatPhong_Load(object sender, EventArgs e)
        {
            QL_DatPhong qldp = new QL_DatPhong(dtgv1);
            qldp.DanhSachPhongTrong();
            qldp.Load_Cbb(cbb_manv);
        }
        #endregion

        #region//Các thao tác với Button
        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi Form?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                this.Close();
                this.Dispose();
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn Lưu thông tin này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string gt = cbb_gioitinh.SelectedItem.ToString();
                QL_DatPhong qldp = new QL_DatPhong();
                QL_KhachHang qlkh = new QL_KhachHang(dtgv1);
                qlkh.Add_Khachang(txt_makh.Text, txt_ten.Text, txt_cccd.Text, txt_sdt.Text, txt_dc.Text, gt, txt_quoctich.Text);
                qldp.ThemPhieuDatPhong(txt_makh, cbb_manv, int.Parse(txt_songuoi.Text), dtgv1, datetime_ngaythue, datetime_ngaytra);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Phần kiểm tra dữ liệu nhập vào
        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Number(txt_sdt);
        }

        private void txt_cccd_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Number(txt_cccd);
        }

        private void txt_songuoi_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Number(txt_songuoi);
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Text(txt_ten);
        }

        private void txt_quoctich_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Text(txt_quoctich);
        }
        #endregion
    }
}
