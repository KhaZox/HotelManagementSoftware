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
    public partial class Fr_QuanLyCTTienNghi : Form
    {
        public Fr_QuanLyCTTienNghi()
        {
            InitializeComponent();
        }

        #region //Phần Load Data
        private void LoadData()
        {
            GetInfor LoadData = new GetInfor(dtgv);
            LoadData.GetInfor_CTTienNghi();
        }
        private void Fr_QuanLyCTTienNghi_Load(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            txt_tentn.Enabled = false;
            cbb_macttn.Enabled = false;
            cbb_MaPhong.Enabled = false;
            LoadData();
            LoadCbb();
            LoadCbb_mcttn();
        }
        private void LoadCbb()
        {
            using (QLKSEntities4 db = new QLKSEntities4())
            {
                cbb_MaPhong.DataSource = db.PHONGs.ToList();
                cbb_MaPhong.DisplayMember = "MAPHONG";
                cbb_MaPhong.ValueMember = "MAPHONG";
            }
        }
        private void LoadCbb_mcttn()
        {
            using (QLKSEntities4 db = new QLKSEntities4())
            {
                cbb_macttn.DataSource = db.CTTIENNGHIs.ToList();
                cbb_macttn.DisplayMember = "MACTTN";
                cbb_macttn.ValueMember = "MACTTN";
            }
        }
        #endregion

        #region //Phần selected datagridview và checkbox
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_tentn, txt_soluong, cbb_macttn,cbb_MaPhong);
            selected.Cell_Click_4_2_Value();
            selected.Show_4_2_Value(false);
        }
        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_tentn, txt_soluong, cbb_macttn, cbb_MaPhong);
            selected.Show_4_2_Value(true);
        }
        //Phần check box thêm
        private void ckb_add_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_add.Checked)
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_tentn, txt_soluong, cbb_macttn, cbb_MaPhong);
                selected.Show_4_2_Value(true);
                selected.Reset_4_2_Value();
                btn_sua.Enabled = false;
                btn_them.Enabled = true;
                txt_tentn.Enabled = false;
            }
            else
            {
                Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_tentn, txt_soluong, cbb_macttn, cbb_MaPhong);
                selected.Show_4_2_Value(false);
                btn_them.Enabled = false;
            }
        }
        #endregion

        #region //Phần search và các thao tác button
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            QL_CTTIENNGHI tt = new QL_CTTIENNGHI(dtgv);
            tt.Search_CTTTienNghi(txt_search.Text);
        }

        //Phàn các nút button
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_search.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            QL_CTTIENNGHI tt = new QL_CTTIENNGHI(dtgv);
            tt.Add_CTTienNghi(cbb_macttn.SelectedValue.ToString(), cbb_MaPhong.SelectedValue.ToString(),int.Parse(txt_soluong.Text));
            LoadData();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            QL_CTTIENNGHI tt = new QL_CTTIENNGHI(dtgv);
            tt.Edit_CTTienNghi(cbb_macttn.SelectedValue.ToString(), cbb_MaPhong.SelectedValue.ToString(), int.Parse(txt_soluong.Text));
            LoadData();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            QL_CTTIENNGHI tt = new QL_CTTIENNGHI(dtgv);
            tt.Del_CTTienNghi(cbb_macttn.Text);
            LoadData();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion

        //phần kiêm tra dữ liệu nhập vào
        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Number(txt_soluong);
        }
    }
}
