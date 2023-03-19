using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Cau2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_Tim_Click(object sender, EventArgs e)
		{
			try
			{
				int thu = int.Parse(txt_Thu.Text);
				string hello = "";
				switch (thu)
				{
					case 2:
						hello = "Chao thu hai";
						break;
					case 3:
						hello = "Chao thu ba";
						break;
					case 4:
						hello = "Chao thu tu";
						break;
					case 5:
						hello = "Chao thu nam";
						break;
					case 6:
						hello = "Chao thu sau";
						break;
					case 7:
						hello = "Chao thu bay";
						break;
					case 8:
						hello = "Chao chu nhat";
						break;
					default:
						hello = "Nhap so tu 2-8 !";
						break;
				}

				MessageBox.Show(hello);
			}
			catch
			{
				MessageBox.Show("Nhap sai !");
			}
		}
	}
}
