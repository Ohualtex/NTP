# Hafta 07 — İsim Alanları, Takma İsimler ve Kütüphane (.dll)

Bu klasör, **Nesne Tabanlı Programlama (NTP)** dersinin 7. haftasında gerçekleştirilen **İsim Alanları (`namespace`)**, **Takma İsimler (`using alias`)**, **Sınıf Kütüphanesi (Class Library — `.dll`)** üretimi/referansı ve **İç İçe İsim Alanları** konularını içeren laboratuvar çalışmasını kapsamaktadır.

---

## 📄 Laboratuvar Yönergesi
Bu haftanın detaylı yönergesi ve görev föyüne aşağıdaki dosyadan ulaşabilirsiniz:
* 📄 [Hafta7_Ogrenci_Foyu.pdf](Hafta7_Ogrenci_Foyu.pdf)

---

## 🎯 Bu Haftanın Konuları ve Temel Kavramlar

* **İsim Alanı (`namespace`):**
  - Sınıfları, yapıları ve numaralandırmaları mantıksal gruplara ayırarak büyük projelerde ad çakışmalarını önler.
  - Dışarıdan nokta erişimi (`IsimAlani.Sinif`) veya `using` yönergesi ile kullanılır.
* **`using` ve Takma İsim (`alias`):**
  - Farklı isim alanlarında aynı adı (`Hesap`) taşıyan sınıflar bulunduğunda oluşan derleyici belirsizliğini ortadan kaldırmak için `using TakmaAd = IsimAlani.Sinif;` sözdizimi kullanılır (`BankaHesap`, `OyunHesap`, `OkulHesap`).
* **Sınıf Kütüphanesi (Class Library — `.dll`):**
  - Doğrudan `.exe` olarak çalıştırılmak yerine başka projelerin referans gösterebileceği yeniden kullanılabilir `.dll` kütüphanesi üretir.
  - Başka projeden erişilebilmesi için kütüphane sınıf ve metotları mutlaka `public` olmalıdır.
* **İç İçe İsim Alanları (Nested Namespaces):**
  - Büyüyen kütüphanelerde türleri alt isim alanlarına (`MatematikKutuphane.Ileri`) bölerek düzenli mimari sunar ve tam nitelikli ad (`MatematikKutuphane.Ileri.BilimselIslemler`) ile doğrudan çağrılabilir.

---

## 📂 Projeler

### 1. `Lab_IsimAlanlariVeKutuphane/` (Laboratuvar Teslim Çözümü)
* **Açıklama:** Föydeki Bölüm A, Bölüm B ve Bölüm 6 (Lab Teslimi) şartlarının tamamını karşılayan iki projeli `.sln` çözümü.
* **Alt Projeler & Sınıflar:**
  - **`MatematikKutuphane/` (Class Library — `.dll`):**
    - `MatematikKutuphane.Islemler`: `Topla(int, int)`, `Faktoriyel(int)`, `Us(int, int)` (`public static`).
    - `MatematikKutuphane.Ileri.BilimselIslemler`: İç içe isim alanında `Ebob(int, int)`, `Ekok(int, int)`, `Fibonacci(int)`.
  - **`Hafta7_IsimAlanlari/` (Ana Konsol Uygulaması):**
    - `Bankacilik.Hesap`, `Oyun.Hesap` ve `Okul.Hesap` (öğrenci not ortalaması hesabı) sınıflarının `using alias` (`BankaHesap`, `OyunHesap`, `OkulHesap`) ile kullanımı.
    - `MatematikKutuphane.csproj` proje referansı üzerinden `.dll` metotları ve `MatematikKutuphane.Ileri.BilimselIslemler` tam ad erişimi testleri.
* **Derleme ve Çalıştırma:**
  ```bash
  dotnet build Hafta07/Lab_IsimAlanlariVeKutuphane/Lab_IsimAlanlariVeKutuphane.sln
  dotnet run --project Hafta07/Lab_IsimAlanlariVeKutuphane/Hafta7_IsimAlanlari
  ```

