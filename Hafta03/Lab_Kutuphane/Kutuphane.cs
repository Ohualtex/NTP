using System;
using System.Collections.Generic;

namespace Lab_Kutuphane
{
    class Kutuphane
    {
        // Composition: Kutuphane bir Kitap listesine sahiptir (has-a)
        private List<Kitap> kitaplar = new List<Kitap>();

        // Overload 1: Hazır Kitap nesnesi ekle
        public void KitapEkle(Kitap kitap)
        {
            if (kitap != null)
            {
                kitaplar.Add(kitap);
            }
        }

        // Overload 2: Ad ve yazar alıp nesneyi metot içinde oluştur
        public void KitapEkle(string ad, string yazar)
        {
            kitaplar.Add(new Kitap(ad, yazar));
        }

        // Kitapları listeleme
        public void KitaplariListele()
        {
            Console.WriteLine("--- KİTAP LİSTESİ ---");
            foreach (Kitap k in kitaplar)
            {
                string durum = k.OduncteMi ? "(ödünçte)" : "(rafta)";
                Console.WriteLine($"• {k.Ad} - {k.Yazar} {durum}");
            }
            Console.WriteLine();
        }

        // Ödünç Verme (Üye ile etkileşim)
        public void OduncVer(string kitapAdi, Uye uye)
        {
            foreach (Kitap k in kitaplar)
            {
                if (k.Ad.Equals(kitapAdi, StringComparison.OrdinalIgnoreCase))
                {
                    if (k.OduncteMi)
                    {
                        Console.WriteLine($"Uyarı: '{k.Ad}' zaten ödünçte!");
                    }
                    else
                    {
                        k.OduncteMi = true;
                        Console.WriteLine($"İşlem: '{k.Ad}', {uye.Ad} adlı üyeye ödünç verildi.");
                    }
                    return;
                }
            }
            Console.WriteLine($"Hata: '{kitapAdi}' kütüphanede bulunamadı!");
        }

        // İade Alma
        public void IadeAl(string kitapAdi)
        {
            foreach (Kitap k in kitaplar)
            {
                if (k.Ad.Equals(kitapAdi, StringComparison.OrdinalIgnoreCase))
                {
                    if (!k.OduncteMi)
                    {
                        Console.WriteLine($"Bilgi: '{k.Ad}' zaten kütüphane rafında.");
                    }
                    else
                    {
                        k.OduncteMi = false;
                        Console.WriteLine($"İşlem: '{k.Ad}' başarıyla iade alındı.");
                    }
                    return;
                }
            }
            Console.WriteLine($"Hata: '{kitapAdi}' kütüphanede bulunamadı!");
        }

        // Bölüm 5 Görevi: Raftaki (ödünçte olmayan) kitap sayısını döndüren metot
        public int RaftakiSayisi()
        {
            int sayac = 0;
            foreach (Kitap k in kitaplar)
            {
                if (!k.OduncteMi)
                {
                    sayac++;
                }
            }
            return sayac;
        }
    }
}
