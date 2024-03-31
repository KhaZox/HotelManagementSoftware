
namespace DOAN
{
    partial class Fr_QuanLyKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOVATEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUOCTICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pel_2 = new System.Windows.Forms.Panel();
            this.Pnel_ThaoTac = new System.Windows.Forms.Panel();
            this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.txt_quoctich = new System.Windows.Forms.TextBox();
            this.lbl_quoctich = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.ckb_add = new System.Windows.Forms.CheckBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.txt_hovaten = new System.Windows.Forms.TextBox();
            this.lbl_sdt = new System.Windows.Forms.Label();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.lbl_cccd = new System.Windows.Forms.Label();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.lbl_hovaten = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.lbl_makh = new System.Windows.Forms.Label();
            this.grb_search = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.Pel_2.SuspendLayout();
            this.Pnel_ThaoTac.SuspendLayout();
            this.grb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.HOVATEN,
            this.CCCD,
            this.SDT,
            this.DIACHI,
            this.GIOITINH,
            this.QUOCTICH});
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv.Location = new System.Drawing.Point(0, 0);
            this.dtgv.Name = "dtgv";
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1105, 577);
            this.dtgv.TabIndex = 3;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            this.dtgv.DoubleClick += new System.EventHandler(this.dtgv_DoubleClick);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MAKH.DefaultCellStyle = dataGridViewCellStyle15;
            this.MAKH.HeaderText = "Mã khách";
            this.MAKH.Name = "MAKH";
            // 
            // HOVATEN
            // 
            this.HOVATEN.DataPropertyName = "HOVATEN";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.HOVATEN.DefaultCellStyle = dataGridViewCellStyle16;
            this.HOVATEN.HeaderText = "Họ và Tên";
            this.HOVATEN.Name = "HOVATEN";
            this.HOVATEN.Width = 200;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CCCD.DefaultCellStyle = dataGridViewCellStyle17;
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.Name = "CCCD";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SDT.DefaultCellStyle = dataGridViewCellStyle18;
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DIACHI.DefaultCellStyle = dataGridViewCellStyle19;
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GIOITINH.DefaultCellStyle = dataGridViewCellStyle20;
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // QUOCTICH
            // 
            this.QUOCTICH.DataPropertyName = "QUOCTICH";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.QUOCTICH.DefaultCellStyle = dataGridViewCellStyle21;
            this.QUOCTICH.HeaderText = "Quốc tịch";
            this.QUOCTICH.Name = "QUOCTICH";
            // 
            // Pel_2
            // 
            this.Pel_2.Controls.Add(this.dtgv);
            this.Pel_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pel_2.Location = new System.Drawing.Point(0, 0);
            this.Pel_2.Name = "Pel_2";
            this.Pel_2.Size = new System.Drawing.Size(1105, 577);
            this.Pel_2.TabIndex = 5;
            // 
            // Pnel_ThaoTac
            // 
            this.Pnel_ThaoTac.Controls.Add(this.cbb_gioitinh);
            this.Pnel_ThaoTac.Controls.Add(this.txt_quoctich);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_quoctich);
            this.Pnel_ThaoTac.Controls.Add(this.btn_sua);
            this.Pnel_ThaoTac.Controls.Add(this.btn_thoat);
            this.Pnel_ThaoTac.Controls.Add(this.btn_xoa);
            this.Pnel_ThaoTac.Controls.Add(this.btn_them);
            this.Pnel_ThaoTac.Controls.Add(this.ckb_add);
            this.Pnel_ThaoTac.Controls.Add(this.txt_sdt);
            this.Pnel_ThaoTac.Controls.Add(this.txt_diachi);
            this.Pnel_ThaoTac.Controls.Add(this.txt_cccd);
            this.Pnel_ThaoTac.Controls.Add(this.txt_hovaten);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_sdt);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_diachi);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_cccd);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_gioitinh);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_hovaten);
            this.Pnel_ThaoTac.Controls.Add(this.txt_makh);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_makh);
            this.Pnel_ThaoTac.Controls.Add(this.grb_search);
            this.Pnel_ThaoTac.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnel_ThaoTac.Location = new System.Drawing.Point(839, 0);
            this.Pnel_ThaoTac.Name = "Pnel_ThaoTac";
            this.Pnel_ThaoTac.Size = new System.Drawing.Size(259, 577);
            this.Pnel_ThaoTac.TabIndex = 6;
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_gioitinh.Location = new System.Drawing.Point(119, 360);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(128, 27);
            this.cbb_gioitinh.TabIndex = 9;
            // 
            // txt_quoctich
            // 
            this.txt_quoctich.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quoctich.Location = new System.Drawing.Point(119, 403);
            this.txt_quoctich.Name = "txt_quoctich";
            this.txt_quoctich.Size = new System.Drawing.Size(128, 27);
            this.txt_quoctich.TabIndex = 10;
            this.txt_quoctich.TextChanged += new System.EventHandler(this.txt_quoctich_TextChanged);
            // 
            // lbl_quoctich
            // 
            this.lbl_quoctich.AutoSize = true;
            this.lbl_quoctich.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quoctich.Location = new System.Drawing.Point(10, 406);
            this.lbl_quoctich.Name = "lbl_quoctich";
            this.lbl_quoctich.Size = new System.Drawing.Size(76, 19);
            this.lbl_quoctich.TabIndex = 22;
            this.lbl_quoctich.Text = "Quốc tịch";
            // 
            // btn_sua
            // 
            this.btn_sua.AutoSize = true;
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(138, 454);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(115, 50);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSize = true;
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(138, 517);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(115, 50);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AutoSize = true;
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(13, 517);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(115, 50);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa ";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.AutoSize = true;
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(13, 454);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 50);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // ckb_add
            // 
            this.ckb_add.AutoSize = true;
            this.ckb_add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_add.Location = new System.Drawing.Point(13, 110);
            this.ckb_add.Name = "ckb_add";
            this.ckb_add.Size = new System.Drawing.Size(235, 25);
            this.ckb_add.TabIndex = 3;
            this.ckb_add.Text = "Bạn muốn thêm khách hàng";
            this.ckb_add.UseVisualStyleBackColor = true;
            this.ckb_add.CheckedChanged += new System.EventHandler(this.ckb_add_CheckedChanged);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(119, 274);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(128, 27);
            this.txt_sdt.TabIndex = 7;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(119, 317);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(128, 27);
            this.txt_diachi.TabIndex = 8;
            // 
            // txt_cccd
            // 
            this.txt_cccd.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cccd.Location = new System.Drawing.Point(119, 231);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(128, 27);
            this.txt_cccd.TabIndex = 6;
            this.txt_cccd.TextChanged += new System.EventHandler(this.txt_cccd_TextChanged);
            // 
            // txt_hovaten
            // 
            this.txt_hovaten.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hovaten.Location = new System.Drawing.Point(119, 188);
            this.txt_hovaten.Name = "txt_hovaten";
            this.txt_hovaten.Size = new System.Drawing.Size(128, 27);
            this.txt_hovaten.TabIndex = 5;
            this.txt_hovaten.TextChanged += new System.EventHandler(this.txt_hovaten_TextChanged);
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.AutoSize = true;
            this.lbl_sdt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sdt.Location = new System.Drawing.Point(10, 277);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(99, 19);
            this.lbl_sdt.TabIndex = 9;
            this.lbl_sdt.Text = "Số điện thoại";
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachi.Location = new System.Drawing.Point(9, 320);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(58, 19);
            this.lbl_diachi.TabIndex = 8;
            this.lbl_diachi.Text = "Địa chỉ";
            // 
            // lbl_cccd
            // 
            this.lbl_cccd.AutoSize = true;
            this.lbl_cccd.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cccd.Location = new System.Drawing.Point(13, 234);
            this.lbl_cccd.Name = "lbl_cccd";
            this.lbl_cccd.Size = new System.Drawing.Size(54, 19);
            this.lbl_cccd.TabIndex = 7;
            this.lbl_cccd.Text = "CCCD";
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioitinh.Location = new System.Drawing.Point(10, 363);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(70, 19);
            this.lbl_gioitinh.TabIndex = 6;
            this.lbl_gioitinh.Text = "Giới tính";
            // 
            // lbl_hovaten
            // 
            this.lbl_hovaten.AutoSize = true;
            this.lbl_hovaten.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hovaten.Location = new System.Drawing.Point(10, 191);
            this.lbl_hovaten.Name = "lbl_hovaten";
            this.lbl_hovaten.Size = new System.Drawing.Size(73, 19);
            this.lbl_hovaten.TabIndex = 3;
            this.lbl_hovaten.Text = "Họ và tên";
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Location = new System.Drawing.Point(119, 145);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(128, 27);
            this.txt_makh.TabIndex = 4;
            // 
            // lbl_makh
            // 
            this.lbl_makh.AutoSize = true;
            this.lbl_makh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_makh.Location = new System.Drawing.Point(9, 148);
            this.lbl_makh.Name = "lbl_makh";
            this.lbl_makh.Size = new System.Drawing.Size(74, 19);
            this.lbl_makh.TabIndex = 1;
            this.lbl_makh.Text = "Mã khách";
            // 
            // grb_search
            // 
            this.grb_search.Controls.Add(this.txt_search);
            this.grb_search.Controls.Add(this.btn_cancel);
            this.grb_search.Location = new System.Drawing.Point(13, 12);
            this.grb_search.Name = "grb_search";
            this.grb_search.Size = new System.Drawing.Size(234, 82);
            this.grb_search.TabIndex = 0;
            this.grb_search.TabStop = false;
            this.grb_search.Text = "Tìm kiếm theo mã khách hàng";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(6, 38);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 22);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(123, 34);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(96, 29);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Fr_QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 577);
            this.Controls.Add(this.Pnel_ThaoTac);
            this.Controls.Add(this.Pel_2);
            this.Name = "Fr_QuanLyKhachHang";
            this.Text = "Quản lý khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.Pel_2.ResumeLayout(false);
            this.Pnel_ThaoTac.ResumeLayout(false);
            this.Pnel_ThaoTac.PerformLayout();
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Panel Pel_2;
        private System.Windows.Forms.Panel Pnel_ThaoTac;
        private System.Windows.Forms.GroupBox grb_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_sdt;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.Label lbl_cccd;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.Label lbl_hovaten;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label lbl_makh;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.TextBox txt_hovaten;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.CheckBox ckb_add;
        private System.Windows.Forms.TextBox txt_quoctich;
        private System.Windows.Forms.Label lbl_quoctich;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOVATEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUOCTICH;
        private System.Windows.Forms.ComboBox cbb_gioitinh;
    }
}