using System;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Fr_QuanLyLoaiPhong : Form
    {
        public Fr_QuanLyLoaiPhong()
        {
            InitializeComponent();
        }

        #region //Phần Load Data
        private void LoadData()
        {
            GetInfor LoadData = new GetInfor(dtgv);
            LoadData.GetInfor_QLLoaiPhong();
        }
        private void Fr_QuanLyLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadData();
            btn_them.Enabled = false;
        }
        #endregion

        #region //Phần selected DataGridview và checkbox
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv,btn_sua,txt_maloaiphong,txt_tenloaiphong,txt_sogiuong);
            selected.Cell_Click_3_Value();
            selected.Show_3_Value(false);
        }
        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_maloaiphong, txt_tenloaiphong, txt_sogiuong);
            selected.Show_3_Value(true);
            txt_maloaiphong.Enabled = false;
        }

        //Phần checkbox
        private void ckb_add_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_add.Checked)
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_maloaiphong, txt_tenloaiphong, txt_sogiuong);
                selected.Show_3_Value(true);
                selected.Reset_3_Value();
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
            }
            else
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_maloaiphong, txt_tenloaiphong, txt_sogiuong);
                selected.Show_3_Value(false);
                btn_them.Enabled = false;
            }

        }
#endregion

        #region //Phần các nút button và tìm kiếm
        private void btn_them_Click(object sender, EventArgs e)
        {
            QL_LoaiPhong tt = new QL_LoaiPhong(dtgv);
            tt.Add_LoaiPhong(txt_maloaiphong.Text, txt_tenloaiphong.Text, int.Parse(txt_sogiuong.Text));
            LoadData();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            QL_LoaiPhong tt = new QL_LoaiPhong(dtgv);
            tt.Edit_LoaiPhong(txt_maloaiphong.Text, txt_tenloaiphong.Text, int.Parse(txt_sogiuong.Text));
            LoadData();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            QL_LoaiPhong tt = new QL_LoaiPhong(dtgv);
            tt.Del_LoaiPhong(txt_maloaiphong.Text);
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

        //Phần tìm kiếm
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            QL_LoaiPhong tt = new QL_LoaiPhong(dtgv);
            tt.Search_MaLoaiPhong(txt_search.Text);
        }
        #endregion

        #region kiểm tra dữ diệu nhập vào
        private void txt_sogiuong_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Number(txt_sogiuong);
        }
        #endregion
    }
}
