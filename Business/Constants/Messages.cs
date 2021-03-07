using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    //sabitler
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductUpdated = "ürün güncellendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakımdayız";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExits = "Aynı isimde birden fazla ürün olamaz";
        public static string CategoryLimitExceded="Kategori Limiti aşıldı";
        public static string AuthorizationDenied ="Yetkiniz yoktur";
        internal static string UserRegistered="Kayıt olundu";
        internal static string UserNotFound="Kullanıcı bulunamadı";
        internal static string PasswordError="Parola hatalı";
        internal static string SuccessfulLogin="Giriş Başarılı";
        internal static string UserAlreadyExists="Kullanıcı Mevcut";
        internal static string AccessTokenCreated="Token Oluşturuldu";
    }
}
