# Hafta 05 — Sınıflar, Yapıcı Metotlar ve Statik Üyeler

Bu klasör, **Nesne Tabanlı Programlama (NTP)** dersinin 5. haftasında gerçekleştirilen **Erişim Belirleyiciler (`public`/`private`)**, **Property Doğrulama (`get`/`set`)**, **Yapıcı Metotlar (`Constructor`)**, **Statik ve Sabit Üyeler (`static`, `const`)** ile nesne ilişkilerini içeren "Evim" laboratuvar çalışmasını ve yapıcı metot aşırı yüklemesi hazırlık ödevini içermektedir.

---

## 📄 Laboratuvar Yönergesi
Bu haftanın detaylı yönergesi ve görev föyüne aşağıdaki dosyadan ulaşabilirsiniz:
* 📄 [Hafta5_Ogrenci_Foyu.pdf](Hafta5_Ogrenci_Foyu.pdf)

---

## 🎯 Bu Haftanın Konuları ve Temel Kavramlar

* **Sınıf Tasarımı ve Kapsülleme (Encapsulation):**
  - Alanların (fields) `private` tutularak doğrudan erişimden korunması; kontrollü erişimin `public` property'ler üzerinden sağlanması.
* **Property Doğrulama (`get`/`set` Validation):**
  - `DogumYili` özelliğinde 1900 ile güncel yıl (`DateTime.Now.Year`) aralığının denetlenmesi.
  - `Meslek` özelliğinde boş/boşluklu girdi kontrolü yapılarak otomatik `"Belirtilmedi"` atanması.
* **Yapıcı Metotlar (`Constructors`):**
  - Nesnelerin `new` operatörü ile oluşturulurken başlangıç değerleriyle güvenli şekilde başlatılması ve veri atamalarının property set bloklarından geçirilmesi.
* **Statik Sayaç (`static`):**
  - `KisiSayisi` alanının sınıfa ait ortak statik sayaç olarak tanımlanması; her yapıcı metot çağrısında artırılarak nesne sayısının izlenmesi (`Kisi.KisiSayisi`).
* **Sabit Alanlar (`const`):**
  - `EvAdresi` bilgisinin derleme zamanı sabiti (`const`) yapılarak tüm ev sakinleri için tek ve değişmez kılınması (`Kisi.EvAdresi`).
* **Bileşim (Composition — "has-a") ve Arama:**
  - `Ev` sınıfının bir `List<Kisi>` tutması; `OrtalamaYas()` ile aritmetik ortalama ve `EnYasli()` metodu ile listenin taranarak en büyük yaşa sahip kişinin referansının bulunması.

---

## 📂 Projeler

### 1. `Lab_Evim/` (Laboratuvar Teslim Görevi)
* **Açıklama:** Föydeki Bölüm 5 teslim şartlarının tamamını karşılayan "Evim" konsol otomasyonu.
* **Sınıflar & İşlevler:**
  - `Kisi`: Doğrulamalı `DogumYili`, boşluk korumalı `Meslek`, `Ad`, statik `KisiSayisi`, sabit `EvAdresi`, `YasHesapla()` ve `BilgiYaz()`.
  - `Ev`: `List<Kisi>` yönetimi, `UyeEkle()`, `TumUyeleriYaz()`, `OrtalamaYas()` ve `EnYasli()`.
  - `Program`: Const adres gösterimi, 4 kişi kaydı, liste dökümü, istatistikler ve statik sayaç kontrolü.
* **Çalıştırma:**
  ```bash
  dotnet run --project Hafta05/Lab_Evim
  ```

