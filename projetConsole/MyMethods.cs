using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetConsole
{
   public  class MyMethods
    {
        //Visibilité[mot-clé] type-retour  nom-méthode (param) {instrcuctions;}

        /// <summary>
        /// Méthode qui calcule la somme de 2 entiers
        /// </summary>
        /// <param name="nb1"></param>
        /// <param name="nb2"></param>
        /// <returns></returns>
        public static int Somme(int nb1, int nb2)
        {
            int somme = 0;
            somme = nb1 + nb2;
            return somme;
        }

        /// <summary>
        /// Méthode Afficher
        /// </summary>
        public static void Afficher()
        {
            Console.WriteLine("Méthode afficher de la classe MyMethods");
        }

        /// <summary>
        /// Méthode qui affiche les éléments du tableau
        /// </summary>
        /// <param name="tab"></param>
        public static void Afficher(int[] tab)
        {
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Méthode qui retourne la somme des élements d'un tableau d'entier
        /// </summary>
        /// <param name="tab"></param>
        /// <returns></returns>
        public static int Somme(int[] tab)
        {
            int somme = 0;
            foreach (var item in tab)
            {
                somme += item;  //somme = somme + item;
            }

            return somme;
        }


        /// <summary>
        ///         Méthode qui renvoie l'élément le plus pétit d'un tableau 
        /// </summary>
        /// <param name="tab"></param>
        /// <returns></returns>
        public static int MinTableau(int[] tab)
        {
            //[3, 2,1,5]
            int min = tab[0];  //min = 3
            
            for (int i = 1; i < tab.Length; i++)
            {
                if(min > tab[i])  
                {
                    min = tab[i]; 
                }
            }

            return min;
        }



        /// <summary>
        /// Méthode qui renvoie la moyenne des éléments d'un tableau 
        /// </summary>
        /// <param name="tab"></param>
        /// <returns></returns>
        public static double  Moyenne(int[] tab)
        {
            double sum = 0.0;
            foreach (var item in tab)
            {
                sum+= item;
            }

            return sum / tab.Length;
        }

        /// <summary>
        /// Méthode qui permute deux entiers 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void PermutDeuxEntiers(ref int x, ref int y)
        {
            int temp = x;
            x= y;
            y = temp;
        }

        /// <summary>
        /// Passage de paramètre optionnels : ce sont des paramètres qui possèdent des valeurs 
        /// par defaut et doivent être définie à la FIN de la liste des paramètres
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int SommeOptional(int a, int b, int c = 10)
        {
            return a + b + c;
        }

    }
}
