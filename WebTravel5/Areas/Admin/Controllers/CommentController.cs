using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace WebTravel5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IDestinationService _destinationService;

        public CommentController(ICommentService commentService, IDestinationService destinationService)
        {
            _commentService = commentService;
            _destinationService = destinationService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult Index()
        {
            var values = _commentService.GetIncludeDestination();
            return View(values);
        }

        [HttpGet]
        public IActionResult CommentDetails(int id)
        {
            var values = _commentService.TGetById(id);
            List<SelectListItem> valueGet = (from x in _destinationService.TGetList()
                                             select new SelectListItem
                                             {
                                                 Text = x.City,
                                                 Value = x.ID.ToString()
                                             }).ToList();
            ViewBag.c = valueGet;
            return View(values);
        }

        public IActionResult CommentDelete(int id)
        {
            var values = _commentService.TGetById(id);
            _commentService.TDelete(values);
            return RedirectToAction("Index", "Comment");
        }
    }
}
