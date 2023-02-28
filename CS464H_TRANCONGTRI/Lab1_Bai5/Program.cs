using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bai5
{
	class Program
	{
		static int nhapSo(int i)
		{
			Console.Write("Nhap so thu " + (i + 1) + ": ");
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
					Console.WriteLine("Nhap sai dinh dang so thu " + (i + 1));
				}
			}
			return x;
		}

		static void xuatSoLe(int[] a)
		{
			Console.WriteLine("\nDay so le la: ");
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] % 2 == 1)
				{
					Console.Write(a[i] + " ");
				}
			}
		}
		static void demSoLe(int[] a)
		{
			int dem = 0;
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] % 2 == 1)
				{
					dem++;
				}
			}
			Console.WriteLine("\nDem cac so le = " + dem);
		}
		static bool isPrime(int n)
		{
			if (n < 2) return false;
			for (int i = 3; i < n; i += 2)
			{
				if (n % i == 0) return false;
			}
			return true;
		}
		static void xuatSoNT(int[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				if (isPrime(a[i]))
				{
					Console.Write(a[i] + " ");
				}
			}
		}

		public static void demSoNT(int[] a)
		{
			int dem = 0;
			for (int i = 0; i < a.Length; i++)
			{
				if (isPrime(a[i]))
				{
					dem++;
				}
			}
			Console.WriteLine("\nDem cac so nguyen to = " + dem);
		}

		public static void sapXepMang(int[] a)
		{
			Array.Sort(a);
			Console.Write("Day so sau khi sap xep la: ");
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i] + " ");
			}
		}

		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			Console.Write("Nhap n: ");
			int n = int.Parse(Console.ReadLine());
			int[] a = new Int32[n];
			for (int i = 0; i < n; i++)
			{
				a[i] = nhapSo(i);
			}

			for (int i = 0; i < n; i++)
			{
				Console.Write(a[i] + " ");
			}

			xuatSoLe(a);
			demSoLe(a);
			xuatSoNT(a);
			demSoNT(a);
			sapXepMang(a);
			

			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
