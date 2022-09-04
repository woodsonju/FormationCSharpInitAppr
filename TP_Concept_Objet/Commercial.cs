using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
   public abstract class Commercial: Employe
    {

        public double ChiffreAffaire { get; set; }

        protected Commercial()
        {
        }

        public Commercial(string Nom, string prenom, int age, string dateEntree, double ChiffreAffaire) : base(Nom, prenom, age, dateEntree)
        {
            this.ChiffreAffaire = ChiffreAffaire;
        }
    }
}
