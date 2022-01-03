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
            this.heso = heso;
            this.phucap = phucap;
        }
        public void Nhap()
        {
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

        public double TinhLuong()
        {
            return this.heso * 10 + this.phucap;
        }
    }
}
