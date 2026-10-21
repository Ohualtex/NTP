# Hafta 04 — Diziler ve Metotlar (Arrays & Methods)

Bu klasör, **Nesne Tabanlı Programlama (NTP)** dersinin 4. haftasında gerçekleştirilen **Diziler (Arrays)**, **`static` Yardımcı Metotlar**, **`params` Parametreleri**, **`Array.Sort` & `Array.Reverse`** algoritmalarını ve nesne tabanlı not dizisi hazırlık ödevini içermektedir.

---

## 📄 Laboratuvar Yönergesi
Bu haftanın detaylı yönergesi ve görev föyüne aşağıdaki dosyadan ulaşabilirsiniz:
* 📄 [Hafta4_Ogrenci_Foyu.pdf](Hafta4_Ogrenci_Foyu.pdf)

---

## 🎯 Bu Haftanın Konuları ve Temel Kavramlar

* **Dizi (Array) Tanımlama ve Bellek Yapısı:**
  - Tek boyutlu tamsayı dizisi (`int[] sayilar = new int[10]`) tanımlama ve salt-okunur `Length` özelliği ile boyut kontrolü.
  - `Random` sınıfı ile 1–100 aralığında rastgele sayı üretimi ve döngülerle (`for`, `foreach`) dizi manipülasyonu.
* **`static` Yardımcı Metotlar:**
  - Nesne örneği (`instance`) üretmeksizin, doğrudan parametre olarak aldığı dizi üzerinde çalışan modüler fonksiyonlar (`DiziYaz`, `Ortalama`, `EnBuyuk`, `EnKucuk`).
* **Tür Dönüşümü (Explicit Casting):**
  - Tamsayı bölmesi kaybını önlemek için toplam değerinin `(double)` ile dönüştürülmesi ve `:F2` formatlayıcısı ile virgülden sonra iki basamak hassasiyetle yazdırılması.
* **Ortalama Üstü Eleman Tespiti:**
  - Bir metodun (`OrtalamaUstu`) başka bir metodu (`Ortalama`) çağırarak elde edilen eşik değere göre elemanları filtreleyip sayması.
* **`Array.Sort` ve `Array.Reverse`:**
  - Diziyi küçükten büyüğe sıralama ve ters çevirerek büyükten küçüğe dizme algoritmalarının hazır kütüphane metotlarıyla işletilmesi.
* **`params` Anahtar Sözcüğü:**
  - Metot tanımında değişken sayıda bağımsız argüman (`static int Topla(params int[] sayilar)`) kabul eden esnek metot yapısı.

---

## 📂 Projeler

### 1. `Lab_DiziAnaliz/` (Laboratuvar Teslim Görevi)
* **Açıklama:** Föydeki Bölüm 5 teslim şartlarının tamamını karşılayan Sayı Dizisi Analiz Aracı konsol uygulaması.
* **İşlevler:**
  - 10 elemanlı rastgele dizi üretimi ve listelenmesi.
  - Ortalama, en büyük, en küçük ve ortalama üstü eleman adedinin hesaplanması.
  - `Array.Sort` ile artan sıralama, `Array.Reverse` ile azalan sıralama.
  - `params Topla(...)` metodu ile değişken argümanlı toplama testleri.
* **Çalıştırma:**
  ```bash
  dotnet run --project Hafta04/Lab_DiziAnaliz
  ```

---

### 2. `Odev_OgrenciNotDizi/` (Gelecek Haftaya Hazırlık Ödevi)
* **Açıklama:** Föydeki Bölüm 8 şartlarına uygun nesne tabanlı not dizisi ve nesne metotları uygulaması.
* **Sınıflar & İşlevler:**
  - `Ogrenci`: `Ad`, `Soyad`, `Numara` ve öğrenciye özel `int[] Notlar` dizisi alanı (field).
  - `OrtalamaHesapla()`: `static` metot yerine öğrencinin kendi not dizisi üzerinden ortalama üreten nesne metodu (instance method).
  - `EnYuksekNot()`: Öğrencinin aldığı en yüksek notu bulan nesne davranışı.
  - `BilgiYazdir()`: Öğrenci bilgilerini, notlarını ve hesaplanan ortalamasını formatlı ekrana basan metot.
* **Çalıştırma:**
  ```bash
  dotnet run --project Hafta04/Odev_OgrenciNotDizi
  ```
