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
    public partial class Fr_QuanLyPhong : Form
    {
        public Fr_QuanLyPhong()
        {
            InitializeComponent();
        }

        //Phần Load Data
        private void LoadData()
        {
            GetInfor LoadData = new GetInfor(dtgv);
            LoadData.GetInfor_QLPhong();
        }
        private void Load_CbbTinhTrang()
        {
            using (QLKSEntities4 db= new QLKSEntities4())
            {
                cbb_tinhtrang.DataSource = db.TINHTRANGs.ToList();
                cbb_tinhtrang.DisplayMember = "TRANGTHAI";
                cbb_tinhtrang.ValueMember = "TRANGTHAI";
            }
        }
        private void Load_CbbTENLOAIPHONG()
        {
            using (QLKSEntities4 db = new QLKSEntities4())
            {
                cbb_loaiphong.DataSource = db.LOAIPHONGs.ToList();
                cbb_loaiphong.DisplayMember = "TENLOAIPHONG";
                cbb_loaiphong.ValueMember = "TENLOAIPHONG";
            }
        }
        private void Fr_QuanLyPhong_Load(object sender, EventArgs e)
        {
            LoadData();
            Load_CbbTENLOAIPHONG();
            Load_CbbTinhTrang();
            cbb_loaiphong.Enabled = false;
            cbb_tinhtrang.Enabled = false;
        }

        //Phần selected DataGridView
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_sophong,txt_trigiaphong, cbb_tinhtrang, cbb_loaiphong);
            selected.Cell_Click_4_2_Value();
        }
        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_sophong, txt_trigiaphong, cbb_tinhtrang, cbb_loaiphong);
            selected.Double_Click_4_2_Value();
        }

        //Phần checkbox
        private void ckb_add_CheckStateChanged(object sender, EventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_sua, txt_sophong, txt_trigiaphong, cbb_tinhtrang, cbb_loaiphong);
            selected.Show_4_2_Value(true);
            selected.Reset_4_2_Value();
        }


        //Phần các nút butotn
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string a = cbb_tinhtrang.SelectedValue.ToString();
            string b = cbb_loaiphong.SelectedValue.ToString();
            float c = float.Parse(txt_trigiaphong.Text);
            QL_Phong tt = new QL_Phong(dtgv);
            tt.Edit__QLPhong(txt_sophong.Text,a,b,c);
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
            QL_Phong tt = new QL_Phong(dtgv);
            tt.Search_MaPhong(txt_search.Text);
        }

        //Check giá trị nhập vào
        private void txt_trigiaphong_TextChanged(object sender, EventArgs e)
        {
            Check_TextBox check = new Check_TextBox();
            check.Value_Number(txt_trigiaphong);
        }
    }
}
