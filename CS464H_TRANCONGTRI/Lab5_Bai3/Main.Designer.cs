namespace Lab5_Bai3
{
	partial class Main
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
			this.lbl_TenTaiKhoan = new System.Windows.Forms.Label();
			this.txt_TenTaiKhoan = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_MatKhau = new System.Windows.Forms.TextBox();
			this.btn_DangNhap = new System.Windows.Forms.Button();
			this.btn_NhapLai = new System.Windows.Forms.Button();
			this.btn_Thoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_TenTaiKhoan
			// 
			this.lbl_TenTaiKhoan.AutoSize = true;
			this.lbl_TenTaiKhoan.Location = new System.Drawing.Point(30, 62);
			this.lbl_TenTaiKhoan.Name = "lbl_TenTaiKhoan";
			this.lbl_TenTaiKhoan.Size = new System.Drawing.Size(76, 13);
			this.lbl_TenTaiKhoan.TabIndex = 7;
			this.lbl_TenTaiKhoan.Text = "Tên tài khoản:";
			this.lbl_TenTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_TenTaiKhoan
			// 
			this.txt_TenTaiKhoan.Location = new System.Drawing.Point(112, 62);
			this.txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
			this.txt_TenTaiKhoan.Size = new System.Drawing.Size(187, 20);
			this.txt_TenTaiKhoan.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Mật khẩu:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_MatKhau
			// 
			this.txt_MatKhau.Location = new System.Drawing.Point(112, 105);
			this.txt_MatKhau.Name = "txt_MatKhau";
			this.txt_MatKhau.Size = new System.Drawing.Size(187, 20);
			this.txt_MatKhau.TabIndex = 8;
			// 
			// btn_DangNhap
			// 
			this.btn_DangNhap.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DangNhap.ForeColor = System.Drawing.Color.Blue;
			this.btn_DangNhap.Location = new System.Drawing.Point(194, 193);
			this.btn_DangNhap.Name = "btn_DangNhap";
			this.btn_DangNhap.Size = new System.Drawing.Size(89, 23);
			this.btn_DangNhap.TabIndex = 10;
			this.btn_DangNhap.Text = "Đăng nhập";
			this.btn_DangNhap.UseVisualStyleBackColor = false;
			this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
			// 
			// btn_NhapLai
			// 
			this.btn_NhapLai.Location = new System.Drawing.Point(224, 140);
			this.btn_NhapLai.Name = "btn_NhapLai";
			this.btn_NhapLai.Size = new System.Drawing.Size(75, 23);
			this.btn_NhapLai.TabIndex = 11;
			this.btn_NhapLai.Text = "Nhập lại";
			this.btn_NhapLai.UseVisualStyleBackColor = true;
			this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
			// 
			// btn_Thoat
			// 
			this.btn_Thoat.Location = new System.Drawing.Point(289, 193);
			this.btn_Thoat.Name = "btn_Thoat";
			this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
			this.btn_Thoat.TabIndex = 12;
			this.btn_Thoat.Text = "Thoát";
			this.btn_Thoat.UseVisualStyleBackColor = true;
			this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 228);
			this.Controls.Add(this.btn_Thoat);
			this.Controls.Add(this.btn_NhapLai);
			this.Controls.Add(this.btn_DangNhap);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_MatKhau);
			this.Controls.Add(this.lbl_TenTaiKhoan);
			this.Controls.Add(this.txt_TenTaiKhoan);
			this.Name = "Main";
			this.Text = "Đăng Nhập";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_TenTaiKhoan;
		private System.Windows.Forms.TextBox txt_TenTaiKhoan;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_MatKhau;
		private System.Windows.Forms.Button btn_DangNhap;
		private System.Windows.Forms.Button btn_NhapLai;
		private System.Windows.Forms.Button btn_Thoat;
	}
}

