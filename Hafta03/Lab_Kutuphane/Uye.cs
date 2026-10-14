using System;

namespace Lab_Kutuphane
{
    class Uye
    {
        public string Ad { get; set; } = string.Empty;
        public int UyeNo { get; set; }

        public Uye(string ad, int uyeNo)
        {
            Ad = ad;
            UyeNo = uyeNo;
        }
    }
}
