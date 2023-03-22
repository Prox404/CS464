namespace Lab7_Cau1
{
	partial class SinhVien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinhVien));
			this.label1 = new System.Windows.Forms.Label();
			this.txt_MaSinhVien = new System.Windows.Forms.TextBox();
			this.lbl_MaSinhVien = new System.Windows.Forms.Label();
			this.lbl_HoVaTen = new System.Windows.Forms.Label();
			this.txt_HoVaTen = new System.Windows.Forms.TextBox();
			this.lbl_Lop = new System.Windows.Forms.Label();
			this.cb_Lop = new System.Windows.Forms.ComboBox();
			this.lbl_NgaySinh = new System.Windows.Forms.Label();
			this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
			this.lbl_DiaChi = new System.Windows.Forms.Label();
			this.txt_DiaChi = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_Them = new System.Windows.Forms.Button();
			this.btn_Sua = new System.Windows.Forms.Button();
			this.btn_Xoa = new System.Windows.Forms.Button();
			this.lbl_DanhSachSinhVien = new System.Windows.Forms.Label();
			this.dataGridView_DanhSachSinhVien = new System.Windows.Forms.DataGridView();
			this.MaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachSinhVien)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(180, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(351, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cap nhat danh sach sinh vien";
			// 
			// txt_MaSinhVien
			// 
			this.txt_MaSinhVien.Location = new System.Drawing.Point(119, 109);
			this.txt_MaSinhVien.Name = "txt_MaSinhVien";
			this.txt_MaSinhVien.Size = new System.Drawing.Size(161, 20);
			this.txt_MaSinhVien.TabIndex = 1;
			// 
			// lbl_MaSinhVien
			// 
			this.lbl_MaSinhVien.AutoSize = true;
			this.lbl_MaSinhVien.Location = new System.Drawing.Point(42, 112);
			this.lbl_MaSinhVien.Name = "lbl_MaSinhVien";
			this.lbl_MaSinhVien.Size = new System.Drawing.Size(71, 13);
			this.lbl_MaSinhVien.TabIndex = 2;
			this.lbl_MaSinhVien.Text = "Ma SInh Vien";
			// 
			// lbl_HoVaTen
			// 
			this.lbl_HoVaTen.AutoSize = true;
			this.lbl_HoVaTen.Location = new System.Drawing.Point(42, 150);
			this.lbl_HoVaTen.Name = "lbl_HoVaTen";
			this.lbl_HoVaTen.Size = new System.Drawing.Size(54, 13);
			this.lbl_HoVaTen.TabIndex = 4;
			this.lbl_HoVaTen.Text = "Ho va ten";
			// 
			// txt_HoVaTen
			// 
			this.txt_HoVaTen.Location = new System.Drawing.Point(119, 147);
			this.txt_HoVaTen.Name = "txt_HoVaTen";
			this.txt_HoVaTen.Size = new System.Drawing.Size(161, 20);
			this.txt_HoVaTen.TabIndex = 3;
			// 
			// lbl_Lop
			// 
			this.lbl_Lop.AutoSize = true;
			this.lbl_Lop.Location = new System.Drawing.Point(42, 191);
			this.lbl_Lop.Name = "lbl_Lop";
			this.lbl_Lop.Size = new System.Drawing.Size(25, 13);
			this.lbl_Lop.TabIndex = 6;
			this.lbl_Lop.Text = "Lop";
			// 
			// cb_Lop
			// 
			this.cb_Lop.FormattingEnabled = true;
			this.cb_Lop.Location = new System.Drawing.Point(119, 191);
			this.cb_Lop.Name = "cb_Lop";
			this.cb_Lop.Size = new System.Drawing.Size(161, 21);
			this.cb_Lop.TabIndex = 7;
			// 
			// lbl_NgaySinh
			// 
			this.lbl_NgaySinh.AutoSize = true;
			this.lbl_NgaySinh.Location = new System.Drawing.Point(42, 234);
			this.lbl_NgaySinh.Name = "lbl_NgaySinh";
			this.lbl_NgaySinh.Size = new System.Drawing.Size(54, 13);
			this.lbl_NgaySinh.TabIndex = 8;
			this.lbl_NgaySinh.Text = "Ngay sinh";
			// 
			// date_NgaySinh
			// 
			this.date_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_NgaySinh.Location = new System.Drawing.Point(119, 234);
			this.date_NgaySinh.Name = "date_NgaySinh";
			this.date_NgaySinh.Size = new System.Drawing.Size(161, 20);
			this.date_NgaySinh.TabIndex = 10;
			// 
			// lbl_DiaChi
			// 
			this.lbl_DiaChi.AutoSize = true;
			this.lbl_DiaChi.Location = new System.Drawing.Point(42, 276);
			this.lbl_DiaChi.Name = "lbl_DiaChi";
			this.lbl_DiaChi.Size = new System.Drawing.Size(40, 13);
			this.lbl_DiaChi.TabIndex = 11;
			this.lbl_DiaChi.Text = "Dia chi";
			// 
			// txt_DiaChi
			// 
			this.txt_DiaChi.Location = new System.Drawing.Point(119, 276);
			this.txt_DiaChi.Name = "txt_DiaChi";
			this.txt_DiaChi.Size = new System.Drawing.Size(161, 20);
			this.txt_DiaChi.TabIndex = 12;
			// 
			// pictureBox1
			// 
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(425, 109);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(179, 187);
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// btn_Them
			// 
			this.btn_Them.Location = new System.Drawing.Point(45, 329);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(75, 23);
			this.btn_Them.TabIndex = 14;
			this.btn_Them.Text = "Them";
			this.btn_Them.UseVisualStyleBackColor = true;
			// 
			// btn_Sua
			// 
			this.btn_Sua.Location = new System.Drawing.Point(126, 329);
			this.btn_Sua.Name = "btn_Sua";
			this.btn_Sua.Size = new System.Drawing.Size(75, 23);
			this.btn_Sua.TabIndex = 15;
			this.btn_Sua.Text = "Sua";
			this.btn_Sua.UseVisualStyleBackColor = true;
			// 
			// btn_Xoa
			// 
			this.btn_Xoa.Location = new System.Drawing.Point(205, 329);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
			this.btn_Xoa.TabIndex = 16;
			this.btn_Xoa.Text = "Xoa";
			this.btn_Xoa.UseVisualStyleBackColor = true;
			// 
			// lbl_DanhSachSinhVien
			// 
			this.lbl_DanhSachSinhVien.AutoSize = true;
			this.lbl_DanhSachSinhVien.Location = new System.Drawing.Point(42, 383);
			this.lbl_DanhSachSinhVien.Name = "lbl_DanhSachSinhVien";
			this.lbl_DanhSachSinhVien.Size = new System.Drawing.Size(104, 13);
			this.lbl_DanhSachSinhVien.TabIndex = 17;
			this.lbl_DanhSachSinhVien.Text = "Danh sach sinh vien";
			// 
			// dataGridView_DanhSachSinhVien
			// 
			this.dataGridView_DanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_DanhSachSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSinhVien,
            this.HoVaTen,
            this.Ngaysinh,
            this.DiaChi,
            this.HinhAnh,
            this.MaLop});
			this.dataGridView_DanhSachSinhVien.Location = new System.Drawing.Point(28, 421);
			this.dataGridView_DanhSachSinhVien.Name = "dataGridView_DanhSachSinhVien";
			this.dataGridView_DanhSachSinhVien.Size = new System.Drawing.Size(622, 191);
			this.dataGridView_DanhSachSinhVien.TabIndex = 18;
			// 
			// MaSinhVien
			// 
			this.MaSinhVien.HeaderText = "Mã sinh viên";
			this.MaSinhVien.Name = "MaSinhVien";
			// 
			// HoVaTen
			// 
			this.HoVaTen.HeaderText = "Họ và tên";
			this.HoVaTen.Name = "HoVaTen";
			// 
			// Ngaysinh
			// 
			this.Ngaysinh.HeaderText = "Ngày sinh";
			this.Ngaysinh.Name = "Ngaysinh";
			// 
			// DiaChi
			// 
			this.DiaChi.HeaderText = "Địa chỉ";
			this.DiaChi.Name = "DiaChi";
			// 
			// HinhAnh
			// 
			this.HinhAnh.HeaderText = "Hình ảnh";
			this.HinhAnh.Name = "HinhAnh";
			// 
			// MaLop
			// 
			this.MaLop.HeaderText = "Mã lớp";
			this.MaLop.Name = "MaLop";
			// 
			// SinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 624);
			this.Controls.Add(this.dataGridView_DanhSachSinhVien);
			this.Controls.Add(this.lbl_DanhSachSinhVien);
			this.Controls.Add(this.btn_Xoa);
			this.Controls.Add(this.btn_Sua);
			this.Controls.Add(this.btn_Them);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txt_DiaChi);
			this.Controls.Add(this.lbl_DiaChi);
			this.Controls.Add(this.date_NgaySinh);
			this.Controls.Add(this.lbl_NgaySinh);
			this.Controls.Add(this.cb_Lop);
			this.Controls.Add(this.lbl_Lop);
			this.Controls.Add(this.lbl_HoVaTen);
			this.Controls.Add(this.txt_HoVaTen);
			this.Controls.Add(this.lbl_MaSinhVien);
			this.Controls.Add(this.txt_MaSinhVien);
			this.Controls.Add(this.label1);
			this.Name = "SinhVien";
			this.Text = "SinhVien";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachSinhVien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_MaSinhVien;
		private System.Windows.Forms.Label lbl_MaSinhVien;
		private System.Windows.Forms.Label lbl_HoVaTen;
		private System.Windows.Forms.TextBox txt_HoVaTen;
		private System.Windows.Forms.Label lbl_Lop;
		private System.Windows.Forms.ComboBox cb_Lop;
		private System.Windows.Forms.Label lbl_NgaySinh;
		private System.Windows.Forms.DateTimePicker date_NgaySinh;
		private System.Windows.Forms.Label lbl_DiaChi;
		private System.Windows.Forms.TextBox txt_DiaChi;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_Them;
		private System.Windows.Forms.Button btn_Sua;
		private System.Windows.Forms.Button btn_Xoa;
		private System.Windows.Forms.Label lbl_DanhSachSinhVien;
		private System.Windows.Forms.DataGridView dataGridView_DanhSachSinhVien;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaSinhVien;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
		private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
	}
}