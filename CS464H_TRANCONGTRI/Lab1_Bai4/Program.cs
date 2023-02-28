using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bai4
{
	class Program
	{
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			int canha, canhb, canhc;
			Console.Write("\n");
			Console.Write("Kiem tra tam giac deu, can, lech\n");

			Console.Write("Nhap canh a: ");
			canha = Convert.ToInt32(Console.ReadLine());

			Console.Write("Nhap canh b: ");
			canhb = Convert.ToInt32(Console.ReadLine());

			Console.Write("Nhap canh c: ");
			canhc = Convert.ToInt32(Console.ReadLine());


			if (canha == canhb && canhb == canhc)
			{
				Console.Write("Day la tam giac deu.\n");
			}
			else if (canha == canhb || canha == canhc || canhb == canhc)
			{
				Console.Write("Day la tam giac can.\n");
			}
			else if (canha + canhb < canhc || canhb + canhc < canha || canhc + canha < canhb)
			{
				Console.Write("Day khong phai tam giac.\n");
			}
			else
			{
				Console.Write("Day la tam giac lech.\n");
			}


			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
