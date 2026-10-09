using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    internal class Employe
    {
        public Service Service { get; set; }
        public int NoEmploye { get; set; }
        public Employe(Service service, int noEmploye)
        {
            Service = service;
            NoEmploye = noEmploye;
        }
    }
}
