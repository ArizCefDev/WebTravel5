using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTravel5.Areas.Users.Controllers
{
    [Area("Users")]
    [Route("Users/[controller]/[action]")]
    public class ReservationController : Controller
    {
        DestinationService ds = new DestinationService(new EfDestinationRepository());
        ReservationService rs = new ReservationService(new EfReservationRepository());
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> CurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuelist = rs.GetListWithReservationByCurrent(values.Id);
            return View(valuelist);
        }

        public async Task<IActionResult> OldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuelist = rs.GetListWithReservationByOld(values.Id);
            return View(valuelist);
        }

        public async Task<IActionResult> ApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuelist = rs.GetListWithReservationByApproval(values.Id);
            return View(valuelist);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in ds.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.ID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.AppUserID = 2;
            p.Status = "Cavab gözləyən";
            rs.TInsert(p);
            return RedirectToAction("CurrentReservation");
        }
    }
}
