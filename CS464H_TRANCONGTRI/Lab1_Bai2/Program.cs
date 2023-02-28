using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bai2
{
	class Program
	{
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Nhập n có 3 chữ số: ");
			int n = Int32.Parse(Console.ReadLine());
			float tong = 0, tich = 1;

			int tram = n / 100;
			int chuc = (n % 100) / 10;
			int donvi = n % 10;

			tong = tram + donvi;
			tich = tram * donvi;

			Console.WriteLine("Tổng là: " + tong);
			Console.WriteLine("Tích là: " + tich);
			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
