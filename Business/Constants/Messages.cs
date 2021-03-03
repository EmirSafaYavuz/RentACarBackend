using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Cars
        public static string CarAdded = "Araç Eklendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarUpdated = "Araç Güncellendi";
        public static string CarsListed = "Araçlar Listelendi";

        //Brands
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";

        //CarImages
        public static string CarImageAdded = "Araç Resmi Eklendi";
        public static string CarImageDeleted = "Araç Resmi Silindi";
        public static string CarImageUpdated = "Araç Resmi Güncellendi";
         
        //Colors
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";

        //Rental
        public static string RentalAdded = "Kiralama İşlemi Başarılı";
        public static string RentalDeleted = "Kiralama İşlemi Silindi";
        public static string RentalUpdated = "Kiralama İşlemi Güncellendi";


        //Users
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        //Customers
        public static string CustomerAdded = "Müşteri Eklendi";

        //Invalids
        public static string PriceInvalid = "Geçersiz Fiyat";
        public static string BrandNameInvalid = "Marka İsmi Geçersiz";
        public static string BrandNameLengthInvalid = "Marka İsmi En Az İki Harften Oluşmalıdır";
        public static string ColorNameLengthInvalid = "Renk Adı En Az İki Harften Oluşmalıdır";
        public static string CompanyNameLengthInvalid = "Şirket Adı En Az İki Harften Oluşmalıdır";
        public static string UserNameLengthInvalid = "Kullanıcı İsmi En Az Dört Harften Oluşmalıdır";

        public static string AuthorizationDenied = "Erişim Reddedildi";
        public static string UserRegistered = "Kullanıcı Kaydedildi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Zaten Mevcut";
        public static string AccessTokenCreated = "Access Token Oluşturuldu";
    }
}
