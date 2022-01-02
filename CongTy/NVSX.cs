using System;
using System.Collections.Generic;
using System.Text;

namespace CongTy
{
    class NVSX
    {
        private string manv;
        private string hoten;
        private string diachi;
        private int slsanpham;

        public NVSX(string manv, string hoten, string diachi, int slsanpham)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.diachi = diachi;
            this.slsanpham = slsanpham;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ma Nhan Vien:");
            this.manv = Console.ReadLine();
            Console.WriteLine("Nhap ten Nhan Vien:");
            this.hoten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi Nhan Vien:");
            this.diachi = Console.ReadLine();
            Console.WriteLine("Nhap so luong san pham:");
            this.slsanpham = int.Parse(Console.ReadLine());

        }
        public void Xuat()
        {
            Console.WriteLine($"{this.manv}     {this.hoten}     {this.diachi}    {this.slsanpham}");
        }
    }
}
