using System.Windows;
using PreagusFietsen.ViewModel;
using PreagusFietsen.View;

namespace PreagusFietsen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //GET DATA FROM ViewModel -> MainViewModel
            DataContext = new MainViewModel();
        }

        //OPEN EDIT BIKE BUTTON
        private void openEditBikeWin(object sender, RoutedEventArgs e)
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

        private void openEditStoreWin(object sender, RoutedEventArgs e)
        {
            MainViewModel svm = (MainViewModel)DataContext;

            StoreEditViewModel editsvm = new StoreEditViewModel(svm.Stores);

            StoresEdit StoreView = new StoresEdit();

            StoreView.DataContext = editsvm;

            StoreView.Show();
        }
    }
}
