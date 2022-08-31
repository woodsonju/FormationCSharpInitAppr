using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Encapsulation
{
    public class CompteBancaire
    {

        public string Numero { get; set; } 
        public double Solde { get; set; } 

        public static int NbCompte { get; set; }

        public static string Banque = "Credit Lyonnais";

        public CompteBancaire()
        {
            NbCompte++;
        }

        public CompteBancaire(string Numero, double Solde) : this(Numero)
        {
            //this : Represente l'objet dans lequel nous nous trouvons 
            //On peut faire appel à this pour acceder à une propriété de la même classe
       //   this.Numero = Numero;
            this.Solde = Solde;
        }

        public CompteBancaire(string numero) : this()
        {
            Numero = numero;
        }


        //Pour comparer sémantiquement deux instance on redefini la méthode Equals de la classe Object
        public override bool Equals(object obj)
        {
            CompteBancaire cb = obj as CompteBancaire;

            //On vérifie si l'objet passé en paramètre est null 
            if(cb== null)
            {
                return false;
            }

            //Comparé les propriétés de l'instance courante et de l'objet passé en paramètre 
            return this.Numero == cb.Numero && this.Solde == cb.Solde;
        }

        //Nous nous serons du fait que chaque variable de la classe possède déjà un identifiant obtenu 
        //avec la même GetHascode(). 
        //En combinant chaque identifiant de chaque propriété nous pouvons créer un nouveau
        public override int GetHashCode()
        {
            return Numero.GetHashCode() * Solde.GetHashCode(); 
        }

        public override string ToString()
        {
            return "Numero : " + Numero + " - " + "Solde : " + Solde;
        }

    }
}
