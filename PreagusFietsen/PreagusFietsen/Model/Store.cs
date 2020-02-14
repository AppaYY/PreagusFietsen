using System.Collections.ObjectModel;
using System.ComponentModel;


namespace PreagusFietsen.Model
{
    public class Store : INotifyPropertyChanged
    {
        private string _address;
        private string _city;
        private int _maxCapacity;
        private ObservableCollection<Bike> _bikes;


        public event PropertyChangedEventHandler PropertyChanged;


        public string Address { get => _address; set { _address = value; Notify("Address"); } }
        public string City { get => _city; set { _city = value; Notify("City"); } }
        public int MaxCapacity { get => _maxCapacity; set { _maxCapacity = value; Notify("MaxCapacity"); } }
        public ObservableCollection<Bike> Bikes { get => _bikes; set { _bikes = value; Notify("Bikes"); } }


        public Store() 
        {
            Bikes = new ObservableCollection<Bike>();
        }


        public void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
