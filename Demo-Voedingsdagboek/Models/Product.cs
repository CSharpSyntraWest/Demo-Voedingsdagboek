using Demo_Voedingsdagboek.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Voedingsdagboek.Models
{
    public class Product:ObservableObject
    {
        private int _productID;

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public string Naam { get; set; }
        public short Portie { get; set; }
        public short EnKcal { get; set; }
        public int EnKJ { get; set; }
        public float Eiwit { get; set; }
        public float Vet { get; set; }
        public float VV { get; set; }
        public float EOV { get; set; }
        public float MOV { get; set; }
        public float Linol { get; set; }
        public float Chol { get; set; }
        public float KH { get; set; }
        public float Suikers { get; set; }
        public float ZML { get; set; }
        public float VdVz { get; set; }
        public float Water { get; set; }
        public float Na { get; set; }
        public float K { get; set; }
        public float Ca { get; set; }
        public float P { get; set; }
        public float Mg { get; set; }
        public float Fe { get; set; }
        public float Cu { get; set; }
        public float Zn { get; set; }
        public float VitA { get; set; }
        public float VitB1 { get; set; }
        public float VitB2 { get; set; }
        public float VitB12 { get; set; }
        public float Vitc { get; set; }
        public string Klasse { get; set; }
        public float VitD { get; set; }
        public float VitE { get; set; }
        public float Zout { get; set; }
    }
}
