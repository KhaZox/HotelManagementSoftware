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
    public partial class Fr_Phong_DichVu : Form
    {
        public Fr_Phong_DichVu()
        {
            InitializeComponent();
        }

        //Phần load dữ liệu
        private void LoadComboBox_Phong()
        {
            using (QLKSEntities4 db= new QLKSEntities4())
            {
                cbb_phong.DataSource = db.PHONGs.ToList();
                cbb_phong.DisplayMember = "MAPHONG";
                cbb_phong.ValueMember = "MAPHONG";
            }
        }
        private void LoadComboBox_DichVu()
        {
            using (QLKSEntities4 db = new QLKSEntities4())
            {
                cbb_madv.DataSource = db.DICHVUs.ToList();
                cbb_madv.DisplayMember = "MADV";
                cbb_madv.ValueMember = "MADV";
            }
        }
        private void LoadData()
        {
            GetInfor infor = new GetInfor(dtgv);
            infor.GetInfor_Phong_DichVu();
        }
        private void Fr_Phong_DichVu_Load(object sender, EventArgs e)
        {
            LoadComboBox_Phong();
            LoadComboBox_DichVu();
            LoadData();
        }

        //Phần thao tác với các nút button
        private void btn_them_Click(object sender, EventArgs e)
        {
            QL_DV tt = new QL_DV(dtgv);
            tt.Add_DichVu_Phong(cbb_phong.SelectedValue.ToString(), cbb_madv.SelectedValue.ToString());
            LoadData();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            QL_DV tt = new QL_DV(dtgv);
            tt.Del_DichVu_Phong(cbb_phong.SelectedValue.ToString(), cbb_madv.SelectedValue.ToString());
            LoadData();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            LoadData();
        }

        //Phần thao tác với DataGridView
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, cbb_phong, txt_tenphong, cbb_madv, txt_tendv, txt_tenloaidv, txt_dongia);
            selected.Cell_Click_6_Value();
            selected.Show_6_Value(false);
            
        }

        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, cbb_phong, txt_tenphong, cbb_madv, txt_tendv, txt_tenloaidv, txt_dongia);
            selected.Show_6_Value(false);
            cbb_madv.Enabled = true;
            cbb_phong.Enabled = true;
        }

        //Phần tìm kiếm
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            QL_DV tt = new QL_DV(dtgv);
            tt.Search_DichVu_Phong(txt_search.Text);
        }
    }
}
