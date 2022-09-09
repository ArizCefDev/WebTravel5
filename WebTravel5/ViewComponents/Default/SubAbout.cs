using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.ViewComponents.Default
{
    public class SubAbout : ViewComponent
    {
        SubAboutService sas = new SubAboutService(new EfSubAboutRepository());

        public IViewComponentResult Invoke()
        {
            var values = sas.TGetList();
            return View(values);
        }
    }
}
