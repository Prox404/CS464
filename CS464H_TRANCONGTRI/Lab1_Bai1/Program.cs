using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bai1
{
	class Program
	{
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			// Console.WriteLine("Hello World!");
			Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            DateTime ngaySinh;
            Console.WriteLine("Nhập ngày sinh: ");
            do
            {
                try
                {
                    ngaySinh = DateTime.Parse(Console.ReadLine()); break;
                }
                catch
                {
                    Console.WriteLine("Nhập sai định dạng, vui lòng nhập lại!");
                }
            }
            while (true);

            int tuoi = DateTime.Today.Year - ngaySinh.Year;
            Console.Write("Họ tên là: " + hoTen);
            if (ngaySinh.Day == DateTime.Today.Day && ngaySinh.Month == DateTime.Today.Month)
            {
                Console.WriteLine("\nChúc mừng sinh nhật lần thứ {0}", tuoi);
            }
            Console.WriteLine("\nKết thúc chương trình");
			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
