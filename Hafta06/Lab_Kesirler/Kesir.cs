using System;

namespace Hafta6_Kesirler
{
    // Değer tipi (Value Type) olarak modellenen rasyonel sayı yapısı
    public struct Kesir : IEquatable<Kesir>
    {
        public int Pay;
        public int Payda;

        // Kurucu Metot: Paydanın 0 girilmesi durumunda 1'e sabitleyerek sıfıra bölme hatasını önler
        public Kesir(int pay, int payda)
        {
            Pay = pay;
            Payda = (payda == 0) ? 1 : payda;
        }

        // Konsola formatlı yazdırma metodu
        public void Yaz()
        {
            Console.WriteLine($"{Pay}/{Payda}");
        }

        public override string ToString()
        {
            return $"{Pay}/{Payda}";
        }

        // Adım B: Aritmetik Toplama Operatörü Aşırı Yüklemesi: a/b + c/d = (a*d + c*b) / (b*d)
        public static Kesir operator +(Kesir a, Kesir b)
        {
            int pay = a.Pay * b.Payda + b.Pay * a.Payda;
            int payda = a.Payda * b.Payda;
            return new Kesir(pay, payda);
        }

        // Adım B: Aritmetik Çarpma Operatörü Aşırı Yüklemesi: a/b * c/d = (a*c) / (b*d)
        public static Kesir operator *(Kesir a, Kesir b)
        {
            return new Kesir(a.Pay * b.Pay, a.Payda * b.Payda);
        }

        // Adım C: İlişkisel Eşitlik Operatörü (==) Aşırı Yüklemesi (Çapraz Çarpım Kontrolü)
        public static bool operator ==(Kesir a, Kesir b)
        {
            return a.Pay * b.Payda == b.Pay * a.Payda;
        }

        // Adım C: İlişkisel Eşitsizlik Operatörü (!=) Aşırı Yüklemesi (Çift kuralı zorunluluğu)
        public static bool operator !=(Kesir a, Kesir b)
        {
            return !(a == b);
        }

        // C# Derleyici Uyarılarını (CS0660, CS0661) önlemek için Equals ve GetHashCode ezme
        public override bool Equals(object? obj)
        {
            if (obj is Kesir k)
            {
                return this == k;
            }
            return false;
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

