using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationRepository : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByApproval(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status
                == "Cavab gözləyən" && x.AppUserID == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByCurrent(int id)
        {
            using (var context=new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status
                == "Qəbul edilən" && x.AppUserID == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByOld(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status
                == "Keçmiş" && x.AppUserID == id).ToList();
            }
        }
    }
}
