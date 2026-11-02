using System;

namespace Hafta5_Evim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HAFTA 5: SINIFLAR, YAPICI METOTLAR VE STATİK ÜYELER (EVİM) ===");
            Console.WriteLine();

            // 3. Görev: Const/statik alan olan EvAdresi bilgisini doğrudan sınıf adıyla yazdırma
            Console.WriteLine($"Ev Adresi (const) : {Kisi.EvAdresi}");
            Console.WriteLine();

            // Ev nesnesi oluşturma
            Ev evim = new Ev();

            // 4. Görev: En az 4 kişi nesnesi oluşturup eve ekleme
            // (1. Görevi doğrulamak için 'Kardeş' nesnesinin mesleği boş bırakılmıştır -> 'Belirtilmedi' atanır)
            evim.UyeEkle(new Kisi("Baba", 1968, "Mühendis"));
            evim.UyeEkle(new Kisi("Anne", 1972, "Öğretmen"));
            evim.UyeEkle(new Kisi("Ben", 2004, "Yazılımcı"));
            evim.UyeEkle(new Kisi("Kardeş", 2012, "")); // Boş meslek doğrulaması testi

            // Tüm ev üyelerini listeleme
            Console.WriteLine("--- EV ÜYELERİ LİSTESİ ---");
            evim.TumUyeleriYaz();
            Console.WriteLine();

            // Ortalama yaş, en yaşlı üye ve statik sayaç sonuçları
            Console.WriteLine("--- EV İSTATİSTİKLERİ ---");
            Console.WriteLine($"Ortalama Yaş       : {evim.OrtalamaYas():F1}");

            // 2. Görev: En yaşlı üyeyi bulup yazdırma
            Kisi? enYasliUye = evim.EnYasli();
            if (enYasliUye != null)
            {
                Console.WriteLine($"En Yaşlı Üye       : {enYasliUye.Ad} ({enYasliUye.YasHesapla()} yaşında - {enYasliUye.Meslek})");
            }

            // Statik üyeye sınıf üzerinden erişim
            Console.WriteLine($"Toplam Kişi Sayısı : {Kisi.KisiSayisi} (Kisi.KisiSayisi statik sayaç)");
        }
    }
}
