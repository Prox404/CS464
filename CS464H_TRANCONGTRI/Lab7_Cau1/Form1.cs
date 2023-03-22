using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Cau1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(Application.OpenForms["SinhVien"] == null)
			{
				SinhVien sv = new SinhVien();
				sv.MdiParent = this;
				sv.Show();
			}
			else
			{
				Application.OpenForms["SinhVien"].Activate();
			}
		}
	}
}
