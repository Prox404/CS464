using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Bai6
{
    class Program
    {
        public static int fibonacci(int n)
        {
            int[] f = new int[n + 2];
            int i;

            f[0] = 0;
            f[1] = 1;

            for (i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }

        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            int n = 0;
			Console.WriteLine("Nhap so thang: ");
			n = int.Parse(Console.ReadLine());

			Console.WriteLine("So con tho: " + fibonacci(n));
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
