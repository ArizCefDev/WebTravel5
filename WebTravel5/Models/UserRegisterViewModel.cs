using System.ComponentModel.DataAnnotations;

namespace WebTravel5.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfən adınızı girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfən soyadınızı girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfən istifadəçi adınızı girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfən email adresinizi girin")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfən şifrənizi girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfən şifrənizi təkrar girin")]
        [Compare("Password",ErrorMessage ="Şifrələr eyni deyil")]
        public string ConfirmPasword { get; set; }
    }
}
