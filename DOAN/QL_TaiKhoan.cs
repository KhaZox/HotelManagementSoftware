using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DOAN
{
    class QL_TaiKhoan
    {
        //Khai báo biên DataGridView
        private DataGridView dtgv = new DataGridView();

        //Contructor của class QL_TaiKhoan
        public QL_TaiKhoan(DataGridView dtgv)
        {
            this.dtgv = dtgv;
        }
        #region Thêm Sửa Xóa Search Quản Lý TÀI KHOẢN

        /// <summary>
        /// Hàm thêm tài khoản cho nhân viên
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pas"></param>
        /// <param name="manv"></param>
        /// <param name="capdoquyen"></param>
        public void Add_TaiKhoan(string user, string pas, string manv, int capdoquyen)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    NHANVIEN checkmanv = db.NHANVIENs.FirstOrDefault(nv => nv.MANV == manv);
                    if (checkmanv != null)
                    {
                        TAIKHOAN tk = new TAIKHOAN
                        {
                            USERNAME = user,
                            PASSWORD = pas,
                            CAPDOQUYEN= capdoquyen,
                        };
                        checkmanv.TAIKHOAN = tk;
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Chưa có mã nhân viên này trong hệ thống", "Thông báo"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Hàm xóa tài khoản của nhân viên
        /// </summary>
        /// <param name="a"></param>
        public void Del_TaiKhoan(int a)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc rằng muốn xóa tài khoản này?", "Thông báo"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (QLKSEntities4 db = new QLKSEntities4())
                    {
                        NHANVIEN checkmanv = db.NHANVIENs.FirstOrDefault(nv => nv.MATK == a);

                        if (checkmanv != null)
                        {
                            // Xóa thông tin tài khoản nếu có
                            if (checkmanv.TAIKHOAN != null)
                            {
                                db.TAIKHOANs.Remove(checkmanv.TAIKHOAN);
                            }
                            // Cập nhật liên kết giữa nhân viên và tài khoản
                            checkmanv.TAIKHOAN = null;
                            // Lưu thay đổi vào cơ sở dữ liệu
                            db.SaveChanges();

                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Hàm chỉnh sửa tài khoản
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pas"></param>
        /// <param name="manv"></param>
        /// <param name="capdoquyen"></param>
        public void Edit_TaiKhoan(string user, string pas, string manv, int capdoquyen)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    NHANVIEN checkmanv = db.NHANVIENs.FirstOrDefault(nv => nv.MANV == manv);
                    if (checkmanv != null)
                    {
                        checkmanv.TAIKHOAN.USERNAME = user;
                        checkmanv.TAIKHOAN.PASSWORD = pas;
                        checkmanv.TAIKHOAN.CAPDOQUYEN = capdoquyen;
                        db.SaveChanges();
                        MessageBox.Show("Update thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Hàm tìm kiếm tên tài khoản, mã nhân viên và mã tài khoản
        /// </summary>
        /// <param name="a"></param>
        public void Search_TenTK(string a)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = db.NHANVIENs
                                        .Where(nv =>
                                        nv.MATK.ToString() == a ||
                                        nv.TAIKHOAN.USERNAME.Contains(a) ||
                                        nv.MANV.Contains(a))
                                        .Select(nv => new
                                        {
                                            nv.MATK,
                                            nv.TAIKHOAN.USERNAME,
                                            nv.TAIKHOAN.PASSWORD,
                                            nv.MANV,
                                            nv.TAIKHOAN.CAPDOQUYEN
                                        }).ToList();
                    dtgv.DataSource = query;                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion
    }
}
