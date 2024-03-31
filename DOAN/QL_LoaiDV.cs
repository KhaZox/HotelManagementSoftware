using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DOAN
{
    class QL_LoaiDV
    {
        //Khai báo biến
        private DataGridView dtgv = new DataGridView();

        //Constructor
        public QL_LoaiDV(DataGridView dtgv)
        {
            this.dtgv = dtgv;
        }
        #region Thêm Sửa Xóa Search Quản Lý LOAIDV

        /// <summary>
        /// Thêm loại dịch vụ
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Add_LoaiDV(string a, string b)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    LOAIDICHVU ldv = new LOAIDICHVU
                    {
                        MALOAIDV = a,
                        TENLOAIDV = b,
                    };

                    db.LOAIDICHVUs.Add(ldv);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có mã dịch vụ trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        /// <summary>
        /// Hàm xóa loại dịch vụ
        /// </summary>
        /// <param name="a"></param>
        public void Del_LoaiDV(string a)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc rằng muốn xóa Loại Dịch Vụ này?", "Thông báo"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (QLKSEntities4 db = new QLKSEntities4())
                    {
                        var Del = db.LOAIDICHVUs.FirstOrDefault(x => x.MALOAIDV == a);

                        if (Del != null)
                        {
                            db.LOAIDICHVUs.Remove(Del);
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
        /// Hàm cập nhật loại dịch vụ
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Edit_LoaiDV(string a, string b)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var Upadate = db.LOAIDICHVUs.FirstOrDefault(k => (k.MALOAIDV == a));
                    if (Upadate != null)
                    {
                        Upadate.TENLOAIDV = b;
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
        /// Hàm tìm kiếm theo tên loại dịch vụ
        /// </summary>
        /// <param name="a"></param>
        public void Search_TenLoaiDV(string a)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from c in db.LOAIDICHVUs.Where(x => x.TENLOAIDV.Contains(a)) select new { c.MALOAIDV, c.TENLOAIDV };
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
