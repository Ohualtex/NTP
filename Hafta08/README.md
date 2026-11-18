# Hafta 08 — System İsim Alanı: String İşlemleri, Biçimlendirme ve Düzenli İfadeler

Bu klasör, **Nesne Tabanlı Programlama (NTP)** dersinin 8. haftasında gerçekleştirilen **`String` Metotları (`Trim`, `ToUpper`, `ToLower`, `Split`, `Join`, `IndexOf`, `Replace`, `Substring`)**, **Sayısal/Metinsel Biçimlendirme (`N`, `P`, `C`, hizalama)** ve **`Regex` (Düzenli İfadeler)** konularını içeren "Metin İşleme Aracı" laboratuvar çalışmasını kapsamaktadır.

---

## 📄 Laboratuvar Yönergesi
Bu haftanın detaylı yönergesi ve görev föyüne aşağıdaki dosyadan ulaşabilirsiniz:
* 📄 [Hafta8_Ogrenci_Foyu.pdf](Hafta8_Ogrenci_Foyu.pdf)

---

## 🎯 Bu Haftanın Konuları ve Temel Kavramlar

* **`String` Metotları ve Değişmezlik (Immutability):**
  - `String` nesneleri değiştirilemez (`immutable`); her dönüşüm metodu (`Trim`, `ToUpper`, `ToLower`, `Replace`, `Substring`) yeni bir metin döndürür.
  - Türkçe `i/İ` ve `ı/I` dönüşümlerinin tüm işletim sistemlerinde doğru çalışması için `CultureInfo("tr-TR")` kullanılır.
* **Parçalama ve Birleştirme (`Split` / `Array.Reverse` / `Join`):**
  - Cümleler boşluk karakterlerinden kelime dizisine ayrılır (`Split`), sıralaması tersine çevrilir (`Array.Reverse`) ve istenen ayırıcı ile yeniden tek metin hâline getirilir (`string.Join`).
* **Biçimlendirme (Format Belirleyiciler):**
  - `N2` (binlik ayraçlı ondalıklı), `P0` (yüzde), `C` (para birimi) ve pozitif/negatif genişlik belirleyicileri (`{0,10}` sağa, `{0,-10}` sola hizalama) ile düzenli konsol çıktısı üretilir.
* **Düzenli İfadeler (`System.Text.RegularExpressions.Regex`):**
  - `^[\w\.-]+@[\w\.-]+\.\w+$` kalıbı ile e-posta adreslerinin yapısal geçerliliği denetlenir.

---

## 📂 Projeler

### 1. `Lab_MetinIsleme/` (Laboratuvar Teslim Projesi)
* **Açıklama:** Föydeki Bölüm A, Bölüm B ve Bölüm 6 (Lab Teslimi) şartlarının tamamını karşılayan Metin İşleme Aracı konsol uygulaması.
* **Sınıflar & İşlevler:**
  - `MetinAraci`: `KelimelereAyir`, `KelimeleriTersBirlestir` (`Split` + `Array.Reverse` + `Join`), `EpostaGecerliMi` ve `EpostaDogrula` (`Regex` ile `"Geçerli"` / `"Geçersiz"`).
  - `Program`: Bölüm A `String` testleri, Bölüm B biçimlendirme/hizalama testleri, `Console.ReadLine()` ile kullanıcı cümlesi analizi ve 4 örnekli e-posta doğrulama testi.
* **Derleme ve Çalıştırma:**
  ```bash
  dotnet build Hafta08/Lab_MetinIsleme/Lab_MetinIsleme.csproj
  dotnet run --project Hafta08/Lab_MetinIsleme
  ```

---

### 2. `Odev_MetinIstatistigi/` (Gelecek Haftaya Hazırlık Ödevi)
* **Açıklama:** Föydeki Bölüm 9 şartlarına uygun olarak girilen bir paragrafta kelime sayısını, boşluksuz karakter sayısını ve noktalama temizliğiyle en uzun kelimeyi bulan "Metin İstatistiği" konsol uygulaması.
* **Sınıflar & İşlevler:**
  - `MetinIstatistigi`: `AnalizEt(string?)` ile `Split` kelime ayrımı, `foreach` döngüsüyle boşluksuz karakter sayımı ve noktalama işaretlerinden arındırılmış en uzun kelime tespiti; `Yazdir()` ile hizalı raporlama.
  - `Program`: Kullanıcıdan paragraf girdisi alma, boş girdi kontrolü ve istatistik çıktısını gösterme.
* **Derleme ve Çalıştırma:**
  ```bash
  dotnet build Hafta08/Odev_MetinIstatistigi/Odev_MetinIstatistigi.csproj
  dotnet run --project Hafta08/Odev_MetinIstatistigi
  ```

