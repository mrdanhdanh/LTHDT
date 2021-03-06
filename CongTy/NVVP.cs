using System;
using System.Collections.Generic;
using System.Text;

namespace CongTy
{
    class NVVP : NHANVIEN
    {
        private double heso;
        private int phucap;

        public NVVP()
        {

        }
        public NVVP(string manv, string hoten, string diachi, double heso, int phucap ) : base(manv, hoten, diachi)
        {
            //this.manv = manv là không được vì this.manv là private của class NHANVIEN, ta phải dùng base để truy cập hàm tạo của class NHANVIEN. Để giải uyết thì ta cho nó thành protected, dễ truy xuất dữ liệu hơn
            this.heso = heso;
            this.phucap = phucap;
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin NV Van Phong: ");
            base.Nhap();

            Console.WriteLine("Nhap he so:");
            this.heso = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phu cap:");
            this.phucap = int.Parse(Console.ReadLine());

        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"    {this.heso}     {this.phucap}");
        }

        public override double TinhLuong()
        {
            return this.heso * 10 + this.phucap;
        }
    }
}
