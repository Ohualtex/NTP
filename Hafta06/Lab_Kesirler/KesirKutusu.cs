using System;

namespace Hafta6_Kesirler
{
    // 1. Görev: İçinde Kesir dizisi barındıran ve indeksleyici (indexer) ile erişilen kapsayıcı sınıf
    public class KesirKutusu
    {
        private Kesir[] kesirler;

        // Kurucu Metot: Belirli bir kapasite ile dizi tahsisi yapar
        public KesirKutusu(int kapasite = 5)
        {
            if (kapasite <= 0)
            {
                kapasite = 5;
            }
            kesirler = new Kesir[kapasite];
        }

        // 1. Görev: İndeksleyici (Indexer) - Nesneye dizi gibi kutu[i] sözdizimiyle erişim sağlar
        public Kesir this[int indeks]
        {
            get
            {
                if (indeks >= 0 && indeks < kesirler.Length)
                {
                    return kesirler[indeks];
                }
                throw new IndexOutOfRangeException($"Geçersiz indeks ({indeks})! Kutu kapasitesi: {kesirler.Length}");
            }
            set
            {
                if (indeks >= 0 && indeks < kesirler.Length)
                {
                    kesirler[indeks] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException($"Geçersiz indeks ({indeks})! Kutu kapasitesi: {kesirler.Length}");
                }
            }
        }

        public int Kapasite => kesirler.Length;
    }
}

