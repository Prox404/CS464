using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_QuanLyXe
{

	// Lớp Sổ Hợp Đồng (tương tự lớp Quản lý xe đây là lớp Quản lý sổ hợp đồng)
		// a. Bao gồm thư viện: Sổ cái (Dictionary<string, HOPDONGCHOTHUE>)
		// b. Phương thức Lưu() void: với yêu cầu. 
		// i. Nhập vào hợp đồng cho thuê và lưu vào sổ cái (Dictionary<Sohopdong, 
		// HOPDONGCHOTHUE>)
		// c. Phương thức Tìm (Sohopdong): Xuất ra thông tin về hợp đồng nếu tìm thấy.
		// d. Phương thức Xóa (Sohopdong) Xóa HOPDONGTHUE XE theo Sohopdong trong Sổ cái


	class SoHopDong
	{
		private Dictionary<string, HopDongChoThue> dsHopDong;

		public Dictionary<string, HopDongChoThue> DsHopDong { get => dsHopDong; set => dsHopDong = value; }

		public SoHopDong()
		{
			dsHopDong = new Dictionary<string, HopDongChoThue>();
		}

		public void Luu(){
			HopDongChoThue hopDong = new HopDongChoThue();
			hopDong.Nhap();
			dsHopDong.Add(hopDong.SoHopDong, hopDong);
		}

		public HopDongChoThue Tim(string maHopDong){
			if (dsHopDong.ContainsKey(maHopDong))
			{
				return dsHopDong[maHopDong];
			}
			return null;
		}

		public void Xoa(string maHopDong){
			if (dsHopDong.ContainsKey(maHopDong))
			{
				dsHopDong.Remove(maHopDong);
				Console.WriteLine("Xoa thanh cong!");
			}
			else{
				Console.WriteLine("Khong co hop dong nay!");
			}
		}
	}
}
