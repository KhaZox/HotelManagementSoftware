using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DOAN
{
    class GetInfor
    {
        //Khai báo biến
        private DataGridView dtgv = new DataGridView(); 

        //contructor
        public GetInfor(DataGridView a)
        {
            this.dtgv = a;
        }

        //Load Tài khoản
        public void GetInfor_QLTaiKhoan()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from c in db.NHANVIENs
                                select new
                                {
                                    c.MATK,
                                    c.TAIKHOAN.USERNAME,
                                    c.TAIKHOAN.PASSWORD,
                                    c.MANV,
                                    c.TAIKHOAN.CAPDOQUYEN
                                };
                    dtgv.DataSource = query.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Load Nhân Viên
        public void GetInfor_NhanVien()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    dtgv.DataSource = db.NHANVIENs.Select(x => new
                    {
                        x.MANV,
                        x.HOVATEN,
                        x.CHUCVU,
                        x.GIOITINH,
                        x.DIACHI,
                        x.SDT,
                        x.CCCD,
                        x.LUONG
                    }).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Load Khách hàng
        public void GetInfor_Khachang()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    dtgv.DataSource = db.KHACHHANGs.Select(x => new
                    {
                        x.MAKH,
                        x.HOVATEN,
                        x.CCCD,
                        x.SDT,
                        x.DIACHI,
                        x.GIOITINH,
                        x.QUOCTICH
                    }).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Load Tiện Nghi
        public void GetInfor_TienNghi()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    dtgv.DataSource = db.TIENNGHIs.Select(x => new
                    {
                        x.MATIENNGHI,
                        x.TENTIENNGHI
                    }).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Load Chi Tiết Tiện Nghi
        public void GetInfor_CTTienNghi()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var queryy = from c in db.Phong_CTTIENNGHI
                                 select new
                                 {
                                     c.MACTTN,
                                     c.CTTIENNGHI.TENTIENNGHI,
                                     c.MAPHONG,
                                     c.SOLUONG
                                 };

                    dtgv.DataSource = queryy.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Load Loại Phòng
        public void GetInfor_QLLoaiPhong()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    dtgv.DataSource = db.LOAIPHONGs.Select(x => new
                    {
                        x.MALOAIPHONG,
                        x.TENLOAIPHONG,
                        x.SOGIUONG,
                    }).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Load Quản lý Phòng
        public void GetInfor_QLPhong()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from p in db.PHONGs
                                select new
                                {
                                    p.MAPHONG,
                                    p.TRIGIAPHONG,
                                    p.TINHTRANG.TRANGTHAI,
                                    p.LOAIPHONG.TENLOAIPHONG,
                                };
                    dtgv.DataSource = query.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Load Dịch Vụ
        public void GetInfor_QLDichVu()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from c in db.DICHVUs
                                select new
                                {
                                    c.MADV,
                                    c.TENDV,
                                    c.LOAIDICHVU.TENLOAIDV,
                                    c.TRIGIADV
                                };

                    dtgv.DataSource = query.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Load Loại Dịch Vụ
        public void GetInfor_QLLoaiDichVu()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    dtgv.DataSource = db.LOAIDICHVUs.Select(x => new
                    {
                        x.MALOAIDV,
                        x.TENLOAIDV
                    }).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Load Phong_DichVu
        public void GetInfor_Phong_DichVu()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from pd in db.DICHVUPHONGs
                                    //join dv in db.DICHVUs on pd.MADV equals dv.MADV
                                select new
                                {
                                    MAPHONG = pd.MAPHONG,
                                    TENPHONG = pd.PHONG.TENPHONG,
                                    MADV = pd.MADV,
                                    TENDV = pd.DICHVU.TENDV,
                                    TENLOAIDV = db.LOAIDICHVUs.Where(x => x.MALOAIDV.Equals(pd.DICHVU.MALOAIDV)).Select(x => x.TENLOAIDV).FirstOrDefault(),
                                    TRIGIADV = pd.DICHVU.TRIGIADV,
                                };
                    dtgv.DataSource = query.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Load Hóa đơn
        public void GetInfor_HoaDon()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from hoadon in db.HOADONs
                                select new
                                {
                                    MAHD = hoadon.MAHD,
                                    MAPHIEU = hoadon.MAPHIEU,
                                    NGAYLAP = hoadon.NGAYLAP,
                                    HOVATEN = hoadon.KHACHHANG.HOVATEN,
                                    TONGHOADON = hoadon.TONGHOADON,
                                };
                    dtgv.DataSource = query.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Load PhieuDatPhong
        public void GetInfor_PhieuDatPhong()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from phieudatphong in db.PHIEUDATPHONGs
                                select new
                                {
                                    MAPHIEU = phieudatphong.MAPHIEU,
                                    HOVATEN1 = phieudatphong.KHACHHANG.HOVATEN,
                                    NGAYDK = phieudatphong.NGAYDK,
                                    HOVATEN2 = phieudatphong.NHANVIEN.HOVATEN,
                                };
                    dtgv.DataSource = query.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
