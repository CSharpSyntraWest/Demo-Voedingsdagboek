using Demo_Voedingsdagboek.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Voedingsdagboek.Models
{
    public enum Geslacht
    {
        Man,
        Vrouw
    }
    public class Klant : ObservableObject
    {
        private int _klantID;
        private List<VoedingsConsumptie> _consumpties;
        private string _naam;
        private string _adres;
        private int _postcode;
        private string _woonplaats;
        private string _telNr;
        private string _email;
        private Geslacht _geslacht;
        private DateTime _geboorteDatum;
        private float _lengte;

        public int KlantID { get { return _klantID; } set { _klantID = value; } }
        public string Naam { get { return _naam; } set { _naam = value; } }
        public string Adres { get { return _adres; } set { _adres = value; } }
        public int Postcode { get { return _postcode; } set { _postcode = value; } }
        public string Woonplaats { get { return _woonplaats; } set { _woonplaats = value; } }
        public string TelNr { get { return _telNr; } set { _telNr = value; } }

        public string Email { get { return _email; } set { _email = value; } }
        public Geslacht Geslacht { get { return _geslacht; } set { _geslacht = value; } }
        public DateTime GeboorteDatum { get { return _geboorteDatum; } set { _geboorteDatum = value; } }
        public float Lengte { get { return _lengte; } set { _lengte = value; } }

        public Klant()
        {
            _consumpties = new List<VoedingsConsumptie>();
        }
        public List<VoedingsConsumptie> Consumpties
        {
            get { return _consumpties; }
            set { _consumpties = value; }
        }
    }
}
