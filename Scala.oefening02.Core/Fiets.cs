using System;
using System.Collections.Generic;
using System.Text;

namespace Scala.Oefening02.Core
{
    public class Fiets
    {
        public string Merk { get; set; }
        public string Serie { get; set; }
        public decimal VerkoopprijsEuro { get; set; }
        public bool IsElektrisch { get; set; }
        public byte AantalWielen { get; set; }

        public Fiets()
        {
        }
        public Fiets(string merk, string serie, decimal verkoopprijsEuro, bool isElektrisch, byte aantalWielen)
        {
            Merk = merk;
            Serie = serie;
            VerkoopprijsEuro = verkoopprijsEuro;
            IsElektrisch = isElektrisch;
            AantalWielen = aantalWielen;
        }
        public override string ToString()
        {
            return $"{Merk} - {Serie}";
        }
        public decimal GetVerkoopprijsAndereMunt(double wisselkoers)
        {
            return VerkoopprijsEuro * (decimal)wisselkoers;

            // £ = 0.88;
            // $ = 1.2;
        }

    }
}
