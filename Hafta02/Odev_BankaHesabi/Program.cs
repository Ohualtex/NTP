using System;

namespace Odev_BankaHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HAFTA 2 ÖDEVİ: HESAPLAR ARASI PARA TRANSFERİ (COMPOSITION) ===");
            Console.WriteLine();

            // 1. Hesap Nesnelerinin Tanımlanması
            Hesap hesap1 = new Hesap("Ayşe Yılmaz", "TR1001", 800);
            Hesap hesap2 = new Hesap("Mehmet Demir", "TR1002", 200);

            Console.WriteLine("--- BAŞLANGIÇ HESAP DURUMLARI ---");
            Console.WriteLine($"Hesap 1 ({hesap1.SahipAdi} - {hesap1.HesapNo}): {hesap1.Bakiye} TL");
            Console.WriteLine($"Hesap 2 ({hesap2.SahipAdi} - {hesap2.HesapNo}): {hesap2.Bakiye} TL");
            Console.WriteLine();

            // Senaryo 1: Başarılı Para Transferi
            Console.WriteLine("--- Senaryo 1: Başarılı Transfer (Ayşe -> Mehmet: 300 TL) ---");
            hesap1.ParaTransferi(hesap2, 300);
            Console.WriteLine();

            // Senaryo 2: Yetersiz Bakiye ile Transfer Denemesi
            Console.WriteLine("--- Senaryo 2: Yetersiz Bakiye Testi (Ayşe -> Mehmet: 1000 TL) ---");
            hesap1.ParaTransferi(hesap2, 1000);
            Console.WriteLine();

            // Senaryo 3: Geçersiz Negatif Tutar Testi
            Console.WriteLine("--- Senaryo 3: Negatif Tutar Testi (Mehmet -> Ayşe: -50 TL) ---");
            hesap2.ParaTransferi(hesap1, -50);
            Console.WriteLine();

            // Son Durum Raporu
            Console.WriteLine("========================================");
            Console.WriteLine("📌 TRANSFERLER SONRASI GÜNCEL BAKİYELER");
            Console.WriteLine("========================================");
            Console.WriteLine($"Hesap 1 ({hesap1.SahipAdi} - {hesap1.HesapNo}): {hesap1.Bakiye} TL");
            Console.WriteLine($"Hesap 2 ({hesap2.SahipAdi} - {hesap2.HesapNo}): {hesap2.Bakiye} TL");
        }
    }
}
