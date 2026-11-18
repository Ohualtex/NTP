using System;
using System.Globalization;
using System.Text;

namespace Hafta8_MetinIstatistigi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("tr-TR");

            Console.WriteLine("=== HAFTA 8: HAZIRLIK ÖDEVİ (METİN İSTATİSTİĞİ ARACI) ===");
            Console.WriteLine();

            Console.WriteLine("Analiz edilecek paragrafı giriniz:");
            Console.Write("> ");
            string? paragraf = Console.ReadLine();

            Console.WriteLine();
            if (string.IsNullOrWhiteSpace(paragraf))
            {
                Console.WriteLine("Uyarı: Analiz edilecek geçerli bir metin girilmedi.");
                return;
            }

            MetinIstatistigi sonuc = MetinIstatistigi.AnalizEt(paragraf);

            Console.WriteLine("--- PARAGRAF İSTATİSTİK RAPORU ---");
            sonuc.Yazdir();
        }
    }
}
