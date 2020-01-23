using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace PreagusFietsen.Model
{
    class Store {
        //PROPERTIES
        public int ID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int MaxCapacity { get; set; }
        public ObservableCollection<Bike> Bikes { get; set; }

        private static int totalStores = 0;

        public Store() 
        {
            Bikes = new ObservableCollection<Bike>(); // create new empty list of Students when creating a new Course
            totalStores++;
            ID = totalStores;
        }
    }
}
