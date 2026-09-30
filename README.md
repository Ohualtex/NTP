# Nesne Tabanlı Programlama (NTP) — Laboratuvar ve Alıştırmalar

Bu depo, **Nesne Tabanlı Programlama (NTP)** dersi kapsamında gerçekleştirilen haftalık laboratuvar çalışmalarını, hazırlık ödevlerini, kaynak kodları ve ilgili dökümantasyonu içermektedir.

---

## 🛠️ Teknolojiler ve Geliştirme Ortamı

* **Programlama Dili:** C#
* **Çalışma Zamanı / SDK:** [.NET 10.0 (LTS)](https://dotnet.microsoft.com/)
* **Geliştirme Ortamı (IDE):** VS Code (C# Dev Kit) / Visual Studio Community 2026
* **Platform:** Çapraz Platform (macOS, Linux, Windows)

---

## 📂 Dizin Yapısı

Depo, modüler ve temiz bir dosya organizasyonuna sahiptir:

```text
NTP/
├── README.md                     # Depo tanıtımı ve kılavuz
├── dokumanlar/                   # Laboratuvar föyleri ve ders dökümantasyonu
│   └── Hafta1_Ogrenci_Foyu.pdf
├── arsiv/                        # Teslim edilen sıkıştırılmış (.zip) proje paketleri
│   ├── Hafta1_OgrenciKayit.zip
│   └── Hafta1_Odev.zip
├── Hafta1_OgrenciKayit/          # Hafta 1 Laboratuvar Teslim Projesi
│   ├── Hafta1_OgrenciKayit.csproj
│   ├── Ogrenci.cs
│   └── Program.cs
└── Hafta1_Odev/                  # Hafta 1 Gelecek Haftaya Hazırlık Ödevi Projesi
    ├── Hafta1_Odev.csproj
    ├── Ogrenci.cs
    └── Program.cs
```

---

## 📅 Haftalık İlerleme ve Müfredat

| Hafta | Konu | İlgili Projeler | Durum |
| :---: | :--- | :--- | :---: |
| **01** | Ortam Kurulumu, İlk Sınıf (`class`), Nesne (`object`), Alanlar (`field`), Metotlar (`method`) ve Konsol Girdisi | `Hafta1_OgrenciKayit`<br>`Hafta1_Odev` |  Tamamlandı |
| **02** | Kapsülleme (Encapsulation), Erişim Belirteçleri (`public`/`private`), Özellikler (`Properties`) | — | ⏳ Planlanan |
| **03** | Yapıcı Metotlar (Constructors), Aşırı Yükleme (Overloading) | — | ⏳ Planlanan |
| **04** | Koleksiyonlar (`List<T>`), Dizi ve Nesne Yönetimi | — | ⏳ Planlanan |
| **05+** | Kalıtım (Inheritance), Polimorfizm, Soyutlama (Abstraction), Arayüzler (Interfaces) | — | ⏳ Planlanan |

---

## 🚀 Projeleri Çalıştırma Kılavuzu

Depodaki herhangi bir projeyi terminal üzerinden derlemek ve çalıştırmak için aşağıdaki adımları izleyebilirsiniz.

### 1. Gereksinim Kontrolü
Sisteminizde .NET 10 SDK'nın kurulu olduğundan emin olun:
```bash
dotnet --version
```

### 2. Projeyi Derleme (Build)
İlgili proje klasörünün içine girmeden doğrudan ana dizinden derlemek için:
```bash
dotnet build Hafta1_OgrenciKayit/Hafta1_OgrenciKayit.csproj
```

### 3. Projeyi Çalıştırma (Run)
* **Hafta 1 Laboratuvar Projesi:**
  ```bash
  dotnet run --project Hafta1_OgrenciKayit
  ```
* **Hafta 1 Hazırlık Ödevi:**
  ```bash
  dotnet run --project Hafta1_Odev
  ```

---

## 📌 Kod ve İsimlendirme Standartları

* **ASCII Standartları:** Çapraz platform ve terminal uyumluluğu için tüm dosya, klasör ve değişken isimlerinde ASCII karakterler tercih edilmektedir.
* **Klasik Şablon:** Başlangıç aşamasında C# program anatomisini (`class Program` ve `static void Main`) net kavramak adına *Top-level statements* kullanılmamaktadır.
* **Nesne Yönelimli Tasarım (OOP):** Her sınıf kendi bağımsız dosyasında (örn. `Ogrenci.cs`) tanımlanmakta, sorumluluklar sınıflara ve metotlara dağıtılmaktadır.
