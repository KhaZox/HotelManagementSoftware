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
    public partial class Fr_QuanLyDatPhong : Form
    {
        public Fr_QuanLyDatPhong()
        {
            InitializeComponent();
        }

        #region //Load dữ liệu
        private void Fr_QuanLyDatPhong_Load(object sender, EventArgs e)
        {
            GetInfor LoadData = new GetInfor(dtgv);
            LoadData.GetInfor_PhieuDatPhong();
        }
        #endregion

        #region //Các thoa tác với DataGridView
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_tinhtien, txt_sophieuthue, txt_tenkhachang, txt_ngaylap, txt_tennv);
            selected.Cell_Click_4_Value();
            selected.Show_4_Value(false);
            btn_tinhtien.Enabled = true;
        }
        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_DataGridView selected = new Selected_DataGridView(dtgv, btn_tinhtien, txt_sophieuthue, txt_tenkhachang, txt_ngaylap, txt_tennv);
            selected.Cell_Click_4_Value();
            selected.Show_4_Value(true);
        }
        private void dtgv_SelectionChanged(object sender, EventArgs e)
        {
            QL_DatPhong ql = new QL_DatPhong(dtgv);
            ql.ChonPhieu(txt_manv, txt_makh, txt_songuoi, txt_tenphong, txt_maphong);
        }
        #endregion

        #region //Các nút Button thực hiện và tìm kiếm
        private void btn_datphong_Click(object sender, EventArgs e)
        {
            Fr_DatPhong fr = new Fr_DatPhong();
            fr.ShowDialog();
        }
        private void btn_tinhtien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thanh toán phòng này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                string ngaylapValue = txt_ngaylap.Text;
                QL_HoaDon qlhd = new QL_HoaDon();
                QL_DatPhong qldp = new QL_DatPhong();
                DateTime ngaytra = datetime_ngaytra.Value;
                if (DateTime.TryParse(ngaylapValue, out DateTime ngaylap))
                {
                    qlhd.ThemHoaDon(txt_makh, txt_manv, ngaylap, ngaytra, txt_maphong);
                    qldp.TraPhong(dtgv);
                    int maphieu = int.Parse(txt_sophieuthue.Text);
                    Fr_HoaDon_ThanhToan fr = new Fr_HoaDon_ThanhToan(maphieu);
                    fr.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kiểu ngày không đúng", "Thông báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_nhanphong_Click(object sender, EventArgs e)
        {
            QL_DatPhong qldp = new QL_DatPhong();
            qldp.NhanPhong(dtgv);
        }
        private void btn_themdv_Click(object sender, EventArgs e)
        {
            Fr_Phong_DichVu fr = new Fr_Phong_DichVu();
            fr.ShowDialog();
        }
        //Tìm kiếm theo tên khách hàng hoặc tên nhân viên
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            QL_DatPhong ql = new QL_DatPhong(dtgv);
            ql.Search_NameKH(txt_search.Text);
        }
        #endregion
    }
}
