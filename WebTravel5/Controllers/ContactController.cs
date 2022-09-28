using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IMessageService _messageService;

        public ContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public IActionResult MessageAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MessageAdd(Message p)
        {
            _messageService.TInsert(p);
            return RedirectToAction("Index","Contact");
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
