namespace Lab12
{
	partial class DanhSachSinhVien
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_Xoa = new System.Windows.Forms.Button();
			this.btn_Sua = new System.Windows.Forms.Button();
			this.btn_Them = new System.Windows.Forms.Button();
			this.rtb_DiaChi = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_HoVaTen = new System.Windows.Forms.Label();
			this.txt_HoTen = new System.Windows.Forms.TextBox();
			this.lbl_MaSinhVien = new System.Windows.Forms.Label();
			this.txt_MaSinhVien = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cb_Khoa = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Lop = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(39, 313);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(716, 276);
			this.dataGridView1.TabIndex = 70;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// btn_Xoa
			// 
			this.btn_Xoa.Location = new System.Drawing.Point(254, 246);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
			this.btn_Xoa.TabIndex = 69;
			this.btn_Xoa.Text = "Xoa";
			this.btn_Xoa.UseVisualStyleBackColor = true;
			this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
			// 
			// btn_Sua
			// 
			this.btn_Sua.Location = new System.Drawing.Point(146, 247);
			this.btn_Sua.Name = "btn_Sua";
			this.btn_Sua.Size = new System.Drawing.Size(75, 23);
			this.btn_Sua.TabIndex = 68;
			this.btn_Sua.Text = "Sua";
			this.btn_Sua.UseVisualStyleBackColor = true;
			this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
			// 
			// btn_Them
			// 
			this.btn_Them.Location = new System.Drawing.Point(39, 246);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(75, 23);
			this.btn_Them.TabIndex = 67;
			this.btn_Them.Text = "Them";
			this.btn_Them.UseVisualStyleBackColor = true;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// rtb_DiaChi
			// 
			this.rtb_DiaChi.Location = new System.Drawing.Point(459, 43);
			this.rtb_DiaChi.Name = "rtb_DiaChi";
			this.rtb_DiaChi.Size = new System.Drawing.Size(296, 226);
			this.rtb_DiaChi.TabIndex = 66;
			this.rtb_DiaChi.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(367, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 65;
			this.label1.Text = "Dia Chi";
			// 
			// lbl_HoVaTen
			// 
			this.lbl_HoVaTen.AutoSize = true;
			this.lbl_HoVaTen.Location = new System.Drawing.Point(36, 84);
			this.lbl_HoVaTen.Name = "lbl_HoVaTen";
			this.lbl_HoVaTen.Size = new System.Drawing.Size(59, 13);
			this.lbl_HoVaTen.TabIndex = 64;
			this.lbl_HoVaTen.Text = "Ho Va Ten";
			// 
			// txt_HoTen
			// 
			this.txt_HoTen.Location = new System.Drawing.Point(127, 81);
			this.txt_HoTen.Name = "txt_HoTen";
			this.txt_HoTen.Size = new System.Drawing.Size(202, 20);
			this.txt_HoTen.TabIndex = 63;
			// 
			// lbl_MaSinhVien
			// 
			this.lbl_MaSinhVien.AutoSize = true;
			this.lbl_MaSinhVien.Location = new System.Drawing.Point(36, 43);
			this.lbl_MaSinhVien.Name = "lbl_MaSinhVien";
			this.lbl_MaSinhVien.Size = new System.Drawing.Size(70, 13);
			this.lbl_MaSinhVien.TabIndex = 62;
			this.lbl_MaSinhVien.Text = "Ma Sinh Vien";
			// 
			// txt_MaSinhVien
			// 
			this.txt_MaSinhVien.Location = new System.Drawing.Point(127, 43);
			this.txt_MaSinhVien.Name = "txt_MaSinhVien";
			this.txt_MaSinhVien.Size = new System.Drawing.Size(202, 20);
			this.txt_MaSinhVien.TabIndex = 61;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 72;
			this.label2.Text = "Khoa";
			// 
			// cb_Khoa
			// 
			this.cb_Khoa.FormattingEnabled = true;
			this.cb_Khoa.Location = new System.Drawing.Point(127, 119);
			this.cb_Khoa.Name = "cb_Khoa";
			this.cb_Khoa.Size = new System.Drawing.Size(202, 21);
			this.cb_Khoa.TabIndex = 73;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 75;
			this.label3.Text = "Lop";
			// 
			// txt_Lop
			// 
			this.txt_Lop.Location = new System.Drawing.Point(127, 161);
			this.txt_Lop.Name = "txt_Lop";
			this.txt_Lop.Size = new System.Drawing.Size(202, 20);
			this.txt_Lop.TabIndex = 74;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 77;
			this.label4.Text = "Ngayn Sinh";
			// 
			// date_NgaySinh
			// 
			this.date_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_NgaySinh.Location = new System.Drawing.Point(127, 206);
			this.date_NgaySinh.Name = "date_NgaySinh";
			this.date_NgaySinh.Size = new System.Drawing.Size(200, 20);
			this.date_NgaySinh.TabIndex = 78;
			// 
			// DanhSachSinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(800, 615);
			this.Controls.Add(this.date_NgaySinh);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_Lop);
			this.Controls.Add(this.cb_Khoa);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_Xoa);
			this.Controls.Add(this.btn_Sua);
			this.Controls.Add(this.btn_Them);
			this.Controls.Add(this.rtb_DiaChi);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_HoVaTen);
			this.Controls.Add(this.txt_HoTen);
			this.Controls.Add(this.lbl_MaSinhVien);
			this.Controls.Add(this.txt_MaSinhVien);
			this.Name = "DanhSachSinhVien";
			this.Text = "DanhSachNhanVien";
			this.Load += new System.EventHandler(this.DanhSachSinhVien_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_Xoa;
		private System.Windows.Forms.Button btn_Sua;
		private System.Windows.Forms.Button btn_Them;
		private System.Windows.Forms.RichTextBox rtb_DiaChi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_HoVaTen;
		private System.Windows.Forms.TextBox txt_HoTen;
		private System.Windows.Forms.Label lbl_MaSinhVien;
		private System.Windows.Forms.TextBox txt_MaSinhVien;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cb_Khoa;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_Lop;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker date_NgaySinh;
	}
}