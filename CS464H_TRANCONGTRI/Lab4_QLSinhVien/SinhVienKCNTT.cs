using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_QLSinhVien
{
	//DiemCS414, DiemIS311, DiemCS311.

	class SinhVienKCNTT : SinhVien
	{
		private Double diemCS414;
		private Double diemIS311;
		private Double diemCS311;

		public double DiemCS414 { get => diemCS414; set => diemCS414 = value; }
		public double DiemIS311 { get => diemIS311; set => diemIS311 = value; }
		public double DiemCS311 { get => diemCS311; set => diemCS311 = value; }

		public SinhVienKCNTT() : base()
		{
			diemCS414 = 0;
			diemIS311 = 0;
			diemCS311 = 0;
		}

		public SinhVienKCNTT(string mssv, string hoTen, string diaChi, DateTime ngaySinh, double diemCS414, double diemIS311, double diemCS311) : base(mssv, hoTen, diaChi, ngaySinh)
		{
			this.diemCS414 = diemCS414;
			this.diemIS311 = diemIS311;
			this.diemCS311 = diemCS311;
		}

		public override void Nhap()
		{
			base.Nhap();
			while (true)
			{
				try
				{
					Console.Write("Nhap diem CS414: ");
					diemCS414 = Double.Parse(Console.ReadLine());
					Console.Write("Nhap diem IS311: ");
					diemIS311 = Double.Parse(Console.ReadLine());
					Console.Write("Nhap diem CS311: ");
					diemCS311 = Double.Parse(Console.ReadLine());
					break;
				}
				catch (Exception e)
				{
					Console.WriteLine("Diem khong hop le, vui long nhap lai!");
				}
			}
		}

		

		public override double TinhDTB()
		{
			return (diemCS414 + diemIS311 + diemCS311) / 3;
		}

		// Trong lớp SinhVienKCTT tạo phương thức TinhXepLoai() dựa vào điểm trung bình
		// a. Điểm TB >=8 thì xếp loại Giỏi
		// b. Điểm TB >=6.5 thì xếp loại Khá
		// c. Điểm TB >=5 thì xếp loại TB
		// d. Còn lại thì xếp loại Yếu
		public override string XepLoai()
		{
			Double dtb = TinhDTB();

			if (dtb  >= 8)
			{
				return "Gioi";
			}else if (dtb >= 6.5)
			{
				return "Kha";
			}else if (dtb >= 5)
			{
				return "TB";
			}
			else
			{
				return "Yeu";
			}
		}

		public override void Xuat()
		{
			base.Xuat();
			Console.WriteLine("Diem CS414: {0}", diemCS414);
			Console.WriteLine("Diem IS311: {0}", diemIS311);
			Console.WriteLine("Diem CS311: {0}", diemCS311);
			Console.WriteLine("Diem trung binh: {0}", TinhDTB());
			Console.WriteLine("Xep loai: {0}", XepLoai());
		}
	}
}
