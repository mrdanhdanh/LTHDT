using System;
using System.Collections.Generic;
using System.Text;

namespace MatPhang
{
    class DIEM
    {
        private double X;
        private double Y;

        public DIEM()
        {

        }
        public DIEM(double a, double b)
        {
            this.X = a;
            this.Y = b;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap toa do x: ");
            this.X = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do y: ");
            this.Y = double.Parse(Console.ReadLine());
        }
    }
}
