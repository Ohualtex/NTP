using System;

namespace Bankacilik
{
    /// <summary>
    /// Bankacılık isim alanında banka hesabını ve bakiyesini temsil eden sınıf.
    /// </summary>
    public class Hesap
    {
        public double Bakiye;

        public void Yaz() => Console.WriteLine($"Banka bakiyesi: {Bakiye} TL");
    }
}

