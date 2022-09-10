using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebTravel5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values.OrderByDescending(x=>x.ID));
        }

        [HttpGet]
        public IActionResult GuideAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GuideAdd(Guide p)
        {
            p.Status = true;
            _guideService.TInsert(p);
            return RedirectToAction("Index", "Guide");
        }

        [HttpGet]
        public IActionResult GuideDetails(int id)
        {
            var values = _guideService.TGetById(id);
            return View(values);
        }

        public IActionResult DestinationDelete(int id)
        {
            var values = _guideService.TGetById(id);
            _guideService.TDelete(values);
            return RedirectToAction("Index", "Guide");
        }
    }
}
