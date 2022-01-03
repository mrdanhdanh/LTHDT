using System;
using System.Collections.Generic;
using System.Text;

namespace MatPhang
{
    class HINH
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
        public void Nhap()
        {
            Console.WriteLine("Nhap ma hinh: ");
            this.ma = Console.ReadLine();
            Console.WriteLine("Nhap ten hinh:");
            this.tenhinh = Console.ReadLine();
            Console.WriteLine("Nhap màu sac: ");
            this.mausac = Console.ReadLine();
        }
    }
}
