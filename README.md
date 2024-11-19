# Unfurned

Unfurned, Unity ile geliştirilmiş bir FPS oyunu prototipidir. Bu projede temel mekanikler, silah etkileşimleri, ateş etme sistemi ve düşman hareketleri bulunmaktadır.

---

## 🚀 Proje Özellikleri

- **Silah Etkileşimi:**
  - Silahı yere bırakabilir ve geri alabilirsiniz.
  - Yere bırakıldığında fizik etkileri aktif hale gelir.
  - Silah sadece oyuncunun elindeyken ateş edebilir.

- **Ateş Etme Mekanizması:**
  - Mermiler silahın ucundan çıkar ve belirli bir hızla hareket eder.
  - Mermiler düşmana çarptığında hasar verir ve yok edilir.

- **Düşman Sistemi:**
  - Düşmanlar oyuncuyu takip eder ve çarpıştığında hasar verir.

---

## 📂 Proje Yapısı

```plaintext
Unfurned/
├── Assets/
│   ├── Scripts/            # Tüm C# scriptleri
│   │   ├── GunController.cs
│   │   ├── WeaponInteraction.cs
│   │   ├── EnemyHealth.cs
│   │   ├── EnemyMovement.cs
│   │   ├── PlayerController.cs
│   │   └── PlayerHealth.cs
│   ├── Prefabs/            # Tüm prefablardan oluşan dizin
│   ├── Scenes/             # Unity sahneleri
│   ├── Materials/          # Malzemeler
│   └── Models/             # 3D modeller
└── README.md               # Proje hakkında bilgi
