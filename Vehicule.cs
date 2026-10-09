using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    internal class Vehicule
    {
        public string Plaque { get; set; }
        public Service Service { get; set; }

        public Vehicule(string plaque, Service service)
        {
            Plaque = plaque;
            Service = service;
        }
    }
}
