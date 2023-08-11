using System.ComponentModel.DataAnnotations;

namespace ReservationApp.Panel.UI.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen bu alanı boş bırakmayınız")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Lütfen bu alanı boş bırakmayınız")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen bu alanı boş bırakmayınız")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen bu alanı boş bırakmayınız")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Lütfen bu alanı boş bırakmayınız")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen bu alanı boş bırakmayınız")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }
    }
}
