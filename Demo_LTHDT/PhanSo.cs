using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_LTHDT
{
    class PhanSo
    {
        private int TuSo;
        private int MauSo;

        public PhanSo() //Dùng để tạo giá trị mặc định cho đôi tượng
        {
            this.TuSo = 0;
            this.MauSo = 1;
        }
        public PhanSo(int a, int b) {
            while (b==0) {
                Console.WriteLine("Mau so khong phu hop, vui long nhap lai");
                b = int.Parse(Console.ReadLine());
            }
            this.TuSo = a;
            this.MauSo = b;

        }
        public void Nhap(string ghichu)
        {
            Console.WriteLine(ghichu);
            Console.WriteLine("Nhap tu so: ");
            this.TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            this.MauSo = int.Parse(Console.ReadLine());
        }

        public static int USCLonNhat(int a, int b)
        {
            Boolean check = false;
            int c = a;
            while (check == false)
            {
                if (a % c == 0 && b % c == 0)
                {
                    check = true;
                    break;
                }
                else c--;
            }
            return c;
        }
        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq;
            kq = new PhanSo();
            kq.MauSo = this.MauSo * p.MauSo;
            kq.TuSo = this.MauSo * p.TuSo + p.MauSo * this.TuSo;
            int usc = USCLonNhat(kq.TuSo, kq.MauSo);
            kq.MauSo = kq.MauSo / usc;
            kq.TuSo = kq.TuSo / usc;
            return kq;
        }
        public void Xuat()
        {
            Console.WriteLine($"{this.TuSo}/{this.MauSo}");
        }
    }

    class Diem
    {
        public int x;
        public int y;

        public void Nhap(string ghichu)
        {
            Console.WriteLine(ghichu);
            Console.WriteLine("Nhap toa do X: ");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do Y: ");
            this.y = int.Parse(Console.ReadLine());
        }

        public double KhoangCach(Diem D)
        {
            return Math.Sqrt((this.x - D.x) * (this.x - D.x) + (this.y - D.y) * (this.y - D.y));
        }
    }
}
