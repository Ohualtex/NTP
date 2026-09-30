using System;

namespace Hafta1_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HAFTA 1 ÖDEVİ: EN YÜKSEK ORTALAMALI ÖĞRENCİ TESPİTİ ===");
            Console.WriteLine();

            // 1. Öğrenci nesnesi
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

            // 2. Öğrenci nesnesi
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

            // 3. Öğrenci nesnesi
            Console.WriteLine(">> 3. Öğrenci Bilgilerini Giriniz:");
            Ogrenci ogr3 = new Ogrenci();
            Console.Write("Ad: ");
            ogr3.Ad = Console.ReadLine() ?? string.Empty;
            Console.Write("Soyad: ");
            ogr3.Soyad = Console.ReadLine() ?? string.Empty;
            Console.Write("Numara: ");
            ogr3.Numara = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Vize: ");
            ogr3.Vize = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Final: ");
            ogr3.Final = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine();

            // Tüm öğrencileri listeleme
            Console.WriteLine("--- KAYITLI ÖĞRENCİLERİN NOT DURUMU ---");
            Console.WriteLine();

            Console.WriteLine("[1. Öğrenci]");
            ogr1.BilgiYazdir();
            Console.WriteLine($"Ortalama: {ogr1.OrtalamaHesapla()}");
            Console.WriteLine();

            Console.WriteLine("[2. Öğrenci]");
            ogr2.BilgiYazdir();
            Console.WriteLine($"Ortalama: {ogr2.OrtalamaHesapla()}");
            Console.WriteLine();

            Console.WriteLine("[3. Öğrenci]");
            ogr3.BilgiYazdir();
            Console.WriteLine($"Ortalama: {ogr3.OrtalamaHesapla()}");
            Console.WriteLine();

            // En yüksek ortalamayı bulma algoritması
            Ogrenci enBasarili = ogr1;

            if (ogr2.OrtalamaHesapla() > enBasarili.OrtalamaHesapla())
            {
                enBasarili = ogr2;
            }

            if (ogr3.OrtalamaHesapla() > enBasarili.OrtalamaHesapla())
            {
                enBasarili = ogr3;
            }

            // Sonucu ekrana yazdırma
            Console.WriteLine("========================================");
            Console.WriteLine("🏆 EN YÜKSEK ORTALAMAYA SAHİP ÖĞRENCİ");
            Console.WriteLine("========================================");
            enBasarili.BilgiYazdir();
            Console.WriteLine($"En Yüksek Ortalama: {enBasarili.OrtalamaHesapla()}");
        }
    }
}
