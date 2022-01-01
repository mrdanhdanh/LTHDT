using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_LTHDT
{
    class SinhVien
    {
        public string MSSV;
        public string HoTen;
        public int NamSinh;
        public int DToan;
        public int DVan;
        public int DAnh;

        public void NhapSV(string[] SV)
        {
            this.MSSV = SV[0];
            this.HoTen = SV[1];
            this.NamSinh = int.Parse(SV[2]);
            this.DToan = int.Parse(SV[3]);
            this.DVan = int.Parse(SV[4]);
            this.DAnh = int.Parse(SV[5]);
        }

        public void XuatSV()
        {
            Console.WriteLine($"Ma SV: {this.MSSV}, Ho va Ten; {this.HoTen}");
        }
    }
}
