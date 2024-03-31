using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    class QL_Dangnhap
    {
        //Khai báo biến
        private string a, b;

        //Contructror
        public QL_Dangnhap() { }
        public QL_Dangnhap(string a, string b)
        {
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Hàm kiểm tra thông tin tài khoản khi đăng nhập vào hệ thống
        /// </summary>
        public void Checkthongtindangnhap()
        {
            try
            {
                using (QLKSEntities4 db = new QLKSEntities4())
                {
                    var check = db.TAIKHOANs.FirstOrDefault(x => x.USERNAME == a && x.PASSWORD == b);
                    var capdo = db.TAIKHOANs.Where(x => x.CAPDOQUYEN == 1);
                    if (check!= null)
                    {
                        if (check.CAPDOQUYEN == 1)
                        {
                            Fr_TrangChu fr = new Fr_TrangChu();
                            fr.ShowDialog();
                        }
                        else
                        {
                            Fr_Trangchu_NhanVien fr = new Fr_Trangchu_NhanVien();
                            fr.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin tài khoản không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa có tài khoản","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
                throw;
            }
        }

        /// <summary>
        /// Hiển thị các form con trong form trang chủ
        /// </summary>
        /// <param name="currentFrch"></param>
        /// <param name="Panel_Body"></param>
        /// <param name="frch"></param>
        public void OpenChildForm(Form currentFrch,Panel Panel_Body,Form frch)
        {
            if (currentFrch != null)
            {
                currentFrch.Close();
            }
            currentFrch = frch;
            frch.TopLevel = false;
            frch.FormBorderStyle = FormBorderStyle.None;
            frch.Dock = DockStyle.Fill;
            Panel_Body.Controls.Add(frch);
            Panel_Body.Tag = frch;
            frch.BringToFront();
            frch.Show();
        }
    }
}
