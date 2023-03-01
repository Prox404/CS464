using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_QuanLyXe
{

	// a. Bao gồm các trường cuả lớp xe, bổ sung thêm trường Số chỗ ngồi (int)
	// b. Bao gồm phương thức của lớp Xe. Bổ sung vào phương thức Nhập() và Xuất() số chỗ ngồi

	class XeDuLich : Xe
	{
		private int soChoNgoi;

		public int SoChoNgoi { get => soChoNgoi; set => soChoNgoi = value; }

		public XeDuLich()
		{
			soChoNgoi = 0;
		}

		public XeDuLich(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuanBang, int soChoNgoi) : base(bienSo, tenXe, trongTai, ngayDangKiem, tieuChuanBang)
		{
			this.soChoNgoi = soChoNgoi;
		}

		public override void Nhap()
		{
			base.Nhap();
			while (true)
			{
				try
				{
					Console.WriteLine("Nhap so cho ngoi: ");
					soChoNgoi = int.Parse(Console.ReadLine());
					break;
				}
				catch (Exception)
				{
					Console.WriteLine("Nhap sai, nhap lai!");
				}
			}
		}

		public override void Xuat()
		{
			base.Xuat();
			Console.WriteLine("So cho ngoi: " + soChoNgoi);
		}

	}
}
