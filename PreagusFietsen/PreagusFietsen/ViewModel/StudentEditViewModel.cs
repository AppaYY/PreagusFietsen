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
                    Type = "Schindelhauer Lotte",
                    Gender = "female",
                    Size = "large",
                    Weight = 11.0,
                    Speed = 11,
                    HourRate = 0.2,
                    DailyRate = 2,
                },
                new Bikes(){
                    ID = 2,
                    Type = "Whippet British Folding Bicycle",
                    Gender = "male",
                    Size = "small",
                    Weight = 11.5,
                    Speed = 9,
                    HourRate = 0.4,
                    DailyRate = 4,
                },
                new Bikes(){
                    ID = 3,
                    Type = "Budnitz Alpha Belt Drive Commuter Bicycle",
                    Gender = "male",
                    Size = "medium",
                    Weight = 11.5,
                    Speed = 8,
                    HourRate = 0.4,
                    DailyRate = 4,
                },
                new Bikes(){
                    ID = 4,
                    Type = "?",
                    Gender = "male",
                    Size = "small",
                    Weight = 11.5,
                    Speed = 9,
                    HourRate = 0.4,
                    DailyRate = 4,
                }
            };
        }
    }
}
