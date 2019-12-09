using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreagusFietsen.Model;
// Observable collection import
using System.Collections.ObjectModel;

namespace PreagusFietsen.ViewModel
{
    class BikeViewModel
    {
        public ObservableCollection<Bikes> BikeList { get; set; }

        public BikeViewModel()
        {
            BikeList = new ObservableCollection<Bikes>
            {
                new Bikes()
                {
                    ID = 1,
                    Type = "Schindelhauer Lotte",
                    Gender = "female",
                    Size = "large",
                    WeightKG = 11.0,
                    Speed = 11,
                    HourRateEUR = 0.6,
                    DailyRateEUR = 6,
                },
                new Bikes(){
                    ID = 2,
                    Type = "Whippet British Folding Bicycle",
                    Gender = "male",
                    Size = "small",
                    WeightKG = 11.5,
                    Speed = 9,
                    HourRateEUR = 0.4,
                    DailyRateEUR = 4,
                },
                new Bikes(){
                    ID = 3,
                    Type = "Budnitz Alpha Belt Drive Commuter Bicycle",
                    Gender = "male",
                    Size = "medium",
                    WeightKG = 11.5,
                    Speed = 8,
                    HourRateEUR = 0.2,
                    DailyRateEUR = 2,
                },
                new Bikes(){
                    ID = 4,
                    Type = "Mokumono Delta Sportive Commuter Bike",
                    Gender = "male",
                    Size = "medium",
                    WeightKG = 12.0,
                    Speed = 11,
                    HourRateEUR = 0.6,
                    DailyRateEUR = 6,
                }
            };
        }
    }
}
