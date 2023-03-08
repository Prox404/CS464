using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_QLSinhVien
{
    // Tạo lớp SinhVienKCNTT gồm các thuộc tính: MSSV, HoTen, DiaChi, NgaySinh, 

    class SinhVien
    {
        private string mssv;
        private string hoTen;
        private string diaChi;
        private DateTime ngaySinh;

        public string Mssv { get => mssv; set => mssv = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public SinhVien()
        {
            mssv = "";
            hoTen = "";
            diaChi = "";
            ngaySinh = DateTime.Now;
        }

        public SinhVien(string mssv, string hoTen, string diaChi, DateTime ngaySinh)
        {
            this.mssv = mssv;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
        }

        public virtual void Nhap()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhap MSSV: ");
                    mssv = Console.ReadLine();
                    Console.Write("Nhap Ho Ten: ");
                    hoTen = Console.ReadLine();
                    Console.Write("Nhap Dia Chi: ");
                    diaChi = Console.ReadLine();
                    Console.Write("Nhap Ngay Sinh: ");
                    ngaySinh = DateTime.Parse(Console.ReadLine());

					if (ngaySinh > DateTime.Now)
					{
						Console.WriteLine("Ngay sinh khong hop le, vui long nhap lai!");
					}else{
						break;
					}
                }
                catch
                {
					Console.WriteLine("Nhap sai dinh dang, vui long nhap lai!");
                }
            }

        }

        public virtual void Xuat()
        {
            Console.WriteLine("MSSV: {0}", mssv);
            Console.WriteLine("Ho Ten: {0}", hoTen);
            Console.WriteLine("Dia Chi: {0}", diaChi);
            Console.WriteLine("Ngay Sinh: {0: dd/MM/yyyy}", ngaySinh);
        }

        public virtual double TinhDTB()
        {
            return 0;
        }

		public virtual string XepLoai()
		{
			return "Cui bap";
		}
    }
}
