using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_QLSinhVien
{
	// Phương thức Nhập() void: với yêu cầu.Nhập vào(D) sinh viên điện tử, (C) sinh viên công nghệ thông tin

	class QLSinhVien
	{
		private Dictionary<string, SinhVien> dsSinhVien;

		public Dictionary<string, SinhVien> DsSinhVien { get => dsSinhVien; set => dsSinhVien = value; }

		public QLSinhVien()
		{
			dsSinhVien = new Dictionary<string, SinhVien>();
		}

		public void Nhap()
		{
			while (true)
			{
				Console.WriteLine("Nhap (D) sinh vien dien tu, (C) sinh vien cong nghe thong tin, (K) ket thuc: ");
				string chon = Console.ReadLine();
				if (chon == "K")
				{
					break;
				}
				else if (chon == "D")
				{
					SinhVienDienTu sv = new SinhVienDienTu();
					sv.Nhap();
					dsSinhVien.Add(sv.Mssv, sv);
				}
				else if (chon == "C")
				{
					SinhVienKCNTT sv = new SinhVienKCNTT();
					sv.Nhap();
					dsSinhVien.Add(sv.Mssv, sv);
				}
				else
				{
					Console.WriteLine("Nhap sai, nhap lai!");
				}
			}
		}

		public void Xuat()
		{
			foreach (var item in dsSinhVien)
			{
				if (item.Value is SinhVienDienTu)
				{
					SinhVienDienTu sv = (SinhVienDienTu)item.Value;
					sv.Xuat();
				}
				else if (item.Value is SinhVienKCNTT)
				{
					SinhVienKCNTT sv = (SinhVienKCNTT)item.Value;
					sv.Xuat();
				}
			}
		}
	}
}
