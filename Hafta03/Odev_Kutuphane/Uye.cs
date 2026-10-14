using System;

namespace Odev_Kutuphane
{
    // Kisi sınıfından türeyen Uye sınıfı
    class Uye : Kisi
    {
        public int UyeNo { get; set; }

        public Uye(string ad, int uyeNo) : base(ad)
        {
            UyeNo = uyeNo;
        }

        public override void BilgiYazdir()
        {
            Console.WriteLine($"Üye: {Ad} (Üye No: {UyeNo})");
        }
    }
}
