using System;
using System.Collections.Generic;
using System.Text;

namespace CongTy
{
    class NVSX : NHANVIEN
    {
        private string manv;
        private string hoten;
        private string diachi;
        private int slsanpham;
        public NVSX()
        {

        }
        public NVSX(string manv, string hoten, string diachi, int slsanpham)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.diachi = diachi;
            this.slsanpham = slsanpham;
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin NV San Xuat: ");
            base.Nhap();

            Console.WriteLine("Nhap so luong san pham:");
            this.slsanpham = int.Parse(Console.ReadLine());

        }
        public void Xuat()
        {
            Console.WriteLine($"{this.manv}     {this.hoten}     {this.diachi}    {this.slsanpham}");
        }
        public override double TinhLuong()
        {
            return this.slsanpham * 10;
        }
    }
}
