using System.Windows;
using PreagusFietsen.ViewModel;
using PreagusFietsen.View;

namespace PreagusFietsen
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //GET DATA FROM ViewModel -> MainViewModel
            DataContext = new MainViewModel();
        }

    }
}
