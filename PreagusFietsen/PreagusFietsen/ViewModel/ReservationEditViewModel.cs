using System.Collections.ObjectModel;
using PreagusFietsen.Model;
using System.Windows;
using System;



namespace PreagusFietsen.ViewModel
{
    class ReservationEditViewModel
    {
        public ObservableCollection<Reservation> Reservations { get; set; }
        public Reservation SelectedReservation { get; set; }
        public RelayCommand DeleteClick { get; set; }
        public RelayCommand AddClick { get; set; }
        public ReservationEditViewModel(ObservableCollection<Reservation> reservations)
        {
            Reservations = reservations;
            DeleteClick = new RelayCommand(DeleteReservation);
            AddClick = new RelayCommand(AddReservation);
        }

        public int ReservationID { get; set; }
        public int ReservationCustomerID { get; set; }
        public int ReservationBikesID { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
        public int ReservationPickupStoreID { get; set; }
        public int ReservationDropoffStoreID { get; set; }


        public void DeleteReservation(object a)
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

        public void AddReservation(object a)
        {
           
            var data = new Reservation
            {
                ID = ReservationID,
                CustomerID = ReservationCustomerID,
                BikesID = ReservationBikesID,
                Start = ReservationStart,
                End = ReservationEnd,
                PickupStoreID = ReservationPickupStoreID,
                DropoffStoreID = ReservationDropoffStoreID,
            };
            
            Reservations.Add(data);
           
        }
    }


}