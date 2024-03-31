using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    internal class QL_HoaDon
    {
        //Contructor
        public QL_HoaDon() { }

        /// <summary>
        /// Hàm thêm hóa đơn
        /// </summary>
        /// <param name="makh"></param>
        /// <param name="manv"></param>
        /// <param name="ngaylap"></param>
        /// <param name="ngaytra"></param>
        /// <param name="maphong"></param>
        public void ThemHoaDon(TextBox makh, TextBox manv, DateTime ngaylap, DateTime ngaytra, TextBox maphong)
        {
            using (QLKSEntities4 db = new QLKSEntities4())
            {
                string makhh = makh.Text;
                string manvv = manv.Text;
                string maphongg = maphong.Text;
                // Truy xuất bản ghi PHIEUDATPHONG được liên kết với phòng đã cho
                PHIEUDATPHONG phieuDatPhong = db.PHIEUDATPHONGs.FirstOrDefault(pd => pd.MAPHONG == maphongg && pd.NGAYDK == ngaylap);
                if (phieuDatPhong == null)
                {
                    MessageBox.Show("Vui lòng chọn thời gian phù hợp", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Tính giá phòng dựa trên phiếu đặt phòng và hàm tính tiền CalculateRoomCost
                double trigiaPhong = CalculateRoomCost(phieuDatPhong.PHONG, ngaylap, ngaytra);
                // Tìm và tính trị giá dịch vụ
                double trigiaDV = db.DICHVUPHONGs.Where(dp => dp.MAPHONG == maphongg).Sum(dp => dp.TRIGIADV) ?? 0;
                // Tính tổng hóa đơn
                double tongHoaDon = trigiaDV + trigiaPhong;
                // Tạo hóa đơn mới
                var newHoaDon = new HOADON
                {
                    MAPHIEU = phieuDatPhong.MAPHIEU,
                    MAKH = makhh,
                    MANV = manvv,
                    NGAYLAP = ngaylap,
                    NGAYTRA = ngaytra,
                    MAPHONG = maphongg,
                    TENPHONG = phieuDatPhong.TENPHONG,
                    TRIGIADV = trigiaDV,
                    TRIGIAPHONG = trigiaPhong,
                    TONGHOADON = tongHoaDon
                };
                db.HOADONs.Add(newHoaDon);
                db.SaveChanges();
                MessageBox.Show("Thanh toán thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Hàm tính toán tiền phòng và dịch vụ
        /// </summary>
        /// <param name="phong"></param>
        /// <param name="ngayLap"></param>
        /// <param name="ngayTra"></param>
        /// <returns></returns>
        private double CalculateRoomCost(PHONG phong, DateTime ngayLap, DateTime ngayTra)
        {
            double tongtien = 0;
            double giagio = phong.TRIGIAPHONG / 24 ?? 0; // Giá tiền phòng trên mỗi giờ

            //TimeSpan đại diện khoảng thơi giang trôi qua giữa hai ngày gồm ngày giờ phút
            TimeSpan ngaysudung = ngayTra - ngayLap; // Tính khoảng thời gian đặt phòng

            // Tính số giờ trễ so với 24 giờ (làm tròn xuống)
            //TotalHour chuyển đổi thời gian sử dụng qua giờ
            double sogiotre = Math.Floor(ngaysudung.TotalHours) % 24;

            // Tính số ngày đầy và giá tiền phòng tương ứng
            //TotalDays chuyển đổi thời gian sử dụng qua ngày
            int songay = (int)Math.Floor(ngaysudung.TotalDays);
            double giangay = songay * phong.TRIGIAPHONG ?? 0;

            // Tính giá tiền cho khoảng thời gian trễ
            if (sogiotre < 3)
            {
                tongtien = giangay + sogiotre * giagio * 0.3;
            }
            else if (sogiotre <= 12)
            {
                tongtien = giangay + sogiotre * giagio * 0.5;
            }
            else
            {
                tongtien = giangay + sogiotre * giagio;
            }

            return tongtien;
        }

        //Load Dữ liệu lên phieus thanh toán hóa đơn
        public void Load_ThanhToanHoaDon(int maphieu,Label lbl_name, Label lbl_ngaylap, Label lbl_mahd, 
            Label lbl_songuoi, Label lbl_name_nv, Label lbl_sophong, Label lbl_songay, Label lbl_thanhtien)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from hoadon in db.HOADONs
                                join phieudatphong in db.PHIEUDATPHONGs on hoadon.MAPHIEU equals maphieu
                                select new
                                {
                                    MAHD = hoadon.MAHD,
                                    NGAYLAP = hoadon.NGAYLAP,
                                    HOVATEN = hoadon.KHACHHANG.HOVATEN,
                                    HOVATEN2 = hoadon.NHANVIEN.HOVATEN,
                                    TENPHONG = phieudatphong.TENPHONG,
                                    SONGUOI = phieudatphong.SONGUOI,
                                    //Tính số ngày giữa NGAYDK và NGAYTRA
                                    SONGAY = (int)(DbFunctions.DiffDays(hoadon.NGAYLAP, hoadon.NGAYTRA) ?? 0),
                                    TONGTIEN = hoadon.TONGHOADON
                                };
                    var result = query.ToList().Select(hoaDon => new
                    {
                        //hiển thị thành tiền lên form hóa đơn thanh toán
                        TONGTIEN = string.Format("{0:N0}", hoaDon.TONGTIEN)
                    });
                    // Duyệt qua danh sách hoá đơn và hiển thị thông tin lên các Label
                    foreach (var hoaDon in query)
                    {
                        lbl_name.Text = hoaDon.HOVATEN;
                        lbl_ngaylap.Text = hoaDon.NGAYLAP.ToString();
                        lbl_mahd.Text = hoaDon.MAHD.ToString();
                        lbl_songuoi.Text = hoaDon.SONGUOI.ToString();
                        lbl_name_nv.Text = hoaDon.HOVATEN2;
                        lbl_sophong.Text = hoaDon.TENPHONG;
                        lbl_songay.Text = hoaDon.SONGAY.ToString();
                    }
                    foreach (var hoaDon in result)
                    {
                        // Update labels with formatted TONGTIEN
                        lbl_thanhtien.Text = hoaDon.TONGTIEN;
                        // Other label updates
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu khi thực hiện tải dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hàm tìm kiếm hóa đơn
        /// </summary>
        /// <param name="dtgv"></param>
        /// <param name="ten"></param>
        public void Search_HoaDon(DataGridView dtgv,string ten)
        {
            using (QLKSEntities4 db= new QLKSEntities4())
            {
                var query = from c in db.HOADONs.Where(x => x.KHACHHANG.HOVATEN.Contains(ten))
                            select new
                            {
                                c.MAHD,
                                c.MAPHIEU,
                                c.NGAYLAP,
                                HOVATEN = c.KHACHHANG.HOVATEN,
                                c.TONGHOADON,
                            };
                dtgv.DataSource = query.ToList();
            }
        }
    }
}
