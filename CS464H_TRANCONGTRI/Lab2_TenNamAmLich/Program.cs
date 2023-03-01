using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TenNamAmLich
{
	class Program
	{
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			// Console.WriteLine("Hello World!");

			int nam = 0;

			while (true)
			{
				try
				{
					Console.Write("Nhap nam: ");
					nam = int.Parse(Console.ReadLine());
					if (nam >= 1)
					{
						break;
					}
				}
				catch
				{
					Console.WriteLine("Sai roi nhap lai di em ei");
				}
			}

			int can = nam % 10;
			int chi = nam % 12;

			string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            
            string[] Chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui" };

			Console.WriteLine("Nam am lich: " + Can[can] + " " + Chi[chi]);

			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
