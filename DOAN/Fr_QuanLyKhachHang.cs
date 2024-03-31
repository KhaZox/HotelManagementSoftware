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
    public partial class Fr_QuanLyKhachHang : Form
    {
        public Fr_QuanLyKhachHang()
        {
            InitializeComponent();
        }

        #region //Phần Load Data
        private void LoadData()
        {
            GetInfor LoadData = new GetInfor(dtgv);
            LoadData.GetInfor_Khachang();
        }
        private void Fr_QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            LoadData();
        }
        #endregion

        #region //Phần selected datagridview
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv,btn_sua,txt_makh,txt_hovaten,txt_cccd,txt_sdt,txt_diachi,cbb_gioitinh,txt_quoctich);
            selected.Cell_Click_7_Value();
        }
        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_makh, txt_hovaten, txt_cccd, txt_sdt, txt_diachi, cbb_gioitinh, txt_quoctich);
            selected.Show_7_Value(true);
            txt_makh.Enabled = false;
        }


        //Phần checkbox
        private void ckb_add_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_add.Checked)
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_makh, txt_hovaten, txt_cccd, txt_sdt, txt_diachi, cbb_gioitinh, txt_quoctich);
                selected.Show_7_Value(true);
                selected.Reset_7_Value();
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
            }
            else
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_makh, txt_hovaten, txt_cccd, txt_sdt, txt_diachi, cbb_gioitinh, txt_quoctich);
                selected.Show_7_Value(false);
                btn_them.Enabled = false;
            }
        }
        #endregion

        #region Phần các nút button và tìm kiếm
        //Phần search
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            QL_KhachHang tt = new QL_KhachHang(dtgv); tt.Search_Khachhang(txt_search.Text);
            tt.Search_Khachhang(txt_search.Text);
        }
        //phần button
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_search.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            QL_KhachHang tt = new QL_KhachHang(dtgv);
            tt.Add_Khachang(txt_makh.Text, txt_hovaten.Text, txt_cccd.Text, txt_sdt.Text, txt_diachi.Text, cbb_gioitinh.SelectedItem.ToString(), txt_quoctich.Text);
            
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            QL_KhachHang tt = new QL_KhachHang(dtgv); 
            tt.Edit_Khachhang(txt_makh.Text,txt_hovaten.Text, txt_cccd.Text, txt_sdt.Text,cbb_gioitinh.SelectedItem.ToString(), txt_diachi.Text,txt_quoctich.Text);
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            QL_KhachHang tt = new QL_KhachHang(dtgv); tt.Del_Khahhang(txt_makh.Text);
            LoadData();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion

        #region check dữ liệu nhập vào
        private void txt_hovaten_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Text(txt_hovaten);
        }

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
        private void txt_quoctich_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Number(txt_quoctich);
        }
        #endregion
    }
}
