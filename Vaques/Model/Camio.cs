using System;
using System.Collections.Generic;
using System.Text;

namespace Vaques.Model
{
    public class Camio
    {
        public Camio(double pesMax) {
            PesMaxim = pesMax;            
            Vaques = new List<Vaca>();
            Pes = 0;
        }
        private double Pes { get; set; }
        public double PesMaxim { get; }
        public List<Vaca> Vaques { get; }
        public bool EntraVaca(Vaca vaca) {

            if (Pes + vaca.Pes > PesMaxim)
                return false;
            Pes += vaca.Pes;
            Vaques.Add(vaca);
            return true;
        }

        public bool TreureVaca(Vaca vaca)
        {            
            return Vaques.Remove(vaca); 
        }
    }
}
