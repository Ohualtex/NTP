using System;

namespace MatematikKutuphane
{
    namespace Temel
    {
        /// <summary>
        /// MatematikKutuphane.Temel alt isim alanında yer alan temel aritmetik işlemleri.
        /// </summary>
        public class TemelIslemler
        {
            /// <summary>
            /// İki tam sayının toplamını döndürür.
            /// </summary>
            public static int Topla(int a, int b)
            {
                return a + b;
            }

            /// <summary>
            /// Verilen sıfır veya pozitif tam sayının faktöriyelini hesaplar.
            /// </summary>
            public static long Faktoriyel(int n)
            {
                if (n < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(n), "Negatif sayıların faktöriyeli hesaplanamaz.");
                }

                long sonuc = 1;
                for (int i = 2; i <= n; i++)
                {
                    sonuc *= i;
                }

                return sonuc;
            }

            /// <summary>
            /// Taban değerinin belirtilen negatif olmayan tam sayı üssünü hesaplar.
            /// </summary>
            public static int Us(int taban, int us)
            {
                if (us < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(us), "Tam sayı üs değeri negatif olamaz.");
                }

                int sonuc = 1;
                for (int i = 0; i < us; i++)
                {
                    sonuc *= taban;
                }

                return sonuc;
            }
        }
    }
}

