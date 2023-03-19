using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Bai3
{
	public partial class Main : Form
	{
		string tenTaiKhoan = "";
		string matKhau = "";
		int soLanNhap = 0;

		public Main()
		{
			InitializeComponent();
		}

		private void btn_NhapLai_Click(object sender, EventArgs e)
		{
			txt_TenTaiKhoan.Text = "";
			txt_MatKhau.Text = "";
		}

		private void btn_DangNhap_Click(object sender, EventArgs e)
		{
			
			try
			{
				tenTaiKhoan = txt_TenTaiKhoan.Text.ToLower();
				matKhau = txt_MatKhau.Text;
			}
			catch
			{
				MessageBox.Show("Nhập sai định dạng !");
			}
			
			if(tenTaiKhoan == "admin" && matKhau == "123456")
			{
				this.Hide();
				QLSinhVien qLSinhVien = new QLSinhVien();
				qLSinhVien.Closed += (s, args) => this.Close();
				qLSinhVien.Show();
				
			}
			else
			{
				soLanNhap += 1;
				if(soLanNhap >= 3)
				{
					string message = "Bạn đã nhập sai quá 3 lần !";
					string title = "Cảnh báo";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
					if(result == DialogResult.OK)
					{
						this.Close();
					}
				}
				MessageBox.Show("Bạn đã nhập sai " + soLanNhap.ToString() + " lần !");
			}
		}

		private void btn_Thoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
