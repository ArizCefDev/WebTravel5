using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult Index(string s)
        {
            var values = _destinationService.TGetList();
            if (!string.IsNullOrEmpty(s))
            {
                return View(_destinationService.SearchDestination(s));
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
            _destinationService.TInsert(p);
            return RedirectToAction("Index","Destination");
        }

        [HttpGet]
        public IActionResult DestinationUpdate(int id)
        {
            var values = _destinationService.TGetById(id);
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
            _destinationService.TUpdate(p);
            return RedirectToAction("Index","Destination");
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            var values = _destinationService.TGetById(id);
            return View(values);
        }

        public IActionResult DestinationDelete(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.TDelete(values);
            return RedirectToAction("Index","Destination");
        }
    }
}
