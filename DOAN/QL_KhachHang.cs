using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    class QL_KhachHang
    {
        //Khai báo biến
        private DataGridView dtgv = new DataGridView();

        //Contructor
        public QL_KhachHang(DataGridView dtgv)
        {
            this.dtgv = dtgv;
        }
        #region Thêm Sửa Xóa Search Quản Lý KHÁCH HÀNG

        /// <summary>
        /// Hàm thêm khách hàng
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <param name="g"></param>
        public void Add_Khachang(string a, string b, string c, string d, string e, string f, string g)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    KHACHHANG kh = new KHACHHANG
                    {
                        MAKH = a,
                        HOVATEN = b,
                        CCCD = c,
                        SDT = d,
                        DIACHI = e,
                        GIOITINH = f,
                        QUOCTICH = g,
                    };

                    db.KHACHHANGs.Add(kh);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có khách hàng này trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        
        /// <summary>
        /// Hàm xóa khách hàng
        /// </summary>
        /// <param name="a"></param>
        public void Del_Khahhang(string a)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc rằng muốn xóa Khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (QLKSEntities4 db = new QLKSEntities4())
                    {
                        var Del = db.KHACHHANGs.FirstOrDefault(x => x.MAKH == a);

                        if (Del != null)
                        {
                            db.KHACHHANGs.Remove(Del);
                            db.SaveChanges();
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa khách hàng này vì khách hàng này có hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Hàm cập nhật khách hàng ngoại trừ mã khách hàng
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <param name="g"></param>
        public void Edit_Khachhang(string a,string b, string c, string d, string e, string f, string g)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var Upadate = db.KHACHHANGs.FirstOrDefault(k => (k.MAKH == a));
                    if (Upadate != null)
                    {
                        
                        Upadate.HOVATEN = b;
                        Upadate.CCCD = c;
                        Upadate.SDT = d;
                        Upadate.GIOITINH = e;
                        Upadate.DIACHI = f;
                        Upadate.QUOCTICH = g;
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
        /// Hàm tìm kiếm khách hàng theo mã khách hàng
        /// </summary>
        /// <param name="a"></param>
        public void Search_Khachhang(string a)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from c in db.KHACHHANGs.Where(x => x.MAKH.Contains(a)) select new { c.MAKH, c.HOVATEN, c.CCCD, c.SDT, c.DIACHI, c.GIOITINH, c.QUOCTICH };
                    dtgv.DataSource = query.ToList(); ;
                }
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
