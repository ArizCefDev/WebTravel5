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
    public class NewsLetterService : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLetterService(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void TDelete(NewsLetter t)
        {
            _newsLetterDal.Delete(t);
        }

        public NewsLetter TGetById(int id)
        {
            return _newsLetterDal.GetById(id);
        }

        public List<NewsLetter> TGetList()
        {
            return _newsLetterDal.GetList();
        }

        public void TInsert(NewsLetter t)
        {
            _newsLetterDal.Add(t);
        }

        public void TUpdate(NewsLetter t)
        {
            _newsLetterDal.Update(t);
        }
    }
}
