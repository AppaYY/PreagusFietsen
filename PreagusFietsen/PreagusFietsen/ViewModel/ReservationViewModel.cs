using System.Collections.ObjectModel;
using PreagusFietsen.Model;
using System.Windows;

namespace PreagusFietsen.ViewModel
{
    class ReservationEditViewModel
    {
        public ObservableCollection<Reservation> Reservation { get; set; }
        public Bike SelectedBike { get; set; }
        public RelayCommand DeleteClick { get; set; }
        public RelayCommand AddClick { get; set; }
        public ReservationEditViewModel(ObservableCollection<Reservation> Reservations)
        {
            Reservations = Reservations; 
            ChangeNameClick = new RelayCommand(ChangeName);
            DeleteClick = new RelayCommand(DeleteReservation);
            AddClick = new RelayCommand(AddReservation);
        }

       
        public int ReservationCustomerID { get; set; }
        public List<int> ReservationBikesID { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
        public int ReservationPickupStoreID { get; set; }
        public int ReservationDropoffStoreID { get; set; }
   

        public void addSelectedReservation(object a)
        {
            if (SelectedReservation != null)
            {
                Reservations.Remove(SelectedReservation);
            }
            else
            {
                MessageBox.Show("Please select a bike please");
            }
        }

        public void removeSelectedReservation(object a)
        {
            var data = new Bike
            {
                CustomerID = CustomerID,
                BikesID = BikesID,
                Start = Start,
                End = End,
                PickupStoreID = PickupStoreID,
                DropoffStoreID = DropoffStoreID,
            };

           Reservation.Add(data);
        }
    }


}