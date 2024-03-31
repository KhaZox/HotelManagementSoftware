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
    public partial class Fr_QuanLyHoaDon : Form
    {
        public Fr_QuanLyHoaDon()
        {
            InitializeComponent();
        }
        #region //Phàn load data
        private void LoadData()
        {
            GetInfor infor = new GetInfor(dtgv);
            infor.GetInfor_HoaDon();
        }
        private void Fr_QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region  //Phần thao tác với datagridview
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_thoat, txt_mahd, txt_mactphieuthue, txt_ngaylap, txt_tenkh, txt_tongtien);
            selected.Cell_Click_5_Value();
            selected.Show_5_Value(false);
            btn_thoat.Enabled = true;
        }
        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_thoat, txt_mahd, txt_mactphieuthue, txt_ngaylap, txt_tenkh, txt_tongtien);
            selected.Show_5_Value(true);
        }
        #endregion

        //Phần tìm kiếm
        private void txt_seach_TextChanged(object sender, EventArgs e)
        {
            QL_HoaDon hd = new QL_HoaDon();
            hd.Search_HoaDon(dtgv, txt_seach.Text);
        }

        //btn thoát
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

    }
}
