using Demo_Voedingsdagboek.Models;
using Demo_Voedingsdagboek.Services;
using Demo_Voedingsdagboek.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_Voedingsdagboek.ViewModels
{
    public class ConsumptieViewModel:ObservableObject
    {
        private IDataService _dataservice;
        private ObservableCollection<VoedingsConsumptie> _consumpties;
        private VoedingsConsumptie _selectedConsumptie;
        public ConsumptieViewModel(IDataService dataservice)
        {
            _dataservice = dataservice;
            _consumpties = new ObservableCollection<VoedingsConsumptie>(_dataservice.GeefAlleConsumpties());
        }
        public VoedingsConsumptie SelectedConsumptie
        {
            get { return _selectedConsumptie; }
            set { OnPropertyChanged(ref _selectedConsumptie, value); }
        }
        public ObservableCollection<VoedingsConsumptie> Consumpties
        {
            get { return _consumpties; }
            set { OnPropertyChanged(ref _consumpties, value); }
        }
    }
}
