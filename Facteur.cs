using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    internal class Facteur : Employe
    {
        public Vehicule Vehicule { get; set; }
        // Car composition et non aggrégation.
        public List<Punch> Punchs { get; set; }
        public Facteur(Service service, int noEmploye, Vehicule vehicule) : base(service, noEmploye)
        {
            Vehicule = vehicule;
            Punchs = new List<Punch>();
        }
    }
}
