using System;

namespace Hafta5_Evim
{
    class Kisi
    {
        // 3. Görev: Ev adresini tutan const alan (sınıf üzerinden erişilir)
        public const string EvAdresi = "Atatürk Mah. Karanfil Sok. No: 12/3 Kadıköy / İstanbul";

        // Statik sayaç: Tüm nesneler için ortak, her yeni kişi oluşturulduğunda artar
        public static int KisiSayisi = 0;

        private int dogumYili;
        private string meslek = string.Empty;

        // Auto-property
        public string Ad { get; set; } = string.Empty;

        // Doğrulamalı Property: Doğum yılı 1900 ile mevcut yıl arasında olmalı
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
                    Console.WriteLine($"[Uyarı] Geçersiz doğum yılı ({value})! 1900 ile {DateTime.Now.Year} arasında olmalıdır.");
                }
            }
        }

        // 1. Görev: Meslek doğrulamalı property (boş veya boşluklu ise "Belirtilmedi" atanır)
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

        // Yapıcı Metot (Constructor): Başlangıç değerlerini atar ve sayaç artırır
        public Kisi(string ad, int dogumYili, string meslek)
        {
            Ad = ad;
            DogumYili = dogumYili; // Property set bloğundan geçer (doğrulama tetiklenir)
            Meslek = meslek;       // Property set bloğundan geçer (boşluk kontrolü tetiklenir)
            KisiSayisi++;          // Her yeni kişi nesnesi oluştukça statik sayaç 1 artar
        }

        // Nesneye ait metot: Doğum yılından güncel yaşı hesaplar
        public int YasHesapla()
        {
            return DateTime.Now.Year - dogumYili;
        }

        // Nesneye ait metot: Kişi bilgilerini ve hesaplanan yaşını ekrana basar
        public void BilgiYaz()
        {
            Console.WriteLine($"{Ad} - {Meslek} - {YasHesapla()} yaşında");
        }
    }
}

