using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_QLSinhVien
{
	class Program
	{
		// Trong hàm Main tạo một mảng có tên dsSinhVien để nhập thông tin với số lượng sinh viên nhập từ bàn phím
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			// Console.WriteLine("Hello World!");

			// Dictionary<string, SinhVienKCNTT> dsSinhVien = new Dictionary<string, SinhVienKCNTT>();
			
			// Console.WriteLine("Nhap so luong sinh vien: ");
			// int n = int.Parse(Console.ReadLine());
			// for (int i = 0; i < n; i++)
			// {
			// 	SinhVienKCNTT sv = new SinhVienKCNTT();
			// 	sv.Nhap();
			// 	dsSinhVien.Add(sv.Mssv, sv);
			// }

			// Console.WriteLine("Danh sach sinh vien: ");
			// foreach (var item in dsSinhVien)
			// {
			// 	item.Value.Xuat();
			// }

			// // Đếm số lượng sinh viên giỏi, khá, tb hay yếu

			// int soLuongSVGioi = 0;
			// int soLuongSVKha = 0;
			// int soLuongSVTB = 0;
			// int soLuongSVYeu = 0;

			// foreach (var item in dsSinhVien)
			// {
			// 	if (item.Value.XepLoai() == "Gioi")
			// 	{
			// 		soLuongSVGioi++;
			// 	}else if (item.Value.XepLoai() == "Kha")
			// 	{
			// 		soLuongSVKha++;
			// 	}else if (item.Value.XepLoai() == "TB")
			// 	{
			// 		soLuongSVTB++;
			// 	}else if (item.Value.XepLoai() == "Yeu")
			// 	{
			// 		soLuongSVYeu++;
			// 	}
			// }

			// Console.WriteLine("So luong sinh vien gioi: " + soLuongSVGioi);
			// Console.WriteLine("So luong sinh vien kha: " + soLuongSVKha);
			// Console.WriteLine("So luong sinh vien trung binh: " + soLuongSVTB);
			// Console.WriteLine("So luong sinh vien yeu: " + soLuongSVYeu);

			QLSinhVien qlsv = new QLSinhVien();
			qlsv.Nhap();
			qlsv.Xuat();

			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
