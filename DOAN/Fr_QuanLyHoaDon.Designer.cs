
namespace DOAN
{
    partial class Fr_QuanLyHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pcb_search = new System.Windows.Forms.PictureBox();
            this.txt_seach = new System.Windows.Forms.TextBox();
            this.Pnel_ThaoTac = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_mactphieuthue = new System.Windows.Forms.TextBox();
            this.lbl_mactphieuthue = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.lbl_tennv = new System.Windows.Forms.Label();
            this.txt_ngaylap = new System.Windows.Forms.TextBox();
            this.lbl_ngaylap = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.lbl_mahd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search)).BeginInit();
            this.Pnel_ThaoTac.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_search
            // 
            this.pcb_search.Image = global::DOAN.Properties.Resources.Icon_Search;
            this.pcb_search.Location = new System.Drawing.Point(24, 30);
            this.pcb_search.Name = "pcb_search";
            this.pcb_search.Size = new System.Drawing.Size(31, 26);
            this.pcb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search.TabIndex = 4;
            this.pcb_search.TabStop = false;
            // 
            // txt_seach
            // 
            this.txt_seach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seach.Location = new System.Drawing.Point(66, 30);
            this.txt_seach.Name = "txt_seach";
            this.txt_seach.Size = new System.Drawing.Size(162, 26);
            this.txt_seach.TabIndex = 1;
            this.txt_seach.TextChanged += new System.EventHandler(this.txt_seach_TextChanged);
            // 
            // Pnel_ThaoTac
            // 
            this.Pnel_ThaoTac.Controls.Add(this.groupBox1);
            this.Pnel_ThaoTac.Controls.Add(this.btn_thoat);
            this.Pnel_ThaoTac.Controls.Add(this.txt_mactphieuthue);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_mactphieuthue);
            this.Pnel_ThaoTac.Controls.Add(this.txt_tongtien);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_TongTien);
            this.Pnel_ThaoTac.Controls.Add(this.txt_tenkh);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_tennv);
            this.Pnel_ThaoTac.Controls.Add(this.txt_ngaylap);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_ngaylap);
            this.Pnel_ThaoTac.Controls.Add(this.txt_mahd);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_mahd);
            this.Pnel_ThaoTac.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnel_ThaoTac.Location = new System.Drawing.Point(893, 0);
            this.Pnel_ThaoTac.Name = "Pnel_ThaoTac";
            this.Pnel_ThaoTac.Size = new System.Drawing.Size(262, 464);
            this.Pnel_ThaoTac.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcb_search);
            this.groupBox1.Controls.Add(this.txt_seach);
            this.groupBox1.Location = new System.Drawing.Point(10, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 78);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm Tên Khách hàng";
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSize = true;
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(10, 398);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(243, 50);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_mactphieuthue
            // 
            this.txt_mactphieuthue.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mactphieuthue.Location = new System.Drawing.Point(125, 167);
            this.txt_mactphieuthue.Name = "txt_mactphieuthue";
            this.txt_mactphieuthue.Size = new System.Drawing.Size(128, 27);
            this.txt_mactphieuthue.TabIndex = 3;
            this.txt_mactphieuthue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_mactphieuthue
            // 
            this.lbl_mactphieuthue.AutoSize = true;
            this.lbl_mactphieuthue.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mactphieuthue.Location = new System.Drawing.Point(6, 170);
            this.lbl_mactphieuthue.Name = "lbl_mactphieuthue";
            this.lbl_mactphieuthue.Size = new System.Drawing.Size(111, 19);
            this.lbl_mactphieuthue.TabIndex = 32;
            this.lbl_mactphieuthue.Text = "Mã Phiếu Thuê";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Location = new System.Drawing.Point(125, 296);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(128, 27);
            this.txt_tongtien.TabIndex = 5;
            this.txt_tongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.Location = new System.Drawing.Point(6, 299);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(73, 19);
            this.lbl_TongTien.TabIndex = 30;
            this.lbl_TongTien.Text = "Tổng tiền";
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.Location = new System.Drawing.Point(125, 253);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(128, 27);
            this.txt_tenkh.TabIndex = 4;
            // 
            // lbl_tennv
            // 
            this.lbl_tennv.AutoSize = true;
            this.lbl_tennv.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tennv.Location = new System.Drawing.Point(6, 256);
            this.lbl_tennv.Name = "lbl_tennv";
            this.lbl_tennv.Size = new System.Drawing.Size(81, 19);
            this.lbl_tennv.TabIndex = 28;
            this.lbl_tennv.Text = "Tên Khách";
            // 
            // txt_ngaylap
            // 
            this.txt_ngaylap.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaylap.Location = new System.Drawing.Point(125, 210);
            this.txt_ngaylap.Name = "txt_ngaylap";
            this.txt_ngaylap.Size = new System.Drawing.Size(128, 27);
            this.txt_ngaylap.TabIndex = 6;
            // 
            // lbl_ngaylap
            // 
            this.lbl_ngaylap.AutoSize = true;
            this.lbl_ngaylap.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaylap.Location = new System.Drawing.Point(6, 213);
            this.lbl_ngaylap.Name = "lbl_ngaylap";
            this.lbl_ngaylap.Size = new System.Drawing.Size(68, 19);
            this.lbl_ngaylap.TabIndex = 26;
            this.lbl_ngaylap.Text = "Ngày lập";
            // 
            // txt_mahd
            // 
            this.txt_mahd.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahd.Location = new System.Drawing.Point(125, 124);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(128, 27);
            this.txt_mahd.TabIndex = 2;
            this.txt_mahd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_mahd
            // 
            this.lbl_mahd.AutoSize = true;
            this.lbl_mahd.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mahd.Location = new System.Drawing.Point(6, 127);
            this.lbl_mahd.Name = "lbl_mahd";
            this.lbl_mahd.Size = new System.Drawing.Size(94, 19);
            this.lbl_mahd.TabIndex = 24;
            this.lbl_mahd.Text = "Mã hóa đơn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 464);
            this.panel1.TabIndex = 27;
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.Column5,
            this.NGAYLAP,
            this.Column3,
            this.Column4});
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv.Location = new System.Drawing.Point(0, 0);
            this.dtgv.Name = "dtgv";
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(893, 464);
            this.dtgv.TabIndex = 0;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            this.dtgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellDoubleClick);
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MAHD.DefaultCellStyle = dataGridViewCellStyle1;
            this.MAHD.HeaderText = "Mã hóa đơn";
            this.MAHD.Name = "MAHD";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MAPHIEU";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Mã CT phiếu thuê";
            this.Column5.Name = "Column5";
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.Width = 225;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HOVATEN";
            this.Column3.HeaderText = "Tên Khách hàng";
            this.Column3.Name = "Column3";
            this.Column3.Width = 225;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TONGHOADON";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Fr_QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnel_ThaoTac);
            this.Name = "Fr_QuanLyHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.Fr_QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search)).EndInit();
            this.Pnel_ThaoTac.ResumeLayout(false);
            this.Pnel_ThaoTac.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_search;
        private System.Windows.Forms.TextBox txt_seach;
        private System.Windows.Forms.Panel Pnel_ThaoTac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.TextBox txt_mactphieuthue;
        private System.Windows.Forms.Label lbl_mactphieuthue;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label lbl_tennv;
        private System.Windows.Forms.TextBox txt_ngaylap;
        private System.Windows.Forms.Label lbl_ngaylap;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label lbl_mahd;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}