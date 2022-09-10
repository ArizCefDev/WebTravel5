using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.ViewComponents.Default
{
    public class SubAbout : ViewComponent
    {
        private readonly ISubAboutService _subAboutService;

        public SubAbout(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _subAboutService.TGetList();
            return View(values);
        }
    }
}
