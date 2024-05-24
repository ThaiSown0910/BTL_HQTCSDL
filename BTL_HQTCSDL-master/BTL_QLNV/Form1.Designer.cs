namespace BTL_QLNV
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.dtime_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_mapb1 = new System.Windows.Forms.TextBox();
            this.tb_tennv = new System.Windows.Forms.TextBox();
            this.tb_tienluong = new System.Windows.Forms.TextBox();
            this.tb_chucvu = new System.Windows.Forms.TextBox();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_tenpb = new System.Windows.Forms.TextBox();
            this.tb_mapb2 = new System.Windows.Forms.TextBox();
            this.bt_sua1 = new System.Windows.Forms.Button();
            this.bt_xoa1 = new System.Windows.Forms.Button();
            this.bt_khoitao1 = new System.Windows.Forms.Button();
            this.bt_them1 = new System.Windows.Forms.Button();
            this.bt_them2 = new System.Windows.Forms.Button();
            this.bt_sua2 = new System.Windows.Forms.Button();
            this.bt_xoa2 = new System.Windows.Forms.Button();
            this.bt_khoitao2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(6, 21);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(829, 363);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.cb_gioitinh);
            this.groupBox2.Controls.Add(this.dtime_ngaysinh);
            this.groupBox2.Controls.Add(this.tb_mapb1);
            this.groupBox2.Controls.Add(this.tb_tennv);
            this.groupBox2.Controls.Add(this.tb_tienluong);
            this.groupBox2.Controls.Add(this.tb_chucvu);
            this.groupBox2.Controls.Add(this.tb_manv);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Điều Khiển";
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(124, 200);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(216, 24);
            this.cb_gioitinh.TabIndex = 3;
            this.cb_gioitinh.SelectedIndexChanged += new System.EventHandler(this.cb_gioitinh_SelectedIndexChanged);
            // 
            // dtime_ngaysinh
            // 
            this.dtime_ngaysinh.Location = new System.Drawing.Point(455, 42);
            this.dtime_ngaysinh.Name = "dtime_ngaysinh";
            this.dtime_ngaysinh.Size = new System.Drawing.Size(273, 22);
            this.dtime_ngaysinh.TabIndex = 2;
            // 
            // tb_mapb1
            // 
            this.tb_mapb1.Location = new System.Drawing.Point(124, 275);
            this.tb_mapb1.Name = "tb_mapb1";
            this.tb_mapb1.Size = new System.Drawing.Size(216, 22);
            this.tb_mapb1.TabIndex = 1;
            // 
            // tb_tennv
            // 
            this.tb_tennv.Location = new System.Drawing.Point(124, 125);
            this.tb_tennv.Name = "tb_tennv";
            this.tb_tennv.Size = new System.Drawing.Size(216, 22);
            this.tb_tennv.TabIndex = 1;
            // 
            // tb_tienluong
            // 
            this.tb_tienluong.Location = new System.Drawing.Point(455, 202);
            this.tb_tienluong.Name = "tb_tienluong";
            this.tb_tienluong.Size = new System.Drawing.Size(273, 22);
            this.tb_tienluong.TabIndex = 1;
            // 
            // tb_chucvu
            // 
            this.tb_chucvu.Location = new System.Drawing.Point(455, 125);
            this.tb_chucvu.Name = "tb_chucvu";
            this.tb_chucvu.Size = new System.Drawing.Size(273, 22);
            this.tb_chucvu.TabIndex = 1;
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(124, 41);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(216, 22);
            this.tb_manv.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Phòng Ban";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tiền Lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chức Vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv2);
            this.groupBox3.Location = new System.Drawing.Point(878, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 390);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Phòng Ban";
            // 
            // dgv2
            // 
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(6, 21);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(634, 363);
            this.dgv2.TabIndex = 0;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tb_diachi);
            this.groupBox4.Controls.Add(this.tb_tenpb);
            this.groupBox4.Controls.Add(this.tb_mapb2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(878, 430);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 315);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bảng Điều Khiển";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Phòng Ban";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Phòng Ban";
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(152, 197);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(318, 22);
            this.tb_diachi.TabIndex = 1;
            // 
            // tb_tenpb
            // 
            this.tb_tenpb.Location = new System.Drawing.Point(152, 119);
            this.tb_tenpb.Name = "tb_tenpb";
            this.tb_tenpb.Size = new System.Drawing.Size(318, 22);
            this.tb_tenpb.TabIndex = 1;
            // 
            // tb_mapb2
            // 
            this.tb_mapb2.Location = new System.Drawing.Point(152, 41);
            this.tb_mapb2.Name = "tb_mapb2";
            this.tb_mapb2.Size = new System.Drawing.Size(318, 22);
            this.tb_mapb2.TabIndex = 1;
            // 
            // bt_sua1
            // 
            this.bt_sua1.BackColor = System.Drawing.Color.PowderBlue;
            this.bt_sua1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua1.ForeColor = System.Drawing.Color.White;
            this.bt_sua1.Location = new System.Drawing.Point(757, 514);
            this.bt_sua1.Name = "bt_sua1";
            this.bt_sua1.Size = new System.Drawing.Size(96, 57);
            this.bt_sua1.TabIndex = 4;
            this.bt_sua1.Text = "Sửa";
            this.bt_sua1.UseVisualStyleBackColor = false;
            this.bt_sua1.Click += new System.EventHandler(this.bt_sua1_Click);
            // 
            // bt_xoa1
            // 
            this.bt_xoa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(152)))), ((int)(((byte)(190)))));
            this.bt_xoa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa1.ForeColor = System.Drawing.Color.White;
            this.bt_xoa1.Location = new System.Drawing.Point(757, 603);
            this.bt_xoa1.Name = "bt_xoa1";
            this.bt_xoa1.Size = new System.Drawing.Size(96, 57);
            this.bt_xoa1.TabIndex = 4;
            this.bt_xoa1.Text = "Xóa";
            this.bt_xoa1.UseVisualStyleBackColor = false;
            this.bt_xoa1.Click += new System.EventHandler(this.bt_xoa1_Click);
            // 
            // bt_khoitao1
            // 
            this.bt_khoitao1.BackColor = System.Drawing.Color.PowderBlue;
            this.bt_khoitao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_khoitao1.ForeColor = System.Drawing.Color.White;
            this.bt_khoitao1.Location = new System.Drawing.Point(757, 688);
            this.bt_khoitao1.Name = "bt_khoitao1";
            this.bt_khoitao1.Size = new System.Drawing.Size(96, 57);
            this.bt_khoitao1.TabIndex = 4;
            this.bt_khoitao1.Text = "Khởi Tạo";
            this.bt_khoitao1.UseVisualStyleBackColor = false;
            this.bt_khoitao1.Click += new System.EventHandler(this.bt_khoitao1_Click);
            // 
            // bt_them1
            // 
            this.bt_them1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(152)))), ((int)(((byte)(190)))));
            this.bt_them1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them1.ForeColor = System.Drawing.Color.White;
            this.bt_them1.Location = new System.Drawing.Point(757, 433);
            this.bt_them1.Name = "bt_them1";
            this.bt_them1.Size = new System.Drawing.Size(96, 57);
            this.bt_them1.TabIndex = 4;
            this.bt_them1.Text = "Thêm";
            this.bt_them1.UseVisualStyleBackColor = false;
            this.bt_them1.Click += new System.EventHandler(this.bt_them1_Click);
            // 
            // bt_them2
            // 
            this.bt_them2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(152)))), ((int)(((byte)(190)))));
            this.bt_them2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them2.ForeColor = System.Drawing.Color.White;
            this.bt_them2.Location = new System.Drawing.Point(1428, 433);
            this.bt_them2.Name = "bt_them2";
            this.bt_them2.Size = new System.Drawing.Size(96, 57);
            this.bt_them2.TabIndex = 4;
            this.bt_them2.Text = "Thêm";
            this.bt_them2.UseVisualStyleBackColor = false;
            this.bt_them2.Click += new System.EventHandler(this.bt_them2_Click);
            // 
            // bt_sua2
            // 
            this.bt_sua2.BackColor = System.Drawing.Color.PowderBlue;
            this.bt_sua2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua2.ForeColor = System.Drawing.Color.White;
            this.bt_sua2.Location = new System.Drawing.Point(1428, 514);
            this.bt_sua2.Name = "bt_sua2";
            this.bt_sua2.Size = new System.Drawing.Size(96, 57);
            this.bt_sua2.TabIndex = 4;
            this.bt_sua2.Text = "Sửa";
            this.bt_sua2.UseVisualStyleBackColor = false;
            this.bt_sua2.Click += new System.EventHandler(this.bt_sua2_Click);
            // 
            // bt_xoa2
            // 
            this.bt_xoa2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(152)))), ((int)(((byte)(190)))));
            this.bt_xoa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa2.ForeColor = System.Drawing.Color.White;
            this.bt_xoa2.Location = new System.Drawing.Point(1428, 603);
            this.bt_xoa2.Name = "bt_xoa2";
            this.bt_xoa2.Size = new System.Drawing.Size(96, 57);
            this.bt_xoa2.TabIndex = 4;
            this.bt_xoa2.Text = "Xóa";
            this.bt_xoa2.UseVisualStyleBackColor = false;
            this.bt_xoa2.Click += new System.EventHandler(this.bt_xoa2_Click);
            // 
            // bt_khoitao2
            // 
            this.bt_khoitao2.BackColor = System.Drawing.Color.PowderBlue;
            this.bt_khoitao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_khoitao2.ForeColor = System.Drawing.Color.White;
            this.bt_khoitao2.Location = new System.Drawing.Point(1428, 688);
            this.bt_khoitao2.Name = "bt_khoitao2";
            this.bt_khoitao2.Size = new System.Drawing.Size(96, 57);
            this.bt_khoitao2.TabIndex = 4;
            this.bt_khoitao2.Text = "Khởi Tạo";
            this.bt_khoitao2.UseVisualStyleBackColor = false;
            this.bt_khoitao2.Click += new System.EventHandler(this.bt_khoitao2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1757, 772);
            this.Controls.Add(this.bt_khoitao1);
            this.Controls.Add(this.bt_xoa1);
            this.Controls.Add(this.bt_khoitao2);
            this.Controls.Add(this.bt_xoa2);
            this.Controls.Add(this.bt_sua2);
            this.Controls.Add(this.bt_them2);
            this.Controls.Add(this.bt_them1);
            this.Controls.Add(this.bt_sua1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_sua1;
        private System.Windows.Forms.Button bt_xoa1;
        private System.Windows.Forms.Button bt_khoitao1;
        private System.Windows.Forms.Button bt_them1;
        private System.Windows.Forms.Button bt_them2;
        private System.Windows.Forms.Button bt_sua2;
        private System.Windows.Forms.Button bt_xoa2;
        private System.Windows.Forms.Button bt_khoitao2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mapb1;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tennv;
        private System.Windows.Forms.TextBox tb_tienluong;
        private System.Windows.Forms.TextBox tb_chucvu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_tenpb;
        private System.Windows.Forms.TextBox tb_mapb2;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.DateTimePicker dtime_ngaysinh;

    }
}

