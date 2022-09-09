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
    public class GuideService : IGuideService
    {
        IGuideDal _guideDal;

        public GuideService(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TDelete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public Guide TGetById(int id)
        {
            return _guideDal.GetById(id);
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public void TInsert(Guide t)
        {
            _guideDal.Add(t);
        }

        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);
        }
    }
}
