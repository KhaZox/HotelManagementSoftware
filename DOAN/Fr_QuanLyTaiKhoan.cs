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
    public partial class Fr_QuanLyTaiKhoan : Form
    {
        public Fr_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        //Phần Load Data
        private void LoadData()
        {
            GetInfor LoadData = new GetInfor(dtgv);
            LoadData.GetInfor_QLTaiKhoan();
        }
        private void Fr_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            LoadData();
        }

        //phần Select vào datagridview
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_matk, txt_user, txt_pas,txt_manv,txt_capdoquyen);
            selected.Cell_Click_5_Value();

        }
        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_matk,txt_user, txt_pas, txt_manv, txt_capdoquyen);
            selected.Double_Click_5_Value();
            selected.Show_5_Value(true);
            txt_manv.Enabled = false;
            txt_matk.Enabled = false;
        }

        //phàn checkbox
        private void ckb_add_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_add.Checked)
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_matk, txt_user, txt_pas, txt_manv, txt_capdoquyen);
                selected.Show_5_Value(true);
                selected.Reset_5_Value();
                btn_sua.Enabled = false;
                btn_them.Enabled = true;
                txt_matk.Enabled = false;
            }
            else
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_matk, txt_user, txt_pas, txt_manv, txt_capdoquyen);
                selected.Show_5_Value(false);
                btn_them.Enabled = false;
            }
        }

        //Các thao tác với nút button
        private void btn_them_Click(object sender, EventArgs e)
        {
            int capdoquyen = int.Parse(txt_capdoquyen.Text);
            QL_TaiKhoan tt = new QL_TaiKhoan(dtgv);
            tt.Add_TaiKhoan(txt_user.Text, txt_pas.Text,txt_manv.Text, capdoquyen);
            LoadData();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            int capdoquyen = int.Parse(txt_capdoquyen.Text);

            QL_TaiKhoan tt = new QL_TaiKhoan(dtgv);
            tt.Edit_TaiKhoan(txt_user.Text, txt_pas.Text,txt_manv.Text, capdoquyen);
            LoadData();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            QL_TaiKhoan tt = new QL_TaiKhoan(dtgv);
            tt.Del_TaiKhoan(int.Parse(txt_matk.Text));
            LoadData();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_search.Text = "";
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        //Phần tìm kiếm
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            QL_TaiKhoan tt = new QL_TaiKhoan(dtgv);
            tt.Search_TenTK(txt_search.Text);
        }

    }
}
