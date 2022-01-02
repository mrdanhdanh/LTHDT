using System;
using System.Collections.Generic;
using System.Text;

namespace CongTy
{
    class CONGTY
    {
        private string tencty;
        private NVSX[] dssx;
        private NVVP[] dsvp;

        public CONGTY()
        {

        }
        public CONGTY(string tencty, NVSX[] dssx, NVVP[] dsvp)
        {
            this.tencty = tencty;
            this.dssx = dssx;
            this.dsvp = dsvp;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ten cong ty: ");
            this.tencty = Console.ReadLine();
            Console.WriteLine("Nhap so luong nhan vien SX:");
            int n = int.Parse(Console.ReadLine());
            NVSX[] dssx = new NVSX[n];
            for (int i = 0; i<n; i++)
            {
                NVSX a = new NVSX();
                a.Nhap();
                dssx[i] = a;
            }
            this.dssx = dssx;

            Console.WriteLine("Nhap so luong nhan vien VP:");
            n = int.Parse(Console.ReadLine());
            NVVP[] dsvp = new NVVP[n];
            for (int i = 0; i < n; i++)
            {
                NVVP a = new NVVP();
                a.Nhap();
                dsvp[i] = a;
            }
            this.dsvp = dsvp;
        }
        public double TongLuong()
        {
            double luong = 0;
            for (int i = 0; i<this.dssx.Length; i++)
            {
                luong += this.dssx[i].TinhLuong();
            }
            for (int i = 0; i < this.dsvp.Length; i++)
            {
                luong += this.dsvp[i].TinhLuong();
            }
            return luong;
        }
    }
}
