using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_NgayTrongThang
{
	class Program
	{
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

			int n = 0;
			while (true)
			{
				try
				{
					Console.Write("Nhap so thang: ");
					n = int.Parse(Console.ReadLine());
					if(n>= 1 && n <= 12)
					{
						break;
					}
				}
				catch
				{
					Console.WriteLine("Sai roi nhap lai di em ei");
				}
			}

			switch (n)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					Console.WriteLine("Thang {0} co 31 ngay", n);
					break;
				case 4:
				case 6:
				case 9:
				case 11:
					Console.WriteLine("Thang {0} co 30 ngay", n);
					break;
				case 2:
					Console.Write("\nNhap nam: ");
					int year = int.Parse(Console.ReadLine());

					if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
					{
						Console.WriteLine("Thang {0} co 29 ngay", n);
					}
					else
					{
						Console.WriteLine("Thang {0} co 28 ngay", n);
					}
					
					break;
				default:
					break;
			}

			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
