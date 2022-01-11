using System;
using System.Collections.Generic;
using System.Text;

namespace MatPhang
{
    class HINHTRON : HINH, TinhToan
    {
        private DIEM I { get; set; }
        private double R { get; set; }

        public HINHTRON()
        {

        }
        public HINHTRON(string ma, string tenhinh, string mausac, double x, double y, double r) : base(ma,tenhinh,mausac)
        {
            DIEM i = new DIEM(x, y);
            this.I = i;
            this.R = r;
        }

        public override void Nhap(string ghichu)
        {
            
            base.Nhap(ghichu);
            this.I = new DIEM();
            this.I.Nhap();
            Console.WriteLine("Nhap ban kinh R: ");
            this.R = double.Parse(Console.ReadLine());
        }
        public override double ChuVi()
        {
            return Math.PI * this.R;
        }
        public double ChuVi2()
        {
            return Math.PI * this.R;
        }
    }
}
