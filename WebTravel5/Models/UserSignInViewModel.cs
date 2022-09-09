using System.ComponentModel.DataAnnotations;

namespace WebTravel5.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfən istifadəçi adınızı girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfən Şifrənizi girin")]
        public string Password { get; set; }

    }
}
