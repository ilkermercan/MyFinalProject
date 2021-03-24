using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductsListed= "Ürünler listelendi";
        internal static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        internal static string ProductNameAlreadyExists="Bu isimde başka bir ürün var.";
        internal static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        internal static string AuthorizationDenied="Yetkiniz yok.";
        internal static string UserRegistered="Kayit oldu";
        internal static string UserNotFound="Kullanici bulunamadi";
        internal static string PasswordError="Paralo hatasi";
        internal static string SuccessfulLogin="Basarili giris";
        internal static string UserAlreadyExists="Kullanici mevcut";
        internal static string AccessTokenCreated="Token olusturuldu";
    }
}
