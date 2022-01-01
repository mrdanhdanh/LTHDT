using System;

namespace TamGiacLTHDT
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Diem A = new Diem(0, 0);
            Diem B = new Diem(1, 1);
            Diem C = new Diem(0, 1);
            TamGiac T = new TamGiac(A,B,C);
            T.dinhA.toadoX = 10;
            Console.WriteLine($"Chu vi cua tam giac: {T.ChuVi()}");
            Console.ReadLine();


            //TamGiac t = new TamGiac();
            //t.Nhap("Nhap vao mot tam giac");
            //while (t.Kiemtra() == false)
            //{
            //    t.Nhap("Tam giac khong hop le, vui long nhap lai");
            //}
            //Console.WriteLine($"Chu vi cua tam giac: {t.ChuVi()}");
            //Console.ReadLine();
        }
    }
}
