using System;

namespace Okul
{
    /// <summary>
    /// Okul isim alanında öğrenci not hesabını temsil eden sınıf (Lab Görevi 1).
    /// </summary>
    public class Hesap
    {
        public string OgrenciAdi = string.Empty;
        public double Vize;
        public double Final;

        /// <summary>
        /// Vize (%40) ve Final (%60) ağırlıklarına göre dönem not ortalamasını hesaplar.
        /// </summary>
        public double OrtalamaHesapla() => (Vize * 0.40) + (Final * 0.60);

        public string GecmeDurumu() => OrtalamaHesapla() >= 60.0 ? "Geçti" : "Kaldı";

        public void Yaz() =>
            Console.WriteLine($"Okul not hesabı ({OgrenciAdi}): Vize={Vize}, Final={Final}, Ortalama={OrtalamaHesapla():F2} ({GecmeDurumu()})");
    }
}

