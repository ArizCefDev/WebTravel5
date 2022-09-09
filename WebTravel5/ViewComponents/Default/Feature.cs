using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.ViewComponents.Default
{
    public class Feature:ViewComponent
    {
        FeatureService fs = new FeatureService(new EfFeatureRepository());

        public IViewComponentResult Invoke()
        {
            var values = fs.TGetList();
            return View(values);
        }
    }
}
