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
    public partial class Fr_QuanLyNhanVien : Form
    {
        public Fr_QuanLyNhanVien()
        {
            InitializeComponent();
        }
        #region Load Data
        private void LoadData()
        {
            GetInfor LoadData = new GetInfor(dtgv);
            LoadData.GetInfor_NhanVien();
        }
        private void Fr_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            LoadData();
        }
        #endregion

        #region Phần Selected DatagridView và CheckBox
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_manv, txt_hovaten, txt_chucvu, cbb_gioitinh, txt_diachi, txt_sdt, txt_cccd, txt_luong);
            selected.Cell_Click_8_Value();
        }

        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_manv, txt_hovaten, txt_chucvu, cbb_gioitinh, txt_diachi, txt_sdt, txt_cccd, txt_luong);
            selected.Show_8_Value(true);
            txt_manv.Enabled = false;
        }

        //Phần Checkbox
        private void ckb_add_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_add.Checked)
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_manv, txt_hovaten, txt_chucvu, cbb_gioitinh, txt_diachi, txt_sdt, txt_cccd, txt_luong);
                selected.Show_8_Value(true);
                selected.Reset_8_Value();
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
            }
            else
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_manv, txt_hovaten, txt_chucvu, cbb_gioitinh, txt_diachi, txt_sdt, txt_cccd, txt_luong);
                selected.Show_8_Value(false);
                btn_them.Enabled = false;
            }
        }
        #endregion

        #region Phần cá nút button và tìm kiếm
        private void btn_them_Click(object sender, EventArgs e)
        {
            QL_NhanVien tt = new QL_NhanVien(dtgv);
            tt.Add_NhanVien(txt_manv.Text,txt_hovaten.Text,txt_chucvu.Text, cbb_gioitinh.SelectedItem.ToString(), txt_diachi.Text,txt_sdt.Text,txt_cccd.Text,float.Parse(txt_luong.Text));
            LoadData();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            QL_NhanVien tt = new QL_NhanVien(dtgv);
            tt.Edit_NhanVien(txt_manv.Text, txt_hovaten.Text, txt_chucvu.Text,cbb_gioitinh.SelectedItem.ToString(), txt_diachi.Text, txt_sdt.Text, txt_cccd.Text, float.Parse(txt_luong.Text));
            LoadData();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            QL_NhanVien tt = new QL_NhanVien(dtgv);
            tt.Del_NhanVien(txt_manv.Text);
            LoadData();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_search.Text = "";
        }
        //Phần Tìm kiếm
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            QL_NhanVien tt = new QL_NhanVien(dtgv);
            tt.Search_MaNV(txt_search.Text);
        }
        #endregion

        #region Kiểm tra dữ diệu nhập vào
        private void txt_cccd_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Number(txt_cccd);
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Number(txt_sdt);
        }

        private void txt_luong_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Number(txt_luong);
        }
        #endregion
    }
}
