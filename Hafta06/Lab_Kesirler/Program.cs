using System;

namespace Hafta6_Kesirler
{
    class Program
    {
        // 3. Görev: Seçilen Islem enum değerine göre iki kesri toplayan veya çarpan metot
        static Kesir KesirIslemiYap(Kesir a, Kesir b, Islem islem)
        {
            switch (islem)
            {
                case Islem.Toplama:
                    return a + b;
                case Islem.Carpma:
                    return a * b;
                default:
                    throw new ArgumentException("Desteklenmeyen işlem türü!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== HAFTA 6: OPERATÖR AŞIRI YÜKLEME, İNDEKSLEYİCİLER, STRUCT VE ENUM ===");
            Console.WriteLine();

            // 1. Temel Operatör Testleri (Adım D)
            Console.WriteLine("--- 1. TEMEL OPERATÖR VE EŞİTLİK TESTLERİ ---");
            Kesir k1 = new Kesir(1, 2);
            Kesir k2 = new Kesir(1, 3);

            Console.Write("k1 = "); k1.Yaz();
            Console.Write("k2 = "); k2.Yaz();

            Console.Write("k1 + k2 = ");
            (k1 + k2).Yaz(); // 5/6

            Console.Write("k1 * k2 = ");
            (k1 * k2).Yaz(); // 1/6

            Console.WriteLine($"k1 == k2 ? {k1 == k2}"); // False

            Kesir k3 = new Kesir(2, 4);
            Kesir k4 = new Kesir(1, 2);
            Console.WriteLine($"2/4 == 1/2 ? {k3 == k4}"); // True (çapraz çarpım: 2*2 == 4*1)
            Console.WriteLine();

            // 2. İndeksleyici (Indexer) ve KesirKutusu Kullanımı (Görev 1 & Görev 4)
            Console.WriteLine("--- 2. KESİR KUTUSU VE İNDEKSLEYİCİ (this[int]) ---");
            KesirKutusu kutu = new KesirKutusu(3);
            kutu[0] = new Kesir(1, 2);
            kutu[1] = new Kesir(1, 3);
            kutu[2] = new Kesir(1, 4);

            Console.WriteLine($"Kutu Kapasitesi: {kutu.Kapasite} eleman");
            for (int i = 0; i < kutu.Kapasite; i++)
            {
                Console.WriteLine($"kutu[{i}] = {kutu[i]}");
            }
            Console.WriteLine();

            // 3. Enum Parametreli İşlem Metodu Testi (Görev 2 & Görev 3)
            Console.WriteLine("--- 3. ENUM İLE İŞLEM YÖNETİMİ (Islem.Toplama & Islem.Carpma) ---");
            Kesir kesirA = kutu[0]; // 1/2
            Kesir kesirB = kutu[1]; // 1/3

            Kesir toplamSonuc = KesirIslemiYap(kesirA, kesirB, Islem.Toplama);
            Kesir carpimSonuc = KesirIslemiYap(kesirA, kesirB, Islem.Carpma);

            Console.WriteLine($"{kesirA} ile {kesirB} için Islem.Toplama sonucu : {toplamSonuc}");
            Console.WriteLine($"{kesirA} ile {kesirB} için Islem.Carpma sonucu  : {carpimSonuc}");
            Console.WriteLine();

            // 4. Kutu İçi Kümülatif İşlem Doğrulaması (Kutudaki 3 kesrin toplamı ve çarpımı)
            Kesir kutuToplam = kutu[0] + kutu[1] + kutu[2]; // (1/2 + 1/3 + 1/4)
            Kesir kutuCarpim = kutu[0] * kutu[1] * kutu[2]; // (1/2 * 1/3 * 1/4)

            Console.WriteLine("--- 4. TÜM KUTU ELEMANLARININ KÜMÜLATİF SONUÇLARI ---");
            Console.WriteLine($"kutu[0] + kutu[1] + kutu[2] = {kutuToplam}");
            Console.WriteLine($"kutu[0] * kutu[1] * kutu[2] = {kutuCarpim}");
        }
    }
}
