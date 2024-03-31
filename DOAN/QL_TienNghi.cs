using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DOAN
{
    class QL_TienNghi
    {
        //khai báo biến datagridview
        private DataGridView dtgv = new DataGridView();
        
        //contructor của class QL_TienNghi
        public QL_TienNghi(DataGridView dtgv)
        {
            this.dtgv = dtgv;
        }

        #region Thêm Sửa Xóa Search Quản Lý TIỆN NGHI

        /// <summary>
        /// Thêm mã tiện nghi tên tiện nghi
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Add_TienNghi(string a, string b)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    TIENNGHI tn = new TIENNGHI
                    {
                        MATIENNGHI = a,
                        TENTIENNGHI = b,
                    };

                    db.TIENNGHIs.Add(tn);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có mã tiện nghi này trong hệ thống", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }


        /// <summary>
        /// Hàm xóa mã tiện nghi
        /// </summary>
        /// <param name="a"></param>
        public void Del_TienNghi(string a)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc rằng muốn xóa Tiện Nghi này?", "Thông báo"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (QLKSEntities4 db = new QLKSEntities4())
                    {
                        var Del = db.TIENNGHIs.FirstOrDefault(x => x.MATIENNGHI == a);

                        if (Del != null)
                        {
                            db.TIENNGHIs.Remove(Del);
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
        /// Hàm cập nhật tên tiện nghi
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Edit_TienNghi(string a, string b)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var Upadate = db.TIENNGHIs.FirstOrDefault(k => (k.MATIENNGHI.Equals(a)));
                    if (Upadate != null)
                    {
                        Upadate.TENTIENNGHI = b;
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
        /// Hàm tìm kiếm tên tiện nghi
        /// </summary>
        /// <param name="a"></param>
        public void Search_TenTienNghi(string a)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from c in db.TIENNGHIs.Where(x => x.TENTIENNGHI.Contains(a))
                                select new
                                {
                                    c.MATIENNGHI,
                                    c.TENTIENNGHI
                                };
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