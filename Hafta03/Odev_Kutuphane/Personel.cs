using System;

namespace Odev_Kutuphane
{
    // Kisi sınıfından türeyen Personel sınıfı (Bölüm 8 Gelecek Haftaya Hazırlık)
    class Personel : Kisi
    {
        public int PersonelNo { get; set; }
        public string Departman { get; set; } = string.Empty;

        public Personel(string ad, int personelNo, string departman) : base(ad)
        {
            PersonelNo = personelNo;
            Departman = departman;
        }

        public override void BilgiYazdir()
        {
            Console.WriteLine($"Personel: {Ad} (No: {PersonelNo}, Görev: {Departman})");
        }
    }
}
