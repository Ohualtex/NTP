using System;

namespace MatematikKutuphane
{
    namespace Ileri
    {
        /// <summary>
        /// İç içe isim alanı (MatematikKutuphane.Ileri) altında yer alan ileri düzey matematik işlemleri.
        /// </summary>
        public class BilimselIslemler
        {
            /// <summary>
            /// İki tam sayının en büyük ortak bölenini (EBOB) Öklid algoritmasıyla hesaplar.
            /// </summary>
            public static int Ebob(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);

                while (b != 0)
                {
                    int gecici = b;
                    b = a % b;
                    a = gecici;
                }

                return a;
            }

            /// <summary>
            /// İki tam sayının en küçük ortak katını (EKOK) hesaplar.
            /// </summary>
            public static int Ekok(int a, int b)
            {
                if (a == 0 || b == 0)
                {
                    return 0;
                }

                int ebob = Ebob(a, b);
                return Math.Abs((a / ebob) * b);
            }

            /// <summary>
            /// Verilen sıradaki Fibonacci sayısını hesaplar.
            /// </summary>
            public static long Fibonacci(int n)
            {
                if (n < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(n), "Fibonacci sırası negatif olamaz.");
                }

                if (n <= 1)
                {
                    return n;
                }

                long onceki = 0;
                long simdiki = 1;
                for (int i = 2; i <= n; i++)
                {
                    long sonraki = onceki + simdiki;
                    onceki = simdiki;
                    simdiki = sonraki;
                }

                return simdiki;
            }
        }
    }
}

