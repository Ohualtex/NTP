using System;

namespace Odev_Kutuphane
{
    // Ortak üst sınıf (Hafta 4 Kalıtım / Inheritance konusuna hazırlık)
    class Kisi
    {
        public string Ad { get; set; } = string.Empty;

        public Kisi(string ad)
        {
            Ad = ad;
        }

        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"Kişi: {Ad}");
        }
    }
}
