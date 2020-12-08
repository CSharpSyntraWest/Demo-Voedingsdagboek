using Demo_Voedingsdagboek.Services;
using Demo_Voedingsdagboek.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Voedingsdagboek.ViewModels
{
    public class MainViewModel:ObservableObject
    {
        private IDataService _dataservice;
        private KlantenViewModel _klantenViewModel;
        public MainViewModel()
        {
            _dataservice = new MockVoedingDataService();
            _klantenViewModel = new KlantenViewModel(_dataservice);
        }
        public KlantenViewModel KlantenVM
        {
            get { return _klantenViewModel; }
            set { OnPropertyChanged(ref _klantenViewModel, value); }
        }

    }
}
