using Microsoft.AspNetCore.Http;

namespace WebTravel5.Areas.Users.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public IFormFile Image { get; set; }
        public string ImageURL { get; set; }
    }
}
