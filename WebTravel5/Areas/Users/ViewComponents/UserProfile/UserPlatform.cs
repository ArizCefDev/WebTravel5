using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Areas.Users.ViewComponents.UserProfile
{
    public class UserPlatform : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
