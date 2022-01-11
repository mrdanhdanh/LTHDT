using System;
using System.Collections.Generic;
using System.Text;

namespace MatPhang
{
    abstract class HINH : TinhToan
    {
        private string ma;
        private string tenhinh;
        private string mausac;

        public HINH()
        {


        }

        public HINH(string ma, string tenhinh, string mausac)
        {
            this.ma = ma;
            this.tenhinh = tenhinh;
            this.mausac = mausac;
        }
        public virtual void Nhap(string ghichu)
        {
            Console.WriteLine(ghichu);
            Console.WriteLine("Nhap ma hinh: ");
            this.ma = Console.ReadLine();
            Console.WriteLine("Nhap ten hinh:");
            this.tenhinh = Console.ReadLine();
            Console.WriteLine("Nhap màu sac: ");
            this.mausac = Console.ReadLine();
        }
        public abstract double ChuVi();
    }
    interface TinhToan
    {
        double ChuVi();
    }
}
