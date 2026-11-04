using System;

namespace Odev_KesirGelismis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HAFTA 6: HAZIRLIK ÖDEVİ (GELİŞMİŞ KESİR İŞLEMLERİ & EBOB SADELEŞTİRME) ===");
            Console.WriteLine();

            Kesir k1 = new Kesir(3, 4);
            Kesir k2 = new Kesir(1, 2);

            Console.WriteLine($"1. Kesir (k1): {k1}");
            Console.WriteLine($"2. Kesir (k2): {k2}");
            Console.WriteLine();

            // 1. Dört İşlem Operatör Testleri
            Console.WriteLine("--- DÖRT İŞLEM OPERATÖR SONUÇLARI ---");
            Kesir toplam = k1 + k2;
            Kesir fark = k1 - k2;
            Kesir carpim = k1 * k2;
            Kesir bolum = k1 / k2;

            Console.WriteLine($"Toplama (k1 + k2) : {toplam,-8} => Sadeleştirilmiş: {toplam.Sadelestir()}");
            Console.WriteLine($"Çıkarma (k1 - k2) : {fark,-8} => Sadeleştirilmiş: {fark.Sadelestir()}");
            Console.WriteLine($"Çarpma  (k1 * k2) : {carpim,-8} => Sadeleştirilmiş: {carpim.Sadelestir()}");
            Console.WriteLine($"Bölme   (k1 / k2) : {bolum,-8} => Sadeleştirilmiş: {bolum.Sadelestir()}");
            Console.WriteLine();

            // 2. Özel Sadeleştirme ve Eşitlik Testi
            Console.WriteLine("--- EBOB İLE SADELEŞTİRME VE EŞİTLİK TESTİ ---");
            Kesir ornek = new Kesir(12, 16);
            Console.WriteLine($"Orijinal Kesir : {ornek} => Sade Hali (EBOB: 4): {ornek.Sadelestir()}");

            Kesir k3 = new Kesir(2, 4);
            Kesir k4 = new Kesir(1, 2);
            Console.WriteLine($"2/4 ile 1/2 eşit mi? (k3 == k4) : {k3 == k4}");
            Console.WriteLine($"2/4'ün sade hali               : {k3.Sadelestir()}");
            Console.WriteLine();

            Console.WriteLine("==================================================");
            Console.WriteLine("📌 PEDAGOJİK KAZANIM NOTU:");
            Console.WriteLine("C# dilinde operatör aşırı yükleme (operator overloading) sayesinde");
            Console.WriteLine("matematiksel nesneler standart aritmetik sembollerle (+, -, *, /)");
            Console.WriteLine("doğrudan ve sezgisel biçimde hesaplanabilmektedir.");
            Console.WriteLine("Öklid EBOB algoritması ile sonuçlar en sade rasyonel forma dönüştürülmüştür.");
            Console.WriteLine("==================================================");
        }
    }
}
