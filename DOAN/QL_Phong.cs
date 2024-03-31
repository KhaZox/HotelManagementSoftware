using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    class QL_Phong
    {
        //Khai báo biên DatagridView
        private DataGridView dtgv = new DataGridView();

        //Contructor của class QL_Phong
        public QL_Phong(DataGridView dtgv)
        {
            this.dtgv = dtgv;
        }
        public QL_Phong() { }


        #region Thêm Sửa search Quản Lý PHÒNG

        /// <summary>
        /// Cập nhật trạng thái phòng, loại phòng và trị giá phòng 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public void Edit__QLPhong(string a, string b,string c, float d)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var Upadate = db.PHONGs.FirstOrDefault(k => (k.MAPHONG == a));
                    if (Upadate != null)
                    {
                        var newTinhTrang = db.TINHTRANGs.FirstOrDefault(tt => tt.TRANGTHAI == b);
                        if (newTinhTrang != null)
                        {
                            Upadate.MATINHTRANG = newTinhTrang.MATINHTRANG; 
                            db.SaveChanges();
                        }

                        var tenloaip = db.LOAIPHONGs.FirstOrDefault(tt => tt.TENLOAIPHONG == c); // Tìm thông tin tình trạng mới
                        if (tenloaip != null)
                        {
                            Upadate.MALOAIPHONG = tenloaip.MALOAIPHONG; // Cập nhật mã tình trạng của phòng
                            db.SaveChanges();
                        }
                        Upadate.TRIGIAPHONG = d;
                        MessageBox.Show("Update thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.SaveChanges();
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
        /// Hàm tìm kiếm mã phòng hoặc tên phòng
        /// </summary>
        /// <param name="a"></param>
        public void Search_MaPhong(string a)
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var query = from c in db.PHONGs.Where(x => x.MAPHONG.Contains(a)) 
                                select new 
                                { 
                                    c.MAPHONG, 
                                    c.TRIGIAPHONG,
                                    c.TINHTRANG.TRANGTHAI, 
                                    c.LOAIPHONG.TENLOAIPHONG 
                                };
                    dtgv.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Load dữ liệu (hiển thị các hình ảnh) lên Fr_Phòng
        /// </summary>
        /// <param name="x"></param>
        public void Load_Phong(FlowLayoutPanel x)
        {
            //xóa dữ liệu hiện hành trên FlowLayoutPanel
            x.Controls.Clear();

            using (QLKSEntities4 db = new QLKSEntities4())
            {
                var query = from phong in db.PHONGs
                            select new
                            {
                                TENPHONG = phong.TENPHONG,
                                TENLOAIPHONG = phong.LOAIPHONG.TENLOAIPHONG,
                                TRIGIAPHONG = phong.TRIGIAPHONG,
                                TRANGTHAI = phong.TINHTRANG.TRANGTHAI
                            };
                //sử dụng vòng lập để duyệt hết danh sách phòng và tạo các panel
                foreach (var phong in query)
                {
                    // tạo panel phòng từ hàm CreatePhongPanel
                    Panel panel = CreatePhongPanel(phong.TENPHONG, phong.TENLOAIPHONG, phong.TRIGIAPHONG, phong.TRANGTHAI);

                    //Thêm các panel vào FlowLayoutPanel
                    x.Controls.Add(panel);
                }
            }
        }

        /// <summary>
        /// Hàm tạo các panel trong FlowLayoutPanel
        /// </summary>
        /// <param name="maPhong"></param>
        /// <param name="tenPhong"></param>
        /// <param name="triGia"></param>
        /// <param name="trangthai"></param>
        /// <returns></returns>
        private Panel CreatePhongPanel(string maPhong, string tenPhong, double? triGia, string trangthai)
        {
            //Tạo kích thước cho từng Panel
            Panel panel = new Panel();
            panel.Width = 250;
            panel.Height = 150;

            //Nếu  trạng thái trống thì sẽ hiển thị ra mã màu dưới (màu xanh)
            if (trangthai == "Trống")
            {
                panel.BackColor = ColorTranslator.FromHtml("#ADDB9A");
            }
            else 
                //Ngược lại phòng đang sử dụng là màu xanh dương
                if (trangthai == "Đang sử dụng")
                {
                    panel.BackColor = ColorTranslator.FromHtml("#8ab6cd");
                }
                else 
                    //Ngược lại màu xám
                    if (trangthai == "Đã đặt trước")
                    {
                        panel.BackColor = ColorTranslator.FromHtml("#737274");
                    }
            //Tạo PictureBox để hiển thị hình ảnh lên từng Panel
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(@"D:\Học Tập\C#\DOAN\DOAN\IMG\Icon_bed.png"); //Link lấy hình ảnh vào phòng
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; //chỉnh hình ảnh hiển thị
            pictureBox.Width = panel.Width;
            pictureBox.Height = panel.Height - 70;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Tag = maPhong;
            pictureBox.Click += Control_Click; // Gắn sự kiện click cho hình ảnh

            //Tạo Label để hiển thị mã phòng
            Label labelMaPhong = new Label();
            labelMaPhong.Text = "" + maPhong;
            labelMaPhong.Tag = maPhong;
            labelMaPhong.Location = new Point(20, panel.Height - 60);
            labelMaPhong.AutoSize = true;
            labelMaPhong.Margin = new Padding(10, 0, 10, 0);
            labelMaPhong.Click += Control_Click; // Gắn sự kiện click cho Mã Phòng

            //Tạo Lable để hiển thị tên phòng
            Label labelTenPhong = new Label();
            labelTenPhong.Text = tenPhong;
            labelTenPhong.Tag = maPhong;
            labelTenPhong.Location = new Point(20, panel.Height - 40);
            labelTenPhong.AutoSize = true;
            labelTenPhong.Margin = new Padding(10, 0, 10, 0);
            labelTenPhong.Click += Control_Click; // Gắn sự kiện click cho Tên Phòng

            //Tạo Lable để hiển thị giá tiền phòng
            Label labelTriGia = new Label();
            labelTriGia.Text = "Giá tiền: " + (triGia.HasValue ? triGia.Value.ToString("N0") : "N/A");
            labelTriGia.Location = new Point(20, panel.Height - 20);
            labelTriGia.AutoSize = true;
            labelTriGia.Margin = new Padding(10, 0, 10, 0);
            labelTriGia.Tag = maPhong;
            labelTriGia.Click += Control_Click; // Gắn sự kiện click cho panel chính

            //Thêm các Label vừa tạo và hình ảnh vào Panel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(labelMaPhong);
            panel.Controls.Add(labelTenPhong);
            panel.Controls.Add(labelTriGia);
            panel.Tag = maPhong;
            panel.Click += Control_Click; //Gắn hành động click vào Panel
            return panel;
        }
        
        /// <summary>
        /// Hàm nhấn click vào Panel hoặc PictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Control_Click(object sender, EventArgs e)
        {
            if (sender is Control clickedControl)
            {
                //Nếu nó khô phải mã màu của trạng thái đang sử dụng và đặt trước thì nó sẽ hiển thị Form_datphong
                if (clickedControl.Tag is string maPhong) // đặt thuộc tính 'Tag' để lưu trữ giá trị maPhong
                {
                    if (clickedControl.BackColor != ColorTranslator.FromHtml("#8ab6cd") && // Đang sử dụng
                        clickedControl.BackColor != ColorTranslator.FromHtml("#737274"))   // Đã đặt trước
                    {
                        Fr_DatPhong fr = new Fr_DatPhong(maPhong);
                        fr.ShowDialog();
                    }
                    else
                    {
                        //Nếu đang sử dụng sẽ hiển thị From_QuanlyDatPhong
                        if (clickedControl.BackColor == ColorTranslator.FromHtml("#8ab6cd"))
                        {
                            Fr_QuanLyDatPhong fr_dp = new Fr_QuanLyDatPhong();
                            fr_dp.ShowDialog();
                        }
                        else
                        {
                            //Nếu đặt trước sẽ hiển thị Form_QuanlyDatPhong
                            if (clickedControl.BackColor == ColorTranslator.FromHtml("#737274") 
                                && MessageBox.Show("Bạn muốn nhận phòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                            {
                                Fr_QuanLyDatPhong fr_dp = new Fr_QuanLyDatPhong();
                                fr_dp.ShowDialog();
                            }
                        }
                    }
                }
            }
        }
        #endregion

    }
}
