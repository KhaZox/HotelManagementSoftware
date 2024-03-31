using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    class QL_DV
    {
        //khái báo biến
        private DataGridView dtgv = new DataGridView();

        //contructor
        public QL_DV(DataGridView dtgv)
        {
            this.dtgv = dtgv;
        }
        #region Thêm Sửa Xóa Search Quản Lý DỊCH VỤ

        /// <summary>
        /// Hàm thêm dịch vụ
        /// </summary>
        /// <param name="cbb"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="d"></param>
        public void Add_DichVu(ComboBox cbb, string a, string b, float d)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    string tk = cbb.SelectedValue.ToString();
                    string c = cbb.SelectedValue.ToString();
                    DICHVU dv = new DICHVU
                    {
                        MADV = a,
                        TENDV = b,
                        LOAIDICHVU = db.LOAIDICHVUs.FirstOrDefault(x => x.TENLOAIDV == c),
                        TRIGIADV = d,
                    };

                    db.DICHVUs.Add(dv);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mã dịch vụ đã có trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Hàm xóa dịch vụ
        /// </summary>
        /// <param name="a"></param>
        public void Del_DichVu(string a)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc rằng muốn xóa Dịch Vụ này?", "Thông báo"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (QLKSEntities4 db = new QLKSEntities4())
                    {
                        var Del = db.DICHVUs.FirstOrDefault(x => x.MADV == a);

                        if (Del != null)
                        {
                            db.DICHVUs.Remove(Del);
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
        /// Hàm cập nhật dịch vụ
        /// </summary>
        /// <param name="cbb"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="d"></param>
        public void Edit_DichVu(ComboBox cbb, string a, string b, float d)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var Upadate = db.DICHVUs.FirstOrDefault(k => (k.MADV == a));
                    if (Upadate != null)
                    {
                        Upadate.MADV = a;
                        Upadate.TENDV = b;
                        Upadate.LOAIDICHVU.TENLOAIDV = cbb.SelectedValue.ToString(); ;
                        Upadate.TRIGIADV = d;
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
        /// Hàm tìm dịch vụ theo tên dịch vụ
        /// </summary>
        /// <param name="a"></param>
        public void Search_DichVu(string a)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from c in db.DICHVUs.Where(x => x.TENDV.Contains(a))
                                select new { c.MADV, c.TENDV, c.LOAIDICHVU.TENLOAIDV, c.TRIGIADV };
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

        #region Phần dịch vụ cho nhiều phòng

        /// <summary>
        /// Hàm thêm dịch vụ cho phòng
        /// </summary>
        /// <param name="mp"></param>
        /// <param name="mdv"></param>
        public void Add_DichVu_Phong(string mp, string mdv)
        {
            using (QLKSEntities4 db = new QLKSEntities4())
            {
                var phongDichvu = new DICHVUPHONG
                {
                    MAPHONG = mp,
                    MADV = mdv,
                    TRIGIADV = db.DICHVUs.Where(x => x.MADV.Equals(mdv)).Select(x => x.TRIGIADV).FirstOrDefault(),
                };

                db.DICHVUPHONGs.Add(phongDichvu);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Hàm xóa dịch vụ phòng
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Del_DichVu_Phong(string a, string b)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc rằng muốn xóa Dịch Vụ của phòng này?", "Thông báo"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (QLKSEntities4 db = new QLKSEntities4())
                    {
                        var Del = db.DICHVUPHONGs.FirstOrDefault(x => x.MADV == b && x.MAPHONG == a);

                        if (Del != null)
                        {
                            db.DICHVUPHONGs.Remove(Del);
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
        /// Hàm tìm dịch vụ phòng
        /// </summary>
        /// <param name="a"></param>
        public void Search_DichVu_Phong(string a)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var search = from c in db.DICHVUPHONGs
                                .Where(x => x.DICHVU.TENDV.Contains(a))
                                 select new
                                 {
                                     c.MAPHONG,
                                     c.PHONG.TENPHONG,
                                     c.MADV,
                                     TENDV = c.DICHVU.TENDV,
                                     TENLOAIDV = db.LOAIDICHVUs.Where(x => x.MALOAIDV.Equals(c.DICHVU.MALOAIDV))
                                                                .Select(x => x.TENLOAIDV).FirstOrDefault(),
                                     TRIGIADV = c.DICHVU.TRIGIADV
                                 };
                    dtgv.DataSource = search.ToList();
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
