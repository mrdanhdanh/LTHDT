using System;
using System.Collections.Generic;
using System.Text;

namespace MatPhang
{
    class HINHCHUNHAT : HINH
    {
        private DIEM A { get; set; }
        private double Dai { get; set; }
        private double Rong { get; set; }

        public HINHCHUNHAT(string ma, string tenhinh, string mausac, double x, double y, double d, double r) : base(ma, tenhinh, mausac)
        {
            this.A = new DIEM(x, y);
            this.Dai = d;
            this.Rong = r;
        }
        public double ChuVi()
        {
            return (this.Dai + this.Rong) * 2;
        }
    }
}
