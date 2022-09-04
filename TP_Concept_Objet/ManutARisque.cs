using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class ManutARisque: Manutentionnaire
    {
        private const double PRIME = 200;

        public ManutARisque()
        {
        }

        public ManutARisque(string Nom, string prenom, int age, string dateEntree, int Heures) : base(Nom, prenom, age, dateEntree, Heures)
        {
        }

        public override double CalculSalaire()
        {
            return base.CalculSalaire() + PRIME;
        }

        public override string GetTitre()
        {
            return "Le manutentionnaire ";
        }
    }
}
