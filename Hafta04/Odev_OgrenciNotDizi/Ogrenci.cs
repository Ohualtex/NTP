using System;

namespace Odev_OgrenciNotDizi
{
    class Ogrenci
    {
        // Alanlar (Fields)
        public string Ad = string.Empty;
        public string Soyad = string.Empty;
        public int Numara;
        public int[] Notlar = Array.Empty<int>();

        // Nesneye ait metot (Instance Method) - Notlar dizisinin ortalamasını hesaplar
        public double OrtalamaHesapla()
        {
            if (Notlar == null || Notlar.Length == 0)
            {
                return 0.0;
            }

            int toplam = 0;
            foreach (int not in Notlar)
            {
                toplam += not;
            }

            return (double)toplam / Notlar.Length;
        }

        // Nesneye ait yardımcı metot - En yüksek sınav notunu döndürür
        public int EnYuksekNot()
        {
            if (Notlar == null || Notlar.Length == 0)
            {
                return 0;
            }

            int enB = Notlar[0];
            for (int i = 1; i < Notlar.Length; i++)
            {
                if (Notlar[i] > enB)
                {
                    enB = Notlar[i];
                }
            }
            return enB;
        }

        // Nesneye ait formatlı bilgi yazdırma davranışı
        public void BilgiYazdir()
        {
            Console.WriteLine($"Öğrenci : {Numara} - {Ad} {Soyad}");
            Console.Write("Notlar  : ");
            if (Notlar != null && Notlar.Length > 0)
            {
                foreach (int n in Notlar)
                {
                    Console.Write(n + " ");
                }
            }
            else
            {
                Console.Write("Kayıtlı not bulunamadı");
            }
            Console.WriteLine();
            Console.WriteLine($"Ortalama: {OrtalamaHesapla():F2}");
            Console.WriteLine($"En Yüksek Not: {EnYuksekNot()}");
        }
    }
}
