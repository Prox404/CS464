using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bai6
{
    class Program
    {

        public static void NhapXe(Dictionary<string, Xe> xe)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap bien so xe: ");
                    string bienSo = Console.ReadLine();
                    Console.WriteLine("Nhap hang san xuat: ");
                    string hangSanXuat = Console.ReadLine();
                    Console.WriteLine("Nhap nam san xuat: ");
                    DateTime namSanXuat = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap chu so huu: ");
                    string chuSoHuu = Console.ReadLine();
                    xe.Add(bienSo, new Xe(bienSo, hangSanXuat, namSanXuat, chuSoHuu));
                    break;
                }
                catch
                {

                    Console.WriteLine("Sai roi, nhap lai");
                }
            }
        }

        public static void XuatXe(Dictionary<string, Xe> xe)
        {
            foreach (KeyValuePair<string, Xe> item in xe)
            {
                item.Value.PrintInformation();
            }
        }

        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            // Console.WriteLine("Hello World!");

            Dictionary<string, Xe> xe = new Dictionary<string, Xe>();
            while (true)
            {
                int luaChon = 0;
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Nhap xe");
                Console.WriteLine("2. Xoa xe theo bien so");
                Console.WriteLine("3. Tim iem va Xuat xe theo bien so");
                Console.WriteLine("Nhap lua chon: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 0:
                        return;
                    case 1:
                        int n = 0;
                        Console.WriteLine("Nhap so luong xe: ");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            NhapXe(xe);
                        }
                        XuatXe(xe);
                        break;
                    case 2:
                        Console.WriteLine("Nhap bien so xe can xoa: ");
                        string bienSo = Console.ReadLine();
                        xe.Remove(bienSo);
                        break;
                    case 3:
                        Console.WriteLine("Nhap bien so xe can tim: ");
                        string bienSoTim = Console.ReadLine();
                        if (xe.ContainsKey(bienSoTim))
                        {
                            Console.WriteLine(xe[bienSoTim].HangSanXuat);
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay");
                        }
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
