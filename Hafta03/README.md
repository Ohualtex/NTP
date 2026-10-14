# Hafta 03 — Metotlar ve Nesne İlişkileri (Overloading & Composition)

Bu klasör, **Nesne Tabanlı Programlama (NTP)** dersinin 3. haftasında gerçekleştirilen **Metot Aşırı Yükleme (Method Overloading)** ve **Nesne Birleştirme (Composition — "has-a")** laboratuvar çalışmasını ve kalıtım hazırlık ödevini içermektedir.

---

## 📄 Laboratuvar Yönergesi
Bu haftanın detaylı yönergesi ve görev föyüne aşağıdaki dosyadan ulaşabilirsiniz:
* 📄 [Hafta3_Ogrenci_Foyu.pdf](Hafta3_Ogrenci_Foyu.pdf)

---

## 🎯 Bu Haftanın Konuları ve Temel Kavramlar

* **Method Overloading (Metot Aşırı Yükleme):**
  - Aynı isimli metodun farklı parametre sayıları veya tipleriyle birden çok kez tanımlanabilmesi (`KitapEkle(Kitap)` ve `KitapEkle(string, string)`).
* **Değer Döndüren Metotlar:**
  - `void` yerine bir veri tipi (`int`, `bool` vb.) belirterek `return` anahtar sözcüğü ile sonuç üretme (`RaftakiSayisi()`).
* **Composition ("has-a" / Sahiplik İlişkisi):**
  - Bir sınıfın, diğer sınıflara ait nesneleri veya koleksiyonları bünyesinde barındırması (`Kutuphane has-a List<Kitap>`, `Kutuphane has-a Personel`).
* **Kalıtım Öncesi Hazırlık (Inheritance):**
  - Ortak özelliklere sahip sınıfları (`Uye` ve `Personel`) ortak bir ata sınıfta (`Kisi`) birleştirerek kod tekrarını önleme.

---

## 📂 Projeler

### 1. `Lab_Kutuphane/` (Laboratuvar Teslim Görevi)
* **Açıklama:** Föydeki Bölüm 5 şartlarına uygun Kütüphane Otomasyonu uygulaması.
* **Sınıflar:**
  - `Kitap`: Kitabın adı, yazarı ve ödünç durumu (`OduncteMi`).
  - `Uye`: Üyenin adı ve üye numarası (`UyeNo`).
  - `Kutuphane`: Kitap listesi, aşırı yüklenmiş `KitapEkle` metotları, `KitaplariListele`, `OduncVer`, `IadeAl` ve `RaftakiSayisi` metotları.
* **Çalıştırma:**
  ```bash
  dotnet run --project Hafta03/Lab_Kutuphane
  ```

---

### 2. `Odev_Kutuphane/` (Gelecek Haftaya Hazırlık Ödevi)
* **Açıklama:** Föydeki Bölüm 8 kalıtım hazırlığı ve personel entegrasyonu projesi.
* **Sınıflar:**
  - `Kisi`: Ortak ata sınıf (`Ad`).
  - `Uye`: `Kisi`'den kalıtım alan üye sınıfı (`UyeNo`).
  - `Personel`: `Kisi`'den kalıtım alan kütüphane görevlisi sınıfı (`PersonelNo`, `Departman`).
  - `Kitap`: Envanterdeki kitap nesnesi.
  - `Kutuphane`: Kitapları ve sorumlu personeli bünyesinde tutan yönetim sınıfı.
* **Çalıştırma:**
  ```bash
  dotnet run --project Hafta03/Odev_Kutuphane
  ```
