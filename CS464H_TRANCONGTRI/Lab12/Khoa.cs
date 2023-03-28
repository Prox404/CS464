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
	public partial class Khoa : Form
	{

		Connection conn = new Connection();
		
		public Khoa()
		{
			InitializeComponent();
		}

		private void LoadData(){
			string sql = "SELECT * FROM Khoa";
			try
			{
				conn.Connect();
				DataTable dt = conn.getData(sql);
				dataGridView1.DataSource = dt;
				conn.close();
			}
			catch (System.Exception)
			{
				
				throw new System.Exception("Loi ket noi");
			}
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			string maKhoa = txt_MaKhoa.Text;
			string tenKhoa = txt_TenKhoa.Text;
			string ghiChu = rtb_GhiChu.Text;

			string sql = "INSERT INTO Khoa VALUES ('" + maKhoa + "', N'" + tenKhoa + "', N'" + ghiChu + "')";

			try
			{
				conn.Connect();
				int affected =  conn.setData(sql);
				if (affected > 0)
				{
					txt_MaKhoa.Text = "";
					txt_TenKhoa.Text = "";
					rtb_GhiChu.Text = "";
					LoadData();
					MessageBox.Show("Thêm thành công");
				}
				else
				{
					MessageBox.Show("Thêm thất bại");
				}
				conn.close();
			}
			catch (System.Exception)
			{
				
				throw  new System.Exception("Loi ket noi");
			}
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			string maKhoa = txt_MaKhoa.Text;
			string tenKhoa = txt_TenKhoa.Text;
			string ghiChu = rtb_GhiChu.Text;

			string sql = "UPDATE Khoa SET TenKhoa = N'" + tenKhoa + "', GhiChu = N'" + ghiChu + "' WHERE MaKhoa = '" + maKhoa + "'";

			try
			{
				conn.Connect();
				int affected = conn.setData(sql);
				if (affected > 0)
				{
					txt_MaKhoa.Text = "";
					txt_TenKhoa.Text = "";
					rtb_GhiChu.Text = "";
					LoadData();
					MessageBox.Show("Sửa thành công");
				}
				else
				{
					MessageBox.Show("Sửa thất bại");
				}
				conn.close();
			}
			catch (System.Exception)
			{
				
				throw new System.Exception("Loi ket noi");
			}
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			String maKhoa = txt_MaKhoa.Text;

			string sql = "DELETE FROM Khoa WHERE MaKhoa = '" + maKhoa + "'";

			try
			{
				conn.Connect();
				int affected = conn.setData(sql);
				if (affected > 0)
				{
					txt_MaKhoa.Text = "";
					txt_TenKhoa.Text = "";
					rtb_GhiChu.Text = "";
					LoadData();
					MessageBox.Show("Xóa thành công");
				}
				else
				{
					MessageBox.Show("Xóa thất bại");
				}
				conn.close();
			}
			catch (System.Exception)
			{
				
				throw new System.Exception("Loi ket noi");
			}
		}

		private void Khoa_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index >= 0)
			{
				txt_MaKhoa.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
				txt_TenKhoa.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
				rtb_GhiChu.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
			}
		}
	}
}
