# ADO.NET ile Veritabani Programlama

## Bu repo ADO.NET ile veritabanı işlemleri için örnek teşkil eder.

### Veritabanı Tasarımı

- Kendi hazırladığım Veritabanındaki Kullanicilar tablosuna kullanıcı ekleme, silme, güncelleme ve listeleme işlemleri yapar.
- DB olarak MSSQL kullanılmıştır.

#### Kullanicilar Tablosu


|Column Name|Data Type|Allow Nulls|
|:---|:---:|---:|
|KullaniciID|int|false|
|Ad|nvarchar(30)|false|
|Soyad|nvarchar(30)|false|
|KullaniciAd|varchar(20)|false|
|Email|varchar(40)|false|
|Sifre|varchar(15)|false|
|Telefon|varchar(11)|false|

#### Stored Procedurs

``` sql
CREATE PROCEDURE [dbo].[pr_KullaniciEkle]
(
	@Ad					NVARCHAR(50),
	@Soyad				NVARCHAR(50),
	@KullaniciAd		NVARCHAR(50),
	@Email				NVARCHAR(50),
	@Sifre				NVARCHAR(15)
)
AS
BEGIN
	INSERT INTO Kullanicilar(Ad, Soyad, KullaniciAd, Email, Sifre) VALUES(@Ad, @Soyad, @KullaniciAd, @Email, @Sifre);
END
```

``` sql
CREATE procedure [dbo].[pr_KullaniciGuncelle]
(
	@KullaniciID			INT,
	@Ad						NVARCHAR(50),
	@Soyad					NVARCHAR(50),
	@KullaniciAd			NVARCHAR(50),
	@Email					NVARCHAR(50),
	@Sifre					NVARCHAR(15)
)
AS
BEGIN
	UPDATE Kullanicilar
	SET
	Ad = @Ad,
	Soyad = @Soyad,
	KullaniciAd = @KullaniciAd,
	Email = @Email,
	Sifre = @Sifre
	WHERE @KullaniciID = @KullaniciID
END;
```

``` sql
CREATE PROCEDURE [dbo].[pr_KullanicilariGetir]
AS
BEGIN
	SELECT * FROM Kullanicilar
END
```

``` sql
CREATE PROCEDURE  [dbo].[pr_KullaniciSil]
(
	@KullaniciID int
)
AS
BEGIN
	DELETE FROM Kullanicilar WHERE KullaniciID = @KullaniciID;
END;
```
