using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PreagusFietsen.Model
{
    public class Bike : INotifyPropertyChanged 
    {
        private string _type;
        private string _gender;
        private string _size;
        private double _weightKg;
        private int _speed;
        private double _hourRateEur;
        private int _dailyRateEUR;


        public event PropertyChangedEventHandler PropertyChanged;


        public string Type { get => _type; set { _type = value; Notify("Type"); } }
        public string Gender { get => _gender; set { _gender = value; Notify("Gender"); } }
        public string Size { get => _size; set { _size = value; Notify("Size"); } }
        public double WeightKG { get => _weightKg; set { _weightKg = value; Notify("WeightKG"); } }
        public int Speed { get => _speed; set { _speed = value; Notify("Speed"); } }
        public double HourRateEUR { get => _hourRateEur; set { _hourRateEur = value; Notify("HourRateEUR"); } }
        public int DailyRateEUR { get => _dailyRateEUR; set { _dailyRateEUR = value; Notify("DailyRateEUR"); } }


        public void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }   
}
