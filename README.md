🎓 Öğrenci Yönetim Sistemi (C# & SQL Server)
Bu proje, öğrencilerin sisteme giriş yapabildiği, bilgilerini görüntüleyebildiği ve yönetici paneli üzerinden işlemlerin kontrol edilebildiği bir Masaüstü Yönetim Sistemidir.

🚀 Proje Hakkında
Bu uygulama, üniversite ödevleri kapsamında C# ve SQL Server teknolojileri kullanılarak geliştirilmiştir. Temel amacı, öğrenci kayıtlarının güvenli bir şekilde tutulması ve rol tabanlı (Yönetici/Öğrenci) giriş sisteminin simüle edilmesidir.

🛠️ Kullanılan Teknolojiler
Dil: C# (.NET Framework / Windows Forms)

Veritabanı: Microsoft SQL Server (LocalDB)

IDE: Visual Studio 2022

Veri Erişimi: ADO.NET (SqlConnection, SqlCommand)

🔑 Özellikler
Rol Bazlı Giriş: Yönetici ve Öğrenci için ayrı giriş yetkilendirmesi.

Veritabanı Entegrasyonu: SQL sorguları ile canlı veri çekme ve listeleme.

Güvenli Oturum: Kullanıcı çıkış yaptığında giriş ekranına güvenli dönüş.

Kullanıcı Dostu Arayüz: Modern ve temiz form tasarımı.

📸 Ekran Görüntüleri

<img width="777" height="501" alt="ss3" src="https://github.com/user-attachments/assets/64229e33-1fcd-4e80-b294-8e784eb05634" />
<img width="435" height="440" alt="ss2" src="https://github.com/user-attachments/assets/bd02e030-87cf-44c1-97ba-02179ab85cc1" />
<img width="286" height="315" alt="ss1" src="https://github.com/user-attachments/assets/6e488719-7712-4bff-9f21-09a087b70d53" />

⚙️ Kurulum
Projeyi bilgisayarınızda çalıştırmak için:

1. Projeyi klonlayın veya indirin.

2. Odev3.sln dosyasını Visual Studio ile açın.

3. SQL Server üzerinde Hafta3Odev veritabanını oluşturun ve database_kurulum.sql dosyasındaki scripti çalıştırın.

4. Bağlantı dizesini (ConnectionString) kendi bilgisayarınızdaki SQL sunucu adınıza göre güncelleyin.

5. F5 tuşu ile projeyi başlatın

📝 SQL Kurulum Scripti
Veritabanını oluşturmak için SQL Server Management Studio'da şu sorguyu çalıştırabilirsiniz:

CREATE DATABASE Hafta3Odev;
USE Hafta3Odev;
CREATE TABLE Ogrenciler (
    ID int IDENTITY(1,1) PRIMARY KEY,
    Ad nvarchar(50),
    Soyad nvarchar(50),
    Numara nvarchar(10),
    Sifre nvarchar(50)
);
-- Örnek veri
INSERT INTO Ogrenciler (Ad, Soyad, Numara, Sifre) VALUES ('Ali', 'Yılmaz', '1001', '1234');
