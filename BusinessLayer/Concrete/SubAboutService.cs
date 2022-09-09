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
    public class SubAboutService : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutService(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void TDelete(SubAbout t)
        {
            _subAboutDal.Delete(t);
        }

        public SubAbout TGetById(int id)
        {
            return _subAboutDal.GetById(id);
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDal.GetList();
        }

        public void TInsert(SubAbout t)
        {
            _subAboutDal.Add(t);
        }

        public void TUpdate(SubAbout t)
        {
            _subAboutDal.Update(t);
        }
    }
}
