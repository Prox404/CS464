using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_GiaiPTBac2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void txt_HeSoA_TextChanged(object sender, EventArgs e)
		{

		}

		private void GiaiPTBac2(float a, float b, float c)
		{
			float delta = b * b - 4 * a * c;
			if (delta < 0)
			{
				txt_KetQua.Text = "Phuong trinh vo nghiem";
			}
			else if (delta == 0)
			{
				txt_KetQua.Text = "x1 = x2 = " + (-b / (2 * a));
			}
			else
			{
				txt_KetQua.Text = "x1 = " + ((-b + Math.Sqrt(delta)) / (2 * a)) + " va x2 = " + ((-b - Math.Sqrt(delta)) / (2 * a));
			}
		}

		private void btn_Giai_Click(object sender, EventArgs e)
		{
			float a;
			float b;
			float c;
			a = float.Parse(txt_HeSoA.Text);
			b = float.Parse(txt_HeSoB.Text);
			c = float.Parse(txt_HeSoC.Text);
			GiaiPTBac2(a, b, c);
		}

		private void btn_Thoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
