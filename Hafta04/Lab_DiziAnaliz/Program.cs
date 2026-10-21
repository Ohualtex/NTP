using System;

namespace Hafta4_DiziAnaliz
{
    class Program
    {
        // Adım B: Diziyi ekrana tek satırda yazdıran metot
        static void DiziYaz(int[] dizi)
        {
            foreach (int x in dizi)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        // Adım C: Dizinin aritmetik ortalamasını hesaplayan metot
        static double Ortalama(int[] dizi)
        {
            int toplam = 0;
            foreach (int x in dizi)
            {
                toplam += x;
            }
            // (double) cast ile tamsayı bölmesi engellenir
            return (double)toplam / dizi.Length;
        }

        // Adım C: Dizideki en büyük elemanı bulan metot
        static int EnBuyuk(int[] dizi)
        {
            int enB = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > enB)
                {
                    enB = dizi[i];
                }
            }
            return enB;
        }

        // Adım C: Dizideki en küçük elemanı bulan metot
        static int EnKucuk(int[] dizi)
        {
            int enK = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < enK)
                {
                    enK = dizi[i];
                }
            }
            return enK;
        }

        // 5. Görev 1: Ortalamanın üzerinde kaç eleman olduğunu bulan metot
        static int OrtalamaUstu(int[] dizi)
        {
            double ort = Ortalama(dizi);
            int sayac = 0;
            foreach (int x in dizi)
            {
                if (x > ort)
                {
                    sayac++;
                }
            }
            return sayac;
        }

        // 5. Görev 2: params anahtar sözcüğü ile değişken sayıda parametre toplayan metot
        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (int s in sayilar)
            {
                toplam += s;
            }
            return toplam;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== HAFTA 4: DİZİLER VE METOTLAR (SAYI DİZİSİ ANALİZ ARACI) ===");
            Console.WriteLine();

            // Adım A: 10 elemanlı dizi oluşturup Random ile 1-100 arası rastgele sayılarla doldurma
            Random rnd = new Random();
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 101); // 1 dahil, 101 hariç (1-100 arası)
            }

            // 1. Orijinal Diziyi Yazdırma
            Console.Write("Dizi: ");
            DiziYaz(sayilar);
            Console.WriteLine();

            // 2. Temel İstatistiksel Hesaplamalar
            double ortalamaDeger = Ortalama(sayilar);
            int enBuyukDeger = EnBuyuk(sayilar);
            int enKucukDeger = EnKucuk(sayilar);
            int ortalamaUstuAdet = OrtalamaUstu(sayilar);

            Console.WriteLine("--- DİZİ İSTATİSTİKLERİ ---");
            Console.WriteLine($"Ortalama        : {ortalamaDeger:F2}");
            Console.WriteLine($"En büyük        : {enBuyukDeger}");
            Console.WriteLine($"En küçük        : {enKucukDeger}");
            Console.WriteLine($"Ortalama üstü   : {ortalamaUstuAdet} adet eleman");
            Console.WriteLine();

            // 3. Array.Sort ile Küçükten Büyüğe Sıralama
            Array.Sort(sayilar);
            Console.Write("Sıralı dizi (A-Z)       : ");
            DiziYaz(sayilar);

            // 4. Array.Reverse ile Ters Çevirme (Büyükten Küçüğe Sıralama)
            Array.Reverse(sayilar);
            Console.Write("Ters çevrilmiş dizi (Z-A): ");
            DiziYaz(sayilar);
            Console.WriteLine();

            // 5. params Metot Testleri
            Console.WriteLine("--- PARAMS METOT KULLANIMI ---");
            int toplam1 = Topla(5, 10);
            int toplam2 = Topla(1, 2, 3, 4);
            int toplam3 = Topla(10, 20, 30, 40, 50);

            Console.WriteLine($"Topla(5, 10)                 => {toplam1}");
            Console.WriteLine($"Topla(1, 2, 3, 4)            => {toplam2}");
            Console.WriteLine($"Topla(10, 20, 30, 40, 50)    => {toplam3}");
        }
    }
}
