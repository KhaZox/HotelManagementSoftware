using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace DOAN
{
    class QL_CTTIENNGHI
    {
        //Khai báo biến
        private DataGridView dtgv = new DataGridView();

        //contructor
        public QL_CTTIENNGHI(DataGridView dtgv)
        {
            this.dtgv = dtgv;
        }
        #region Thêm Sửa Xóa Search Quản Lý CTTIENNGHI

        /// <summary>
        /// Hàm thêm chi tiết tiện nghi
        /// </summary>
        /// <param name="macttn"></param>
        /// <param name="map"></param>
        /// <param name="sl"></param>
        public void Add_CTTienNghi(string macttn, string map, int sl)
        {
            try
            {
                using (QLKSEntities4 db= new QLKSEntities4())
                {
                    Phong_CTTIENNGHI newpct = new Phong_CTTIENNGHI
                    {
                        MACTTN = macttn,
                        MAPHONG = map,
                        SOLUONG = sl,
                    };
                    db.Phong_CTTIENNGHI.Add(newpct);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Hàm xóa chi tiết tiện nghi
        /// </summary>
        /// <param name="a"></param>
        public void Del_CTTienNghi(string a)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc rằng muốn xóa Chi Tiết Tiện Nghi này?", "Thông báo"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (QLKSEntities4 db = new QLKSEntities4())
                    {
                        var Del = db.Phong_CTTIENNGHI.FirstOrDefault(x => x.MACTTN == a);

                        if (Del != null)
                        {
                            db.Phong_CTTIENNGHI.Remove(Del);
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
        /// Hàm cập nhật chi tiết tiện nghi
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void Edit_CTTienNghi(string a, string b, int c)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var Upadate = db.Phong_CTTIENNGHI.FirstOrDefault(k => (k.MACTTN == a));
                    if (Upadate != null)
                    {
                        Upadate.MACTTN = a;
                        Upadate.MAPHONG = b;
                        Upadate.SOLUONG = c;
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
        /// Hàm tìm chi tiết tiện nghi theo mã chi tiết tiện nghi
        /// </summary>
        /// <param name="a"></param>
        public void Search_CTTTienNghi(string a)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from c in db.Phong_CTTIENNGHI.Where(x => x.MACTTN.Contains(a)) 
                                select new 
                                { 
                                    c.MACTTN,
                                    c.MAPHONG, 
                                    c.CTTIENNGHI.TENTIENNGHI, 
                                    c.SOLUONG };
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
