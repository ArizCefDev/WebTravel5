using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebTravel5.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentService cs = new CommentService(new EfCommentRepository());

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            cs.TInsert(p);
            return RedirectToAction("Index", "Destination");
        }
    }
}
