using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreagusFietsen.Model
{
    public class Reservation {
        //PROPERTIES
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public List<int> BikesID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int PickupStoreID { get; set; }
        public int DropoffStoreID { get; set; }

        private static int totalReservation = 0;

        public Reservation()
        {
            totalReservation++;
            ID = totalReservation;
        }
    }
}
