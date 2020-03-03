using System.Collections.ObjectModel;
using PreagusFietsen.Model;
using System.Windows;

namespace PreagusFietsen.ViewModel
{
    class BikeEditViewModel
    {
        public ObservableCollection<Bike> Bikes { get; set; }
        public Bike SelectedBike { get; set; }
        public RelayCommand DeleteClick { get; set; }
        public RelayCommand AddClick { get; set; }
        public BikeEditViewModel()
        {
            // Use the collection Bikes from the other View as a later property for Stores
            DeleteClick = new RelayCommand(DeleteBike);
            AddClick = new RelayCommand(AddBike);
        }

        // ADD BIKE VALUES
        public string bikeType { get; set; }
        public string bikeGender { get; set; }
        public string bikeSize { get; set; }
        public double bikeWeight { get; set; }
        public int bikeSpeed { get; set; }
        public double bikeHourRate { get; set; }
        public int bikeDailyRate { get; set; }


        public void DeleteBike(object a)
        {
            if (SelectedBike != null)
            {
                Bikes.Remove(SelectedBike);
            }
            else
            {
                MessageBox.Show("Please select a bike please");
            }
        }
        
        public void AddBike(object a)
        {
            var data = new Bike
            {
                Type = bikeType,
                Gender = bikeGender,
                Size = bikeSize,
                WeightKG = bikeWeight,
                Speed = bikeSpeed,
                HourRateEUR = bikeHourRate,
                DailyRateEUR = bikeDailyRate,
            };

            Bikes.Add(data);
        }
    }


}  