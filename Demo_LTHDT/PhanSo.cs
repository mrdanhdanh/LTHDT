using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_LTHDT
{
    class PhanSo
    {
        private int TuSo;
        private int MauSo;
        public string Mau_So
        {
            get
            {
                return this.MauSo.ToString();
            }
            set
            {

                bool isNum = int.TryParse(value, out int n);
                if (isNum == false)
                {
                    throw new Exception("Mau so phai la so");
                }
                else
                {
                    int nvalue = int.Parse(value);
                    if (nvalue != 0)
                    {
                        this.MauSo = nvalue;
                    }
                    else
                    {
                        throw new Exception("Mau so phai khac 0");
                    }
                }
            }
        }

        public PhanSo() //Dùng để tạo giá trị mặc định cho đôi tượng
        {
            this.TuSo = 0;
            this.MauSo = 1;
        }
        public PhanSo(int a, string b) {
            try
            {
                this.TuSo = a;
                this.Mau_So = b;
            }
            catch (Exception e)
            {
                Console.WriteLine("Co loi: " + e.Message);
                NhapEr();
            }
            

        }
        private void NhapEr()
        {
            try
            {
                Console.WriteLine("Vui long nhap lai mau so:");
                this.Mau_So = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Co loi: " + e.Message);
                NhapEr();
            }

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
