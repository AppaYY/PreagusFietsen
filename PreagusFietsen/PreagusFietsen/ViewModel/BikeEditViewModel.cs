using System.Collections.ObjectModel;
using PreagusFietsen.Model;
using System.Windows;

namespace PreagusFietsen.ViewModel
{
    class BikeEditViewModel
    {
        public ObservableCollection<Bike> Bikes { get; set; }
        public Bike SelectedBike { get; set; }
        public RelayCommand ChangeNameClick { get; set; }
        public RelayCommand DeleteClick { get; set; }
        public RelayCommand AddClick { get; set; }
        public BikeEditViewModel(ObservableCollection<Bike> bikes)
        {
            Bikes = bikes; // set the property Courses (that is bound to the view) to be the collection we get passed from the other View
            ChangeNameClick = new RelayCommand(ChangeName);
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

        public void ChangeName(object a)
        {
            if (SelectedBike != null)
            {
                SelectedBike.Type = "CHANGED TYPE";
            }
            else
            {
                MessageBox.Show("Please select a bike please");
            }
        }

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