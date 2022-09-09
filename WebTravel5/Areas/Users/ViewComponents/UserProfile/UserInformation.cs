using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebTravel5.Areas.Users.ViewComponents.UserProfile
{
    public class UserInformation : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public UserInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.Name + " " + values.Surname;
            ViewBag.userPhone = values.PhoneNumber;
            ViewBag.userMail = values.Email;
            return View();
        }
    }
}
