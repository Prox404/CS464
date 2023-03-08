using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_QLSinhVien
{
	class SinhVienDienTu : SinhVien
	{
		private Double diemEE200;
		private Double diemEE201;
		private Double diemEE205;

		public double DiemEE200 { get => diemEE200; set => diemEE200 = value; }
		public double DiemEE201 { get => diemEE201; set => diemEE201 = value; }
		public double DiemEE205 { get => diemEE205; set => diemEE205 = value; }

		public SinhVienDienTu() : base()
		{
			diemEE200 = 0;
			diemEE201 = 0;
			diemEE205 = 0;
		}

		public SinhVienDienTu(string mssv, string hoTen, string diaChi, DateTime ngaySinh, double diemEE200, double diemEE201, double diemEE205) : base(mssv, hoTen, diaChi, ngaySinh)
		{
			this.diemEE200 = diemEE200;
			this.diemEE201 = diemEE201;
			this.diemEE205 = diemEE205;
		}

		public override void Nhap()
		{
			base.Nhap();
			while (true)
			{
				try
				{
					Console.Write("Nhap diem EE200: ");
					diemEE200 = Double.Parse(Console.ReadLine());
					Console.Write("Nhap diem EE201: ");
					diemEE201 = Double.Parse(Console.ReadLine());
					Console.Write("Nhap diem EE205: ");
					diemEE205 = Double.Parse(Console.ReadLine());
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
			return (diemEE200 + diemEE201 + diemEE205) / 3;
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
			Console.WriteLine("Diem EE200: {0}", diemEE200);
			Console.WriteLine("Diem EE201: {0}", diemEE201);
			Console.WriteLine("Diem EE205: {0}", diemEE205);
			Console.WriteLine("Diem trung binh: {0}", TinhDTB());
			Console.WriteLine("Xep loai: {0}", XepLoai());
		}
	}
}
