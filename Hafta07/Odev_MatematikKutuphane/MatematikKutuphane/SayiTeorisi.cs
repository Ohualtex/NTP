using System;
using System.Collections.Generic;

namespace MatematikKutuphane
{
    namespace SayiTeorisi
    {
        /// <summary>
        /// MatematikKutuphane.SayiTeorisi alt isim alanında yer alan sayı kuramı ve asallık metotları.
        /// </summary>
        public class SayiAnalizi
        {
            /// <summary>
            /// Verilen tam sayının asal olup olmadığını O(√n) karmaşıklıkla belirler (Bölüm 9 Ödevi).
            /// </summary>
            public static bool AsalMi(int n)
            {
                if (n <= 1)
                {
                    return false;
                }

                if (n == 2)
                {
                    return true;
                }

                if (n % 2 == 0)
                {
                    return false;
                }

                // Taşma (overflow) riskini önlemek için i * i <= n yerine i <= n / i kullanılır
                for (int i = 3; i <= n / i; i += 2)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            /// <summary>
            /// Belirtilen kapalı aralıktaki [baslangic, bitis] asal sayıları dizi olarak döndürür.
            /// </summary>
            public static int[] AraliktakiAsallar(int baslangic, int bitis)
            {
                if (bitis < baslangic)
                {
                    return Array.Empty<int>();
                }

                var asallar = new List<int>();
                for (int sayi = baslangic; sayi <= bitis; sayi++)
                {
                    if (AsalMi(sayi))
                    {
                        asallar.Add(sayi);
                    }
                }

                return asallar.ToArray();
            }
        }
    }
}

