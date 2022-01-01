using System;

namespace TamGiacLTHDT
{
    class Diem
    {
        private double x;
        private double y;

        public Diem(double a, double b)
        {
            this.x = a;
            this.y = b;
        }
        public double toadoXGon
        {
            get;
            set;
        }
        public double toadoX
        {
            get {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public void Nhap(string ghichu)
        {

            Console.WriteLine(ghichu);
            this.x = double.Parse(Console.ReadLine());
            this.y = double.Parse(Console.ReadLine());

        }
        public double KhoangCach(Diem B)
        {
            double kq = Math.Sqrt((this.x-B.x)*(this.x-B.x)+(this.y-B.y)*(this.y-B.y));
            return kq;
        }
    }
    class TamGiac
    {
        private Diem A;
        private Diem B;
        private Diem C;

        public TamGiac(Diem A, Diem B, Diem C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public Diem dinhA
        {
            get
            {
                return this.A;
            }
            set
            {
                this.A = value;
            }
        }
        public void Nhap(string ghichu)
        {
            Console.WriteLine(ghichu);
            this.A = new Diem(0,0);
            this.B = new Diem(1,1);
            this.C = new Diem(1,0);
        }
        public Boolean Kiemtra()
        {
            Boolean check = true;
            double P = this.ChuVi();
            double kcAB = this.A.KhoangCach(this.B);
            double kcBC = this.B.KhoangCach(this.C);
            double kcCA = this.C.KhoangCach(this.A);
            if ((P/2 <= kcAB) || (P / 2 <= kcBC) || (P / 2 <= kcCA)) {
                check = false;
            };
            return check;
        }
        public double ChuVi()
        {
            double kq = this.A.KhoangCach(this.B) + this.B.KhoangCach(this.C) + this.C.KhoangCach(this.A) ;
            return kq;
        }
    }
    class DaGiac
    //{
    //    public Diem[] DSDiem;
        
    //    public void Nhap(string ghichu, int n)
    //    {
    //        this.DSDiem = new Diem[n];
    //        Console.WriteLine(ghichu);
    //        for (int i=0; i< this.DSDiem.Length; i++)
    //        {
    //            this.DSDiem[i] = new Diem();
    //            this.DSDiem[i].Nhap($"Nhap toa do diem {i}: ");
    //        }
    //    }
    //    public double ChuVi()
    //    {
    //        double kq = 0;
    //        for (int i=0; i<this.DSDiem.Length; i++)
    //        {
    //            if (i>0)
    //            {
    //                kq += this.DSDiem[i - 1].KhoangCach(this.DSDiem[i]);
    //            } else
    //            {
    //                kq += this.DSDiem[this.DSDiem.Length-1].KhoangCach(this.DSDiem[0]);
    //            }
    //        }
    //        return kq;
    //    }

    //}
}
