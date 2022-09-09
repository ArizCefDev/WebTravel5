using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Areas.Admin.ViewComponents.AdminDashboard
{
    public class AdminDashboardList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
