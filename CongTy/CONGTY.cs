using System;
using System.Collections.Generic;
using System.Text;

namespace CongTy
{
    class CONGTY
    {
        private string tencty;
        private List<NHANVIEN> dsnv;

        public CONGTY()
        {

        }
        public CONGTY(string tencty, List<NHANVIEN> dsnv)
        {
            this.tencty = tencty;
            this.dsnv = dsnv;
        }

        public void NhapCT()
        {
            Console.WriteLine("Nhap ten cong ty: ");
            this.tencty = Console.ReadLine();
            Console.WriteLine("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            this.dsnv = new List<NHANVIEN>(n);
            
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Chon loai nhan vien (1: NVSX, 2: NVVP): ");
                int l = int.Parse(Console.ReadLine());
                NhapNV(l);
            }
        }
        private void NhapNV(int l)
        {
            switch (l)
            {
                case 1:
                    {
                        NHANVIEN nv = new NVSX();
                        nv.Nhap();
                        this.dsnv.Add(nv);
                        break;
                    }
                case 2:
                    {
                        NHANVIEN nv = new NVVP();
                        nv.Nhap();
                        this.dsnv.Add(nv);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        public double TongLuong()
        {
            double luong = 0;
            for (int i = 0; i < this.dsnv.Count; i++) {
                luong += this.dsnv[i].TinhLuong();
            }
            return luong;
        }
    }
}
