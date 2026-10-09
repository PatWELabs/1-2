using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    internal class Punch
    {
        public DateTime DateHeureArrive { get; set; }
        public DateTime? DateHeureSortie { get; set; }
        public double SalaireHoraire { get; set; }
        public Facteur Facteur { get; set; }
        public Punch(DateTime dateHeureArrive, double salaireHoraire, Facteur facteur)
        {
            DateHeureArrive = dateHeureArrive;
            SalaireHoraire = salaireHoraire;
            Facteur = facteur;
        }
    }
}
