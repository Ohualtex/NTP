using System;

namespace Lab_Kutuphane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HAFTA 3: KÜTÜPHANE OTOMASYONU (COMPOSITION & OVERLOADING) ===");
            Console.WriteLine();

            Kutuphane kutuphane = new Kutuphane();

            // 1. Kitap Ekleme (Her iki overload kullanılarak en az 4 kitap)
            Console.WriteLine("--- 1. Kitapların Eklenmesi (Method Overloading) ---");
            kutuphane.KitapEkle("Suç ve Ceza", "Dostoyevski");           // Overload 2: string, string
            kutuphane.KitapEkle(new Kitap("Sefiller", "Victor Hugo"));     // Overload 1: Kitap nesnesi
            kutuphane.KitapEkle("1984", "George Orwell");                 // Overload 2: string, string
            kutuphane.KitapEkle(new Kitap("Simyacı", "Paulo Coelho"));    // Overload 1: Kitap nesnesi
            Console.WriteLine("4 adet kitap kütüphaneye başarıyla kaydedildi.\n");

            // 2. Üyelerin Oluşturulması (2 Farklı Üye)
            Console.WriteLine("--- 2. Kütüphane Üyeleri ---");
            Uye uye1 = new Uye("Ayşe Yılmaz", 101);
            Uye uye2 = new Uye("Mehmet Demir", 102);
            Console.WriteLine($"Üye 1: {uye1.Ad} (No: {uye1.UyeNo})");
            Console.WriteLine($"Üye 2: {uye2.Ad} (No: {uye2.UyeNo})\n");

            // Başlangıç durumu ve raf sayısı
            kutuphane.KitaplariListele();
            Console.WriteLine($"Başlangıçta Raftaki Kitap Sayısı: {kutuphane.RaftakiSayisi()} adet\n");

            // 3. Ödünç Verme ve İade İşlemleri
            Console.WriteLine("--- 3. Ödünç Verme ve İade İşlemleri ---");

            // Başarılı ödünç verme
            kutuphane.OduncVer("Sefiller", uye1);

            // Zaten ödünçte olan kitabı tekrar ödünç verme denemesi (Uyarı testi)
            kutuphane.OduncVer("Sefiller", uye2);

            // Kütüphanede OLMAYAN bir kitabı ödünç verme denemesi (Hata testi)
            kutuphane.OduncVer("Kürk Mantolu Madonna", uye1);

            // İkinci bir kitabı farklı üyeye ödünç verme
            kutuphane.OduncVer("1984", uye2);

            // İade alma işlemi
            Console.WriteLine("\n--- İade İşlemi ---");
            kutuphane.IadeAl("Sefiller");

            Console.WriteLine();

            // 4. Güncel Kitap Listesi ve Raftaki Kitap Sayısı Raporu
            Console.WriteLine("========================================");
            Console.WriteLine("📌 İŞLEMLER SONRASI GÜNCEL KÜTÜPHANE RAPORU");
            Console.WriteLine("========================================");
            kutuphane.KitaplariListele();
            Console.WriteLine($"📊 Güncel Raftaki (Ödünçte Olmayan) Kitap Sayısı: {kutuphane.RaftakiSayisi()} adet");
        }
    }
}
