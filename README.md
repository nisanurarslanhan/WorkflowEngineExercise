# C# İş Akışı Motoru Simülasyonu (WorkflowEngineExercise)

Bu proje, C# ve Nesne Yönelimli Programlama (OOP) ilkeleri kullanılarak tasarlanmış esnek bir **İş Akışı Motoru (Workflow Engine)** mimarisidir. **Interface (Arayüz)** kullanımı, **Açık/Kapalı Prensibi (Open/Closed Principle)** ve **Gevşek Bağlılık (Loose Coupling)** kavramlarını göstermek amacıyla geliştirilmiştir.

---

## 📌 Özellikler

* **Arayüz Tabanlı Tasarım:** Bütün aktiviteler `IActivity` arayüzünü uygular. `WorkflowEngine` somut sınıflara değil, sadece `IActivity` arayüzüne bağımlıdır.
* **Genişletilebilirlik:** Mevcut motor veya aktivite kodlarına dokunmadan sisteme dilediğiniz zaman yeni adımlar/aktiviteler ekleyebilirsiniz.
* **Dinamik İş Akışı:** `Workflow` sınıfı sayesinde adımlar çalışma zamanında (runtime) sıralı bir liste şeklinde dinamik olarak oluşturulabilir.
