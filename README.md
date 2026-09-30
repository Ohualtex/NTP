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

Depo, haftalık bazda modüler ve ölçeklenebilir bir dosya organizasyonuna sahiptir:

```text
NTP/
├── README.md                     # Ana depo tanıtımı ve genel kılavuz
├── .gitignore                    # Git takip dışı bırakma kuralları
└── Hafta01/                      # 1. Hafta: Ortam Kurulumu, İlk Sınıf ve Nesne
    ├── README.md                 # Hafta 1 özel dökümantasyonu
    ├── Hafta1_Ogrenci_Foyu.pdf   # Laboratuvar görev föyü
    ├── Lab_OgrenciKayit/         # Laboratuvar teslim projesi
    │   ├── Lab_OgrenciKayit.csproj
    │   ├── Ogrenci.cs
    │   └── Program.cs
    └── Odev_OgrenciKayit/        # Gelecek haftaya hazırlık ödevi projesi
        ├── Odev_OgrenciKayit.csproj
        ├── Ogrenci.cs
        └── Program.cs
```

---

## 📅 Haftalık İlerleme ve Müfredat

| Hafta | Konu | İlgili Dizin & Projeler | Durum |
| :---: | :--- | :--- | :---: |
| **01** | Ortam Kurulumu, İlk Sınıf (`class`), Nesne (`object`), Alanlar (`field`), Metotlar (`method`) ve Konsol Girdisi | [`Hafta01/`](Hafta01/)<br>• `Lab_OgrenciKayit`<br>• `Odev_OgrenciKayit` |  Tamamlandı |
| **02** | Kapsülleme (Encapsulation), Erişim Belirteçleri (`public`/`private`), Özellikler (`Properties`) | `Hafta02/` | ⏳ Planlanan |
| **03** | Yapıcı Metotlar (Constructors), Aşırı Yükleme (Overloading) | `Hafta03/` | ⏳ Planlanan |
| **04** | Koleksiyonlar (`List<T>`), Dizi ve Nesne Yönetimi | `Hafta04/` | ⏳ Planlanan |
| **05+** | Kalıtım (Inheritance), Polimorfizm, Soyutlama (Abstraction), Arayüzler (Interfaces) | `Hafta05+/` | ⏳ Planlanan |

---

## 🚀 Projeleri Çalıştırma Kılavuzu

Depodaki herhangi bir projeyi terminal üzerinden doğrudan ana dizinden derleyebilir ve çalıştırabilirsiniz.

### 1. Gereksinim Kontrolü
Sisteminizde .NET 10 SDK'nın kurulu olduğundan emin olun:
```bash
dotnet --version
```

### 2. Projeleri Derleme (Build)
```bash
dotnet build Hafta01/Lab_OgrenciKayit/Lab_OgrenciKayit.csproj
dotnet build Hafta01/Odev_OgrenciKayit/Odev_OgrenciKayit.csproj
```

### 3. Projeleri Çalıştırma (Run)
* **Hafta 1 Laboratuvar Projesi:**
  ```bash
  dotnet run --project Hafta01/Lab_OgrenciKayit
  ```
* **Hafta 1 Hazırlık Ödevi:**
  ```bash
  dotnet run --project Hafta01/Odev_OgrenciKayit
  ```

---

## 📌 Kod ve İsimlendirme Standartları

* **Modüler Mimarisi:** Her haftanın materyali (`HaftaXX/`) kendi föyü, README'si ve projeleri ile izole paketlenir.
* **ASCII Standartları:** Çapraz platform ve terminal uyumluluğu için tüm dosya, klasör ve değişken isimlerinde ASCII karakterler tercih edilmektedir.
* **Klasik Şablon:** Başlangıç aşamasında C# program anatomisini (`class Program` ve `static void Main`) net kavramak adına *Top-level statements* kullanılmamaktadır.
* **Nesne Yönelimli Tasarım (OOP):** Her sınıf kendi bağımsız dosyasında (örn. `Ogrenci.cs`) tanımlanmakta, sorumluluklar sınıflara ve metotlara dağıtılmaktadır.
