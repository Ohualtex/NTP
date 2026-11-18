using System;

namespace Hafta8_MetinIstatistigi
{
    /// <summary>
    /// Girilen bir paragrafın kelime sayısı, boşluksuz karakter sayısı ve en uzun kelime istatistiklerini hesaplayan sınıf.
    /// </summary>
    public class MetinIstatistigi
    {
        private static readonly char[] NoktalamaIsaretleri =
            { '.', ',', ';', ':', '!', '?', '"', '\'', '(', ')', '[', ']', '{', '}', '-', '…' };

        public int KelimeSayisi { get; }
        public int BosluksuzKarakterSayisi { get; }
        public int ToplamKarakterSayisi { get; }
        public string EnUzunKelime { get; }
        public int EnUzunKelimeUzunlugu => EnUzunKelime.Length;

        private MetinIstatistigi(int kelimeSayisi, int bosluksuzKarakterSayisi, int toplamKarakterSayisi, string enUzunKelime)
        {
            KelimeSayisi = kelimeSayisi;
            BosluksuzKarakterSayisi = bosluksuzKarakterSayisi;
            ToplamKarakterSayisi = toplamKarakterSayisi;
            EnUzunKelime = enUzunKelime;
        }

        /// <summary>
        /// Verilen paragrafı Split ile kelimelere ayırır ve foreach döngüsüyle en uzun kelime ile karakter sayılarını hesaplar.
        /// </summary>
        public static MetinIstatistigi AnalizEt(string? paragraf)
        {
            if (string.IsNullOrWhiteSpace(paragraf))
            {
                return new MetinIstatistigi(0, 0, 0, string.Empty);
            }

            // 1. Split ile kelimelere ayırma (ardışık boşluk/sekme karakterlerini temizleyerek)
            string[] kelimeler = paragraf.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);

            // 2. Boşluksuz karakter sayısını hesaplama
            int bosluksuzSayac = 0;
            foreach (char karakter in paragraf)
            {
                if (!char.IsWhiteSpace(karakter))
                {
                    bosluksuzSayac++;
                }
            }

            // 3. foreach ile noktalama işaretlerinden arındırılmış en uzun kelimeyi bulma
            string enUzun = string.Empty;
            foreach (string hamKelime in kelimeler)
            {
                string temizKelime = hamKelime.Trim(NoktalamaIsaretleri);
                string aday = temizKelime.Length > 0 ? temizKelime : hamKelime;

                if (aday.Length > enUzun.Length)
                {
                    enUzun = aday;
                }
            }

            return new MetinIstatistigi(kelimeler.Length, bosluksuzSayac, paragraf.Length, enUzun);
        }

        /// <summary>
        /// Hesaplanan istatistik özetini hizalanmış biçimde konsola yazdırır.
        /// </summary>
        public void Yazdir()
        {
            Console.WriteLine($"{"Kelime sayısı",-28}: {KelimeSayisi}");
            Console.WriteLine($"{"Karakter sayısı (boşluksuz)",-28}: {BosluksuzKarakterSayisi}");
            Console.WriteLine($"{"Toplam karakter sayısı",-28}: {ToplamKarakterSayisi}");
            Console.WriteLine($"{"En uzun kelime",-28}: {EnUzunKelime} ({EnUzunKelimeUzunlugu} harf)");
        }
    }
}
