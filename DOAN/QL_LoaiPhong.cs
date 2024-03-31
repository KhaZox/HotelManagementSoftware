using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace DOAN
{
    class QL_LoaiPhong
    {
        private DataGridView dtgv = new DataGridView();
        public QL_LoaiPhong(DataGridView dtgv)
        {
            this.dtgv = dtgv;
        }
        #region Thêm Sửa Xóa Search Quản Lý LOẠI PHÒNG

        /// <summary>
        /// Hàm thêm loại phòng
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void Add_LoaiPhong(string a, string b, int c)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    LOAIPHONG lp = new LOAIPHONG
                    {
                        MALOAIPHONG = a,
                        TENLOAIPHONG = b,
                        SOGIUONG = c,
                    };

                    db.LOAIPHONGs.Add(lp);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có mã loại phòng trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }


        /// <summary>
        /// Hàm xóa loại phòng
        /// </summary>
        /// <param name="a"></param>
        public void Del_LoaiPhong(string a)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc rằng muốn xóa Loại Phòng này?", "Thông báo", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (QLKSEntities4 db = new QLKSEntities4())
                    {
                        var Del = db.LOAIPHONGs.FirstOrDefault(x => x.MALOAIPHONG == a);

                        if (Del != null)
                        {
                            db.LOAIPHONGs.Remove(Del);
                            db.SaveChanges();
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng xóa các phòng có mã loại này trong phòng trước.", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Hàm cập nhật loại phòng
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void Edit_LoaiPhong(string a, string b, int c)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var Upadate = db.LOAIPHONGs.FirstOrDefault(k => (k.MALOAIPHONG == a));
                    if (Upadate != null)
                    {
                        Upadate.TENLOAIPHONG = b;
                        Upadate.SOGIUONG = c;
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
        /// Hàm tìm kiếm theo mã loại phòng
        /// </summary>
        /// <param name="a"></param>
        public void Search_MaLoaiPhong(string a)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from c in db.LOAIPHONGs.Where(x => x.MALOAIPHONG.Contains(a)) 
                                select new { c.MALOAIPHONG, c.TENLOAIPHONG, c.SOGIUONG };
                    dtgv.DataSource = query.ToList();
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
