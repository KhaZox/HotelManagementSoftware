using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    class Check_TextBox
    {
        public Check_TextBox() { }

        /// <summary>
        /// Hàm kiểm tra dữ liệu nhập vào có phải là số hay không?
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public bool Value_Number(TextBox txt)
        {
            if (!float.TryParse(txt.Text, out _) || float.Parse(txt.Text) < 0)
            {
                MessageBox.Show("Vui lòng nhập số","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Hàm kiểm tra dữ liệu nhập vào có phải là chữ hay không?
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public bool Value_Text(TextBox txt)
        {
            if (float.TryParse(txt.Text, out _))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
