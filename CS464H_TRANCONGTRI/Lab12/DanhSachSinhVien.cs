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
	public partial class DanhSachSinhVien : Form
	{

		Connection conn = new Connection();

		public DanhSachSinhVien()
		{
			InitializeComponent();
		}

		private void LoadData(){
			string sql = "SELECT * FROM SinhVien";
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

		private void DanhSachSinhVien_Load(object sender, EventArgs e)
		{
			try
			{
				conn.Connect();
				DataTable dt = conn.getData("SELECT * FROM Khoa");
				cb_Khoa.DataSource = dt;
				cb_Khoa.DisplayMember = "TenKhoa";
				cb_Khoa.ValueMember = "TenKhoa";
				conn.close();
			}
			catch (System.Exception)
			{
				throw new System.Exception("Loi ket noi");
			}
			LoadData();
			
			
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			string maSV = txt_MaSinhVien.Text;
			string hoTen = txt_HoTen.Text;
			string diaChi = rtb_DiaChi.Text;
			string ngaySinh = date_NgaySinh.Value.ToString("yyyy-MM-dd");
			string khoa = cb_Khoa.Text;
			string lop = txt_Lop.Text;

			string sql = "INSERT INTO SinhVien (MaSV, HoTen, DiaChi, NgaySinh, TenKhoa, Lop) VALUES ('" + maSV + "', N'" + hoTen + "', N'" + diaChi + "', '" + ngaySinh + "', N'" + khoa + "', N'" + lop + "')";
		
			try
			{
				conn.Connect();
				int affected =  conn.setData(sql);
				if (affected > 0)
				{
					txt_MaSinhVien.Text = "";
					txt_HoTen.Text = "";
					rtb_DiaChi.Text = "";
					date_NgaySinh.Value = DateTime.Now;
					txt_Lop.Text = "";
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
				throw new System.Exception("Loi ket noi");
			}
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			string maSV = txt_MaSinhVien.Text;
			string hoTen = txt_HoTen.Text;
			string diaChi = rtb_DiaChi.Text;
			string ngaySinh = date_NgaySinh.Value.ToString("yyyy-MM-dd");
			string khoa = cb_Khoa.Text;
			string lop = txt_Lop.Text;

			string sql = "UPDATE SinhVien SET HoTen = N'" + hoTen + "', DiaChi = N'" + diaChi + "', NgaySinh = '" + ngaySinh + "', TenKhoa = N'" + khoa + "', Lop = N'" + lop + "' WHERE MaSV = '" + maSV + "'";
		
			try
			{
				conn.Connect();
				int affected =  conn.setData(sql);
				if (affected > 0)
				{
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
			string maSV = txt_MaSinhVien.Text;
			string sql = "DELETE FROM SinhVien WHERE MaSV = '" + maSV + "'";
			try
			{
				conn.Connect();
				int affected =  conn.setData(sql);
				if (affected > 0)
				{
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index >= 0)
			{
				txt_MaSinhVien.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
				txt_HoTen.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
				rtb_DiaChi.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
				date_NgaySinh.Value = DateTime.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString());
				cb_Khoa.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
				txt_Lop.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
			}
		}

		private void cb_Khoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			string Khoa = cb_Khoa.Text;

			string sql = "SELECT * FROM SinhVien WHERE TenKhoa = N'" + Khoa + "'";

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
	}
}
