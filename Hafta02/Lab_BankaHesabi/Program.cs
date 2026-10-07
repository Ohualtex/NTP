using System;

namespace Lab_BankaHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HAFTA 2: KAPSÜLLEME (BANKA HESABI UYGULAMASI) ===");
            Console.WriteLine();

            // 1. Hesap Nesnesi
            Hesap hesap1 = new Hesap("Ayşe Yılmaz", "TR1001", 500);
            Console.WriteLine($"[Hesap 1]");
            Console.WriteLine($"Hesap Sahibi : {hesap1.SahipAdi}");
            Console.WriteLine($"Hesap No     : {hesap1.HesapNo}");
            Console.WriteLine($"İlk Bakiye   : {hesap1.Bakiye} TL");
            Console.WriteLine();

            // FaizOrani doğrulaması testi
            Console.WriteLine("--- Faiz Oranı Belirleme Testi ---");
            hesap1.FaizOrani = 12.5;
            Console.WriteLine($"Geçerli Faiz Oranı: %{hesap1.FaizOrani}");
            hesap1.FaizOrani = -5.0; // Negatif faiz oranı -> Uyarı vermeli
            Console.WriteLine($"Son Faiz Oranı: %{hesap1.FaizOrani}");
            Console.WriteLine();

            // 1. Hesap İşlemleri
            Console.WriteLine("--- Hesap 1 İşlemleri ---");
            hesap1.ParaYatir(250);
            hesap1.ParaCek(1000); // Yetersiz bakiye -> Uyarı vermeli
            hesap1.ParaCek(300);
            Console.WriteLine();

            // 2. Hesap Nesnesi
            Hesap hesap2 = new Hesap("Mehmet Demir", "TR1002", 1200);
            Console.WriteLine($"[Hesap 2]");
            Console.WriteLine($"Hesap Sahibi : {hesap2.SahipAdi}");
            Console.WriteLine($"Hesap No     : {hesap2.HesapNo}");
            Console.WriteLine($"İlk Bakiye   : {hesap2.Bakiye} TL");
            Console.WriteLine();

            // 2. Hesap İşlemleri
            Console.WriteLine("--- Hesap 2 İşlemleri ---");
            hesap2.ParaYatir(400);
            hesap2.ParaYatir(-100); // Geçersiz negatif tutar -> Uyarı vermeli
            hesap2.ParaCek(500);
            Console.WriteLine();

            // Kapsülleme Kanıtı (Derleme hatası verir, açıklama olarak belirtildi)
            // hesap1.bakiye = 1000000; // HATA: 'Hesap.bakiye' private olduğu için erişilemez.

            // Son Bakiye Raporu
            Console.WriteLine("========================================");
            Console.WriteLine("📌 GÜNCEL HESAP BAKİYELERİ RAPORU");
            Console.WriteLine("========================================");
            Console.WriteLine($"Hesap 1 ({hesap1.SahipAdi} - {hesap1.HesapNo}): {hesap1.Bakiye} TL");
            Console.WriteLine($"Hesap 2 ({hesap2.SahipAdi} - {hesap2.HesapNo}): {hesap2.Bakiye} TL");
        }
    }
}
