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
    public partial class Fr_QuanLyTienNghi : Form
    {
        public Fr_QuanLyTienNghi()
        {
            InitializeComponent();
        }
        //Phần LoadData
        private void LoadData()
        {
            GetInfor LoadData = new GetInfor(dtgv);
            LoadData.GetInfor_TienNghi();
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
        }
        private void Fr_QuanLyTienNghi_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        //Phần Seclected DatagridView
        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_matn, txt_tenloaitn);
            selected.Double_Click_2_Value();
            btn_sua.Enabled = true;
        }
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv,btn_sua,txt_matn,txt_tenloaitn);
            selected.Cell_Click_2_Value();
        }

        //Phần checkbox
        private void ckb_add_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_add.Checked)
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_matn, txt_tenloaitn);
                selected.Show_2_Value(true);
                selected.Reset_2_Value();
                btn_sua.Enabled = false;
                btn_them.Enabled = true;
            }
            else
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_matn, txt_tenloaitn);
                selected.Show_2_Value(false);
                btn_them.Enabled = false;
            }

        }


        //Phần các nút button
        private void btn_them_Click(object sender, EventArgs e)
        {
            QL_TienNghi tn = new QL_TienNghi(dtgv);
            tn.Add_TienNghi(txt_matn.Text, txt_tenloaitn.Text);
            LoadData();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            QL_TienNghi tn = new QL_TienNghi(dtgv);
            tn.Edit_TienNghi(txt_matn.Text, txt_tenloaitn.Text);
            LoadData();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            QL_TienNghi tn = new QL_TienNghi(dtgv);
            tn.Del_TienNghi(txt_matn.Text);
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
            QL_TienNghi tn = new QL_TienNghi(dtgv);
            tn.Search_TenTienNghi(txt_search.Text);
        }
    }
}
