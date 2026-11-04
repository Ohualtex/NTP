# Hafta 06 — Operatör Aşırı Yükleme, İndeksleyiciler, Yapılar ve Enum

Bu klasör, **Nesne Tabanlı Programlama (NTP)** dersinin 6. haftasında gerçekleştirilen **Değer Tipi Yapılar (`struct`)**, **Aritmetik ve İlişkisel Operatör Aşırı Yükleme (`operator +`, `*`, `==`, `!=`)**, **İndeksleyiciler (`this[int]`)** ve **Numaralandırmalar (`enum`)** konularını içeren "Kesirler" laboratuvar çalışmasını ve gelişmiş dört işlem/sadeleştirme hazırlık ödevini içermektedir.

---

## 📄 Laboratuvar Yönergesi
Bu haftanın detaylı yönergesi ve görev föyüne aşağıdaki dosyadan ulaşabilirsiniz:
* 📄 [Hafta6_Ogrenci_Foyu.pdf](Hafta6_Ogrenci_Foyu.pdf)

---

## 🎯 Bu Haftanın Konuları ve Temel Kavramlar

* **`struct` (Değer Tipi Yapısı):**
  - Sınıfa (`class`) benzer ancak belleğin *stack* bölgesinde saklanan değer tipi veri modeli. Küçük ve ilişkili veri çiftleri (Pay, Payda) için yüksek performans sağlar.
  - Kurucu metotta sıfıra bölme hatasını (`DivideByZeroException`) engellemek için payda 0 girildiğinde 1'e sabitleme koruması.
* **Operatör Aşırı Yükleme (Operator Overloading):**
  - Kullanıcı tanımlı tiplerin temel aritmetik sembollerle çalışabilmesi:
    - Toplama: `operator +` $\rightarrow (a \cdot d + b \cdot c) / (b \cdot d)$
    - Çarpma: `operator *` $\rightarrow (a \cdot c) / (b \cdot d)$
    - Çıkarma: `operator -` $\rightarrow (a \cdot d - b \cdot c) / (b \cdot d)$
    - Bölme: `operator /` $\rightarrow (a \cdot d) / (b \cdot c)$
* **İlişkisel Operatörler ve Zıt Çift Kuralı:**
  - `==` operatörü aşırı yüklendiğinde `!=` operatörünün de zorunlu olarak yüklenmesi. İki rasyonel sayının denkliği için çapraz çarpım ($a \cdot d == b \cdot c$) algoritması.
* **İndeksleyici (Indexer — `this[int]`):**
  - Sınıf nesnelerine dizi gibi köşeli parantezle (`kutu[0]`) doğrudan okuma (`get`) ve yazma (`set`) erişimi sunan yapı.
* **`enum` (Numaralandırma):**
  - İşlem türlerini (`Islem.Toplama`, `Islem.Carpma`) adlandırılmış sabitlerle tanımlayarak tip güvenli metot parametresi kullanımı.

---

## 📂 Projeler

### 1. `Lab_Kesirler/` (Laboratuvar Teslim Görevi)
* **Açıklama:** Föydeki Bölüm 5 teslim şartlarının tamamını karşılayan Kesir ve KesirKutusu konsol otomasyonu.
* **Sınıflar & İşlevler:**
  - `struct Kesir`: Pay, payda, 0 payda koruması, `operator +`, `operator *`, `operator ==`, `operator !=`, `Yaz()` ve `ToString()`.
  - `enum Islem`: `Toplama` ve `Carpma` sabitleri.
  - `class KesirKutusu`: `Kesir[]` dizisi ve `this[int]` indeksleyicisi.
  - `Program`: Temel operatör doğrulamaları, indeksleyici testleri ve enum parametreli `KesirIslemiYap` metodu.
* **Çalıştırma:**
  ```bash
  dotnet run --project Hafta06/Lab_Kesirler
  ```

