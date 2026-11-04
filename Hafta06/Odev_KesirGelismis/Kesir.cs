using System;

namespace Odev_KesirGelismis
{
    // Gelişmiş dört işlem ve EBOB sadeleştirme yeteneğine sahip Kesir yapısı
    public struct Kesir : IEquatable<Kesir>
    {
        public int Pay;
        public int Payda;

        public Kesir(int pay, int payda)
        {
            Pay = pay;
            Payda = (payda == 0) ? 1 : payda; // 0 payda koruması
        }

        // 1. Toplama: a/b + c/d = (a*d + c*b) / (b*d)
        public static Kesir operator +(Kesir a, Kesir b)
        {
            int pay = a.Pay * b.Payda + b.Pay * a.Payda;
            int payda = a.Payda * b.Payda;
            return new Kesir(pay, payda);
        }

        // 2. Çıkarma (Ödev İsteri): a/b - c/d = (a*d - c*b) / (b*d)
        public static Kesir operator -(Kesir a, Kesir b)
        {
            int pay = a.Pay * b.Payda - b.Pay * a.Payda;
            int payda = a.Payda * b.Payda;
            return new Kesir(pay, payda);
        }

        // 3. Çarpma: a/b * c/d = (a*c) / (b*d)
        public static Kesir operator *(Kesir a, Kesir b)
        {
            return new Kesir(a.Pay * b.Pay, a.Payda * b.Payda);
        }

        // 4. Bölme (Ödev İsteri): a/b / c/d = a/b * d/c = (a*d) / (b*c)
        public static Kesir operator /(Kesir a, Kesir b)
        {
            if (b.Pay == 0)
            {
                Console.WriteLine("[Hata] Sıfıra bölme yapılamaz! (Bölen kesrin payı 0)");
                return new Kesir(0, 1);
            }
            int pay = a.Pay * b.Payda;
            int payda = a.Payda * b.Pay;
            return new Kesir(pay, payda);
        }

        // Eşitlik Operatörleri
        public static bool operator ==(Kesir a, Kesir b)
        {
            return a.Pay * b.Payda == b.Pay * a.Payda;
        }

        public static bool operator !=(Kesir a, Kesir b)
        {
            return !(a == b);
        }

        // En Büyük Ortak Bölen (EBOB / GCD) - Öklid Algoritması
        private static int Ebob(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a == 0 ? 1 : a;
        }

        // Sadeleştirme Metodu (Ödev Notu: 2/4 -> 1/2 dönüşümü)
        public Kesir Sadelestir()
        {
            int ebob = Ebob(Pay, Payda);
            int sadePay = Pay / ebob;
            int sadePayda = Payda / ebob;

            // Negatif işareti pay kısmında tutma standardı
            if (sadePayda < 0)
            {
                sadePay = -sadePay;
                sadePayda = -sadePayda;
            }

            return new Kesir(sadePay, sadePayda);
        }

        public void Yaz()
        {
            Console.WriteLine($"{Pay}/{Payda}");
        }

        public override string ToString()
        {
            return $"{Pay}/{Payda}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Kesir k && this == k;
        }

        public bool Equals(Kesir other)
        {
            return this == other;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Pay, Payda);
        }
    }
}

