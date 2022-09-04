using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class Manutentionnaire : Employe
    {
        public int Heures { get; set; }
        private const double SALAIRE_HORAIRE = 65;

        public Manutentionnaire()
        {
        }

        public Manutentionnaire(string Nom, string prenom, int age, string dateEntree, int Heures) : base(Nom, prenom, age, dateEntree)
        {
            this.Heures = Heures;
        }

        public override double CalculSalaire()
        {
            return SALAIRE_HORAIRE * Heures;
        }

        public override string GetTitre()
        {
            return "Le Manutentionnaire ";
        }
    }
}
