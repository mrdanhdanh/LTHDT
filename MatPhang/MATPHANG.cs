using System;
using System.Collections.Generic;
using System.Text;

namespace MatPhang
{
    class MATPHANG
    {
        private HINHTRON[] dshtron;
        private HINHCHUNHAT[] dshcn;

        public void Nhap()
        {
            Console.WriteLine("Nhap so hinh tron");
            int n = int.Parse(Console.ReadLine());
            this.dshtron = new HINHTRON[n];
            for (int i = 0; i < n; i++)
            {
                this.dshtron[i] = new HINHTRON();
                this.dshtron[i].Nhap($"Nhap thogn tin hinh trong thu {i+1}");
            }
        }

        public double ChuViTong()
        {
            double P = 0;
            for (int i=0; i<this.dshtron.Length; i++)
            {
                P += this.dshtron[i].ChuVi();
            }
            return P;
        }
    }
}
