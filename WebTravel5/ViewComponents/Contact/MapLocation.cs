using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.ViewComponents.Contact
{
    public class MapLocation : ViewComponent
    {
        private readonly IContactService _contactService;

        public MapLocation(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.TGetList();
            return View(values);
        }
    }
}
