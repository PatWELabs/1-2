using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    internal class Service
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public Service(string Nom, string Adresse)
        {
            this.Nom = Nom;
            this.Adresse = Adresse;
        }
    }
}
