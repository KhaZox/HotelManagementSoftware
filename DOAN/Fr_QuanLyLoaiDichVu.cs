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
    public partial class Fr_QuanLyLoaiDichVu : Form
    {
        public Fr_QuanLyLoaiDichVu()
        {
            InitializeComponent();
        }

        //Phần LoadData
        private void LoadData()
        {
            GetInfor LoadData = new GetInfor(dtgv);
            LoadData.GetInfor_QLLoaiDichVu();
        }
        private void Fr_QuanLyLoaiDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
            btn_them.Enabled = false;
        }


        //Phần selected datagridView
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_maloaidv, txt_tenloaidv);
            selected.Cell_Click_2_Value();
            selected.Show_2_Value(false);
        }
        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_maloaidv, txt_tenloaidv);
            selected.Show_2_Value(true);
            txt_maloaidv.Enabled = false;
        }


        //Phần các nút butotn
        private void btn_them_Click(object sender, EventArgs e)
        {
            QL_LoaiDV tt = new QL_LoaiDV(dtgv);
            tt.Add_LoaiDV(txt_maloaidv.Text, txt_tenloaidv.Text);
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            QL_LoaiDV tt = new QL_LoaiDV(dtgv);
            tt.Edit_LoaiDV(txt_maloaidv.Text, txt_tenloaidv.Text);
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            QL_LoaiDV tt = new QL_LoaiDV(dtgv);
            tt.Del_LoaiDV(txt_maloaidv.Text);
            LoadData();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        
        //Phần tìm kiếm
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            QL_LoaiDV tt = new QL_LoaiDV(dtgv);
            tt.Search_TenLoaiDV(txt_search.Text);
        }


        //Phần Checkbox
        private void ckb_add_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_add.Checked)
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_maloaidv, txt_tenloaidv);
                selected.Show_2_Value(true);
                selected.Reset_2_Value();
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
            }
            else
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_maloaidv, txt_tenloaidv);
                selected.Show_2_Value(false);
                btn_them.Enabled = false;
            }

        }
    }
}
