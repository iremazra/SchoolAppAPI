# SchoolApp API: Role-Based Personnel Management System
SchoolApp API, bir eğitim kurumundaki öğretmen, öğrenci ve idari personel verilerini merkezi bir servis üzerinden yönetmek amacıyla geliştirilmiş, RESTful mimariye sahip bir backend projesidir.

## Projenin Amacı
Sistem, farklı kullanıcı rollerine (Öğretmen, Öğrenci, Çalışan) göre veri yönetimini (CRUD) standartlaştırmayı ve bu verileri dış uygulamalara (Frontend/Mobile) güvenli bir API aracılığıyla sunmayı hedefler.

## Teknik Özellikler
* **RESTful Architecture:** Tüm işlemler standart HTTP metodları (GET, POST, PUT, DELETE) üzerinden yürütülür.
* **Role-Based Logic:** Sistemdeki veriler; öğretmen, öğrenci ve çalışan rolleri baz alınarak kategorize edilmiş ve yönetilmiştir.
* **Database Integration:** İlişkisel veritabanı entegrasyonu ile tüm personel bilgileri güvenli bir şekilde depolanır ve sorgulanır.
* **Data Integrity:** CRUD işlemleri sırasında veri bütünlüğü ve doğruluğu ön planda tutulmuştur.

## Teknoloji Yığını
* **Backend:** C# / .NET 
* **Database:** SQL Server 
* **API Documentation:** REST standartlarına uygun endpoint tasarımı.

## ⚙️ DevOps Hazırlığı
Bu API, modern mikroservis yaklaşımlarına uygun olarak tasarlanmış olup; çevresel değişkenlerin yönetimi, loglama altyapısı ve Dockerize edilmeye uygun bir yapıya sahiptir.
