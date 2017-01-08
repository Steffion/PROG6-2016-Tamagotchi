using GalaSoft.MvvmLight;
using PROG6_2016_Tamagotchi.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Timers;

namespace Tamagotchi.WPF.ViewModel
{
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private Database _database;

        public ObservableCollection<PROG6_2016_Tamagotchi.Models.Tamagotchi> Tamagotchi { get; set; }

        public MainViewModel()
        {
            _database = new Database();

            Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(UpdateTamagotchi);
            myTimer.Interval = 2000;
            myTimer.Enabled = true;
        }

        public void UpdateTamagotchi(object source, ElapsedEventArgs e)
        {
            Tamagotchi = new ObservableCollection<PROG6_2016_Tamagotchi.Models.Tamagotchi>();

            foreach (PROG6_2016_Tamagotchi.Models.Tamagotchi tamagotchi in _database.Tamagotchis)
            {
                Tamagotchi.Add(tamagotchi);
            }

            RaisePropertyChanged("Tamagatochi");
        }
    }
}