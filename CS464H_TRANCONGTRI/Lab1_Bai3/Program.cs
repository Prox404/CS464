using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bai3
{
	class Program
	{
		static void giaiPTBac2(float a, float b, float c)
		{
			if (a == 0)
			{
				if (b == 0)
				{
					Console.Write("Phuong trinh vo nghiem!");
				}
				else
				{
					Console.Write("Phuong trinh co mot nghiem: x = {0}", (-c / b));
				}
				return;
			}
			float delta = b * b - 4 * a * c;
			float x1;
			float x2;
			if (delta > 0)
			{
				x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
				x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
				Console.Write("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", x1, x2);
			}
			else if (delta == 0)
			{
				x1 = (-b / (2 * a));
				Console.Write("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
			}
			else
			{
				Console.Write("Phuong trinh vo nghiem!");
			}
		}

		static int nhapSo(char i)
		{
			Console.WriteLine("\nNhap he so " + i);
			int x;
			while (true)
			{
				try
				{
					x = int.Parse(Console.ReadLine());
					break;
				}
				catch (Exception)
				{
					Console.WriteLine("Nhap sai he so " + i);
				}
			}
			return x;
		}

		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Nhập n có 3 chữ số: ");
			Console.Write("Nhap he so bac 2, a = ");
			float a = nhapSo('a');
			float b = nhapSo('b');
			float c = nhapSo('c');
			giaiPTBac2(a, b, c);

			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
