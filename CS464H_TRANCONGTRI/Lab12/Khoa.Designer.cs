namespace Lab12
{
	partial class Khoa
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
			this.lbl_HoVaTen = new System.Windows.Forms.Label();
			this.txt_TenKhoa = new System.Windows.Forms.TextBox();
			this.lbl_MaSinhVien = new System.Windows.Forms.Label();
			this.txt_MaKhoa = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rtb_GhiChu = new System.Windows.Forms.RichTextBox();
			this.btn_Them = new System.Windows.Forms.Button();
			this.btn_Sua = new System.Windows.Forms.Button();
			this.btn_Xoa = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_HoVaTen
			// 
			this.lbl_HoVaTen.AutoSize = true;
			this.lbl_HoVaTen.Location = new System.Drawing.Point(36, 75);
			this.lbl_HoVaTen.Name = "lbl_HoVaTen";
			this.lbl_HoVaTen.Size = new System.Drawing.Size(54, 13);
			this.lbl_HoVaTen.TabIndex = 54;
			this.lbl_HoVaTen.Text = "Ten Khoa";
			// 
			// txt_TenKhoa
			// 
			this.txt_TenKhoa.Location = new System.Drawing.Point(127, 72);
			this.txt_TenKhoa.Name = "txt_TenKhoa";
			this.txt_TenKhoa.Size = new System.Drawing.Size(202, 20);
			this.txt_TenKhoa.TabIndex = 53;
			// 
			// lbl_MaSinhVien
			// 
			this.lbl_MaSinhVien.AutoSize = true;
			this.lbl_MaSinhVien.Location = new System.Drawing.Point(36, 34);
			this.lbl_MaSinhVien.Name = "lbl_MaSinhVien";
			this.lbl_MaSinhVien.Size = new System.Drawing.Size(50, 13);
			this.lbl_MaSinhVien.TabIndex = 52;
			this.lbl_MaSinhVien.Text = "Ma Khoa";
			// 
			// txt_MaKhoa
			// 
			this.txt_MaKhoa.Location = new System.Drawing.Point(127, 34);
			this.txt_MaKhoa.Name = "txt_MaKhoa";
			this.txt_MaKhoa.Size = new System.Drawing.Size(202, 20);
			this.txt_MaKhoa.TabIndex = 51;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(367, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 55;
			this.label1.Text = "Ghi chu";
			// 
			// rtb_GhiChu
			// 
			this.rtb_GhiChu.Location = new System.Drawing.Point(459, 34);
			this.rtb_GhiChu.Name = "rtb_GhiChu";
			this.rtb_GhiChu.Size = new System.Drawing.Size(296, 139);
			this.rtb_GhiChu.TabIndex = 56;
			this.rtb_GhiChu.Text = "";
			// 
			// btn_Them
			// 
			this.btn_Them.Location = new System.Drawing.Point(39, 149);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(75, 23);
			this.btn_Them.TabIndex = 57;
			this.btn_Them.Text = "Them";
			this.btn_Them.UseVisualStyleBackColor = true;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// btn_Sua
			// 
			this.btn_Sua.Location = new System.Drawing.Point(146, 150);
			this.btn_Sua.Name = "btn_Sua";
			this.btn_Sua.Size = new System.Drawing.Size(75, 23);
			this.btn_Sua.TabIndex = 58;
			this.btn_Sua.Text = "Sua";
			this.btn_Sua.UseVisualStyleBackColor = true;
			this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
			// 
			// btn_Xoa
			// 
			this.btn_Xoa.Location = new System.Drawing.Point(254, 149);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
			this.btn_Xoa.TabIndex = 59;
			this.btn_Xoa.Text = "Xoa";
			this.btn_Xoa.UseVisualStyleBackColor = true;
			this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(39, 204);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(716, 276);
			this.dataGridView1.TabIndex = 60;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Khoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 515);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_Xoa);
			this.Controls.Add(this.btn_Sua);
			this.Controls.Add(this.btn_Them);
			this.Controls.Add(this.rtb_GhiChu);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_HoVaTen);
			this.Controls.Add(this.txt_TenKhoa);
			this.Controls.Add(this.lbl_MaSinhVien);
			this.Controls.Add(this.txt_MaKhoa);
			this.Name = "Khoa";
			this.Text = "Khoa";
			this.Load += new System.EventHandler(this.Khoa_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_HoVaTen;
		private System.Windows.Forms.TextBox txt_TenKhoa;
		private System.Windows.Forms.Label lbl_MaSinhVien;
		private System.Windows.Forms.TextBox txt_MaKhoa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox rtb_GhiChu;
		private System.Windows.Forms.Button btn_Them;
		private System.Windows.Forms.Button btn_Sua;
		private System.Windows.Forms.Button btn_Xoa;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}