using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class FlatModel
    {
        public int FlatId { get; set; }
        public string FlatSize { get; set; }
        public string FlatDetails { get; set; }
        public string Location { get; set; }
        public int Rent { get; set; }
        public int UserId { get; set; }
        public string FlatImage { get; set; }
        public string Status { get; set; }
        public string City { get; set; }

        public virtual UserModel User { get; set; }
        
    }
}
