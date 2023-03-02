using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_MonHoc
{
	class Program
	{

		public static Dictionary<string, MonHoc> insertIntoPosition(int position, MonHoc monHoc, Dictionary<string, MonHoc> dsMonHoc)
		{
			if (position < 0 || position > dsMonHoc.Count)
			{
				Console.WriteLine("Vi tri khong hop le");
				return dsMonHoc;
			}
			Dictionary<string, MonHoc> newDsMonHoc = new Dictionary<string, MonHoc>();

			int i = 1;
			foreach (KeyValuePair<string, MonHoc> item in dsMonHoc)
			{
				if (i == position)
				{
					newDsMonHoc.Add(monHoc.MaMon, monHoc);
				}
				newDsMonHoc.Add(item.Key, item.Value);
				i++;
			}
			return newDsMonHoc;
		}
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			// Console.WriteLine("Hello World!");


			Dictionary<string, MonHoc> dsMonHoc = new Dictionary<string, MonHoc>();

			dsMonHoc.Add("cs465", new MonHoc("cs465", ".NET"));
			dsMonHoc.Add("cs464", new MonHoc("cs464", "KTTMDT"));
			while (true)
            {
                int luaChon = 0;
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Nhap thong tin mon hoc");
                Console.WriteLine("2. Kiem tra mon kttmdt da ton tai hay chua, neu chua thi them vao");
                Console.WriteLine("3. xem danh sach mon hoc");
                Console.WriteLine("4. dem xem co bao nhieu mon hoc");
                Console.WriteLine("5. thuc hien xoa mon cs464");
				Console.WriteLine("6. chen vao vi tri n");
				

                Console.WriteLine("Nhap lua chon: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 0:
                        return;
                    case 1:
						Console.WriteLine("Nhap ma mon hoc: ");
						string maMonHoc = Console.ReadLine();
						Console.WriteLine("Nhap ten mon hoc: ");
						string tenMonHoc = Console.ReadLine();
						dsMonHoc.Add(maMonHoc, new MonHoc(maMonHoc, tenMonHoc));
						break;
					case 2:
						if (dsMonHoc.ContainsKey("cs464"))
						{
							Console.WriteLine("Mon hoc da ton tai");
						}
						else
						{
							dsMonHoc.Add("cs464", new MonHoc("cs464", "KTTMDT"));
						}
						break;
					case 3:
						foreach (KeyValuePair<string, MonHoc> item in dsMonHoc)
						{
							Console.WriteLine(item.Value.TenMon);
						}
						break;
					case 4:
						Console.WriteLine("So luong mon hoc la: " + dsMonHoc.Count);
						break;
					case 5:
						dsMonHoc.Remove("cs464");
						break;
					case 6:
						Console.WriteLine("Nhap vi tri can chen: ");
						int viTri = int.Parse(Console.ReadLine());
						Console.WriteLine("Nhap ma mon hoc: ");
						string maMonHoc1 = Console.ReadLine();
						Console.WriteLine("Nhap ten mon hoc: ");
						string tenMonHoc1 = Console.ReadLine();
						dsMonHoc = insertIntoPosition(viTri, new MonHoc(maMonHoc1, tenMonHoc1), dsMonHoc);
						break;

                    default:
						Console.WriteLine("Nhap dung di anh ban");
						break;
                }

				if (luaChon == 0)
					break;
            }
			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
