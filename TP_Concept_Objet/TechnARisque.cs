using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class TechnARisque: Technicien
    {
        private const double PRIME = 200;

        public TechnARisque()
        {
        }

        public TechnARisque(string Nom, string prenom, int age, string dateEntree, int Unites) : base(Nom, prenom, age, dateEntree, Unites)
        {
        }

        public override double CalculSalaire()
        {
            return base.CalculSalaire() + PRIME;
        }

        public override string GetTitre()
        {
            return "Le technicien ";
        }
    }
}
