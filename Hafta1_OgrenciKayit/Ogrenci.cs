using System;

namespace Hafta1_OgrenciKayit
{
    class Ogrenci
    {
        // Field'lar (nesnenin verisi)
        public string Ad = string.Empty;
        public string Soyad = string.Empty;
        public int Numara;
        public double Vize;
        public double Final;

        // Method (nesnenin davranışı)
        public void BilgiYazdir()
        {
            Console.WriteLine($"No: {Numara} | {Ad} {Soyad}");
            Console.WriteLine($"Vize: {Vize}, Final: {Final}");
        }

        public double OrtalamaHesapla()
        {
            return Vize * 0.4 + Final * 0.6;
        }
    }
}
