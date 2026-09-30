# Hafta 01 — Ortam Kurulumu, İlk Sınıf ve Nesne

Bu klasör, **Nesne Tabanlı Programlama (NTP)** dersinin 1. haftasında gerçekleştirilen ortam kurulumunu, laboratuvar teslim çalışmasını ve hazırlık ödevini içermektedir.

---

## 📄 Laboratuvar Yönergesi
Bu haftanın detaylı yönergesi ve görev föyüne aşağıdaki dosyadan ulaşabilirsiniz:
* 📄 [Hafta1_Ogrenci_Foyu.pdf](Hafta1_Ogrenci_Foyu.pdf)

---

## 🎯 Bu Haftanın Konuları ve Temel Kavramlar

* **Sınıf (Class):** Nesnelerin özelliklerini ve davranışlarını tanımlayan soyut kalıptır (Örn: Kurabiye kalıbı).
* **Nesne (Object):** Tanımlanan sınıftan `new` anahtar sözcüğü ile bellekte üretilen somut örnektir (Örn: Kurabiye).
* **Alan (Field):** Nesnenin verilerini/özniteliklerini saklayan değişkenlerdir (`Ad`, `Soyad`, `Numara`, `Vize`, `Final`).
* **Metot (Method):** Nesnenin gerçekleştirebildiği iş ve davranışları temsil eder (`BilgiYazdir()`, `OrtalamaHesapla()`).
* **Konsol Girdisi:** `Console.ReadLine()` ve tür dönüştürme fonksiyonları (`int.Parse`, `double.Parse`).

---

## 📂 Projeler

Bu hafta kapsamında iki ayrı konsol projesi geliştirilmiştir:

### 1. `Lab_OgrenciKayit/` (Laboratuvar Teslim Görevi)
* **Açıklama:** Föydeki Bölüm 8 şartlarını yerine getiren resmi laboratuvar teslim çalışması.
* **Özellikler:**
  - `Ogrenci` sınıfı `Ogrenci.cs` dosyasında tanımlandı.
  - İki bağımsız öğrenci nesnesi (`ogr1`, `ogr2`) oluşturuldu.
  - Veriler kullanıcıdan dinamik olarak `Console.ReadLine()` ile alındı.
  - Her iki öğrencinin bilgileri ve ağırlıklı not ortalamaları (`Vize * 0.4 + Final * 0.6`) ekrana yazdırıldı.
* **Çalıştırma:**
  ```bash
  dotnet run --project Hafta01/Lab_OgrenciKayit
  ```

---

### 2. `Odev_OgrenciKayit/` (Gelecek Haftaya Hazırlık Ödevi)
* **Açıklama:** Föydeki Bölüm 11 hazırlık ödevi uygulaması.
* **Özellikler:**
  - 3 ayrı `Ogrenci` nesnesi (`ogr1`, `ogr2`, `ogr3`) tanımlandı.
  - Henüz koleksiyonlar (`List<T>`) işlenmediği için referans karşılaştırması mantığıyla en yüksek not ortalamasına sahip olan öğrenci nesnesi tespit edildi.
  - Başarılı öğrencinin bilgileri ve ortalaması ekrana yansıtıldı.
* **Çalıştırma:**
  ```bash
  dotnet run --project Hafta01/Odev_OgrenciKayit
  ```
