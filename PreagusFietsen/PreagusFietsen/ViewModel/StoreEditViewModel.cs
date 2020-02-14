using System.Collections.ObjectModel;
using System.Windows;
using PreagusFietsen.Model;

namespace PreagusFietsen.ViewModel
{
    class StoreEditViewModel
    {
        public ObservableCollection<Store> Stores { get; set; }
        public Store SelectedStore { get; set; }
        public RelayCommand ChangeNameClick { get; set; }
        public RelayCommand DeleteClick { get; set; }
        public RelayCommand AddClick { get; set; }
        public StoreEditViewModel(ObservableCollection<Store> stores)
        {
            Stores = stores; // set the property Courses (that is bound to the view) to be the collection we get passed from the other View
            ChangeNameClick = new RelayCommand(ChangeName);
            DeleteClick = new RelayCommand(DeleteStore);
            AddClick = new RelayCommand(AddStore);
        }

        //ADDING STORE VALUES
        public string Address { get; set; }
        public string City { get; set; }
        public int MaxCapacity { get; set; }

        public void AddStore(object a)
        {
            var data = new Store
            {
                Address = Address,
                City = City,
                MaxCapacity = MaxCapacity,
            };

            Stores.Add(data);
        }

        public void ChangeAddress(object a)
        {
            if (SelectedStore != null)
            {
                SelectedStore.Address = "CHANGED ADDRESS";
            }
            else
            {
                MessageBox.Show("Please select a Store please");
            }
        }

        public void DeleteStore(object a)
        {
            if (SelectedStore != null)
            {
                Stores.Remove(SelectedStore);
            }
            else
            {
                MessageBox.Show("Please select a Store please");
            }
        }


    }
}