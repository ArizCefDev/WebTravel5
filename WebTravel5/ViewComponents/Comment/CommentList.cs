using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.ViewComponents.Comment
{
    public class CommentList : ViewComponent
    {
        private readonly ICommentService _commentService;

        public CommentList(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.TGetDestinationById(id);
            return View(values);
        }
    }
}
