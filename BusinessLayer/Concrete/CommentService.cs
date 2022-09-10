using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentService : ICommentService
    {
        ICommentDal _commentDal;

        public CommentService(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> CommentSearch(string s)
        {
            return _commentDal.GetListByFilter(x=>x.CommentUser.Contains(s));
        }

        public List<Comment> GetIncludeDestination()
        {
            return _commentDal.GetListWithDestination();
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> TGetDestinationById(int id)
        {
            return _commentDal.GetListByFilter(x => x.DestinationID == id);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetList();
        }

        public void TInsert(Comment t)
        {
            _commentDal.Add(t);
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
    }
}
