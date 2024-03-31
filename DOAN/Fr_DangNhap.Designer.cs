
namespace DOAN
{
    partial class Fr_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_DangNhap));
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_dn = new System.Windows.Forms.Button();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.lbl_tk = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.lbl_mk = new System.Windows.Forms.Label();
            this.Pnel_ThaoTac = new System.Windows.Forms.Panel();
            this.pct_user = new System.Windows.Forms.PictureBox();
            this.pnel_pic = new System.Windows.Forms.Panel();
            this.Pnel_ThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_user)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(24, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(598, 31);
            this.lbl_title.TabIndex = 14;
            this.lbl_title.Text = "CHÀO MỪNG ĐẾN VỚI KHÁCH SẠN MAISON";
            // 
            // btn_dn
            // 
            this.btn_dn.AutoSize = true;
            this.btn_dn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btn_dn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btn_dn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_dn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_dn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dn.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dn.Location = new System.Drawing.Point(93, 286);
            this.btn_dn.Name = "btn_dn";
            this.btn_dn.Size = new System.Drawing.Size(117, 39);
            this.btn_dn.TabIndex = 3;
            this.btn_dn.Text = "Đăng Nhập";
            this.btn_dn.UseVisualStyleBackColor = false;
            this.btn_dn.Click += new System.EventHandler(this.btn_dn_Click);
            // 
            // txt_mk
            // 
            this.txt_mk.BackColor = System.Drawing.SystemColors.Window;
            this.txt_mk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mk.Location = new System.Drawing.Point(135, 220);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '*';
            this.txt_mk.Size = new System.Drawing.Size(145, 29);
            this.txt_mk.TabIndex = 2;
            // 
            // lbl_tk
            // 
            this.lbl_tk.AutoSize = true;
            this.lbl_tk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tk.Location = new System.Drawing.Point(21, 177);
            this.lbl_tk.Name = "lbl_tk";
            this.lbl_tk.Size = new System.Drawing.Size(92, 21);
            this.lbl_tk.TabIndex = 6;
            this.lbl_tk.Text = "Tài Khoản:";
            // 
            // txt_tk
            // 
            this.txt_tk.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(135, 175);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(145, 29);
            this.txt_tk.TabIndex = 1;
            // 
            // lbl_mk
            // 
            this.lbl_mk.AutoSize = true;
            this.lbl_mk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mk.Location = new System.Drawing.Point(21, 222);
            this.lbl_mk.Name = "lbl_mk";
            this.lbl_mk.Size = new System.Drawing.Size(83, 21);
            this.lbl_mk.TabIndex = 7;
            this.lbl_mk.Text = "Mật khẩu:";
            // 
            // Pnel_ThaoTac
            // 
            this.Pnel_ThaoTac.BackColor = System.Drawing.Color.White;
            this.Pnel_ThaoTac.Controls.Add(this.pct_user);
            this.Pnel_ThaoTac.Controls.Add(this.btn_dn);
            this.Pnel_ThaoTac.Controls.Add(this.txt_mk);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_tk);
            this.Pnel_ThaoTac.Controls.Add(this.txt_tk);
            this.Pnel_ThaoTac.Controls.Add(this.lbl_mk);
            this.Pnel_ThaoTac.Location = new System.Drawing.Point(323, 55);
            this.Pnel_ThaoTac.Name = "Pnel_ThaoTac";
            this.Pnel_ThaoTac.Size = new System.Drawing.Size(301, 348);
            this.Pnel_ThaoTac.TabIndex = 15;
            // 
            // pct_user
            // 
            this.pct_user.Image = global::DOAN.Properties.Resources.User_Login;
            this.pct_user.Location = new System.Drawing.Point(61, -12);
            this.pct_user.Name = "pct_user";
            this.pct_user.Size = new System.Drawing.Size(189, 163);
            this.pct_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_user.TabIndex = 0;
            this.pct_user.TabStop = false;
            // 
            // pnel_pic
            // 
            this.pnel_pic.BackColor = System.Drawing.Color.White;
            this.pnel_pic.BackgroundImage = global::DOAN.Properties.Resources.TOWER;
            this.pnel_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnel_pic.Location = new System.Drawing.Point(12, 55);
            this.pnel_pic.Name = "pnel_pic";
            this.pnel_pic.Size = new System.Drawing.Size(305, 348);
            this.pnel_pic.TabIndex = 16;
            // 
            // Fr_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(636, 414);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.Pnel_ThaoTac);
            this.Controls.Add(this.pnel_pic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fr_DangNhap";
            this.Text = "Đăng nhập";
            this.Pnel_ThaoTac.ResumeLayout(false);
            this.Pnel_ThaoTac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_dn;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Label lbl_tk;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label lbl_mk;
        private System.Windows.Forms.Panel Pnel_ThaoTac;
        private System.Windows.Forms.Panel pnel_pic;
        private System.Windows.Forms.PictureBox pct_user;
    }
}

