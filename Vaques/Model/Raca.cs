using System;
using System.Collections.Generic;
using System.Text;

namespace Vaques.Model
{
   public class Raca
    {
        public static string Desconeguda = "Desconeguda";
        public Raca(string nom, double litres)
        {
            if (string.IsNullOrWhiteSpace(nom))
            {
                nom = Desconeguda;
            }
            Nom = nom;
            LitresPerKg = litres;
        }

        public string Nom { get; }
        public virtual double LitresPerKg { get; }
    }
}
