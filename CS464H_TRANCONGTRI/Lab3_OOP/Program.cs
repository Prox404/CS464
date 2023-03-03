using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{

	// Tạo Lớp Xe:
		//  Bao gồm các trường: Biển số
		// (string), Tên xe (string), Trọng
		// tải (int), Ngày đăng kiểm
		// (DateTime), Tiêu chuẩn bằng
		// (int)
		//  Phương thức Nhập() void, và
		// Xuất() void 

	class Xe{
		private string bienSo;
		private string tenXe;
		private int trongTai;
		private DateTime ngayDangKiem;
		private int tieuChuanBang;

		public string BienSo { get => bienSo; set => bienSo = value; }
		public string TenXe { get => tenXe; set => tenXe = value; }
		public int TrongTai { get => trongTai; set => trongTai = value; }
		public DateTime NgayDangKiem { get => ngayDangKiem; set => ngayDangKiem = value; }
		public int TieuChuanBang { get => tieuChuanBang; set => tieuChuanBang = value; }

		public Xe()
		{
			bienSo = "";
			tenXe = "";
			trongTai = 0;
			ngayDangKiem = DateTime.Now;
			tieuChuanBang = 0;
		}

		public Xe(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuanBang)
		{
			this.bienSo = bienSo;
			this.tenXe = tenXe;
			this.trongTai = trongTai;
			this.ngayDangKiem = ngayDangKiem;
			this.tieuChuanBang = tieuChuanBang;
		}

		public virtual void Nhap()
		{
			while (true)
			{
				try
				{
					Console.WriteLine("Nhap bien so: ");
					bienSo = Console.ReadLine();
					Console.WriteLine("Nhap ten xe: ");
					tenXe = Console.ReadLine();
					Console.WriteLine("Nhap trong tai: ");
					trongTai = int.Parse(Console.ReadLine());
					Console.WriteLine("Nhap ngay dang kiem: ");
					ngayDangKiem = DateTime.Parse(Console.ReadLine());
					Console.WriteLine("Nhap tieu chuan bang: ");
					tieuChuanBang = int.Parse(Console.ReadLine());
					break;
				}
				catch (Exception e)
				{
					Console.WriteLine("Loi: " + e.Message);
				}
			}
		}

		public virtual void Xuat()
		{
			Console.WriteLine("Bien so: " + bienSo);
			Console.WriteLine("Ten xe: " + tenXe);
			Console.WriteLine("Trong tai: " + trongTai);
			Console.WriteLine("Ngay dang kiem: " + ngayDangKiem);
			Console.WriteLine("Tieu chuan bang: " + tieuChuanBang);
		}
	}

	class Program
	{

		
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			// Console.WriteLine("Hello World!");
			Xe xe = new Xe();
			xe.Nhap();
			xe.Xuat();
			
			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
