using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BookingModel
    {
        public int BookingId { get; set; }
        public int FlatId { get; set; }
        public int UserId { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }

    
        public virtual FlatModel Flat { get; set; }
        public virtual UserModel User { get; set; }
    }
}
