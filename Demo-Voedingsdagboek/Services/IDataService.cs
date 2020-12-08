using Demo_Voedingsdagboek.Models;
using System.Collections.Generic;

namespace Demo_Voedingsdagboek.Services
{
    public interface IDataService
    {
        IList<Klant> GeefAlleKlanten();
        IList<Product> GeefAlleProducten();
        IList<Klant> GeefConsumptiesVoorKlant(Klant klant);
        IList<Klant> VerwijderKlant(Klant klant);
        IList<VoedingsConsumptie> VoegConsumptieToeVoorKlant(int KlantIndex, VoedingsConsumptie consumptie);
        IList<Klant> VoegKlantToe(Klant klant);
        void WijzigKlant(Klant klant);
    }
}