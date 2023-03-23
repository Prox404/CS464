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


        //move selected item to listboxB
        private void btn_1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lib_A.SelectedItems.Count; i++)
                {
                    lib_B.Items.Add(lib_A.SelectedItems[i]);
                }
                for (int i = lib_A.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lib_A.Items.Remove(lib_A.SelectedItems[i]);
                }
            }
            catch
            {


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

        //move selected item to listboxA
        private void btn_3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lib_B.SelectedItems.Count; i++)
                {
                    lib_A.Items.Add(lib_B.SelectedItems[i]);
                }
                for (int i = lib_B.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lib_B.Items.Remove(lib_B.SelectedItems[i]);
                }
            }
            catch
            {

            }
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
