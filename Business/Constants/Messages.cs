using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string DailyPriceInvalid = "Günlük kiralama bedeli 0 olamaz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarIdInvalid = "Araba Id'si bulunamadı";
        public static string CarUpdated = "Araba güncellendi";
        public static string RentedCar = "Araba kiralandı";
        public static string CarNotAvailable = "Araba kiralanmaya uygun değil";

        public static string CarLimitExceeded = "En fazla 5 resim ekleyebilirsiniz";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
