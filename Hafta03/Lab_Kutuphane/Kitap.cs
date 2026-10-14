using System;

namespace Lab_Kutuphane
{
    class Kitap
    {
        public string Ad { get; set; } = string.Empty;
        public string Yazar { get; set; } = string.Empty;
        public bool OduncteMi { get; set; }

        public Kitap(string ad, string yazar)
        {
            Ad = ad;
            Yazar = yazar;
            OduncteMi = false;
        }
    }
}
