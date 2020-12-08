using Demo_Voedingsdagboek.Models;
using Demo_Voedingsdagboek.Services;
using Demo_Voedingsdagboek.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_Voedingsdagboek.ViewModels
{
    public class KlantenViewModel:ObservableObject
    {
        private IDataService _dataservice;
        private ObservableCollection<Klant> _klanten;
        private Klant _selectedKlant;
        public KlantenViewModel(IDataService dataservice)
        {
            _dataservice = dataservice;
            _klanten = new ObservableCollection<Klant>(_dataservice.GeefAlleKlanten());
        }
        public Klant SelectedKlant
        {
            get { return _selectedKlant; }
            set { OnPropertyChanged(ref _selectedKlant, value); }
        }
        public ObservableCollection<Klant> Klanten
        { 
            get{ return _klanten; }
            set { OnPropertyChanged(ref _klanten, value); }
        }
    }
}
