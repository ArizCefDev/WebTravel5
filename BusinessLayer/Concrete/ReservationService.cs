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
    public class ReservationService : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationService(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetListApprovalReservation(int id)
        {
            return _reservationDal.GetListByFilter(x => x.AppUserID == id);
        }

        public List<Reservation> GetListWithReservationByApproval(int id)
        {
            return _reservationDal.GetListWithReservationByApproval(id);
        }

        public List<Reservation> GetListWithReservationByCurrent(int id)
        {
            return _reservationDal.GetListWithReservationByCurrent(id);
        }

        public List<Reservation> GetListWithReservationByOld(int id)
        {
            return _reservationDal.GetListWithReservationByOld(id);
        }

        public void TDelete(Reservation t)
        {
            _reservationDal.Delete(t);
        }

        public Reservation TGetById(int id)
        {
            return _reservationDal.GetById(id);
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public void TInsert(Reservation t)
        {
            _reservationDal.Add(t);
        }

        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);
        }
    }
}
