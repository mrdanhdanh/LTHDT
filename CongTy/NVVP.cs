using System;
using System.Collections.Generic;
using System.Text;

namespace CongTy
{
    class NVVP
    {
        private string manv;
        private string hoten;
        private string diachi;
        private double heso;
        private int phucap;

        public NVVP()
        {

        }
        public NVVP(string manv, string hoten, string diachi, double heso, int phucap )
        {
            this.manv = manv;
            this.hoten = hoten;
            this.diachi = diachi;
            this.heso = heso;
            this.phucap = phucap;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ma Nhan Vien:");
            this.manv = Console.ReadLine();
            Console.WriteLine("Nhap ten Nhan Vien:");
            this.hoten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi Nhan Vien:");
            this.diachi = Console.ReadLine();
            Console.WriteLine("Nhap he so:");
            this.heso = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phu cap:");
            this.phucap = int.Parse(Console.ReadLine());

        }
        public void Xuat()
        {
            Console.WriteLine($"{this.manv}     {this.hoten}     {this.diachi}    {this.heso}     {this.phucap}");
        }

        public double TinhLuong()
        {
            return this.heso * 10 + this.phucap;
        }
    }
}
