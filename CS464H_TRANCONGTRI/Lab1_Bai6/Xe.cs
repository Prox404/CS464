using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bai6
{
	class Xe
	{
		private string bienSo;
		private string hangSanXuat;
		private DateTime namSanXuat;
		private string chuSoHuu;

		public string BienSo { get => bienSo; set => bienSo = value; }
		public string HangSanXuat { get => hangSanXuat; set => hangSanXuat = value; }
		public DateTime NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
		public string ChuSoHuu { get => chuSoHuu; set => chuSoHuu = value; }

		public Xe()
		{
			bienSo = "";
			hangSanXuat = "";
			namSanXuat = DateTime.Today;
			chuSoHuu = "";
		}

		public Xe(string bienSo, string hangSanXuat, DateTime namSanXuat, string chuSoHuu)
		{
			this.bienSo = bienSo;
			this.hangSanXuat = hangSanXuat;
			this.namSanXuat = namSanXuat;
			this.chuSoHuu = chuSoHuu;
		}

		public void PrintInformation(){
			Console.WriteLine("Bien so: " + bienSo);
			Console.WriteLine("Hang san xuat: " + hangSanXuat);
			Console.WriteLine("Nam san xuat: " + namSanXuat);
			Console.WriteLine("Chu so huu: " + chuSoHuu);
		}

	}
}
