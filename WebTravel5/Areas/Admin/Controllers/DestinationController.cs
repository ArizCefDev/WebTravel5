using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Areas.Admin.Controllers
{

    //dashboard //yorum //rota //misafir //mesaj //rehber //one cikanlar
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationService ds = new DestinationService(new EfDestinationRepository());

        [Route("Admin/[controller]/[action]")]
        public IActionResult Index(string s)
        {
            var values = ds.TGetList();
            if (!string.IsNullOrEmpty(s))
            {
                return View(ds.SearchDestination(s));
            }
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DestinationAdd(Destination p)
        {
            p.Status = true;
            p.CoverImage = "null";
            p.Details1 = "null";
            p.Details2 = "null";
            p.image2 = "null";
            ds.TInsert(p);
            return RedirectToAction("Index","Destination");
        }

        [HttpGet]
        public IActionResult DestinationUpdate(int id)
        {
            var values = ds.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationUpdate(Destination p)
        {
            p.Status = true;
            p.CoverImage = "null";
            p.Details1 = "null";
            p.Details2 = "null";
            p.image2 = "null";
            ds.TUpdate(p);
            return RedirectToAction("Index","Destination");
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            var values = ds.TGetById(id);
            return View(values);
        }

        public IActionResult DestinationDelete(int id)
        {
            var values = ds.TGetById(id);
            ds.TDelete(values);
            return RedirectToAction("Index","Destination");
        }
    }
}
