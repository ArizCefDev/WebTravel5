using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.ViewComponents.Default
{
    public class PopularDestinations : ViewComponent
    {
        DestinationService ds = new DestinationService(new EfDestinationRepository());

        public IViewComponentResult Invoke()
        {
            var values = ds.TGetList();
            return View(values);
        }
    }
}
