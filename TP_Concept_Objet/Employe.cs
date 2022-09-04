using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public abstract class Employe
    {
        //public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string DateEntree { get; set; }

        public Employe()
        {
        }

        public Employe(string Nom, string prenom, int age, string dateEntree)
        {
            this.Nom = Nom;
            Prenom = prenom;
            Age = age;
            DateEntree = dateEntree;
        }

        public abstract double CalculSalaire();

        public  string GetNom()
        {
            return this.GetTitre() + this.Prenom + " " + this.Nom;
        }

        public virtual string GetTitre()
        {
            return "L'employé ";
        }
    }
}
