using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Concept_Objet
{
    public class Personnel : IPersonnel
    {
        public List<Employe> Employes { get; set; } //null

        public Personnel()
        {
            Employes = new List<Employe>();
        }

        public void AjouterEmploye(Employe employe)
        {
            Employes.Add(employe);
        }

        public void AfficherSalaires()
        {
            for (int i = 0; i < Employes.Count; i++)
            {
                Console.WriteLine(Employes[i].GetNom() + " gagne " + Employes[i].CalculSalaire() + " Euros.");
            }
        }

        public double SalaireMoyen()
        {
            double cumulSalaire = 0.0;
            foreach (var employe in Employes)
            {
                cumulSalaire += employe.CalculSalaire();
            }
            return cumulSalaire / Employes.Count;
        }
    }
}
