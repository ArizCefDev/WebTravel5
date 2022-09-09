using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Areas.Admin.ViewComponents.Statistics
{
    public class StatisticsBottom3 : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
