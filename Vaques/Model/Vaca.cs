using System;
using System.Collections.Generic;
using System.Text;

namespace Vaques.Model
{
    public class Vaca
    {
        public Vaca(string nom, double pes, Raca raca)
        {
            Nom = nom;
            Pes = pes;
            Raca = raca;
        }

        public string Nom { get; set; }
        public virtual double Pes { get; set; }

        public Raca Raca { get; }

        public virtual double GetLitres() => Pes * Raca.LitresPerKg;
    }
}
