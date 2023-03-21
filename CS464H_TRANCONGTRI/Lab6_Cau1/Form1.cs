using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Cau1
{
	public partial class Form1 : Form
	{
		private Object selected = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void btn_sort_Click(object sender, EventArgs e)
		{
			ArrayList list = new ArrayList();
			foreach (Object item in lib_A.Items)
			{
				list.Add(item);
			}
			list.Sort();
			lib_A.Items.Clear();
			foreach (Object item in list)
			{
				lib_A.Items.Add(item);
			}
		}

		private void lib_A_SelectedIndexChanged(object sender, EventArgs e)
		{
			selected = lib_A.SelectedItem;
		}

		//move one to listboxB
		private void btn_1_Click(object sender, EventArgs e)
		{
			if (selected != null)
			{
				lib_B.Items.Add(selected);
				lib_A.Items.Remove(selected);
			}
		}

		//move all to listboxB
		private void btn_2_Click(object sender, EventArgs e)
		{
			foreach (Object item in lib_A.Items)
			{
				lib_B.Items.Add(item);
			}
			lib_A.Items.Clear();
		}

		//move one to listboxA
		private void btn_3_Click(object sender, EventArgs e)
		{
			if (selected != null)
			{
				lib_A.Items.Add(selected);
				lib_B.Items.Remove(selected);
			}
		}

		private void lib_B_SelectedIndexChanged(object sender, EventArgs e)
		{
			selected = lib_B.SelectedItem;
		}

		//move all to listboxA
		private void btn_4_Click(object sender, EventArgs e)
		{
			foreach (Object item in lib_B.Items)
			{
				lib_A.Items.Add(item);
			}
			lib_B.Items.Clear();
		}
	}
}
