using Microsoft.AspNetCore.Mvc;

namespace WebTravel5.Areas.Users.ViewComponents.UserProfile
{
    public class UserProject : ViewComponent
    {
        //CommentService cs = new CommentService(new EfCommentRepository());

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
