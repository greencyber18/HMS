using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{


    public class BookingRepo : BRepository<Booking, int>
    {
        HomeRentEntities db;
        public BookingRepo(HomeRentEntities db)
        {
            this.db = db;
        }
        public void AddBooking(Booking e)
        {
            e.Status = "Processing";
            db.Bookings.Add(e);
            db.SaveChanges();
        }

        public List<Booking> GetBooking(int id)
        {
            var Booking = (from b in db.Bookings
                           where b.UserId == id
                           select b).ToList();

            return Booking;

        }

       /* public Booking GetBooking(int id)
        {
            var Booking = (from b in db.Bookings
                           where b.UserId == id
                           select b).First();
            return Booking;
        } */
    }

  
}
