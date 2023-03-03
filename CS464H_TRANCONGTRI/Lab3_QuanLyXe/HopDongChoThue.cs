using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_QuanLyXe
{

	// Lớp Hợp Đồng Cho Thuê:
		// a. Bao gồm các trường Sổ hợp đồng (string), Xe (Xe), Nhân viên (Người), Khách Hàng (Người), Số
		// ngày thuê (int), Đơn giá (double), Ngày thuê (DateTime),Đối tượng List (QUANLYXE)
		// b. Phương thức Thành tiền() = đơn giá nhân số ngày thuê; (Nếu là xe chở hàng thì đơn giá = 500K, 
		// Nếu là xe du lịch thì nếu <=5 chỗ thì là 500K, <=7 chỗ thì là 700K, còn lại thì 1 triệu.
		// c. Phương thức Nhập(): yêu cầu gọi phương thức nhập của lớp Quản lý xe. Nhập thông tin về biển số
		// xe cần thuê, nếu có xe cần thuê thì nhập tiếp Nhân viên và Khách hàng.
		// Phương thức Xuất(): in ra Xe thuê, số tiền cần phải trả và Nhân viên, Khách hàng

	class HopDongChoThue
	{
		private string soHopDong;
		private Xe xe;
		private Nguoi nhanVien;
		private Nguoi khachHang;
		private int soNgayThue;
		private double donGia;
		private DateTime ngayThue;
		private QuanLyXe quanLyXe;

		public string SoHopDong { get => soHopDong; set => soHopDong = value; }
		public Xe Xe { get => xe; set => xe = value; }
		public Nguoi NhanVien { get => nhanVien; set => nhanVien = value; }
		public Nguoi KhachHang { get => khachHang; set => khachHang = value; }
		public int SoNgayThue { get => soNgayThue; set => soNgayThue = value; }
		public double DonGia { get => donGia; set => donGia = value; }
		public DateTime NgayThue { get => ngayThue; set => ngayThue = value; }
		public QuanLyXe QuanLyXe { get => quanLyXe; set => quanLyXe = value; }

		public HopDongChoThue()
		{
			soHopDong = "";
			xe = new Xe();
			nhanVien = new Nguoi();
			khachHang = new Nguoi();
			soNgayThue = 0;
			donGia = 0;
			ngayThue = DateTime.Now;
			quanLyXe = new QuanLyXe();
		}

		public HopDongChoThue(string soHopDong, Xe xe, Nguoi nhanVien, Nguoi khachHang, int soNgayThue, double donGia, DateTime ngayThue, QuanLyXe quanLyXe)
		{
			this.soHopDong = soHopDong;
			this.xe = xe;
			this.nhanVien = nhanVien;
			this.khachHang = khachHang;
			this.soNgayThue = soNgayThue;
			this.donGia = donGia;
			this.ngayThue = ngayThue;
			this.quanLyXe = quanLyXe;
		}

		public double ThanhTien()
		{
			if (xe is XeChoHang)
			{
				donGia = 500000;
			}
			else if (xe is XeDuLich)
			{
				XeDuLich xeDuLich = xe as XeDuLich;
				if (xeDuLich.SoChoNgoi <= 5)
				{
					donGia = 500000;
				}
				else if (xeDuLich.SoChoNgoi <= 7)
				{
					donGia = 700000;
				}
				else
				{
					donGia = 1000000;
				}
			}
			return donGia * soNgayThue;
		}

		public void Nhap()
		{
			Console.Write("Nhap so hop dong: ");
			soHopDong = Console.ReadLine();
			Console.Write("Nhap bien so xe: ");
			string bienSo = Console.ReadLine();
			xe = quanLyXe.TimXe(bienSo);
			if (xe != null)
			{
				Console.WriteLine("Nhap thong tin nhan vien: ");
				nhanVien.Nhap();
				Console.WriteLine("Nhap thong tin khach hang: ");
				khachHang.Nhap();
			}
			else
			{
				Console.WriteLine("Khong tim thay xe co bien so {0}", bienSo);
			}
		}

		public void Xuat(){
			xe.Xuat();
			Console.WriteLine("Thanh tien: {0}", ThanhTien());
			
		} 
	}
}
