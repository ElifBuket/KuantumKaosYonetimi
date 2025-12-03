# 🚀 Kuantum Kaos Yönetimi – C# Versiyonu

Bu proje, "Omega Sektörü"ndeki Kuantum Veri Ambarı'nın simülasyonu için hazırlanmıştır.  
Amaç, depoya gelen maddeleri güvenli bir şekilde analiz etmek ve Kuantum Çöküşünü önlemektir.

---

## 🧩 Özellikler

- **OOP Tasarımı:** Abstract class, encapsulation, interface ve polymorphism kullanılmıştır.
- **Nesne Türleri:**
  1. **VeriPaketi:** Güvenli veri, analiz edildiğinde stabilite -5.
  2. **KaranlıkMadde:** Tehlikeli, analiz -15, acil soğutma +50.
  3. **AntiMadde:** Çok tehlikeli, analiz -25, uyarı mesajı verir, acil soğutma +50.
- **Custom Exception:** `KuantumCokusuException` ile stabilite 0 altına düşerse sistem çöker.
- **Oynanış Döngüsü:**
  - Yeni nesne ekleme
  - Tüm envanteri listeleme
  - Nesneyi analiz etme
  - Acil durum soğutması
  - Çıkış

---

## 💻 Kullanım

1. Projeyi bilgisayarınıza klonlayın veya indirin.  
2. Visual Studio 2022 ile `KuantumKaos_CSharp` çözümünü açın.  
3. Projeyi **Run (F5)** ile çalıştırın.  
4. Açılan menü üzerinden nesneleri ekleyip analiz edebilir, stabiliteyi takip edebilirsiniz.

---

## 📂 Proje Yapısı
KuantumKaosYonetimi
├─ Program.cs
├─ KuantumNesnesi.cs
├─ VeriPaketi.cs
├─ KaranlikMadde.cs
├─ AntiMadde.cs
├─ IKritik.cs
├─ KuantumCokusuException.cs
└─ README.md

---

## ⚡ Oynanış Mantığı

- Nesnelerin stabilitesi her analiz işleminde azalır.  
- Stabilite 0 altına düşerse: **"SİSTEM ÇÖKTÜ! TAHLİYE BAŞLATILIYOR..."** mesajı gösterilir.  
- Kritik nesneler için acil soğutma yapılabilir (+50 stabilite).

---
