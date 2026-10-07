# Hafta 02 — Kapsülleme (Encapsulation)

Bu klasör, **Nesne Tabanlı Programlama (NTP)** dersinin 2. haftasında gerçekleştirilen **Kapsülleme (Encapsulation)** laboratuvar çalışmasını ve nesneler arası etkileşim ödevini içermektedir.

---

## 📄 Laboratuvar Yönergesi
Bu haftanın detaylı yönergesi ve görev föyüne aşağıdaki dosyadan ulaşabilirsiniz:
* 📄 [Hafta2_Ogrenci_Foyu.pdf](Hafta2_Ogrenci_Foyu.pdf)

---

## 🎯 Bu Haftanın Konuları ve Temel Kavramlar

* **Erişim Belirleyiciler (Access Modifiers):**
  - `public`: Sınıf dışından serbestçe erişilebilir.
  - `private`: Yalnızca sınıfın kendi kod blokları içinden erişilebilir (veriyi gizlemenin ilk adımı).
* **Property (Özellik):**
  - **Full Property:** `get` ve `set` blokları ile veri okuma/yazma süreçlerini kontrol eder; `set` içinde veri doğrulama (`value >= 0`) yapılır.
  - **Auto-Property:** Ekstra doğrulama gerekmeyen durumlarda pratik kısa yazım (`{ get; set; }`).
  - **Salt-Okunur Property (Read-Only):** Sadece `get` içeren, dışarıdan doğrudan değiştirilemeyen özellik (`{ get; }` veya `get { return bakiye; }`).
* **Constructor (Yapıcı Metot):** Nesne `new` ile örneklendiğinde otomatik çalışarak başlangıç değerlerini atar ve nesneyi tutarlı durumda başlatır.
* **Nesneler Arası İlişkiler (Composition):** Bir nesnenin diğer bir nesneyi parametre olarak alıp metotları üzerinden etkileşime girmesi.

---

## 📂 Projeler

### 1. `Lab_BankaHesabi/` (Laboratuvar Teslim Görevi)
* **Açıklama:** Föydeki Bölüm 6 şartlarına uygun resmi laboratuvar teslim çalışması.
* **Özellikler:**
  - `Hesap` sınıfında `bakiye` alanı `private` yapılarak kapsüllendi.
  - Salt-okunur `Bakiye` ve `HesapNo` özellikleri tanımlandı.
  - Negatif değerleri reddeden doğrulamalı `FaizOrani` özelliği eklendi.
  - Başlangıç bakiyesini sıfırın altına düşürmeyen yapıcı metot yazıldı.
  - `ParaYatir` ve `ParaCek` metotları ile bakiye güvenliği sağlandı.
* **Çalıştırma:**
  ```bash
  dotnet run --project Hafta02/Lab_BankaHesabi
  ```

---

### 2. `Odev_BankaHesabi/` (Gelecek Haftaya Hazırlık Ödevi)
* **Açıklama:** Föydeki Bölüm 9 nesneler arası etkileşim ödevi.
* **Özellikler:**
  - `Hesap` sınıfına `public void ParaTransferi(Hesap hedefHesap, double tutar)` metodu eklendi.
  - Gönderen hesabın bakiyesinden güvenli düşüm yapılarak hedef hesaba aktarım sağlandı.
  - Yetersiz bakiye ve negatif transfer tutarı senaryoları doğrulandı.
* **Çalıştırma:**
  ```bash
  dotnet run --project Hafta02/Odev_BankaHesabi
  ```
