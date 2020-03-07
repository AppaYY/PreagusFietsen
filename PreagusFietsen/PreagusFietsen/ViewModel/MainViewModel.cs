using PreagusFietsen.Model;
using PreagusFietsen.View;
using System.Collections.ObjectModel;

namespace PreagusFietsen.ViewModel
{
    class MainViewModel
    {
        public RelayCommand OpenEditBikeWinClick { get; set; }
        public RelayCommand OpenEditStoreWinClick { get; set; }
        public ObservableCollection<Store> Stores { get; set; }
        public ObservableCollection<Bike> Bikes { get; set; }
        public Store SelectedStore{ get; set; }
        public MainViewModel()
        {
            // CREATE EMPTY LISTS
            Bikes = new ObservableCollection<Bike>();
            Stores = new ObservableCollection<Store>();

            SetData();
            OpenEditBikeWinClick = new RelayCommand(OpenEditBikeWin);
            OpenEditStoreWinClick = new RelayCommand(OpenEditStoreWin);
        }

        // OPEN EDIT BIKE BUTTON
        private void OpenEditBikeWin(object o)
        {
            // CREATE NEW BIKE EDIT VIEWMODEL & PASS VIEW WINDOW DATA
            BikeEditViewModel vm = new BikeEditViewModel { Bikes = SelectedStore.Bikes};
            // MAKE NEW VIEW WINDOW (View -> BikesEdit form)
            BikesEdit BikeView = new BikesEdit();
            // PASS VIEW WINDOW TO VIEWMODEL
            BikeView.DataContext = vm;

            // SHOW VIEW WINDOW
            BikeView.Show();
        }

        // OPEN EDIT STORE BUTTON
        private void OpenEditStoreWin(object o)
        {
            // CREATE NEW STORE EDIT VIEWMODEL & PASS VIEW WINDOW DATA
            StoreEditViewModel vm = new StoreEditViewModel { Stores = Stores }; 
            // MAKE NEW VIEW WINDOW (View -> BikesEdit form)
            StoresEdit StoreView = new StoresEdit();
            // PASS VIEW WINDOW TO VIEWMODEL
            StoreView.DataContext = vm;

            // SHOW VIEW WINDOW
            StoreView.Show();
        }

        // TEST DATA
        private void SetData()
        {
            Store store1 = new Store
            {
                Address = "1234AB 4",
                City = "Almere",
                MaxCapacity = 1334,
                Bikes = new ObservableCollection<Bike>()
            };

            Bike bike1 = new Bike
            {
                Type = "Schindelhauer Lotte",
                Gender = "female",
                Size = "large",
                WeightKG = 11.0,
                Speed = 11,
                HourRateEUR = 0.6,
                DailyRateEUR = 6,
            };

            Bike bike2 = new Bike
            {
                Type = "Whippet British Folding Bicycle",
                Gender = "male",
                Size = "small",
                WeightKG = 11.5,
                Speed = 9,
                HourRateEUR = 0.4,
                DailyRateEUR = 4,
            };

            Bike bike3 = new Bike
            {
                Type = "Budnitz Alpha Belt Drive Commuter Bicycle",
                Gender = "male",
                Size = "medium",
                WeightKG = 11.5,
                Speed = 8,
                HourRateEUR = 0.2,
                DailyRateEUR = 2,
            };

            Bike bike4 = new Bike
            {
                Type = "Mokumono Delta Sportive Commuter Bike",
                Gender = "male",
                Size = "medium",
                WeightKG = 12.0,
                Speed = 11,
                HourRateEUR = 0.6,
                DailyRateEUR = 6,
            };
            
            // CONNECT BIKE TO STORE
            store1.Bikes.Add(bike1);
            store1.Bikes.Add(bike2);
            store1.Bikes.Add(bike3);
            store1.Bikes.Add(bike4);

            // ADD STORE DATA TO STORE COLLECTION
            Stores.Add(store1);

            // ADD BIKE DATA TO BIKE COLLECTION
            Bikes.Add(bike1);
            Bikes.Add(bike2);
            Bikes.Add(bike3);
            Bikes.Add(bike4);
        }
    }
}
