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
        public RelayCommand OpenStoreListClick { get; set; }
        public RelayCommand OpenBikeListClick { get; set; }
        public MainViewModel()
        {
            OpenStoreListClick = new RelayCommand(OpenStoreList);
            OpenBikeListClick = new RelayCommand(OpenBikeList);

            Stores = new ObservableCollection<Store>
            {
                new Store
                {
                    Address = "1234AB 4",
                    City = "Almere",
                    MaxCapacity = 1334,
                    Bikes = new ObservableCollection<Bike>
                    {
                        new Bike()
                        {
                            Type = "Schindelhauer Lotte",
                            Gender = "female",
                            Size = "large",
                            WeightKG = 11.0,
                            Speed = 11,
                            HourRateEUR = 0.6,
                            DailyRateEUR = 6,
                        },
                        new Bike(){
                            Type = "Whippet British Folding Bicycle",
                            Gender = "male",
                            Size = "small",
                            WeightKG = 11.5,
                            Speed = 9,
                            HourRateEUR = 0.4,
                            DailyRateEUR = 4,
                        },
                        new Bike(){
                            Type = "Budnitz Alpha Belt Drive Commuter Bicycle",
                            Gender = "male",
                            Size = "medium",
                            WeightKG = 11.5,
                            Speed = 8,
                            HourRateEUR = 0.2,
                            DailyRateEUR = 2,
                        },
                        new Bike(){
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

        public void OpenStoreList(object a)
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

        public void OpenBikeList(object a)
        {
            //GET DATA FROM ViewModel -> MainViewModel
            MainViewModel bvm = (MainViewModel)DataContext;
            if (bvm.SelectedStore == null)
            {
                MessageBox.Show("Select a store please");
            }
            else
            {
                //PASS ON DATA TO ViewModel -> BikeEditViewModel
                BikeEditViewModel editbvm = new BikeEditViewModel(bvm.SelectedStore.Bikes);

                //MAKE NEW VIEW WINDOW (View -> BikesEdit form)
                BikesEdit BikeView = new BikesEdit();
                //PASS VIEW WINDOW TO VIEWMODEL
                BikeView.DataContext = editbvm;
                //SHOW VIEW WINDOW
                BikeView.Show();
            }
        }
    }
}
