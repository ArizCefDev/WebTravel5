using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Areas.Users.ViewComponents.UserProfile
{
    public class GuideInformation : ViewComponent
    {
        GuideService gs = new GuideService(new EfGuideRepository());

        public IViewComponentResult Invoke()
        {
            var values = gs.TGetList();
            return View(values);
        }
    }
}
