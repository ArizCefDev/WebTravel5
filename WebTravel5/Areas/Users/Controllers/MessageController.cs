using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Areas.Users.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
