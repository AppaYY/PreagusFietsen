using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreagusFietsen.Model
{
    class Bike { 
        //PROPERTIES
        public int ID { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public double WeightKG { get; set; }
        public int Speed { get; set; }
        public double HourRateEUR { get; set; }
        public int DailyRateEUR { get; set; }
    }
}
