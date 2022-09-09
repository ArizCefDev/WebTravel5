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
    public class DestinationService : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationService(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public Destination TGetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetList();
        }

        public void TInsert(Destination t)
        {
            _destinationDal.Add(t);
        }

        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }

        public List<Destination> SearchDestination(string s)
        {
            return _destinationDal.GetListByFilter(x => x.City == s);
        }
    }
}
