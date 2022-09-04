using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class Vendeur : Commercial
    {
      
        private const double POURCENT_VENDEUR = 0.2;
        private const double BONUS_VENDEUR = 400;

        public Vendeur()
        {
        }

        public Vendeur(string Nom, string prenom, int age, string dateEntree, double ChiffreAffaire) : base(Nom, prenom, age, dateEntree, ChiffreAffaire)
        {
        }

        public override double CalculSalaire()
        {
            return (ChiffreAffaire * POURCENT_VENDEUR) + BONUS_VENDEUR;
        }

        public override string GetTitre()
        {
            return "Le vendeur ";
        }
    }
}
