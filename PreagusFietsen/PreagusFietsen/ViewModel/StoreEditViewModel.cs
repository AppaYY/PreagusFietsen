using System.Collections.ObjectModel;
using PreagusFietsen.Model;

namespace PreagusFietsen.ViewModel
{
    class StoreEditViewModel
    {
        public ObservableCollection<Store> Stores { get; set; }

        public StoreEditViewModel(ObservableCollection<Store> Stores)
        {
            Stores = stores; // set the property Courses (that is bound to the view) to be the collection we get passed from the other View
        }
    }
}
