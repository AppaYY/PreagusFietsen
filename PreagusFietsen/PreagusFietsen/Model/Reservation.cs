using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreagusFietsen.Model
{
    class Reservation { 
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public List<int> BikesID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int PickupStoreID { get; set; }
        public int DropoffStoreID { get; set; }
    }
}
