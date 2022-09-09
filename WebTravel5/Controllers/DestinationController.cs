using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationService ds = new DestinationService(new EfDestinationRepository());

        public IActionResult Index()
        {
            var values = ds.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.i = id;
            var values = ds.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }
    }
}
