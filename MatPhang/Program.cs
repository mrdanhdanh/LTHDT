using System;

namespace MatPhang
{
    class Program
    {
        static void Main(string[] args)
        {
            MATPHANG M = new MATPHANG();
            M.NhapMP();
            Console.WriteLine($"Chu vi tong la: {M.ChuViTong()}");
            Console.ReadLine();
        }
    }
}
