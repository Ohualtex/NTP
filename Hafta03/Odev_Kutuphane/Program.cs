using System;

namespace Odev_Kutuphane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HAFTA 3 ÖDEVİ: KALITIM & COMPOSITION DESTEKLİ KÜTÜPHANE SİSTEMİ ===");
            Console.WriteLine();

            // 1. Ortak Üst Sınıf (Kisi) ve Kalıtım Deneyimi
            Console.WriteLine("--- 1. Kalıtım (Inheritance) Gösterimi: Kişi, Üye ve Personel ---");
            Personel sorumlu = new Personel("Fatma Yıldız", 501, "Kütüphane Uzmanı");
            Uye uye1 = new Uye("Ahmet Yılmaz", 1001);
            Uye uye2 = new Uye("Zeynep Kaya", 1002);

            // Ortak ata sınıftan gelen özellikleri listeleme
            Kisi[] kisiler = new Kisi[] { sorumlu, uye1, uye2 };
            foreach (Kisi k in kisiler)
            {
                k.BilgiYazdir();
            }
            Console.WriteLine();

            // 2. Kütüphane Kurulumu ve Composition
            Console.WriteLine("--- 2. Kütüphane Nesnesi ve Sorumlu Personel (Composition) ---");
            Kutuphane kutuphane = new Kutuphane(sorumlu);

            // Method Overloading ile Kitap Ekleme
            kutuphane.KitapEkle("Nutuk", "Mustafa Kemal Atatürk");
            kutuphane.KitapEkle(new Kitap("İnce Memed", "Yaşar Kemal"));
            kutuphane.KitapEkle("Dönüşüm", "Franz Kafka");
            kutuphane.KitapEkle(new Kitap("Saatleri Ayarlama Enstitüsü", "Ahmet Hamdi Tanpınar"));
            Console.WriteLine("4 kitap envantere eklendi.\n");

            // Kütüphane Başlangıç Durumu
            kutuphane.KutuphaneBilgisiYazdir();

            // 3. Ödünç ve İade İşlemleri
            Console.WriteLine("--- 3. İşlem Senaryoları ---");
            kutuphane.OduncVer("Nutuk", uye1);
            kutuphane.OduncVer("Nutuk", uye2); // Zaten ödünçte kontrolü
            kutuphane.OduncVer("Bilinmeyen Kitap", uye1); // Olmayan kitap kontrolü
            kutuphane.OduncVer("Dönüşüm", uye2);

            Console.WriteLine("\n--- İade İşlemi ---");
            kutuphane.IadeAl("Nutuk");
            Console.WriteLine();

            // 4. Son Durum Raporu
            Console.WriteLine("========================================");
            Console.WriteLine("📌 GÜNCEL KÜTÜPHANE VE RAF DURUMU");
            Console.WriteLine("========================================");
            kutuphane.KitaplariListele();
            Console.WriteLine($"Toplam Raf Mevcudu: {kutuphane.RaftakiSayisi()} adet");
        }
    }
}
