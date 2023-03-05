using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_QuanLyXe
{
	class Program
	{
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			Dictionary<string, HopDongChoThue> dsHopDong = new Dictionary<string, HopDongChoThue>();
			HopDongChoThue hd = new HopDongChoThue();
			hd.Nhap();
			dsHopDong.Add(hd.SoHopDong, hd);
			hd.Xuat();
			

			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
