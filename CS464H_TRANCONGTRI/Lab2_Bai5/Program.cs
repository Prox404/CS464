using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Bai5
{
	class Program
	{

		public static int giaiThua(int n){
			int result = 1;
			for(int i=1; i<=n; i++){
				result *= i;
			}
			//Console.Write("Giai thua: " + result);
			return result;
		}
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

			// x - ((x^3) / 3!) + ((x^5) / 5!) - ((x^7) / 7!) ...

			int x = 0;
			int n = 0;

			Console.WriteLine("Nhap x: ");
			x = int.Parse(Console.ReadLine());
			Console.WriteLine("Nhap n: ");
			n = int.Parse(Console.ReadLine());

			double sum = 0;
			int i = 1;
			while (i <= n)
			{
				//Console.WriteLine(i);
				sum += (Math.Pow(x, (i*2)-1)* Math.Pow(-1, i+1)) / giaiThua(i*2-1);
				Console.WriteLine(Math.Pow(x, (i * 2) - 1));
				i++;
			}

			Console.WriteLine("S = " + sum);

			Console.WriteLine("End!");
			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
