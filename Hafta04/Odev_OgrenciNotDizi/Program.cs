using System;

namespace Odev_OgrenciNotDizi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HAFTA 4: HAZIRLIK ÖDEVİ (ÖĞRENCİ NOT DİZİSİ VE NESNE METOTLARI) ===");
            Console.WriteLine();

            // 1. Öğrenci Nesnesi Oluşturma
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Ad = "Ayşe";
            ogr1.Soyad = "Yılmaz";
            ogr1.Numara = 201;
            ogr1.Notlar = new int[] { 75, 85, 90, 80 };

            // 2. Öğrenci Nesnesi Oluşturma
            Ogrenci ogr2 = new Ogrenci();
            ogr2.Ad = "Mehmet";
            ogr2.Soyad = "Demir";
            ogr2.Numara = 202;
            ogr2.Notlar = new int[] { 60, 65, 70, 85, 95 };

            // Nesnelerin Kendi Metotlarını Çağırma
            Console.WriteLine("--- 1. ÖĞRENCİ RAPORU ---");
            ogr1.BilgiYazdir();
            Console.WriteLine();

            Console.WriteLine("--- 2. ÖĞRENCİ RAPORU ---");
            ogr2.BilgiYazdir();
            Console.WriteLine();

            // Sınıf İçi Dizi ve Nesne Metodu Avantajı Değerlendirmesi
            Console.WriteLine("==================================================");
            Console.WriteLine("📌 PEDAGOJİK KAZANIM NOTU:");
            Console.WriteLine("Static metotlara dışarıdan dizi göndermek yerine,");
            Console.WriteLine("dizi verisi 'Ogrenci' sınıfının bir alanı (field) yapılmış;");
            Console.WriteLine("'OrtalamaHesapla()' ve 'EnYuksekNot()' metotları nesnenin");
            Console.WriteLine("kendi verisi üzerinde çalışan nesne davranışlarına dönüştürülmüştür.");
            Console.WriteLine("==================================================");
        }
    }
}
