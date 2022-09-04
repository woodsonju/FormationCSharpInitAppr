using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class Representant: Commercial
    {
        private const double POURCENT_REPRESENTANT = 0.2;
        private const double BONUS_REPRESENTANT = 800;

        public Representant()
        {
        }

        public Representant(string Nom, string prenom, int age, string dateEntree, double ChiffreAffaire) : base(Nom, prenom, age, dateEntree, ChiffreAffaire)
        {
        }

        public override double CalculSalaire()
        {
            return (ChiffreAffaire * POURCENT_REPRESENTANT) + BONUS_REPRESENTANT;
        }

        public override string GetTitre()
        {
            return "Le represendant ";
        }
    }
}
