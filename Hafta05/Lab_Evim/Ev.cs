using System;
using System.Collections.Generic;

namespace Hafta5_Evim
{
    class Ev
    {
        // Bileşim (Composition): Ev bir Kisi listesine sahiptir
        private List<Kisi> uyeler = new List<Kisi>();

        // Eve yeni bir kişi nesnesi ekler
        public void UyeEkle(Kisi k)
        {
            if (k != null)
            {
                uyeler.Add(k);
            }
        }

        // Listedeki tüm kişilerin bilgilerini ekrana döker
        public void TumUyeleriYaz()
        {
            foreach (Kisi k in uyeler)
            {
                k.BilgiYaz();
            }
        }

        // Evdeki tüm üyelerin yaş ortalamasını ondalıklı (double) olarak hesaplar
        public double OrtalamaYas()
        {
            if (uyeler.Count == 0)
            {
                return 0.0;
            }

            int toplam = 0;
            foreach (Kisi k in uyeler)
            {
                toplam += k.YasHesapla();
            }

            return (double)toplam / uyeler.Count;
        }

        // 2. Görev: Evdeki en yaşlı üyeyi bulup döndüren metot
        public Kisi? EnYasli()
        {
            if (uyeler.Count == 0)
            {
                return null;
            }

            Kisi enYasli = uyeler[0];
            foreach (Kisi k in uyeler)
            {
                if (k.YasHesapla() > enYasli.YasHesapla())
                {
                    enYasli = k;
                }
            }

            return enYasli;
        }
    }
}

