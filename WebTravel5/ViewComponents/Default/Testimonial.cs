using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.ViewComponents.Default
{
    public class Testimonial : ViewComponent
    {
        TestimonialService ts = new TestimonialService(new EfTestimonialRepository());

        public IViewComponentResult Invoke()
        {
            var values = ts.TGetList();
            return View(values);
        }
    }
}
