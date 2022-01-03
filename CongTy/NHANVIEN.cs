using System;
using System.Collections.Generic;
using System.Text;

namespace CongTy
{
    class NHANVIEN
    {
        private string manv;
        private string hoten;
        private string diachi;
        public NHANVIEN()
        {

        }
        public NHANVIEN(string manv, string hoten, string diachi)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.diachi = diachi;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ma Nhan Vien:");
            this.manv = Console.ReadLine();
            Console.WriteLine("Nhap ten Nhan Vien:");
            this.hoten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi Nhan Vien:");
            this.diachi = Console.ReadLine();

        }
        public void Xuat()
        {
            Console.Write($"{this.manv}     {this.hoten}     {this.diachi}");
        }
    }
}
