using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreagusFietsen.Model;

namespace PreagusFietsen.ViewModel
{
    class StudentEditViewModel
    {
        public List<Bikes> BikeList { get; set; }

        public StudentEditViewModel()
        {
            BikeList = new List<Bikes>
            {
                new Bikes()
                {
                    ID = 1,
                    Type = "testType",
                    Gender = "male",
                }
            };
        }
    }
}
