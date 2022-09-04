using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class Technicien : Employe
    {
        public int Unites { get; set; } //0

        private const double FACTEUR_UNITE = 5;

        public Technicien()
        {
        }

        public Technicien(string Nom, string prenom, int age, string dateEntree, int Unites) : base(Nom, prenom, age, dateEntree)
        {
            this.Unites = Unites;
        }

        public override double CalculSalaire()
        {
            return Unites * FACTEUR_UNITE;
        }

        public override string GetTitre()
        {
            return "Le technicien ";
        }
    }
}
