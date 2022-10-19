using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarModelYearInvalid = "Araba modeli 2005 yılı ve üzeri olmalıdır";
        public static string CarCountOfBrandError = "Bir markaya ait en fazla 10 kayıt olabilir";
        public static string CarDescriptionAlreadyExist = "Aynı açıklama tekrar eklenemez";
        public static string BrandLimitExceded = "Marka limiti aşıldığı için yeni marka eklenemiyor";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorsListed = "Renkler listelendi";
        public static string ColorNameRepeatInvalid = "Aynı Renk Tekrar Eklenilmeye Çalışıldığı İçin Eklenemedi!!!";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string BrandNameRepeatInvalid = "Aynı Marka Tekrar Eklenilmeye Çalışıldığı İçin Eklenemedi!!!";

        public static string UserRegistered = "Kullanıcı Kayıt Edildi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Hatalı Şifre";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten kayıtlı";
        public static string AccessTokenCreated = "Erişim Kodu Üretildi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomersListed = "Müşteriler listelendi";

        public static string RentalAdded = "Araba Kiralandı";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string RentalUpdated = "Kiralama Güncellendi";
        public static string RentalsListed = "Kiralanan Arabalar listelendi";

        public static string ImageAdded = "Resim eklendi";
        public static string ImageDeleted = "Resim Silindi";
        public static string ImageUpdated = "Resim Güncellendi";
        public static string ImagesListed = "Resimler listelendi";
        public static string CarImageCountError = "Bir arabaya 5'ten fazla resim ekleyemezsin";
    }
}
