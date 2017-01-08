using GalaSoft.MvvmLight;
using PROG6_2016_Tamagotchi.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Timers;

namespace Tamagotchi.WPF.ViewModel
{
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private bool _loading { get; set; }
        private Database _database { get; set; }
        private List<PROG6_2016_Tamagotchi.Models.Tamagotchi> _tamagotchi;

        public List<PROG6_2016_Tamagotchi.Models.Tamagotchi> Tamagotchi
        {
            get
            {
                return _tamagotchi;
            }

            set
            {
                _tamagotchi = value;
                RaisePropertyChanged("Tamagotchi");
            }
        }

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
            if (_loading) return;

            _loading = true;
            Tamagotchi = new List<PROG6_2016_Tamagotchi.Models.Tamagotchi>(_database.Tamagotchis);
            _loading = false;
        }
    }
}