using System.Collections.ObjectModel;
using PreagusFietsen.Model;

namespace PreagusFietsen.ViewModel
{
    class BikeEditViewModel
    {
        public ObservableCollection<Bike> Bikes { get; set; }

        public BikeEditViewModel(ObservableCollection<Bike> bikes)
        {
            Bikes = bikes; // set the property Courses (that is bound to the view) to be the collection we get passed from the other View
        }   
    }
}
