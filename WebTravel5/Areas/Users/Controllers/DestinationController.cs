using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Areas.Users.Controllers
{
    [AllowAnonymous]
    [Area("Users")]
    [Route("Users/[controller]/[action]")]
    public class DestinationController : Controller
    {
        DestinationService ds = new DestinationService(new EfDestinationRepository());

        public IActionResult Index()
        {
            var values = ds.TGetList();
            return View(values);
        }
    }
}
