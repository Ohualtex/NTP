using System;

namespace Odev_YapiciAsiriYukleme
{
    class Kisi
    {
        public static int KisiSayisi = 0;

        private int dogumYili;
        private string meslek = string.Empty;

        public string Ad { get; set; } = string.Empty;

        public int DogumYili
        {
            get { return dogumYili; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                {
                    dogumYili = value;
                }
                else
                {
                    dogumYili = DateTime.Now.Year; // Hatalı veya tanımsız girişte güvenli varsayılan
                }
            }
        }

        public string Meslek
        {
            get { return meslek; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    meslek = "Belirtilmedi";
                }
                else
                {
                    meslek = value.Trim();
                }
            }
        }

        // 1. Aşırı Yüklenmiş Yapıcı Metot: Yalnızca 'Ad' alır (varsayılan doğum yılı ve meslek ile)
        public Kisi(string ad) : this(ad, DateTime.Now.Year, "Belirtilmedi")
        {
        }

        // 2. Aşırı Yüklenmiş Yapıcı Metot: 'Ad' ve 'DogumYili' alır (varsayılan meslek ile)
        public Kisi(string ad, int dogumYili) : this(ad, dogumYili, "Belirtilmedi")
        {
        }

        // 3. Aşırı Yüklenmiş Yapıcı Metot: Tam parametreli yapıcı (Constructor Chaining hedefi)
        public Kisi(string ad, int dogumYili, string meslek)
        {
            Ad = ad;
            DogumYili = dogumYili;
            Meslek = meslek;
            KisiSayisi++;
        }

        public int YasHesapla()
        {
            return DateTime.Now.Year - dogumYili;
        }

        public void BilgiYaz()
        {
            Console.WriteLine($"{Ad} - {Meslek} - {YasHesapla()} yaşında (Doğum Yılı: {dogumYili})");
        }
    }
}

