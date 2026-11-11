using System;

namespace Oyun
{
    /// <summary>
    /// Oyun isim alanında oyuncu puan hesabını temsil eden sınıf.
    /// </summary>
    public class Hesap
    {
        public int Puan;

        public void Yaz() => Console.WriteLine($"Oyun puanı: {Puan}");
    }
}

