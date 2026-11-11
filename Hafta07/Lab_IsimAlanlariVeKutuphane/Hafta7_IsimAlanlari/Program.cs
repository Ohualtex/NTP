using System;
using System.Text;
using BankaHesap = Bankacilik.Hesap; // Takma isim 1
using OyunHesap = Oyun.Hesap;       // Takma isim 2
using OkulHesap = Okul.Hesap;       // Takma isim 3 (Lab Görevi 1)
using MatematikKutuphane;             // Sınıf kütüphanesi (.dll) referansı

namespace Hafta7_IsimAlanlari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== HAFTA 7: İSİM ALANLARI, TAKMA İSİMLER VE KÜTÜPHANE (.DLL) ===");
            Console.WriteLine();

            // 1. Bölüm A & Lab Görevi 1: Aynı isimli (Hesap) üç farklı isim alanının alias ile kullanımı
            Console.WriteLine("--- 1. İSİM ALANLARI VE TAKMA İSİM (ALIAS) TESTLERİ ---");
            BankaHesap banka = new BankaHesap();
            banka.Bakiye = 1500;
            banka.Yaz();

            OyunHesap oyun = new OyunHesap();
            oyun.Puan = 350;
            oyun.Yaz();

            OkulHesap okul = new OkulHesap();
            okul.OgrenciAdi = "Miraç Duran";
            okul.Vize = 85;
            okul.Final = 92;
            okul.Yaz();
            Console.WriteLine();

            // 2. Bölüm B & Lab Görevi 2: MatematikKutuphane.dll Referans Kullanımı
            Console.WriteLine("--- 2. SINIF KÜTÜPHANESİ (MatematikKutuphane.dll) TESTLERİ ---");
            Console.WriteLine($"Topla(7, 5) = {Islemler.Topla(7, 5)}");
            Console.WriteLine($"5!          = {Islemler.Faktoriyel(5)}");
            Console.WriteLine($"Us(2, 5)    = {Islemler.Us(2, 5)}");
            Console.WriteLine($"Us(3, 4)    = {Islemler.Us(3, 4)}");
            Console.WriteLine();

            // 3. Lab Görevi 3: İç içe isim alanına tam adıyla (MatematikKutuphane.Ileri.SinifAdi) erişim
            Console.WriteLine("--- 3. İÇ İÇE İSİM ALANI (MatematikKutuphane.Ileri) TAM AD ERİŞİMİ ---");
            Console.WriteLine($"EBOB(24, 36)  = {MatematikKutuphane.Ileri.BilimselIslemler.Ebob(24, 36)}");
            Console.WriteLine($"EKOK(12, 18)  = {MatematikKutuphane.Ileri.BilimselIslemler.Ekok(12, 18)}");
            Console.WriteLine($"Fibonacci(8)  = {MatematikKutuphane.Ileri.BilimselIslemler.Fibonacci(8)}");
        }
    }
}
