using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        
        [Route("Admin/[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
