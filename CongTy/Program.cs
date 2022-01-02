using System;

namespace CongTy
{
    class Program
    {
        static void Main(string[] args)
        {
            NVSX a = new NVSX("SX001", "Nguyen Huu Danh", "Hai Ba Trung", 50);
            NVVP b = new NVVP("VP001", "Nguyen Huu Danh", "Hai Ba Trung", 5.9, 20);
            NVSX[] dssx = new NVSX[1];
            dssx[0] = a;
            NVVP[] dsvp = new NVVP[1];
            dsvp[0] = b;
            CONGTY M = new CONGTY("1235", dssx, dsvp);

            Console.WriteLine(M.TongLuong());
            Console.ReadLine();
        }
    }
}
