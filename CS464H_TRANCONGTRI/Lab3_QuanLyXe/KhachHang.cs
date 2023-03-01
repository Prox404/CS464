using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_QuanLyXe
{

	// Lớp Khách Hàng: thừa kế từ lớp trừu tượng Người
	// a. Bao gồm các trường của lớp Người, bổ sung thêm trường Mã khách hàng (string) và Hạng bằng lai 
	// (DateTime)
	// b. Phương thức Nhập() và Xuất();


	class KhachHang : Nguoi
	{
		private string maKhachHang;
		private DateTime hangBangLai;

		public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
		public DateTime HangBangLai { get => hangBangLai; set => hangBangLai = value; }

		public KhachHang()
		{
			maKhachHang = "";
			hangBangLai = DateTime.Now;
		}

		public KhachHang(long soChungMinh, string hoTen, string diaChi, string dienThoai, string maKhachHang, DateTime hangBangLai) : base(soChungMinh, hoTen, diaChi, dienThoai)
		{
			this.maKhachHang = maKhachHang;
			this.hangBangLai = hangBangLai;
		}

		public override void Nhap()
		{
			base.Nhap();
			Console.WriteLine("Nhap ma khach hang: ");
			maKhachHang = Console.ReadLine();
			while (true)
			{
				try
				{
					Console.WriteLine("Nhap hang bang lai: ");
					hangBangLai = DateTime.Parse(Console.ReadLine());
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
			Console.WriteLine("Ma khach hang: " + maKhachHang);
			Console.WriteLine("Hang bang lai: " + hangBangLai);
		}
	}
}
