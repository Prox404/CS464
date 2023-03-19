namespace Lab5_Bai5
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
			this.txt_HeSoA = new System.Windows.Forms.Label();
			this.txt_MangA = new System.Windows.Forms.TextBox();
			this.lbl_TongCacSoLe = new System.Windows.Forms.Label();
			this.txt_TongCacSoLe = new System.Windows.Forms.TextBox();
			this.lbl_TongCacSoChan = new System.Windows.Forms.Label();
			this.txt_TongCacSoChan = new System.Windows.Forms.TextBox();
			this.lbl_TongCacSoMangA = new System.Windows.Forms.Label();
			this.txt_TongCacSoMangA = new System.Windows.Forms.TextBox();
			this.btn_Tinh = new System.Windows.Forms.Button();
			this.btn_LamMoi = new System.Windows.Forms.Button();
			this.btn_Thoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_HeSoA
			// 
			this.txt_HeSoA.AutoSize = true;
			this.txt_HeSoA.Location = new System.Drawing.Point(79, 24);
			this.txt_HeSoA.Name = "txt_HeSoA";
			this.txt_HeSoA.Size = new System.Drawing.Size(50, 13);
			this.txt_HeSoA.TabIndex = 11;
			this.txt_HeSoA.Text = "Mảng A: ";
			this.txt_HeSoA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_MangA
			// 
			this.txt_MangA.Location = new System.Drawing.Point(161, 24);
			this.txt_MangA.Name = "txt_MangA";
			this.txt_MangA.Size = new System.Drawing.Size(187, 20);
			this.txt_MangA.TabIndex = 10;
			// 
			// lbl_TongCacSoLe
			// 
			this.lbl_TongCacSoLe.AutoSize = true;
			this.lbl_TongCacSoLe.Location = new System.Drawing.Point(45, 61);
			this.lbl_TongCacSoLe.Name = "lbl_TongCacSoLe";
			this.lbl_TongCacSoLe.Size = new System.Drawing.Size(84, 13);
			this.lbl_TongCacSoLe.TabIndex = 13;
			this.lbl_TongCacSoLe.Text = "Tong cac so le: ";
			this.lbl_TongCacSoLe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_TongCacSoLe
			// 
			this.txt_TongCacSoLe.Location = new System.Drawing.Point(161, 61);
			this.txt_TongCacSoLe.Name = "txt_TongCacSoLe";
			this.txt_TongCacSoLe.ReadOnly = true;
			this.txt_TongCacSoLe.Size = new System.Drawing.Size(187, 20);
			this.txt_TongCacSoLe.TabIndex = 12;
			// 
			// lbl_TongCacSoChan
			// 
			this.lbl_TongCacSoChan.AutoSize = true;
			this.lbl_TongCacSoChan.Location = new System.Drawing.Point(29, 98);
			this.lbl_TongCacSoChan.Name = "lbl_TongCacSoChan";
			this.lbl_TongCacSoChan.Size = new System.Drawing.Size(100, 13);
			this.lbl_TongCacSoChan.TabIndex = 15;
			this.lbl_TongCacSoChan.Text = "Tong cac so chan: ";
			this.lbl_TongCacSoChan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_TongCacSoChan
			// 
			this.txt_TongCacSoChan.Location = new System.Drawing.Point(161, 98);
			this.txt_TongCacSoChan.Name = "txt_TongCacSoChan";
			this.txt_TongCacSoChan.ReadOnly = true;
			this.txt_TongCacSoChan.Size = new System.Drawing.Size(187, 20);
			this.txt_TongCacSoChan.TabIndex = 14;
			// 
			// lbl_TongCacSoMangA
			// 
			this.lbl_TongCacSoMangA.AutoSize = true;
			this.lbl_TongCacSoMangA.Location = new System.Drawing.Point(17, 141);
			this.lbl_TongCacSoMangA.Name = "lbl_TongCacSoMangA";
			this.lbl_TongCacSoMangA.Size = new System.Drawing.Size(112, 13);
			this.lbl_TongCacSoMangA.TabIndex = 17;
			this.lbl_TongCacSoMangA.Text = "Tong cac so mang A: ";
			this.lbl_TongCacSoMangA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_TongCacSoMangA.Click += new System.EventHandler(this.lbl_TongCacSoMangA_Click);
			// 
			// txt_TongCacSoMangA
			// 
			this.txt_TongCacSoMangA.Location = new System.Drawing.Point(161, 138);
			this.txt_TongCacSoMangA.Name = "txt_TongCacSoMangA";
			this.txt_TongCacSoMangA.ReadOnly = true;
			this.txt_TongCacSoMangA.Size = new System.Drawing.Size(187, 20);
			this.txt_TongCacSoMangA.TabIndex = 16;
			// 
			// btn_Tinh
			// 
			this.btn_Tinh.Location = new System.Drawing.Point(52, 200);
			this.btn_Tinh.Name = "btn_Tinh";
			this.btn_Tinh.Size = new System.Drawing.Size(75, 23);
			this.btn_Tinh.TabIndex = 18;
			this.btn_Tinh.Text = "Tinh toan";
			this.btn_Tinh.UseVisualStyleBackColor = true;
			this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
			// 
			// btn_LamMoi
			// 
			this.btn_LamMoi.Location = new System.Drawing.Point(162, 200);
			this.btn_LamMoi.Name = "btn_LamMoi";
			this.btn_LamMoi.Size = new System.Drawing.Size(75, 23);
			this.btn_LamMoi.TabIndex = 19;
			this.btn_LamMoi.Text = "Lam moi";
			this.btn_LamMoi.UseVisualStyleBackColor = true;
			this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
			// 
			// btn_Thoat
			// 
			this.btn_Thoat.Location = new System.Drawing.Point(273, 200);
			this.btn_Thoat.Name = "btn_Thoat";
			this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
			this.btn_Thoat.TabIndex = 20;
			this.btn_Thoat.Text = "Thoat";
			this.btn_Thoat.UseVisualStyleBackColor = true;
			this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 263);
			this.Controls.Add(this.btn_Thoat);
			this.Controls.Add(this.btn_LamMoi);
			this.Controls.Add(this.btn_Tinh);
			this.Controls.Add(this.lbl_TongCacSoMangA);
			this.Controls.Add(this.txt_TongCacSoMangA);
			this.Controls.Add(this.lbl_TongCacSoChan);
			this.Controls.Add(this.txt_TongCacSoChan);
			this.Controls.Add(this.lbl_TongCacSoLe);
			this.Controls.Add(this.txt_TongCacSoLe);
			this.Controls.Add(this.txt_HeSoA);
			this.Controls.Add(this.txt_MangA);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label txt_HeSoA;
		private System.Windows.Forms.TextBox txt_MangA;
		private System.Windows.Forms.Label lbl_TongCacSoLe;
		private System.Windows.Forms.TextBox txt_TongCacSoLe;
		private System.Windows.Forms.Label lbl_TongCacSoChan;
		private System.Windows.Forms.TextBox txt_TongCacSoChan;
		private System.Windows.Forms.Label lbl_TongCacSoMangA;
		private System.Windows.Forms.TextBox txt_TongCacSoMangA;
		private System.Windows.Forms.Button btn_Tinh;
		private System.Windows.Forms.Button btn_LamMoi;
		private System.Windows.Forms.Button btn_Thoat;
	}
}

