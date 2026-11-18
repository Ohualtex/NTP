using System;
using System.Text.RegularExpressions;

namespace Hafta8_MetinIsleme
{
    /// <summary>
    /// Metin parçalama, ters çevirme ve düzenli ifade (Regex) ile doğrulama işlemlerini sunan yardımcı sınıf.
    /// </summary>
    public static class MetinAraci
    {
        // Föy Bölüm 6 Madde 2'de belirtilen e-posta doğrulama kalıbı
        private const string EpostaKalibi = @"^[\w\.-]+@[\w\.-]+\.\w+$";

        /// <summary>
        /// Verilen metni boşluk karakterlerinden ayırır; boş girişleri temizleyerek kelime dizisi döndürür.
        /// </summary>
        public static string[] KelimelereAyir(string metin)
        {
            if (string.IsNullOrWhiteSpace(metin))
            {
                return Array.Empty<string>();
            }

            return metin.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Cümledeki kelimeleri Split, Array.Reverse ve string.Join kullanarak ters sırayla birleştirir (Lab Görevi 1).
        /// </summary>
        public static string KelimeleriTersBirlestir(string metin)
        {
            string[] kelimeler = KelimelereAyir(metin);
            Array.Reverse(kelimeler);
            return string.Join(" ", kelimeler);
        }

        /// <summary>
        /// Verilen metnin e-posta kalıbına uygunluğunu System.Text.RegularExpressions.Regex ile denetler (Lab Görevi 2).
        /// </summary>
        public static bool EpostaGecerliMi(string eposta)
        {
            if (string.IsNullOrWhiteSpace(eposta))
            {
                return false;
            }

            return Regex.IsMatch(eposta.Trim(), EpostaKalibi, RegexOptions.None, TimeSpan.FromMilliseconds(250));
        }

        /// <summary>
        /// E-posta doğrulama sonucunu föy yönergesine uygun biçimde "Geçerli" veya "Geçersiz" olarak döndürür.
        /// </summary>
        public static string EpostaDogrula(string eposta)
        {
            return EpostaGecerliMi(eposta) ? "Geçerli" : "Geçersiz";
        }
    }
}
