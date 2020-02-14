using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreagusFietsen.Model
{
    public class Customer {
        //PROPERTIES
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Height { get; set; }
        public string Email { get; set; }

        private static int totalCustomer = 0;

        public Customer()
        {
            totalCustomer++;
            ID = totalCustomer;
        }
    }
}
