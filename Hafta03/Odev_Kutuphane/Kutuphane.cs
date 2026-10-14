using System;
using System.Collections.Generic;

namespace Odev_Kutuphane
{
    class Kutuphane
    {
        // Composition: Kutuphane bir Kitap listesine ve sorumlu bir personele sahiptir
        private List<Kitap> kitaplar = new List<Kitap>();
        public Personel? SorumluPersonel { get; set; }

        public Kutuphane(Personel? sorumluPersonel = null)
        {
            SorumluPersonel = sorumluPersonel;
        }

        // Method Overload 1
        public void KitapEkle(Kitap kitap)
        {
            if (kitap != null)
            {
                kitaplar.Add(kitap);
            }
        }

        // Method Overload 2
        public void KitapEkle(string ad, string yazar)
        {
            kitaplar.Add(new Kitap(ad, yazar));
        }

        public void KitaplariListele()
        {
            Console.WriteLine("--- KİTAPLAR LİSTESİ ---");
            foreach (Kitap k in kitaplar)
            {
                string durum = k.OduncteMi ? "(ödünçte)" : "(rafta)";
                Console.WriteLine($"• {k.Ad} - {k.Yazar} {durum}");
            }
            Console.WriteLine();
        }

        public void OduncVer(string kitapAdi, Uye uye)
        {
            foreach (Kitap k in kitaplar)
            {
                if (k.Ad.Equals(kitapAdi, StringComparison.OrdinalIgnoreCase))
                {
                    if (k.OduncteMi)
                    {
                        Console.WriteLine($"Uyarı: '{k.Ad}' zaten ödünç verilmiş durumda!");
                    }
                    else
                    {
                        k.OduncteMi = true;
                        string gorevli = SorumluPersonel != null ? $" (İşlemi Yapan Görevli: {SorumluPersonel.Ad})" : "";
                        Console.WriteLine($"İşlem: '{k.Ad}' kitabı {uye.Ad} adlı üyeye teslim edildi.{gorevli}");
                    }
                    return;
                }
            }
            Console.WriteLine($"Hata: '{kitapAdi}' kütüphane envanterinde bulunamadı!");
        }

        public void IadeAl(string kitapAdi)
        {
            foreach (Kitap k in kitaplar)
            {
                if (k.Ad.Equals(kitapAdi, StringComparison.OrdinalIgnoreCase))
                {
                    if (!k.OduncteMi)
                    {
                        Console.WriteLine($"Bilgi: '{k.Ad}' zaten rafta bulunmaktadır.");
                    }
                    else
                    {
                        k.OduncteMi = false;
                        Console.WriteLine($"İşlem: '{k.Ad}' kitabı kütüphaneye iade alındı.");
                    }
                    return;
                }
            }
            Console.WriteLine($"Hata: '{kitapAdi}' kütüphane envanterinde bulunamadı!");
        }

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

        public void KutuphaneBilgisiYazdir()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("🏢 KÜTÜPHANE VE YÖNETİM BİLGİSİ");
            Console.WriteLine("========================================");
            if (SorumluPersonel != null)
            {
                SorumluPersonel.BilgiYazdir();
            }
            Console.WriteLine($"Toplam Kitap Sayısı : {kitaplar.Count}");
            Console.WriteLine($"Raftaki Kitap Sayısı: {RaftakiSayisi()}");
            Console.WriteLine();
        }
    }
}
