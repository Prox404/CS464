using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_QuanLyXe
{
	// Lớp trừu tượng Người
	// a. Bao gồm các trường: Số chứng minh (long), Họ tên (string), Địa chỉ (string), Điện thoại(string)
	// b. Phương thức trường tượng Nhập() void, và trường tượng Xuất() void.

	class Nguoi
	{
		private long soChungMinh;
		private string hoTen;
		private string diaChi;
		private string dienThoai;

		public long SoChungMinh { get => soChungMinh; set => soChungMinh = value; }
		public string HoTen { get => hoTen; set => hoTen = value; }
		public string DiaChi { get => diaChi; set => diaChi = value; }
		public string DienThoai { get => dienThoai; set => dienThoai = value; }

		public Nguoi()
		{
			soChungMinh = 0;
			hoTen = "";
			diaChi = "";
			dienThoai = "";
		}

		public Nguoi(long soChungMinh, string hoTen, string diaChi, string dienThoai)
		{
			this.soChungMinh = soChungMinh;
			this.hoTen = hoTen;
			this.diaChi = diaChi;
			this.dienThoai = dienThoai;
		}

		public virtual void Nhap()
		{
			while (true)
			{
				try
				{
					Console.WriteLine("Nhap so chung minh: ");
					soChungMinh = long.Parse(Console.ReadLine());
					break;
				}
				catch (Exception)
				{
					Console.WriteLine("Nhap sai, nhap lai!");
				}
			}
			Console.WriteLine("Nhap ho ten: ");
			hoTen = Console.ReadLine();
			Console.WriteLine("Nhap dia chi: ");
			diaChi = Console.ReadLine();
			Console.WriteLine("Nhap dien thoai: ");
			dienThoai = Console.ReadLine();
		}

		public virtual void Xuat()
		{
			Console.WriteLine("So chung minh: " + soChungMinh);
			Console.WriteLine("Ho ten: " + hoTen);
			Console.WriteLine("Dia chi: " + diaChi);
			Console.WriteLine("Dien thoai: " + dienThoai);
		}
	}
}
