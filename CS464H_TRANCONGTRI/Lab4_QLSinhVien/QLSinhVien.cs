using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_QLSinhVien
{
    // Phương thức Nhập() void: với yêu cầu.Nhập vào(D) sinh viên điện tử, (C) sinh viên công nghệ thông tin

    class QLSinhVien
    {
        private Dictionary<string, SinhVien> dsSinhVien;

        public Dictionary<string, SinhVien> DsSinhVien { get => dsSinhVien; set => dsSinhVien = value; }

        public QLSinhVien()
        {
            dsSinhVien = new Dictionary<string, SinhVien>();
        }

        public void Nhap()
        {
            while (true)
            {
                Console.WriteLine("Nhap (D) sinh vien dien tu, (C) sinh vien cong nghe thong tin, (K) ket thuc: ");
                string chon = Console.ReadLine();
                if (chon == "K")
                {
                    break;
                }
                else if (chon == "D")
                {
                    SinhVienDienTu sv = new SinhVienDienTu();
                    sv.Nhap();
                    dsSinhVien.Add(sv.Mssv, sv);
                }
                else if (chon == "C")
                {
                    SinhVienKCNTT sv = new SinhVienKCNTT();
                    sv.Nhap();
                    dsSinhVien.Add(sv.Mssv, sv);
                }
                else
                {
                    Console.WriteLine("Nhap sai, nhap lai!");
                }
            }
        }

        public void Xuat()
        {
            foreach (var item in dsSinhVien)
            {
                if (item.Value is SinhVienDienTu)
                {
                    SinhVienDienTu sv = (SinhVienDienTu)item.Value;
                    sv.Xuat();
                }
                else if (item.Value is SinhVienKCNTT)
                {
                    SinhVienKCNTT sv = (SinhVienKCNTT)item.Value;
                    sv.Xuat();
                }
            }
        }

        // dem hoc sinh gioi, kha, trung binh yeu

        public void dem()
        {
            int soLuongSVGioiCNTT = 0;
            int soLuongSVKhaCNTT = 0;
            int soLuongSVTBCNTT = 0;
            int soLuongSVYeuCNTT = 0;

            int soLuongSVGioiDienTu = 0;
            int soLuongSVKhaDienTu = 0;
            int soLuongSVTBDienTu = 0;
            int soLuongSVYeuDienTu = 0;
            // 
            foreach (var item in dsSinhVien)
            {
                if (item.Value is SinhVienDienTu)
                {
                    SinhVienDienTu sv = (SinhVienDienTu)item.Value;

                    if (sv.XepLoai() == "Gioi")
                    {
                        soLuongSVGioiDienTu++;
                    }
                    else if (sv.XepLoai() == "Kha")
                    {
                        soLuongSVKhaDienTu++;
                    }
                    else if (sv.XepLoai() == "TB")
                    {
                        soLuongSVTBDienTu++;
                    }
                    else if (sv.XepLoai() == "Yeu")
                    {
                        soLuongSVYeuDienTu++;
                    }
                }
				else if (item.Value is SinhVienKCNTT)
				{
					SinhVienKCNTT sv = (SinhVienKCNTT)item.Value;

                    if (sv.XepLoai() == "Gioi")
                    {
                        soLuongSVGioiCNTT++;
                    }
                    else if (sv.XepLoai() == "Kha")
                    {
                        soLuongSVKhaCNTT++;
                    }
                    else if (sv.XepLoai() == "TB")
                    {
                        soLuongSVTBCNTT++;
                    }
                    else if (sv.XepLoai() == "Yeu")
                    {
                        soLuongSVYeuCNTT++;
                    }
				}
            }

			Console.WriteLine("Sinh vien gioi KCNTT: " + soLuongSVGioiCNTT);
			Console.WriteLine("Sinh vien kha KCNTT: "+ soLuongSVKhaCNTT);
			Console.WriteLine("Sinh vien TB KCNTT: "+ soLuongSVTBCNTT);
			Console.WriteLine("Sinh vien yeu KCNTT: "+ soLuongSVYeuCNTT);

			Console.WriteLine("Sinh vien gioi dien tu: " + soLuongSVGioiDienTu);
			Console.WriteLine("Sinh vien kha dien tu: "+ soLuongSVKhaDienTu);
			Console.WriteLine("Sinh vien TB dien tu: "+ soLuongSVTBDienTu);
			Console.WriteLine("Sinh vien yeu dien tu: "+ soLuongSVYeuDienTu);
        }
    }
}
