using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Areas.Admin.ViewComponents.Statistics
{
    public class StatisticsMiddle : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
