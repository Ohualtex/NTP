using System;

namespace Hafta1_OgrenciKayit
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Programın başında başlık yazdırma
            Console.WriteLine("--- ÖĞRENCİ KAYIT SİSTEMİ ---");
            Console.WriteLine();

            // 1. Öğrenci nesnesi (ogr1) oluşturma ve kullanıcıdan veri alma
            Console.WriteLine(">> 1. Öğrenci Bilgilerini Giriniz:");
            Ogrenci ogr1 = new Ogrenci();

            Console.Write("Ad: ");
            ogr1.Ad = Console.ReadLine() ?? string.Empty;

            Console.Write("Soyad: ");
            ogr1.Soyad = Console.ReadLine() ?? string.Empty;

            Console.Write("Numara: ");
            ogr1.Numara = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Vize: ");
            ogr1.Vize = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Final: ");
            ogr1.Final = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine();

            // 1. Aynı sınıftan ikinci bir nesne (ogr2) üretme ve veri alma
            Console.WriteLine(">> 2. Öğrenci Bilgilerini Giriniz:");
            Ogrenci ogr2 = new Ogrenci();

            Console.Write("Ad: ");
            ogr2.Ad = Console.ReadLine() ?? string.Empty;

            Console.Write("Soyad: ");
            ogr2.Soyad = Console.ReadLine() ?? string.Empty;

            Console.Write("Numara: ");
            ogr2.Numara = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Vize: ");
            ogr2.Vize = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Final: ");
            ogr2.Final = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine();
            Console.WriteLine("--- KAYITLI ÖĞRENCİ BİLGİLERİ VE ORTALAMALAR ---");
            Console.WriteLine();

            // 2. Her iki öğrencinin de bilgilerini ve ortalamasını ekrana yazdırma
            Console.WriteLine("1. Öğrenci:");
            ogr1.BilgiYazdir();
            Console.WriteLine($"Ortalama: {ogr1.OrtalamaHesapla()}");

            Console.WriteLine();

            Console.WriteLine("2. Öğrenci:");
            ogr2.BilgiYazdir();
            Console.WriteLine($"Ortalama: {ogr2.OrtalamaHesapla()}");
        }
    }
}
