using System;
using System.Linq;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Fr_QuanLyDichVu : Form
    {
        public Fr_QuanLyDichVu()
        {
            InitializeComponent();
        }

        #region phần load dữ liệu
        private void LoadData()
        {
            GetInfor LoadData = new GetInfor(dtgv);
            LoadData.GetInfor_QLDichVu();
        }
        private void Fr_QuanLyDichVu_Load(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            LoadData();
            Load_Cbb();
        }
        private void Load_Cbb()
        {
            using (QLKSEntities4 db= new QLKSEntities4())
            {
                cbb_loaidv.DataSource = db.LOAIDICHVUs.ToList();
                cbb_loaidv.DisplayMember = "TENLOAIDV";
                cbb_loaidv.ValueMember = "TENLOAIDV";


            }
        }
        #endregion

        #region //Phần selected DatagridView và checkbox
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv,btn_sua,txt_madv,txt_tendv,cbb_loaidv,txt_dongia);
            selected.Cell_Click_4_1_Value();
            selected.Show_4_1_Value(false);
        }
        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_madv, txt_tendv, cbb_loaidv, txt_dongia);
            selected.Show_4_1_Value(true);
        }


        //Phần checkbox
        private void ckb_search_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_search.Checked)
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_madv, txt_tendv, cbb_loaidv, txt_dongia);
                selected.Show_4_1_Value(true);
                selected.Reset_4_Value();
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
            }
            else
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_madv, txt_tendv, cbb_loaidv, txt_dongia);
                selected.Show_4_1_Value(false);
                btn_them.Enabled = false;

            }
        }
#endregion


        #region //phần các nút button và tìm kiếm
        //Phàn tìm kiếm
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            QL_DV tt = new QL_DV(dtgv);
            tt.Search_DichVu(txt_search.Text);
        }
        //Phần các nút button
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_search.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            QL_DV tt = new QL_DV(dtgv); tt.Add_DichVu(cbb_loaidv,txt_madv.Text, txt_tendv.Text,float.Parse(txt_dongia.Text));
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            QL_DV tt = new QL_DV(dtgv); 
            tt.Edit_DichVu(cbb_loaidv, txt_madv.Text, txt_tendv.Text, float.Parse(txt_dongia.Text));
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            QL_DV tt = new QL_DV(dtgv);
            tt.Del_DichVu(txt_madv.Text);
            LoadData();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion

        //Phàn kiểm tra dữ liệu nhập vào
        private void txt_dongia_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Number(txt_dongia);
        }
    }
}
