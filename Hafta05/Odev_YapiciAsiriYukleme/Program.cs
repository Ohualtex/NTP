using System;
using System.Collections.Generic;

namespace Odev_YapiciAsiriYukleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HAFTA 5: HAZIRLIK ÖDEVİ (YAPICI METOT AŞIRI YÜKLEMESİ - CONSTRUCTOR OVERLOADING) ===");
            Console.WriteLine();

            // 1. Yapıcı (Sadece Ad): Doğum yılı = 2026, Meslek = "Belirtilmedi"
            Kisi kisi1 = new Kisi("Ali");

            // 2. Yapıcı (Ad + Doğum Yılı): Meslek = "Belirtilmedi"
            Kisi kisi2 = new Kisi("Zeynep", 2002);

            // 3. Yapıcı (Ad + Doğum Yılı + Meslek): Tam parametreli
            Kisi kisi3 = new Kisi("Kemal", 1995, "Avukat");

            List<Kisi> kisiler = new List<Kisi> { kisi1, kisi2, kisi3 };

            Console.WriteLine("--- OLUŞTURULAN KİŞİLER (FARKLI CONSTRUCTOR İMZALARI) ---");
            foreach (var k in kisiler)
            {
                k.BilgiYaz();
            }
            Console.WriteLine();

            Console.WriteLine("--- STATİK SAYAÇ DOĞRULAMASI ---");
            Console.WriteLine($"Toplam Üretilen Kişi Sayısı : {Kisi.KisiSayisi}");
            Console.WriteLine();

            Console.WriteLine("==================================================");
            Console.WriteLine("📌 PEDAGOJİK KAZANIM NOTU:");
            Console.WriteLine("Aynı isimli fakat farklı parametre listelerine sahip yapıcı");
            Console.WriteLine("metotlar (Constructor Overloading) ile nesnelerin farklı");
            Console.WriteLine("ihtiyaçlara göre esnek biçimde oluşturulması sağlandı.");
            Console.WriteLine("Constructor Chaining (: this(...)) tekniği ile kod tekrarı");
            Console.WriteLine("önlenerek tüm atamalar ve sayaç artışı tek noktada toplandı.");
            Console.WriteLine("==================================================");
        }
    }
}
