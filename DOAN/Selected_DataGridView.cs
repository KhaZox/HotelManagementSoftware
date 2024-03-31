using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    class Selected_DataGridView
    {
        private DataGridView dtgv = new DataGridView();
        private ComboBox cbb = new ComboBox();
        private ComboBox cbb2 = new ComboBox();
        private Button btn_sua = new Button();
        private TextBox a = new TextBox();
        private TextBox b = new TextBox();
        private TextBox c = new TextBox();
        private TextBox d = new TextBox();
        private TextBox a2 = new TextBox();
        private TextBox b2 = new TextBox();
        private TextBox c2 = new TextBox();
        private TextBox d2 = new TextBox();

        public Selected_DataGridView() { }

        //Constructor 2 giá trị của TextBox
        public Selected_DataGridView(DataGridView dtgv, Button btn_sua, TextBox a, TextBox b)
        {
            this.dtgv = dtgv;
            this.btn_sua = btn_sua;
            this.a = a;
            this.b = b;
        }

        //Constructor 3 giá trị của TextBox
        public Selected_DataGridView(DataGridView dtgv, Button btn_sua, TextBox a, TextBox b, TextBox c)
        {
            this.dtgv = dtgv;
            this.btn_sua = btn_sua;
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //Constructor 4 giá trị của TextBox
        public Selected_DataGridView(DataGridView dtgv, Button btn_sua, TextBox a, TextBox b, TextBox c, TextBox d)
        {
            this.dtgv = dtgv;
            this.btn_sua = btn_sua;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        //Constructor 4 giá trị (3 TextBox 1 ComboBox)
        public Selected_DataGridView(DataGridView dtgv, Button btn_sua, TextBox a, TextBox b, ComboBox c, TextBox d)
        {
            this.dtgv = dtgv;
            this.btn_sua = btn_sua;
            this.a = a;
            this.b = b;
            this.cbb = c;
            this.d = d;
        }

        //Constructor 4 giá trị (2 TextBox 2 ComboBox)
        public Selected_DataGridView(DataGridView dtgv, Button btn_sua, TextBox x,TextBox y,ComboBox z,ComboBox t)
        {
            this.dtgv = dtgv;
            this.btn_sua = btn_sua;
            this.a = x;
            this.b = y;
            this.cbb = z;
            this.cbb2 = t;
        }

        //Constructor 5 giá trị của TextBox
        public Selected_DataGridView(DataGridView dtgv,Button btn_sua, TextBox a, TextBox b, TextBox c, TextBox d, TextBox a2)
        {
            this.dtgv = dtgv;
            this.btn_sua = btn_sua;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.a2 = a2;
        }

        //Contructor 6 giá trị (4 TextBox 2 ComboBox)
        public Selected_DataGridView(DataGridView dtgv, ComboBox a, TextBox b2, ComboBox b, TextBox c, TextBox d, TextBox a2)
        {
            this.dtgv = dtgv;
            this.cbb = a;
            this.cbb2 = b;
            this.c = c;
            this.d = d;
            this.a2 = a2;
            this.b2 = b2;
        }
        //Constructor 7 giá trị (6 TextBox 1 ComboBox)
        public Selected_DataGridView(DataGridView dtgv, Button btn_sua, TextBox a, TextBox b, TextBox c, TextBox d, TextBox a2, ComboBox b2, TextBox c2)
        {
            this.dtgv = dtgv;
            this.btn_sua = btn_sua;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.a2 = a2;
            this.cbb = b2;
            this.c2 = c2;
        }
        //Constructor 8 giá trị (7 TextBox 1 ComboBox)
        public Selected_DataGridView(DataGridView dtgv,Button btn_sua, TextBox a, TextBox b, TextBox c, ComboBox d, TextBox a2, TextBox b2, TextBox c2, TextBox d2)
        {
            this.dtgv = dtgv;
            this.btn_sua = btn_sua;
            this.a = a;
            this.b = b;
            this.c = c;
            this.cbb = d;
            this.a2 = a2;
            this.b2 = b2;
            this.c2 = c2;
            this.d2 = d2;
        }



        #region 2 giá trị TextBox
        /// <summary>
        /// Đây là đoạn code dùng để hiển thị 2 giá trị TextBox không còn Enabled dựa vào tham số bool
        /// </summary>
        /// <param name="x"></param>
        public void Show_2_Value(bool x)
        {
            a.Enabled = x;
            b.Enabled = x;
            btn_sua.Enabled = x;
        }
        /// <summary>
        /// Đây là đoạn code dùng làm mới 2 giá trị TextBox
        /// </summary>
        public void Reset_2_Value()
        {
            a.ResetText();
            b.ResetText();
        }
        /// <summary>
        /// Đây là đoạn code hiển thị các giá trị lên TextBox khi nhấn vài DataGridView
        /// </summary>
        public void Cell_Click_2_Value()
        {
            try
            {
                if (dtgv.SelectedCells.Count > 0)
                {
                    int SelRowindex = dtgv.SelectedCells[0].RowIndex;
                    DataGridViewRow selrow = dtgv.Rows[SelRowindex];
                    a.Text = selrow.Cells[0].Value.ToString();
                    b.Text = selrow.Cells[1].Value.ToString();
                    Show_2_Value(false);
                }else
                {
                    MessageBox.Show("Lỗi dữ liệu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        /// <summary>
        /// Đây là đoạn code dùng để sửa chữa trên TextBox khi nhấn vài DataGridView
        /// </summary>
        public void Double_Click_2_Value()
        {
            try
            {
                Show_2_Value(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
        #endregion

        #region 3 Giá trị TextBox
        /// <summary>
        /// Đây là đoạn code dùng để hiển thị 2 giá trị TextBox không còn Enabled dựa vào tham số bool
        /// </summary>
        /// <param name="x"></param>
        public void Show_3_Value(bool x)
        {
            a.Enabled = x;
            b.Enabled = x;
            c.Enabled = x;
            btn_sua.Enabled = x;
        }
        /// <summary>
        /// Đây là đoạn code dùng làm mới 3 giá trị TextBox
        /// </summary>
        public void Reset_3_Value()
        {
            a.ResetText();
            b.ResetText();
            c.ResetText();
        }
        /// <summary>
        /// Đây là đoạn code hiển thị các giá trị lên TextBox khi nhấn vài DataGridView
        /// </summary>
        public void Cell_Click_3_Value()
        {
            try
            {
                if (dtgv.SelectedCells.Count > 0)
                {
                    int SelRowindex = dtgv.SelectedCells[0].RowIndex;
                    DataGridViewRow selrow = dtgv.Rows[SelRowindex];
                    a.Text = selrow.Cells[0].Value.ToString();
                    b.Text = selrow.Cells[1].Value.ToString();
                    c.Text = selrow.Cells[2].Value.ToString();
                    Show_3_Value(false);
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Đây là đoạn code dùng để sửa chữa trên TextBox khi nhấn vài DataGridView
        /// </summary>
        public void Double_Click_3_Value()
        {
            try
            {
                Show_3_Value(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
        #endregion 3 giá trị

        #region 4 Giá trị TextBox
        /// <summary>
        /// Đây là đoạn code dùng để hiển thị 4 giá trị TextBox không còn Enabled dựa vào tham số bool
        /// </summary>
        /// <param name="x"></param>
        public void Show_4_Value(bool x)
        {
            a.Enabled = x;
            b.Enabled = x;
            c.Enabled = x;
            d.Enabled = x;
            btn_sua.Enabled = x;
        }

        /// <summary>
        /// Đây là đoạn code dùng để làm mới giá trị trên 4 TextBox 
        /// </summary>
        public void Reset_4_Value()
        {
            a.ResetText();
            b.ResetText();
            c.ResetText();
            d.ResetText();
        }

        /// <summary>
        /// Đây là đoạn code hiển thị các giá trị lên 4 TextBox khi nhấn vài DataGridView
        /// </summary>
        public void Cell_Click_4_Value()
        {
            try
            {
                if (dtgv.SelectedCells.Count > 0)
                {
                    int SelRowindex = dtgv.SelectedCells[0].RowIndex;
                    DataGridViewRow selrow = dtgv.Rows[SelRowindex];
                    a.Text = selrow.Cells[0].Value.ToString();
                    b.Text = selrow.Cells[1].Value.ToString();
                    c.Text = selrow.Cells[2].Value.ToString();
                    d.Text = selrow.Cells[3].Value.ToString();
                    Show_4_Value(false);
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Đây là đoạn code dùng để chỉnh sửa giá trị lên 4 TextBox khi nhấn double vào DataGridView
        /// </summary>
        public void Double_Click_4_Value()
        {
            try
            {
                Show_4_Value(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
        #endregion

        #region 4 Giá trị (3 TextBox 1 combobox)
        /// <summary>
        /// Đây là đoạn code dùng để hiển thị 3 giá trị TextBox và 1 ComboBox không còn Enabled dựa vào tham số bool
        /// </summary>
        /// <param name="x"></param>
        public void Show_4_1_Value(bool x)
        {
            a.Enabled = x;
            b.Enabled = x;
            cbb.Enabled = x;
            d.Enabled = x;
            btn_sua.Enabled = x;
        }

        /// <summary>
        /// Đây là đoạn code dùng để làm mới giá trị của 3 giá trị TextBox và 1 ComboBox
        /// </summary>
        public void Reset_4_1_Value()
        {
            a.ResetText();
            b.ResetText();
            cbb.ResetText();
            d.ResetText();
        }

        /// <summary>
        /// Đây là đoạn code dùng để làm hiển thị giá trị lên 3 giá trị TextBox và 1 ComboBox khi nhân vào DataGridView
        /// </summary>
        public void Cell_Click_4_1_Value()
        {
            try
            {
                if (dtgv.SelectedCells.Count > 0)
                {
                    int SelRowindex = dtgv.SelectedCells[0].RowIndex;
                    DataGridViewRow selrow = dtgv.Rows[SelRowindex];
                    a.Text = selrow.Cells[0].Value.ToString();
                    b.Text = selrow.Cells[1].Value.ToString();
                    cbb.Text = selrow.Cells[2].Value.ToString();
                    d.Text = selrow.Cells[3].Value.ToString();
                    Show_4_1_Value(false);
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Đây là đoạn code dùng để làm chỉnh sửa giá trị trên 3 TextBox và 1 ComboBox khi nhấn Double Click vào DataGridView
        /// </summary>
        public void Double_Click_4_1_Value()
        {
            try
            {
                Show_4_1_Value(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
        #endregion

        #region 4 Giá trị (2 TextBox 2 combobox)
        /// <summary>
        ///  Đây là đoạn code dùng để hiển thị 2 giá trị TextBox và 2 ComboBox không còn Enabled dựa vào tham số bool
        /// </summary>
        /// <param name="x"></param>
        public void Show_4_2_Value(bool x)
        {
            a.Enabled = x;
            b.Enabled = x;
            cbb.Enabled = x;
            cbb2.Enabled = x;
            btn_sua.Enabled = x;
        }

        /// <summary>
        /// Đây là đoạn code dùng để làm mới giá trị của 2 giá trị TextBox và 2 ComboBox
        /// </summary>
        public void Reset_4_2_Value()
        {
            a.ResetText();
            b.ResetText();
            cbb.ResetText();
            cbb2.ResetText();
        }

        /// <summary>
        /// Đây là đoạn code dùng để làm hiển thị giá trị lên 2 giá trị TextBox và 2 ComboBox khi nhân vào DataGridView
        /// </summary>
        public void Cell_Click_4_2_Value()
        {
            try
            {
                if (dtgv.SelectedCells.Count > 0)
                {
                    int SelRowindex = dtgv.SelectedCells[0].RowIndex;
                    DataGridViewRow selrow = dtgv.Rows[SelRowindex];
                    a.Text = selrow.Cells[0].Value.ToString();
                    b.Text = selrow.Cells[1].Value.ToString();
                    cbb.Text = selrow.Cells[2].Value.ToString();
                    cbb2.Text = selrow.Cells[3].Value.ToString();
                    Show_4_2_Value(false);
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Đây là đoạn code dùng để  chỉnh sửa giá trị trên 2 TextBox và 2 ComboBox khi nhấn Double Click vào DataGridView
        /// </summary>
        public void Double_Click_4_2_Value()
        {
            try
            {
                Show_4_2_Value(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
        #endregion 

        #region 5 Giá trị TextBox
        /// <summary>
        /// Đây là đoạn code dùng để hiển thị 5 giá trị TextBox không còn Enabled dựa vào tham số bool
        /// </summary>
        /// <param name="x"></param>
        public void Show_5_Value(bool x)
        {
            a.Enabled = x;
            b.Enabled = x;
            c.Enabled = x;
            d.Enabled = x;
            a2.Enabled = x;
            btn_sua.Enabled = x;
        }

        /// <summary>
        /// Đây là đoạn code dùng để làm mới giá trị của 5 TextBox
        /// </summary>
        public void Reset_5_Value()
        {
            a.ResetText();
            b.ResetText();
            c.ResetText();
            d.ResetText();
            a2.ResetText();
        }

        /// <summary>
        /// Đây là đoạn code dùng để làm hiển thị giá trị lên 5 giá trị TextBox  khi nhân vào DataGridView
        /// </summary>
        public void Cell_Click_5_Value()
        {
            try
            {
                if (dtgv.SelectedCells.Count > 0)
                {
                    int SelRowindex = dtgv.SelectedCells[0].RowIndex;
                    DataGridViewRow selrow = dtgv.Rows[SelRowindex];
                    a.Text = selrow.Cells[0].Value.ToString();
                    b.Text = selrow.Cells[1].Value.ToString();
                    c.Text = selrow.Cells[2].Value.ToString();
                    d.Text = selrow.Cells[3].Value.ToString();
                    a2.Text = selrow.Cells[4].Value.ToString();
                    Show_5_Value(false);
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Đây là đoạn code dùng để làm chỉnh sửa  giá trị lên 5 giá trị TextBox  khi nhân Double Click vào DataGridView
        /// </summary>
        public void Double_Click_5_Value()
        {
            try
            {
                Show_5_Value(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
        #endregion

        #region 6 Giá trị (4 TextBox 2 combobox)
        /// <summary>
        /// Đây là đoạn code dùng để hiển thị 3 giá trị TextBox và 2 ComboBox không còn Enabled dựa vào tham số bool
        /// </summary>
        /// <param name="x"></param>
        public void Show_6_Value(bool x)
        {
            cbb.Enabled = x;
            cbb2.Enabled = x;
            c.Enabled = x;
            d.Enabled = x;
            a2.Enabled = x;
            b2.Enabled = x;
        }

        /// <summary>
        /// Đây là đoạn code dùng làm mới giá trị của  3 giá trị TextBox và 2 ComboBox
        /// </summary>
        public void Reset_6_Value()
        {
            cbb.ResetText();
            cbb2.ResetText();
            c.ResetText();
            d.ResetText();
            a2.ResetText();
            b2.ResetText();
        }

        /// <summary>
        /// Đây là đoạn code dùng để hiển thị giá trị lên 3 giá trị TextBox và 2 ComboBox khi nhấn vào DataGridView
        /// </summary>
        public void Cell_Click_6_Value()
        {
            try
            {
                if (dtgv.SelectedCells.Count > 0)
                {
                    int SelRowindex = dtgv.SelectedCells[0].RowIndex;
                    DataGridViewRow selrow = dtgv.Rows[SelRowindex];
                    cbb.Text = selrow.Cells[0].Value.ToString();
                    b2.Text = selrow.Cells[1].Value.ToString();
                    cbb2.Text = selrow.Cells[2].Value.ToString();
                    c.Text = selrow.Cells[3].Value.ToString();
                    d.Text = selrow.Cells[4].Value.ToString();
                    a2.Text = selrow.Cells[5].Value.ToString();
                    Show_6_Value(false);
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Đây là đoạn code dùng để chỉnh sửa trên 3 giá trị TextBox và 2 ComboBox khi nhấn DoubleClick vào DataGriddView
        /// </summary>
        public void Double_Click_6_Value()
        {
            try
            {
                Show_6_Value(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
        #endregion

        #region 7 Giá trị (6 TextBox 1 ComboBox)
        /// <summary>
        /// Đây là đoạn code dùng để hiển thị 6 giá trị TextBox và 1 ComboBox không còn Enabled dựa vào tham số bool
        /// </summary>
        /// <param name="x"></param>
        public void Show_7_Value(bool x)
        {
            a.Enabled = x;
            b.Enabled = x;
            c.Enabled = x;
            d.Enabled = x;
            a2.Enabled = x;
            cbb.Enabled = x;
            c2.Enabled = x;
            btn_sua.Enabled = x;
        }

        /// <summary>
        /// Đây là đoạn code dùng làm mới giá trị của  6 giá trị TextBox và 1 ComboBox
        /// </summary>
        public void Reset_7_Value()
        {
            a.ResetText();
            b.ResetText();
            c.ResetText();
            d.ResetText();
            a2.ResetText();
            cbb.ResetText();
            c2.ResetText();
        }

        /// <summary>
        /// Đây là đoạn code dùng để hiển thị giá trị lên 6 giá trị TextBox và 1 ComboBox khi nhấn vào DataGridView
        /// </summary>
        public void Cell_Click_7_Value()
        {
            try
            {
                if (dtgv.SelectedCells.Count > 0)
                {
                    int SelRowindex = dtgv.SelectedCells[0].RowIndex;
                    DataGridViewRow selrow = dtgv.Rows[SelRowindex];
                    a.Text = selrow.Cells[0].Value.ToString();
                    b.Text = selrow.Cells[1].Value.ToString();
                    c.Text = selrow.Cells[2].Value.ToString();
                    d.Text = selrow.Cells[3].Value.ToString();
                    a2.Text = selrow.Cells[4].Value.ToString();
                    cbb.Text = selrow.Cells[5].Value.ToString();
                    c2.Text = selrow.Cells[6].Value.ToString();
                    Show_7_Value(false);
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Đây là đoạn code dùng để chỉnh sửa trên 6 giá trị TextBox và 1 ComboBox khi nhấn DoubleClick vào DataGriddView
        /// </summary>
        public void Double_Click_7_Value()
        {
            try
            {
                Show_7_Value(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
        #endregion

        #region 8 Giá trị
        /// <summary>
        /// Đây là đoạn code dùng để hiển thị 7 giá trị TextBox và 1 ComboBox không còn Enabled dựa vào tham số bool
        /// </summary>
        /// <param name="x"></param>
        public void Show_8_Value(bool x)
        {
            a.Enabled = x;
            b.Enabled = x;
            c.Enabled = x;
            cbb.Enabled = x;
            a2.Enabled = x;
            b2.Enabled = x;
            c2.Enabled = x;
            d2.Enabled = x;
            btn_sua.Enabled = x;
        }

        /// <summary>
        /// Đây là đoạn code dùng làm mới giá trị của  7 giá trị TextBox và 1 ComboBox
        /// </summary>
        public void Reset_8_Value()
        {
            a.ResetText();
            b.ResetText();
            c.ResetText();
            cbb.ResetText();
            a2.ResetText();
            b2.ResetText();
            c2.ResetText();
            d2.ResetText();
        }

        /// <summary>
        /// Đây là đoạn code dùng để hiển thị giá trị lên 7 giá trị TextBox và 1 ComboBox khi nhấn vào DataGridView
        /// </summary>
        /// </summary>
        public void Cell_Click_8_Value()
        {
            try
            {
                if (dtgv.SelectedCells.Count > 0)
                {
                    int SelRowindex = dtgv.SelectedCells[0].RowIndex;
                    DataGridViewRow selrow = dtgv.Rows[SelRowindex];
                    a.Text = selrow.Cells[0].Value.ToString();
                    b.Text = selrow.Cells[1].Value.ToString();
                    c.Text = selrow.Cells[2].Value.ToString();
                    cbb.Text = selrow.Cells[3].Value.ToString();
                    a2.Text = selrow.Cells[4].Value.ToString();
                    b2.Text = selrow.Cells[5].Value.ToString();
                    c2.Text = selrow.Cells[6].Value.ToString();
                    d2.Text = selrow.Cells[7].Value.ToString();
                    Show_8_Value(false);
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Đây là đoạn code dùng để chỉnh sửa trên 6 giá trị TextBox và 1 ComboBox khi nhấn DoubleClick vào DataGriddView
        /// </summary>
        public void Double_Click_8_Value()
        {
            try
            {
                Show_8_Value(true);
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
