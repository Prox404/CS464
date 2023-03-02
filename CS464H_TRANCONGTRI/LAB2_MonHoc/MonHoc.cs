using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_MonHoc
{
	class MonHoc
	{
		private string maMon;
		private string tenMon;

		public string MaMon { get => maMon; set => maMon = value; }
		public string TenMon { get => tenMon; set => tenMon = value; }

		public MonHoc()
		{
			maMon = "";
			tenMon = "";
		}

		public MonHoc(string maMon, string tenMon)
		{
			this.maMon = maMon;
			this.tenMon = tenMon;
		}

		
	}
}
