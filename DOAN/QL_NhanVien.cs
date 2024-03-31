using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    class QL_NhanVien
    {
        //Khái báo biến
        private DataGridView dtgv = new DataGridView();

        //Contructor 
        public QL_NhanVien(DataGridView dtgv)
        {
            this.dtgv = dtgv;
        }
        #region Thêm Sửa Xóa Search Quản Lý  NHÂN VIÊN

        /// <summary>
        /// Hàm thêm nhân viên
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <param name="g"></param>
        /// <param name="h"></param>
        public void Add_NhanVien(string a, string b, string c, string d, string e, string f, string g, float h)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    NHANVIEN nv = new NHANVIEN
                    {
                        MANV = a,
                        HOVATEN = b,
                        CHUCVU = c,
                        GIOITINH = d,
                        DIACHI = e,
                        SDT = f,
                        CCCD = g,
                        LUONG = h
                    };

                    db.NHANVIENs.Add(nv);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Đã có nhân viên trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        
        /// <summary>
        /// Hàm xóa nhân viên
        /// </summary>
        /// <param name="a"></param>
        public void Del_NhanVien(string a)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc rằng muốn xóa Nhân Viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (QLKSEntities4 db = new QLKSEntities4())
                    {
                        var Del = db.NHANVIENs.FirstOrDefault(x => x.MANV == a);

                        if (Del != null)
                        {
                            db.NHANVIENs.Remove(Del);
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
        /// Hàm cập nhật nhân viên
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <param name="g"></param>
        /// <param name="h"></param>
        public void Edit_NhanVien(string a, string b, string c, string d, string e, string f, string g, float h)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var Upadate = db.NHANVIENs.FirstOrDefault(k => (k.MANV == a));

                    if (Upadate != null)
                    {
                        Upadate.MANV = a;
                        Upadate.HOVATEN = b;
                        Upadate.CHUCVU = c;
                        Upadate.GIOITINH = d;
                        Upadate.DIACHI = e;
                        Upadate.SDT = f;
                        Upadate.CCCD = g;
                        Upadate.LUONG = h;
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
        /// Hàm tìm kiếm mã nhân viên
        /// </summary>
        /// <param name="a"></param>
        public void Search_MaNV(string a)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from c in db.NHANVIENs.Where(x => x.MANV.Contains(a)) select new { c.MANV, c.HOVATEN, c.CHUCVU, c.GIOITINH, c.DIACHI, c.SDT, c.CCCD, c.LUONG };
                    dtgv.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion
    }
}
