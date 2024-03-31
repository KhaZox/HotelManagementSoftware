using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    internal class QL_DatPhong
    {
        //khai báo biến
        private DataGridView dtgv { get; set; }

        //contructor
        public QL_DatPhong() { }
        public QL_DatPhong(DataGridView dtgv)
        {
            this.dtgv = dtgv;
        }

        /// <summary>
        ///  Hiển thị danh sách phòng trống
        /// </summary>
        public void DanhSachPhongTrong()
        {
            using (QLKSEntities4 db = new QLKSEntities4())
            {
                // Truy vấn lấy thông tin các phòng trống
                var query = from phong in db.PHONGs // Lấy từ bảng PHONGs
                            where phong.TINHTRANG.TRANGTHAI == "Trống" // Lọc những phòng có tình trạng "Trống" 
                            select new 
                            {
                                TENPHONG = phong.TENPHONG,
                                TENLOAIPHONG = phong.LOAIPHONG.TENLOAIPHONG,
                            };
                dtgv.DataSource = query.ToList();
            }
        }

        /// <summary>
        /// Hàm Thêm phiếu đặt phòng
        /// </summary>
        /// <param name="maKH"></param>
        /// <param name="cbb_manv"></param>
        /// <param name="songuoi"></param>
        /// <param name="dataGridView"></param>
        /// <param name="ngayDK"></param>
        /// <param name="ngayTra"></param>
        public void ThemPhieuDatPhong(TextBox maKH, ComboBox cbb_manv, int songuoi, DataGridView dataGridView, DateTimePicker ngayDK, DateTimePicker ngayTra)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    //Hàng được chọn
                    int rowIndex = dataGridView.CurrentCell.RowIndex;

                    if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
                    {
                        //Chọn cột phòng đầu tiên
                        string tenPhong = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                        //Tìm phòng dựa vào tên phòng
                        var phong = db.PHONGs.FirstOrDefault(p => p.TENPHONG == tenPhong);

                        if (phong != null)
                        {
                            PHIEUDATPHONG phieuDatPhong = new PHIEUDATPHONG()
                            {
                                MAPHONG = phong.MAPHONG,
                                TENPHONG = tenPhong,
                                MAKH = maKH.Text,
                                NGAYDK = ngayDK.Value,
                                NGAYTRA = ngayTra.Value,
                                MANV = cbb_manv.Text,
                                SONGUOI = songuoi
                            };
                            db.PHIEUDATPHONGs.Add(phieuDatPhong);
                            db.SaveChanges();
                            //Cập nhật trạng thái của phòng
                            var updatedPhong = db.PHONGs.FirstOrDefault(p => p.MAPHONG == phong.MAPHONG);
                            if (updatedPhong != null)
                            {
                                updatedPhong.MATINHTRANG = "TT003";
                                db.SaveChanges();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông tin lỗi cho bạn để kiểm tra.
                MessageBox.Show("Error: " + ex.Message);
                if (ex.InnerException != null)
                {
                    MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                }
            }
        }
        
        
        //Load Combobox Mã nhân viên
        public void Load_Cbb(ComboBox cbb_manv)
        {
            using (QLKSEntities4 db = new QLKSEntities4())
            {
                cbb_manv.DataSource = db.NHANVIENs.ToList();
                cbb_manv.DisplayMember = "MANV";
                cbb_manv.ValueMember = "MANV";
            }
        }

        /// <summary>
        /// Hàm Nhận phòng dùng để cập nhật trạng thái phòng từ đã đặt trước thành đang sử dụng
        /// </summary>
        /// <param name="dataGridView"></param>
        public void NhanPhong(DataGridView dataGridView)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    if (MessageBox.Show("Bạn muốn nhận phòng này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        //Số hàng đang chọn
                        int rowIndex = dataGridView.CurrentCell.RowIndex;

                        if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
                        {
                            int maphieu = int.Parse(dataGridView.Rows[rowIndex].Cells[0].Value.ToString());
                            //Tìm kiếm tên phòng trong PHIEUDATPHONG dựa trên mã phiếu
                            string tenphong = db.PHIEUDATPHONGs.Where(p => p.MAPHIEU == maphieu).Select(p => p.TENPHONG).FirstOrDefault();
                            //Tìm phòng
                            var phong = db.PHONGs.FirstOrDefault(p => p.TENPHONG == tenphong);
                            if (phong != null)
                            {
                                phong.MATINHTRANG = "TT002";
                                db.SaveChanges();
                            }
                        }
                        MessageBox.Show("Nhận phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông tin lỗi cho bạn để kiểm tra.
                MessageBox.Show("Error: " + ex.Message);
                if (ex.InnerException != null)
                {
                    MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                }
            }
        }

        /// <summary>
        /// Hàm thanh toán phòng
        /// </summary>
        /// <param name="dataGridView"></param>
        public void TraPhong(DataGridView dataGridView)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    int rowIndex = dataGridView.CurrentCell.RowIndex;

                    if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
                    {
                        int maphieu = int.Parse(dataGridView.Rows[rowIndex].Cells[0].Value.ToString());
                        string tenphong = db.PHIEUDATPHONGs.Where(p => p.MAPHIEU == maphieu).Select(p => p.TENPHONG).FirstOrDefault();
                        var phong = db.PHONGs.FirstOrDefault(p => p.TENPHONG == tenphong);
                        if (phong != null)
                        {
                            phong.MATINHTRANG = "TT001";
                            db.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông tin lỗi cho bạn để kiểm tra.
                MessageBox.Show("Error: " + ex.Message);
                if (ex.InnerException != null)
                {
                    MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                }
            }
        }

        /// <summary>
        /// Tìm kiếm tên nhan viên hoặc tên khách hàng
        /// </summary>
        /// <param name="search"></param>
        public void Search_NameKH(string search)
        {
            using (QLKSEntities4 db= new QLKSEntities4())
            {
                var manv = db.PHIEUDATPHONGs.Select(x => x.MANV).FirstOrDefault();
                var query = from c in db.PHIEUDATPHONGs.Where(x=>x.PHONG.TENPHONG.Contains(search) || x.KHACHHANG.HOVATEN.Contains(search))
                //var query = from c in db.PHIEUDATPHONGs.Where(x=>x.KHACHHANG.HOVATEN.Contains(search) || x.NHANVIEN.HOVATEN.Contains(search))
                            select new
                            {
                                c.MAPHIEU,
                                HOVATEN1= c.KHACHHANG.HOVATEN,
                                c.NGAYDK,
                                HOVATEN2= c.NHANVIEN.HOVATEN,
                            };
                dtgv.DataSource = query.ToList();
            }
        }

        /// <summary>
        /// Hàm chọn phiếu để hiển thị ra thêm các thông tin manv, mkh, tên phòng, số người và mã phòng
        /// </summary>
        /// <param name="txt_manv"></param>
        /// <param name="txt_makh"></param>
        /// <param name="txt_songuoi"></param>
        /// <param name="txt_tenphong"></param>
        /// <param name="txt_maphong"></param>
        public void ChonPhieu(TextBox txt_manv, TextBox txt_makh,TextBox txt_songuoi, TextBox txt_tenphong, TextBox txt_maphong)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    int mnv = int.Parse(dtgv.CurrentRow.Cells["MAPHIEU"].Value.ToString());
                    var query = db.PHIEUDATPHONGs.Where(x => x.MAPHIEU == mnv);
                    if (query != null)
                    {
                        txt_manv.Text = query.Select(x => x.MANV).FirstOrDefault();
                        txt_makh.Text = query.Select(x => x.MAKH).FirstOrDefault();
                        txt_songuoi.Text = query.Select(x => x.SONGUOI).FirstOrDefault().ToString();
                        txt_tenphong.Text = query.Select(x => x.TENPHONG).FirstOrDefault();
                        txt_maphong.Text = query.Select(x => x.MAPHONG).FirstOrDefault().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
