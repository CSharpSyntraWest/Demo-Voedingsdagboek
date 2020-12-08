using Demo_Voedingsdagboek.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Voedingsdagboek.Models
{
    public class VoedingsConsumptie: ObservableObject
    {
        private DateTime _datum;
        private int _gewicht;
        private Product _product;
        private Klant _klant;

        public Klant Klant
        {
            get { return _klant; }
            set { _klant = value; }
        }
        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }
     
        public int Gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }

        public DateTime Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }

        public override string ToString()
        {
            return this.Datum.ToString("dd-MM") + " " + this.Klant.Naam + " " +  this.Product.Naam +  " " + Gewicht +  "g";
        }
    }
}
