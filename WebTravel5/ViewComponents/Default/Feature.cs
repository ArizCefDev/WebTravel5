using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.ViewComponents.Default
{
    public class Feature : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public Feature(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _featureService.TGetList();
            return View(values);
        }
    }
}
