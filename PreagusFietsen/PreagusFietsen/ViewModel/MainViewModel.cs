using PreagusFietsen.Model;
// Observable collection import
using System.Collections.ObjectModel;

namespace PreagusFietsen.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<Store> Stores { get; set; }
        public ObservableCollection<Bike> Bikes { get; set; }
        public Store SelectedStore{ get; set; }
        public MainViewModel()
        {
            Stores = new ObservableCollection<Store>
            {
                new Store
                {
                    ID = 1,
                    Address = "1234AB 4",
                    City = "Almere",
                    MaxCapacity = 1334,
                    Bikes = new ObservableCollection<Bike>
                    {
                        new Bike()
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
                        new Bike(){
                            ID = 2,
                            Type = "Whippet British Folding Bicycle",
                            Gender = "male",
                            Size = "small",
                            WeightKG = 11.5,
                            Speed = 9,
                            HourRateEUR = 0.4,
                            DailyRateEUR = 4,
                        },
                        new Bike(){
                            ID = 3,
                            Type = "Budnitz Alpha Belt Drive Commuter Bicycle",
                            Gender = "male",
                            Size = "medium",
                            WeightKG = 11.5,
                            Speed = 8,
                            HourRateEUR = 0.2,
                            DailyRateEUR = 2,
                        },
                        new Bike(){
                            ID = 4,
                            Type = "Mokumono Delta Sportive Commuter Bike",
                            Gender = "male",
                            Size = "medium",
                            WeightKG = 12.0,
                            Speed = 11,
                            HourRateEUR = 0.6,
                            DailyRateEUR = 6,
                        }
                    }
                }
            };
        }
    }
}
