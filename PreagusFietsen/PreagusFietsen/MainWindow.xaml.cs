using System.Windows;
using PreagusFietsen.ViewModel;

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

            DataContext = new BikeViewModel();
        }
    }
}
