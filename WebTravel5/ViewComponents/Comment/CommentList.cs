using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.ViewComponents.Comment
{
    public class CommentList : ViewComponent
    {
        CommentService cs = new CommentService(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = cs.TGetDestinationById(id);
            return View(values);
        }
    }
}
