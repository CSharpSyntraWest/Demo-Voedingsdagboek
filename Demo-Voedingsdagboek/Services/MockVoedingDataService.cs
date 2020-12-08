using Demo_Voedingsdagboek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_Voedingsdagboek.Services
{
    public class MockVoedingDataService : IDataService
    {
        private IList<Klant> _klanten;
        private IList<Product> _producten;
        private IList<VoedingsConsumptie> _consumpties;

        public MockVoedingDataService()
        {
            InitLijsten();
        }

        private void InitLijsten()
        {
            InitProducten();
            InitConsumpties();
            InitKlanten();
        }
        private void InitProducten()
        {
            _producten = new List<Product>()
           {
               new Product(){ ProductID = 1, Naam="Chocolade", EnKcal=550,Vet=10,KH=55,Eiwit=0},
               new Product(){ProductID = 2,  Naam="Melk, magere", EnKcal=100,KH=2,Eiwit=2},
               new Product(){ ProductID = 3, Naam="Melk, Volle", EnKcal=150,KH=3,Eiwit=2}
           };
        }
        private void InitConsumpties()
        {
            _consumpties = new List<VoedingsConsumptie>()
            {
                new VoedingsConsumptie(){Datum = new DateTime(2020,12,8), Gewicht=25, Product = _producten[0]},
                new VoedingsConsumptie(){Datum = new DateTime(2020,12,8), Gewicht=100, Product = _producten[1]},
                new VoedingsConsumptie(){Datum = new DateTime(2020,12,7), Gewicht=110, Product = _producten[2]},
            };
        }
        private void InitKlanten()
        {
            _klanten = new List<Klant>()
            {
                new Klant() { KlantID=1, Geslacht=Geslacht.Man,Naam="Jan Jansen"},
                new Klant() { KlantID=2,Geslacht=Geslacht.Vrouw,Naam="Joke De Klos"}
            };
            _klanten[0].Consumpties.Add(_consumpties[0]);
            _klanten[0].Consumpties.Add(_consumpties[1]);
            _klanten[1].Consumpties.Add(_consumpties[2]);
        }

        public IList<Klant> VoegKlantToe(Klant klant)
        {
            int newId = _klanten.Count == 0 ? 1 : _klanten.Max(k => k.KlantID) + 1;
            klant.KlantID = newId;
            _klanten.Add(klant);
            return _klanten;
        }
        public void WijzigKlant(Klant klant)
        {
            int index = _klanten.IndexOf(klant);
            if (index >= 0) _klanten[index] = klant;
        }

        public IList<Klant> VerwijderKlant(Klant klant)
        {
            _klanten.Remove(klant);
            return _klanten;
        }
        public IList<VoedingsConsumptie> VoegConsumptieToeVoorKlant(int KlantIndex, VoedingsConsumptie consumptie)
        {
            _klanten[KlantIndex].Consumpties.Add(consumptie);
            return _klanten[KlantIndex].Consumpties;
        }
        public IList<Klant> GeefAlleKlanten()
        {
            return _klanten;
        }
        public IList<Product> GeefAlleProducten()
        {
            return _producten;
        }
        public IList<Klant> GeefConsumptiesVoorKlant(Klant klant)
        {
            return (IList<Klant>)klant.Consumpties;
        }
    }
}
