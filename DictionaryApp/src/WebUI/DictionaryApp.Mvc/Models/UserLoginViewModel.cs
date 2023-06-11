using System.ComponentModel.DataAnnotations;

namespace DictionaryApp.Mvc.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Kullanıcı Adı Boş Bırakılamaz!")]
        public string UserName { get; set;}

        [Required(ErrorMessage ="Şifre Boş Bırakılamaz!")]
        [DataType(DataType.Password)]
        public string Password { get; set;}
    }
}
