# Hafta 03 — Metotlar ve Nesne İlişkileri (Overloading & Composition)

Bu klasör, **Nesne Tabanlı Programlama (NTP)** dersinin 3. haftasında gerçekleştirilen **Metot Aşırı Yükleme (Method Overloading)** ve **Nesne Birleştirme (Composition — "has-a")** laboratuvar çalışmasını içermektedir.

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
  - Bir sınıfın, diğer sınıflara ait nesneleri veya koleksiyonları bünyesinde barındırması (`Kutuphane has-a List<Kitap>`).
* **Koleksiyon Yönetimi (`List<T>`):**
  - Dinamik nesne listesi üzerinde döngü (`foreach`) ile arama, durum kontrolü ve güncelleme yapılması.

---

## 📂 Projeler

### `Lab_Kutuphane/` (Laboratuvar Teslim Görevi)
* **Açıklama:** Föydeki Bölüm 5 şartlarına uygun Kütüphane Otomasyonu uygulaması.
* **Sınıflar:**
  - `Kitap`: Kitabın adı, yazarı ve ödünç durumu (`OduncteMi`).
  - `Uye`: Üyenin adı ve üye numarası (`UyeNo`).
  - `Kutuphane`: Kitap listesi, aşırı yüklenmiş `KitapEkle` metotları, `KitaplariListele`, `OduncVer`, `IadeAl` ve `RaftakiSayisi` metotları.
* **Senaryolar:**
  - 4 kitap ve 2 üye ile sistemin başlatılması.
  - Başarılı ödünç verme ve iade akışları.
  - Zaten ödünçte olan ve kütüphanede bulunmayan kitaplar için hata/uyarı kontrolleri.
  - Güncel raf mevcudunun dinamik hesaplanması.
* **Çalıştırma:**
  ```bash
  dotnet run --project Hafta03/Lab_Kutuphane
  ```
