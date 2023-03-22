using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab5_Bai5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void lbl_TongCacSoMangA_Click(object sender, EventArgs e)
		{

		}

		private int tongCacSoChan(int[] mangA)
		{
			int tong = 0;
			for (int i = 0; i < mangA.Length; i++)
			{
				if (mangA[i] % 2 == 0)
				{
					tong += mangA[i];
				}
			}
			return tong;
		}

		private int tongCacSoLe(int[] mangA)
		{
			int tong = 0;
			for (int i = 0; i < mangA.Length; i++)
			{
				if (mangA[i] % 2 != 0)
				{
					tong += mangA[i];
				}
			}
			return tong;
		}

		private int tongCacSoMangA(int[] mangA)
		{
			int tong = 0;
			for (int i = 0; i < mangA.Length; i++)
			{
				tong += mangA[i];
			}
			return tong;
		}

		private void btn_Tinh_Click(object sender, EventArgs e)
		{
			string mangA = txt_MangA.Text.Trim();
			string[] parts = mangA.Split(' ');
			int[] mangCacSoA = new int[parts.Length];
			string pattern = @"\d+";
			Regex rgx = new Regex(pattern);

			for (int i = 0; i < parts.Length; i++)
			{
				try {
					if (rgx.IsMatch(parts[i]))
					{
						mangCacSoA[i] = int.Parse(parts[i]);
					}
				}
				catch
				{
					MessageBox.Show("Nhap chua dung dinh dang !");
					return;
				}
			}

			txt_TongCacSoChan.Text = tongCacSoChan(mangCacSoA).ToString();
			txt_TongCacSoLe.Text = tongCacSoLe(mangCacSoA).ToString();
			txt_TongCacSoMangA.Text = tongCacSoMangA(mangCacSoA).ToString();
		}

		private void btn_LamMoi_Click(object sender, EventArgs e)
		{
			txt_MangA.Text = "";
			txt_TongCacSoChan.Text = "";
			txt_TongCacSoLe.Text = "";
			txt_TongCacSoMangA.Text = "";
		}

		private void btn_Thoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
