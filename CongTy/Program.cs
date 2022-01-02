using System;

namespace CongTy
{
    class Program
    {
        static void Main(string[] args)
        {
            NVSX a = new NVSX("SX001", "Nguyen Huu Danh", "Hai Ba Trung", 50);
            a.Xuat();
            Console.ReadLine();
        }
    }
}
