using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_QuanLyXe
{

	// a. Bao gồm các trường của lớp Xe, bổ sung thêm trường Số tấn(double)
	// b. Bao gồm phương thức của lớp Xe. Bổ sung vào phương thức Nhập() và Xuất() số chỗ ngồi

	class XeChoHang : Xe
	{
		private double soTan;

		public double SoTan { get => soTan; set => soTan = value; }

		public XeChoHang()
		{
			soTan = 0;
		}

		public XeChoHang(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuanBang, double soTan) : base(bienSo, tenXe, trongTai, ngayDangKiem, tieuChuanBang)
		{
			this.soTan = soTan;
		}

		public override void Nhap()
		{
			base.Nhap();
			while (true)
			{
				try
				{
					Console.WriteLine("Nhap so tan: ");
					soTan = double.Parse(Console.ReadLine());
					break;
				}
				catch (Exception)
				{
					Console.WriteLine("Nhap sai, nhap lai!");
				}
			}
		}

		public override void Xuat()
		{
			base.Xuat();
			Console.WriteLine("So tan: " + soTan);
		}
	}
}
