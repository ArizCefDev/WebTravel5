using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByApproval(int id);
        List<Reservation> GetListWithReservationByCurrent(int id);
        List<Reservation> GetListWithReservationByOld(int id);
    }
}
