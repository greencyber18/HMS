using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public interface BRepository<T,ID>
    {
        void AddBooking(T e);
        List<T> GetBooking(ID id);

       


    }
}
