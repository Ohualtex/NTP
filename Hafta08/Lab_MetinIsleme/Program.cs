using System;
using System.Globalization;
using System.Text;

namespace Hafta8_MetinIsleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            // Türkçe büyük/küçük harf (i/İ, ı/I) ve yerel sayı/para biçimlendirmesi için tr-TR kültürü
            CultureInfo.CurrentCulture = new CultureInfo("tr-TR");

            Console.WriteLine("=== HAFTA 8: SYSTEM İSİM ALANI — STRING, BİÇİMLENDİRME VE REGEX ===");
            Console.WriteLine();

            // 1. Bölüm A: Temel String İşleme Metotları
            Console.WriteLine("--- 1. BÖLÜM A: METİN İŞLEME METOTLARI ---");
            string cumle = "  Fırat Üniversitesi Yazılım Mühendisliği  ";

            Console.WriteLine($"Orijinal          : [{cumle}]");

            string temiz = cumle.Trim();
            Console.WriteLine($"Trim              : [{temiz}]");
            Console.WriteLine($"Büyük             : {temiz.ToUpper()}");
            Console.WriteLine($"Küçük             : {temiz.ToLower()}");
            Console.WriteLine($"Uzunluk           : {temiz.Length}");

            string[] kelimeler = temiz.Split(' ');
            Console.WriteLine($"Kelime sayısı     : {kelimeler.Length}");

            Console.WriteLine($"'Yazılım' indeksi : {temiz.IndexOf("Yazılım")}");
            Console.WriteLine($"Replace           : {temiz.Replace("Yazılım", "Bilgisayar")}");
            Console.WriteLine($"İlk 5             : {temiz.Substring(0, 5)}");
            Console.WriteLine($"Join              : {string.Join("-", kelimeler)}");
            Console.WriteLine();

            // 2. Bölüm B: Sayısal ve Metinsel Biçimlendirme (Format)
            Console.WriteLine("--- 2. BÖLÜM B: BİÇİMLENDİRME (FORMAT) ---");
            double fiyat = 1234.5;
            Console.WriteLine($"Binlik : {fiyat:N2}");
            Console.WriteLine($"Yüzde  : {0.25:P0}");
            Console.WriteLine($"Para   : {fiyat:C}");
            Console.WriteLine($"Sağa   : {string.Format("[{0,10}]", "sağ")}");
            Console.WriteLine($"Sola   : {string.Format("[{0,-10}]", "sol")}");
            Console.WriteLine();

            // 3. Lab Görevi 1: Kullanıcı Girdisi + Split + Array.Reverse + Join
            Console.WriteLine("--- 3. GÖREV 1: KULLANICI CÜMLESİ ANALİZİ VE TERS BİRLEŞTİRME ---");
            Console.Write("Bir cümle giriniz: ");
            string? kullaniciCumlesi = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(kullaniciCumlesi))
            {
                Console.WriteLine("Uyarı: Geçerli bir cümle girilmedi.");
            }
            else
            {
                string temizGirdi = kullaniciCumlesi.Trim();
                string[] girdiKelimeleri = MetinAraci.KelimelereAyir(temizGirdi);
                string tersBirlesim = MetinAraci.KelimeleriTersBirlestir(temizGirdi);

                Console.WriteLine($"Kelime sayısı : {girdiKelimeleri.Length}");
                Console.WriteLine($"Büyük harf    : {temizGirdi.ToUpper()}");
                Console.WriteLine($"Ters birleşim : {tersBirlesim}");
            }
            Console.WriteLine();

            // 4. Lab Görevi 2 & 3: Regex ile E-posta Doğrulama Testleri
            Console.WriteLine("--- 4. GÖREV 2 & 3: REGEX İLE E-POSTA DOĞRULAMA TESTLERİ ---");
            string[] ornekEpostalar =
            {
                "mirac.duran@firat.edu.tr",
                "ogrenci_2026@gmail.com",
                "hatali-eposta@",
                "ad.soyad@alanadi"
            };

            foreach (string eposta in ornekEpostalar)
            {
                string sonuc = MetinAraci.EpostaDogrula(eposta);
                Console.WriteLine($"{eposta,-28} => {sonuc}");
            }
        }
    }
}
