using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_QuanLyXe
{

	// a. Bao gồm thư viện: List (Dictionary<string, Xe>)
	// b. Phương thức Nhập() void: với yêu cầu. Nhập vào (H) xe chở hàng, (D) xe du lịch
	// 	i. Nếu là xe chở hàng thì gọi phương thức nhập cho xe chở hàng và thêm vào List<Biển số, Xe 
	// 	chở hàng>
	// 	ii. Nếu là xe du lịch thì gọi phương thức nhập cho xe du lịch và thêm vào List<Biển số, Xe du 
	// 	lịch>
	// c. Phương thức Tìm (Biển số): Xuất ra tìm thấy xe theo biển số hoặc không tìm thấy. Xuất ra thông tin 
	// xe nếu tìm thấy
	// d. Phương thức Xóa (Biển số): Xóa Xe theo biển số trong List
	// e. Phương thức Xuất() void

	class QuanLyXe
	{
		private Dictionary<string, Xe> dsXe;

		public Dictionary<string, Xe> DsXe { get => dsXe; set => dsXe = value; }

		public QuanLyXe()
		{
			dsXe = new Dictionary<string, Xe>();
		}

		public void Nhap()
		{
			while (true)
			{
				Console.WriteLine("Nhap (H) xe cho hang, (D) xe du lich, (K) ket thuc: ");
				string chon = Console.ReadLine();
				if (chon == "K")
				{
					break;
				}
				else if (chon == "H")
				{
					XeChoHang xe = new XeChoHang();
					xe.Nhap();
					dsXe.Add(xe.BienSo, xe);
				}
				else if (chon == "D")
				{
					XeDuLich xe = new XeDuLich();
					xe.Nhap();
					dsXe.Add(xe.BienSo, xe);
				}
				else
				{
					Console.WriteLine("Nhap sai, nhap lai!");
				}
			}
		}

		public void Tim(string bienSo)
		{
			if (dsXe.ContainsKey(bienSo))
			{
				Console.WriteLine("Tim thay xe voi bien so " + bienSo);
				dsXe[bienSo].Xuat();
			}
			else
			{
				Console.WriteLine("Khong tim thay xe voi bien so " + bienSo);
			}
		}

		public void Xoa(string bienSo)
		{
			if (dsXe.ContainsKey(bienSo))
			{
				dsXe.Remove(bienSo);
				Console.WriteLine("Xoa thanh cong!");
			}
			else
			{
				Console.WriteLine("Khong tim thay xe voi bien so " + bienSo);
			}
		}

		public void Xuat()
		{
			foreach (var xe in dsXe)
			{
				xe.Value.Xuat();
			}
		}
	}
}
