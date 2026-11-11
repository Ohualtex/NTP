using System;
using System.Text;
using MatematikKutuphane.Temel;         // Temel alt isim alanı
using MatematikKutuphane.SayiTeorisi;   // Sayı teorisi alt isim alanı

namespace AnaProje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== HAFTA 7: HAZIRLIK ÖDEVİ (BÜYÜTÜLMÜŞ KÜTÜPHANE & ASALLIK TESTİ) ===");
            Console.WriteLine();

            // 1. Ödev Görevi: 1-20 arası sayıların AsalMi(int n) ile kontrolü
            Console.WriteLine("--- 1. 1-20 ARASI SAYILARIN ASALLIK DURUMU (SayiTeorisi.AsalMi) ---");
            for (int i = 1; i <= 20; i++)
            {
                bool asal = SayiAnalizi.AsalMi(i);
                string durum = asal ? "Asal" : "Asal Değil";
                Console.WriteLine($"{i,2} -> {durum,-10} (AsalMi({i,2}) = {asal})");
            }

            int[] asallar = SayiAnalizi.AraliktakiAsallar(1, 20);
            Console.WriteLine();
            Console.WriteLine($"1-20 Arası Asal Sayılar ({asallar.Length} adet): {string.Join(", ", asallar)}");
            Console.WriteLine();

            // 2. Kütüphane Modülerliği: Temel ve İleri alt isim alanlarının birlikte kullanımı
            Console.WriteLine("--- 2. ALT İSİM ALANLARI İLE MODÜLER KÜTÜPHANE DOĞRULAMASI ---");
            Console.WriteLine($"[Temel] Topla(7, 5)          = {TemelIslemler.Topla(7, 5)}");
            Console.WriteLine($"[Temel] Us(2, 6)             = {TemelIslemler.Us(2, 6)}");
            Console.WriteLine($"[Temel] Faktoriyel(5)        = {TemelIslemler.Faktoriyel(5)}");
            Console.WriteLine($"[İleri] EBOB(42, 56)         = {MatematikKutuphane.Ileri.BilimselIslemler.Ebob(42, 56)}");
            Console.WriteLine($"[İleri] EKOK(12, 18)         = {MatematikKutuphane.Ileri.BilimselIslemler.Ekok(12, 18)}");
            Console.WriteLine($"[İleri] Fibonacci(10)        = {MatematikKutuphane.Ileri.BilimselIslemler.Fibonacci(10)}");
        }
    }
}
