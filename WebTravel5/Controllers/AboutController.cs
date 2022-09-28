using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        private readonly IGuideService _guideService;

        public AboutController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values);
        }
    }
}
