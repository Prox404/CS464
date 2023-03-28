using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["DanhSachSinhVien"] == null)
			{
				DanhSachSinhVien sv = new DanhSachSinhVien();
				sv.MdiParent = this;
				sv.Show();
			}
			else
			{
				Application.OpenForms["DanhSachSinhVien"].Activate();
			}
		}

		private void hồSơKhoaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["Khoa"] == null)
			{
				Khoa k = new Khoa();
				k.MdiParent = this;
				k.Show();
			}
			else
			{
				Application.OpenForms["Khoa"].Activate();
			}
		}
	}
}
