
namespace DOAN
{
    partial class Fr_QuanLyLoaiPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.MALOAIPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAIPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOGIUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnel_ThaoTac = new System.Windows.Forms.Panel();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.ckb_add = new System.Windows.Forms.CheckBox();
            this.txt_sogiuong = new System.Windows.Forms.TextBox();
            this.txt_tenloaiphong = new System.Windows.Forms.TextBox();
            this.lbl_tenloaiphong = new System.Windows.Forms.Label();
            this.lbl_sogiuong = new System.Windows.Forms.Label();
            this.txt_maloaiphong = new System.Windows.Forms.TextBox();
            this.lbl_maloaiphong = new System.Windows.Forms.Label();
            this.grb_search = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.Pnel_ThaoTac.SuspendLayout();
            this.grb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 450);
            this.panel1.TabIndex = 11;
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAIPHONG,
            this.TENLOAIPHONG,
            this.SOGIUONG});
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv.Location = new System.Drawing.Point(0, 0);
            this.dtgv.Name = "dtgv";
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1090, 450);
            this.dtgv.TabIndex = 2;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            this.dtgv.DoubleClick += new System.EventHandler(this.dtgv_DoubleClick);
            // 
            // MALOAIPHONG
            // 
            this.MALOAIPHONG.DataPropertyName = "MALOAIPHONG";
            this.MALOAIPHONG.HeaderText = "Mã loại phòng";
            this.MALOAIPHONG.Name = "MALOAIPHONG";
            this.MALOAIPHONG.Width = 283;
            // 
            // TENLOAIPHONG
            // 
            this.TENLOAIPHONG.DataPropertyName = "TENLOAIPHONG";
            this.TENLOAIPHONG.HeaderText = "Tên loại phòng";
            this.TENLOAIPHONG.Name = "TENLOAIPHONG";
            this.TENLOAIPHONG.Width = 283;
            // 
            // SOGIUONG
            // 
            this.SOGIUONG.DataPropertyName = "SOGIUONG";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.SOGIUONG.DefaultCellStyle = dataGridViewCellStyle1;
            this.SOGIUONG.HeaderText = "Số giường";
            this.SOGIUONG.Name = "SOGIUONG";
            this.SOGIUONG.Width = 283;
            // 
            // Pnel_ThaoTac
            // 
            this.Pnel_ThaoTac.Controls.Add(this.btn_sua);
            this.Pnel_ThaoTac.Controls.Add(this.btn_thoat);
            this.Pnel_ThaoTac.Controls.Add(this.btn_xoa);
            this.Pnel_ThaoTac.Controls.Add(this.btn_them);
            this.Pnel_ThaoTac.Controls.Add(this.ckb_add);
            this.Pnel_ThaoTac.Controls.Add(this.txt_sogiuong);
            this.Pnel_ThaoTac.Controls.Add(this.txt_tenloaiphong);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_tenloaiphong);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_sogiuong);
            this.Pnel_ThaoTac.Controls.Add(this.txt_maloaiphong);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_maloaiphong);
            this.Pnel_ThaoTac.Controls.Add(this.grb_search);
            this.Pnel_ThaoTac.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnel_ThaoTac.Location = new System.Drawing.Point(893, 0);
            this.Pnel_ThaoTac.Name = "Pnel_ThaoTac";
            this.Pnel_ThaoTac.Size = new System.Drawing.Size(274, 450);
            this.Pnel_ThaoTac.TabIndex = 12;
            // 
            // btn_sua
            // 
            this.btn_sua.AutoSize = true;
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(144, 333);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(115, 50);
            this.btn_sua.TabIndex = 8;
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
            this.btn_thoat.Location = new System.Drawing.Point(144, 396);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(115, 50);
            this.btn_thoat.TabIndex = 10;
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
            this.btn_xoa.Location = new System.Drawing.Point(14, 396);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(115, 50);
            this.btn_xoa.TabIndex = 9;
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
            this.btn_them.Location = new System.Drawing.Point(13, 333);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 50);
            this.btn_them.TabIndex = 7;
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
            this.ckb_add.Size = new System.Drawing.Size(229, 25);
            this.ckb_add.TabIndex = 3;
            this.ckb_add.Text = "Bạn muốn thêm loại phòng";
            this.ckb_add.UseVisualStyleBackColor = true;
            this.ckb_add.CheckedChanged += new System.EventHandler(this.ckb_add_CheckedChanged);
            // 
            // txt_sogiuong
            // 
            this.txt_sogiuong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sogiuong.Location = new System.Drawing.Point(127, 275);
            this.txt_sogiuong.Name = "txt_sogiuong";
            this.txt_sogiuong.Size = new System.Drawing.Size(128, 27);
            this.txt_sogiuong.TabIndex = 6;
            this.txt_sogiuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_sogiuong.TextChanged += new System.EventHandler(this.txt_sogiuong_TextChanged);
            // 
            // txt_tenloaiphong
            // 
            this.txt_tenloaiphong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenloaiphong.Location = new System.Drawing.Point(127, 216);
            this.txt_tenloaiphong.Name = "txt_tenloaiphong";
            this.txt_tenloaiphong.Size = new System.Drawing.Size(128, 27);
            this.txt_tenloaiphong.TabIndex = 5;
            // 
            // lbl_tenloaiphong
            // 
            this.lbl_tenloaiphong.AutoSize = true;
            this.lbl_tenloaiphong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenloaiphong.Location = new System.Drawing.Point(9, 219);
            this.lbl_tenloaiphong.Name = "lbl_tenloaiphong";
            this.lbl_tenloaiphong.Size = new System.Drawing.Size(109, 19);
            this.lbl_tenloaiphong.TabIndex = 4;
            this.lbl_tenloaiphong.Text = "Tên loại phòng";
            // 
            // lbl_sogiuong
            // 
            this.lbl_sogiuong.AutoSize = true;
            this.lbl_sogiuong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sogiuong.Location = new System.Drawing.Point(9, 278);
            this.lbl_sogiuong.Name = "lbl_sogiuong";
            this.lbl_sogiuong.Size = new System.Drawing.Size(78, 19);
            this.lbl_sogiuong.TabIndex = 3;
            this.lbl_sogiuong.Text = "Số giường";
            // 
            // txt_maloaiphong
            // 
            this.txt_maloaiphong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maloaiphong.Location = new System.Drawing.Point(127, 157);
            this.txt_maloaiphong.Name = "txt_maloaiphong";
            this.txt_maloaiphong.Size = new System.Drawing.Size(128, 27);
            this.txt_maloaiphong.TabIndex = 4;
            // 
            // lbl_maloaiphong
            // 
            this.lbl_maloaiphong.AutoSize = true;
            this.lbl_maloaiphong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maloaiphong.Location = new System.Drawing.Point(9, 160);
            this.lbl_maloaiphong.Name = "lbl_maloaiphong";
            this.lbl_maloaiphong.Size = new System.Drawing.Size(106, 19);
            this.lbl_maloaiphong.TabIndex = 1;
            this.lbl_maloaiphong.Text = "Mã loại phòng";
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
            this.grb_search.Text = "Tìm kiếm theo Mã Loại Phòng";
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
            // Fr_QuanLyLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 450);
            this.Controls.Add(this.Pnel_ThaoTac);
            this.Controls.Add(this.panel1);
            this.Name = "Fr_QuanLyLoaiPhong";
            this.Text = "Fr_QuanLyLoaiPhong";
            this.Load += new System.EventHandler(this.Fr_QuanLyLoaiPhong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.Pnel_ThaoTac.ResumeLayout(false);
            this.Pnel_ThaoTac.PerformLayout();
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Panel Pnel_ThaoTac;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.CheckBox ckb_add;
        private System.Windows.Forms.TextBox txt_sogiuong;
        private System.Windows.Forms.TextBox txt_tenloaiphong;
        private System.Windows.Forms.Label lbl_tenloaiphong;
        private System.Windows.Forms.Label lbl_sogiuong;
        private System.Windows.Forms.TextBox txt_maloaiphong;
        private System.Windows.Forms.Label lbl_maloaiphong;
        private System.Windows.Forms.GroupBox grb_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAIPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAIPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOGIUONG;
    }
}