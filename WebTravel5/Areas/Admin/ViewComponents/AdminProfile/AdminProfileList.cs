using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Areas.Admin.ViewComponents.AdminProfile
{
    public class AdminProfileList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
