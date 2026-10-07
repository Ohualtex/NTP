using System;

namespace Odev_BankaHesabi
{
    class Hesap
    {
        // Field'lar (dışarıdan doğrudan erişilemez)
        private double bakiye;
        private double faizOrani;

        // Property'ler
        public string HesapNo { get; }
        public string SahipAdi { get; set; } = string.Empty;

        // Salt-okunur property
        public double Bakiye
        {
            get { return bakiye; }
        }

        // Doğrulamalı property
        public double FaizOrani
        {
            get { return faizOrani; }
            set
            {
                if (value >= 0)
                {
                    faizOrani = value;
                }
                else
                {
                    Console.WriteLine("Hata: Faiz oranı negatif olamaz!");
                }
            }
        }

        // Constructor (Yapıcı Metot)
        public Hesap(string sahipAdi, string hesapNo, double baslangicBakiye)
        {
            SahipAdi = sahipAdi;
            HesapNo = hesapNo;
            bakiye = baslangicBakiye >= 0 ? baslangicBakiye : 0;
        }

        // Para Yatırma
        public void ParaYatir(double tutar)
        {
            if (tutar <= 0)
            {
                Console.WriteLine("Hata: Yatırılacak tutar pozitif olmalı!");
                return;
            }

            bakiye += tutar;
            Console.WriteLine($"{SahipAdi} hesabına {tutar} TL yatırıldı. Yeni bakiye: {bakiye} TL");
        }

        // Para Çekme
        public void ParaCek(double tutar)
        {
            if (tutar <= 0)
            {
                Console.WriteLine("Hata: Çekilecek tutar pozitif olmalı!");
                return;
            }

            if (tutar > bakiye)
            {
                Console.WriteLine($"Hata: {SahipAdi} için yetersiz bakiye! (Mevcut: {bakiye} TL, İstenen: {tutar} TL)");
                return;
            }

            bakiye -= tutar;
            Console.WriteLine($"{SahipAdi} hesabından {tutar} TL çekildi. Yeni bakiye: {bakiye} TL");
        }

        // Nesneler Arası İlişki: Para Transferi Metodu (Bölüm 9 Ödevi)
        public void ParaTransferi(Hesap hedefHesap, double tutar)
        {
            if (hedefHesap == null)
            {
                Console.WriteLine("Hata: Hedef hesap bulunamadı!");
                return;
            }

            if (tutar <= 0)
            {
                Console.WriteLine("Hata: Transfer tutarı pozitif olmalıdır!");
                return;
            }

            if (tutar > bakiye)
            {
                Console.WriteLine($"Hata: Transfer için yetersiz bakiye! ({SahipAdi} bakiyesi: {bakiye} TL, Transfer tutarı: {tutar} TL)");
                return;
            }

            // Kendi bakiyesinden düşer ve hedef hesaba aktarır
            bakiye -= tutar;
            hedefHesap.ParaYatir(tutar);
            Console.WriteLine($"İşlem Özeti: {SahipAdi} -> {hedefHesap.SahipAdi} hesabına {tutar} TL transfer edildi.");
        }
    }
}
