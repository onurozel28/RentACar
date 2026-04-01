using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string BrandAdded = "Marka başarıyla eklendi";
        public static string BrandDeleted = "Marka başarıyla silindi";
        public static string BrandUpdated = "Marka başarıyla güncellendi";

        public static string CarListed = "Araçlar listelendi";
        public static string CarAdded = "Araç başarıyla eklendi";
        public static string CarDeleted = "Araç silme işlemi başarılı";
        public static string CarUpdated = "Araç güncelleme işlemi başarılı";
        public static string CarAvailable = "Araç kiralamaya uygundur.";

        public static string CategoryAdded = "Kategori başarıyla Eklendi";
        public static string CategoryDeleted = "Kategori başarıyla silindi";
        public static string CategoryUpdated = "Kategori başarıyla güncellendi";
        public static string CategoryListed = "Kategori listelendi";

        public static string ColorAdded = "Renk başarıyla Eklendi";
        public static string ColorDeleted = "Renk başarıyla silindi";
        public static string ColorUpdated = "Renk başarıyla güncellendi";

        public static string CustomerAdded = "Müşteri başarıyla Eklendi";
        public static string CustomerDeleted = "Müşteri başarıyla silindi";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi";

        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string RentalDeleted = "Kiralama işlemi silindi";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";
        public static string CheckReturnDate = "Araç geri dönüş tarihini kontrol ediniz !";
        public static string CarNameInvalid = "Araç ismi geçersiz";

        public static string CarNameAlreadyExist = "Hali hazırda bu isimde bir araç mevcut";

        public static string AuthorizationDenied = "yetkiniz yok ";
        public static string UserAdded = "Kullanıcı Eklendi";

        public static string UserRegistered = "Kayıt oldu";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Parola hatası";

        public static string SuccessfulLogin = "Başarılı giriş yapıldı";

        public static string UserAlreadyExists = "Kullanıcı mevcut";

        public static string AccessTokenCreated = "Token oluşturuldu";

        public static string CarImageLimitExcited = "Bir aracın 5 'den fazla resmi olamaz";

        public static string IncorrectFileExtension = "Kabul edilmeyen dosya uzantısı";
    }
}
