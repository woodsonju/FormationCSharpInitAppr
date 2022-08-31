using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Encapsulation
{
    public class Rectangle
    {
        //Propriété simple : Une propriété sans contrainte
        //get : envoie une valeur du même type que la propriété
        //set : permet de mettre à jour la propriété 
        /*        public double Longueur { get; set; }  
                public double Largeur { get; set; }*/

        //Propriété FULL 
        //Champs privé : permet de cahcher l'étatt interne de l'objet
        private double longueur;

        //C'est une pair de méthode permettant l'acccès à un attribut\champs grace au mot clé get et set
        //Avec le mot clé set, on donne la possibilité d'affecter une valeur aux champs privé 
        //Avec le mot clé get, on donne la possibilité de lire un champs privé
        //value : est un mot clé qui permet de dire : la valeur que nous avons affectée à la propriété
        public double Longueur
        {
            get 
            {
                return longueur; 
            }
            set 
            { 
                if(value > 0)
                {
                    longueur = value;
                } else
                {
                    Console.WriteLine("La longueur doit être positive");
                }

            }
        }

        private double largeur;

        public double Largeur
        {
            get 
            { 
                return largeur; 
            }
            set 
            {
                if(value > 0)
                {
                    largeur = value;
                } else
                {
                    Console.WriteLine("La largeur doit être positive");
                }
               
            }
        }



        public double Surface()
        {
            return longueur * largeur;
        }

    }
}
