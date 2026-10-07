using System;

namespace Lab_BankaHesabi
{
    class Hesap
    {
        // Field'lar (dışarıdan doğrudan erişilemez)
        private double bakiye;
        private double faizOrani;

        // Property'ler
        public string HesapNo { get; }
        public string SahipAdi { get; set; } = string.Empty;

        // Salt-okunur property (bakiye dışarıdan yalnızca okunabilir)
        public double Bakiye
        {
            get { return bakiye; }
        }

        // Doğrulamalı property (negatif faiz oranı engellenir)
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

        // Para Yatırma Metodu
        public void ParaYatir(double tutar)
        {
            if (tutar <= 0)
            {
                Console.WriteLine("Hata: Yatırılacak tutar pozitif olmalı!");
                return;
            }

            bakiye += tutar;
            Console.WriteLine($"{tutar} TL yatırıldı. Yeni bakiye: {bakiye} TL");
        }

        // Para Çekme Metodu
        public void ParaCek(double tutar)
        {
            if (tutar <= 0)
            {
                Console.WriteLine("Hata: Çekilecek tutar pozitif olmalı!");
                return;
            }

            if (tutar > bakiye)
            {
                Console.WriteLine("Hata: Yetersiz bakiye!");
                return;
            }

            bakiye -= tutar;
            Console.WriteLine($"{tutar} TL çekildi. Yeni bakiye: {bakiye} TL");
        }
    }
}
