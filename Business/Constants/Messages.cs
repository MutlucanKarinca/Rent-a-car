using Entities.Concrete;
using System;
using System.Collections.Generic;
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
        public static string CarUpdate="Araba güncellendi";
        public static string RentedCar = "Araba kiralandı";
        internal static string CarNotAvailable = "Araba kiralanmaya uygun değil";
    }
}
