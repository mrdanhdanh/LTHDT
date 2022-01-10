using System;
using System.Collections.Generic;
using System.Text;

namespace MatPhang
{
    class MATPHANG
    {
        private List<HINH> dshinh;
        public void NhapMP()
        {
            Console.Write("Nhap so hinh: ");
            int n = int.Parse(Console.ReadLine());
            this.dshinh = new List<HINH>(n);

            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Ban muon nhap hinh nao (1: hinh tron | 2: hinh chu nhat): ");
                int l = int.Parse(Console.ReadLine());
                NhapHinh(l);
            }
        }

        private void NhapHinh(int l)
        {
            switch (l) {
                case 1:
                    {
                        HINH h = new HINHTRON();
                        h.Nhap("Nhap thong tin cho hinh tron: ");
                        this.dshinh.Add(h);
                        break;
                    }
                case 2:
                    {
                        HINH h = new HINHCHUNHAT();
                        h.Nhap("Nhap thong tin cho hinh chu nhat: ");
                        this.dshinh.Add(h);
                        break;
                    }
                default: 
                    {
                        Console.WriteLine("Vui long nhap lai: ");
                        int ll = int.Parse(Console.ReadLine());
                        NhapHinh(ll);
                        break;
                    }

            }
        }
        public double ChuViTong()
        {
            double P = 0;
            for (int i=0; i<this.dshinh.Count; i++)
            {
                P += this.dshinh[i].ChuVi();
            }
            return P;
        }
    }
}
