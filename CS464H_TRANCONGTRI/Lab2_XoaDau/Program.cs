using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_XoaDau
{
    class Program
    {

        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            // Console.WriteLine("Hello World!");

			Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

			Console.WriteLine("Nhap thu trong tuan: ");
			string thu = Console.ReadLine();

			thu = thu.ToLower();
			thu = RemoveUnicode(thu);

			//Console.WriteLine(thu);

			switch (thu)
			{
				case "thu hai":
					Console.WriteLine("Hello, thứ 2");
					break;
				case "thu ba":
					Console.WriteLine("Hello, thứ 3");
					break;
				case "thu tu":
					Console.WriteLine("Hello, thứ 4");
					break;
				case "thu nam":
					Console.WriteLine("Hello, thứ 5");
					break;
				case "thu sau":
					Console.WriteLine("Hello, thứ 6");
					break;
				case "thu bay":
					Console.WriteLine("Hello, thứ 7");
					break;
				case "chu nhat":
					Console.WriteLine("Hello, chủ nhật");
					break;
				default:
					Console.WriteLine("Khong hop le");
					break;
			}
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
