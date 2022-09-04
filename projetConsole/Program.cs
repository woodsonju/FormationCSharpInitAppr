using ProjetDLL;
using ProjetDLL.Abstraction;
using ProjetDLL.Association;
using ProjetDLL.Encapsulation;
using ProjetDLL.Héritage;
using ProjetDLL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetConsole
{
    class Program
    {
        /// <summary>
        /// Le point d'entrée du programme
        /// </summary>
        /// <param name="args">Les arguments du programme</param>
        static void Main(string[] args)
        {

            //Ceci est un commentaire sur une seule ligne 

            /*
             * Ceci est 
             * un commentaire 
             * miltiligne
             */

            Console.WriteLine("Bonjour");

            #region Variable
            //Zone mémoire qui va contenir une valeur typée 
            //Types primitifs : entier, réel, boolean, char 
            //Entiers : byte(1o), short(2o), int(4o), long(8o)
            //Réels : float(4o), double(8o), decimal(16o)
            //Boolean : boolean
            //Types complexes : objets, Tableaux, string,Classes

            int myInt;  //Déclaration 
            myInt = 10;
            int myInt2 = 20;

            Console.WriteLine("La valeur de ma variable myInt : " + myInt);
   
            char myChar = 'C';
            bool myBool = true;
            double myDouble = 10.5;

            string str = "test";

            //Mot clé var : inference de type - La capacité du compilateur à determiner le type de la variable en fonction de la 
            //valeur qui lui a été affecté
            var maVariable = 10;
            //  maVariable = "Jean";   --erreur

            //Bonne pratique : var s'utilise avec des variables locales qui doivent être initialisées

            //Caractère d'échapement : \t (tabulation), \n (saut de ligne)
            Console.WriteLine("\tBonjour, \nJe suis chez Dawan.\nFormation C#");

            //Chaine Verbatim 
            Console.WriteLine(@"    Bonjour, 
                            Je suis Chez Dawan.
                            Formation C#");

            //Formatage de chaine en utilisant l'interpolation 
            int i2 = 15, i3 = 25;
            Console.WriteLine("Mes variable i2 et i3 valent {0} et {1}", i2, i3);

            #endregion

            #region Opérateur 
            //-Arithmétique : +, -, *, /, %(modulo: le reste de la division entière)
            //Incrémentation et décrementation 
            int i = 5;
            i++; //i = i + 1;
            i--; //i = i - 1;

            //opérateur combinés : +=, -=, *= , /= 
            i += 5; //i = i + 5;

            //Opérateur de comparaison : ==, <, >, <=, >=, !=
            //Opérateur logique : &&, || (ou), ^(ou exclusif), ! (non logique)
            //Table logique 
            //A         B           A&&B        A||B            A^B             !A
            // V         V               V             V                F                F    
            // V          F              F              V                V               F
            //  F         V              F              V                V               V
            //  F         F              F              F                 F               V
            int v1 = 10, v2 = 15;
            Console.WriteLine((v2 > v1) ^ (v1 > v2));   //true



            #endregion


            #region Constante
            //Constante : Variable qui contient une valeur typée qu'on ne peut pas modifier 
            //Par convention le nom des constantes est en  MAJUSCULE
            //mot clé const obligatoire
            const double MA_CONSTANTE = 20.5;
            //MA_CONSTANTE = 10; --erreur

            #endregion

            #region "Transtypage - Conversion de type"
            //Conversion implicite : concerne le passage d'un type inferieur vers un type superieur
            byte b = 10;
            int myinteger = b;

            //Conversion explicite : passage d'un type superieur vers un type inferieur 
            //Cast : Concerne les conversions de types compatibles 
            int myInteger2 = 10;
            byte b2 = (byte)myInteger2;


            //Cast : Il faut que le type qui reçoit la valeur ait la capacité de contenir cette valeur
            int myInt10 = 300;
            b = (byte)myInt10;
            Console.WriteLine("b = " + b);

            //Cast : Concerne les conversions de types  compatibles 
            //Donc dans cet exemple on ne peut pas faire le CAST
            string str2 = "15";
            int monInt = Convert.ToInt32(str2);

            //Erreur de format de chaine d'entrée qui est incorrect
            //Impossible de faire la conversion
            /*            string str3 = "lettre";
                        int monIntLettre = Convert.ToInt32(str3);*/

            Console.WriteLine("Merci de fournir votre age  : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("J'ai {0} ans", age);
            #endregion


            #region Condition 
            //Expression d'un test conditionnel : Si (condition est vraie) instructions; sinon d'autres isntructions;
            //if-else 
            int nb = -5;
            if (nb > 0)
            {
                Console.WriteLine("nb est positif");
            }
            else if (nb == 0)
            {
                Console.WriteLine("nb est égale à zero");
            }
            else
            {
                Console.WriteLine("nb est négatif");
            }

            //Switch : variante du if/else 
            int note = 10;
            switch (note)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("Récalé");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("10, 11, 12 :  Juste la moyenne");
                    break;
                default:
                    Console.WriteLine("Réussite garantie");
                    break;
            }

            //Opérateur ternaire 
            int val = 10;
            int result = 0;

            /*            if(val > 5)
                        {
                            result = 25;
                        } else
                        {
                            result = 15;
                        }*/
            result = (val > 5) ? 25 : 15;

            bool myBoolean = (10 > 7) ? false : true;

            #endregion

            #region Boucle 
            //Boucle : Repeter un traitement 
            //for : Connaitre le nombre d'iteration 
            //foreach : Parcours complet de la collection 
            //Boucle conditionnelles : While et Do-While

            //for(initialisation;condition;incrementation)
            for (int i5 = 0; i5 < 5; i5++)
            {
                Console.WriteLine("Passage n° : " + i5);
            }

            //foreach : permet de faire un parcours complet du tableau 
            int[] tab = { 1, 2, 4, 10, 15 };
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }

            for (int i6 = 0; i6 < tab.Length; i6++)
            {
                tab[i6] = 10;
            }

            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }

            //Boucle While 
            int x = 1; 
            while(x < 5)
            {
                Console.WriteLine("Passage n ° : " + x);
                x++;
            }

            do
            {
                Console.WriteLine("Passage n ° : " + x);
                x++;
            } while (x > 10);

            #endregion

            #region Tableau Statique
            //Tableau : Ensemble d'élements typés 
            //1 DIMENSION 
            //Déclaration d'un tableau en initialisant la taille du tableau 
            int[] monTableau = new int[3];
            monTableau[0] = 10;
            monTableau[1] = 15;
            monTableau[2] = 20;

            Console.WriteLine("Taille du tableau : " + monTableau.Length);

            //Boucle for classique
            for (int i7 = 0; i7 < monTableau.Length; i7++)
            {
                Console.WriteLine(monTableau[i7]);
            }

            //Boucle foreach
            foreach (var item in monTableau)
            {
                Console.WriteLine(item);
            }

            //2ème façon de déclarer un tableau (initialisation des valeurs) 
            int[] monTableau2 = { 1, 2, 3, 4, 5 };

            //2 Dimensions 
            /*
             * [10, 20, 30]  1er ligne (indice 0)   :       ligne 1
             * [45, 25, 15]  2ème ligne (indice 1)  :    ligne 2 
             */
            int[,] matrix = new int[2, 3];

            //1ére ligne
            matrix[0, 0] = 10; //1ère colonne
            matrix[0, 1] = 20;
            matrix[0, 2] = 20;

            //2ème ligne 
            matrix[1, 0] = 45; //1ère colonne
            matrix[1, 1] = 25;
            matrix[1, 2] = 15;

            //2ème façon déclarer et initialiser un tableau 2D
            int[,] tab2d = { { 10, 20, 30 }, { 45, 25, 15 } };

            //Récuperer le nombre de lignes 
            Console.WriteLine("Nombre de ligne du tableau 2D : " + tab2d.GetLongLength(0));

            //Récuperer le nombre de colonnes 
            Console.WriteLine("Nombre de colonne du tableau 2D : " + tab2d.GetLongLength(1));

            //Récuperer le nombre d"'élément dans le tableau
            Console.WriteLine("Nombre total d'élément du tableau : " + tab2d.Length);

            //[0,0] = 10 
            //[0,1] = 20
            //-----
            //[1,2] = 15
            for(int ligne = 0; ligne < tab2d.GetLongLength(0); ligne++)//Parcours les éléments de la ligne du tableau
            {
                for (int colonne = 0; colonne < tab2d.GetLongLength(1); colonne++)//Parcours les colonnes de la ligne
                {
                    Console.WriteLine("[" + ligne + ", " + colonne + "]" + " = " + tab2d[ligne, colonne]);
                }
            }

            #endregion

            #region "Methodes" 
            //Méthode : Un ensemble d'instruction réutilisable - eviter de repeter du code 
            //Dans la POO on a deux type de méthodes 
            //Procédure : Une méthode qui ne renvoie aucun résultat (void) 
            //Fonctions : une méthode qui renvoie une résultat 
            //Déclarer une méthode : Visibilité[mot-clé] type-retour  nom-méthode (param) {instrcuctions;}

            int[] tab22 = { 5, 2, 8, 9, 5 };

            MyMethods.Afficher(tab22);

            int somme = MyMethods.Somme(14, 15);
            Console.WriteLine("Somme = " + somme);

            int a1 = 10;
            int b1 = 20;
            Console.WriteLine("Avant permutation : " + "a1 =  " + a1 + " - " + "b1 = " + b1);
            MyMethods.PermutDeuxEntiers(ref a1, ref b1);
            Console.WriteLine("Après permutation : " + "a1 =  " + a1 + " - " + "b1 = " + b1);

            //C'est la valeur par defaut du paramètre qui sera prise en compte 
            int sommeOptional1 = MyMethods.SommeOptional(10, 20);
            int sommeOptional2 = MyMethods.SommeOptional(10, 20, 40);
            #endregion

            #region Dates 
            DateTime dt = new DateTime();
            Console.WriteLine("dt : " + dt);  //valeur par defaut de DateTime 

            DateTime dt1 = DateTime.Now;  //Récupère la date d'aujourd'hui
            Console.WriteLine("dt1 : " + dt1);

            DateTime dt2 = DateTime.Today;  //Retourne la date sans l'heure
            Console.WriteLine("dt2  : " +dt2);

            var dt3 = new DateTime(2022, 8, 30, 15, 20, 57);
            Console.WriteLine("dt3 : " + dt3);

            string dateString = "21/02/2021 10:39:56 AM";
            DateTime dt4 = DateTime.Parse(dateString);
            Console.WriteLine("dt4 : " + dt4);

            //Comparaison 
            Console.WriteLine("Comparaison de dt1 et dt2 avec la méthode Equals : " + dt2.Equals(dt1));

            //Operations  
            Console.WriteLine("dt1 + 2jours : " + dt1.AddDays(2));
            Console.WriteLine("dt1 - dt2 : " + dt1.Subtract(dt2));

            //Recherches 
            Console.WriteLine("Date de dt1 : " + dt1.Date);
            Console.WriteLine( "jour du mois de dt1 : " + dt1.Day);
            Console.WriteLine("Jour de la semaine : " + dt1.DayOfWeek);
            Console.WriteLine("jour de l'année : " + dt1.DayOfYear);

            #endregion

            #region Enumeration 
            //Une enumération est une liste de valeurs constantes 
            //Une énumeration s'utilise lorsque l'ont veut créer un type possédant plusieurs valeurs fixes 
            //Comme le jours de la semaine par exemple 
            //Cela permet d'enrichir les types que nous avons déjà à disposition 
            Jours j = Jours.LUNDI;
            Console.WriteLine("Valeur du jours : " + j);

            #endregion

            #region Concepts Objets 
            //Encapsulation - Héritage - Polymorphisme - Abstraction, Agregation (Association - Composition)

            //ENCAPSULATION
            Rectangle rec = new Rectangle();
            rec.Longueur = 15;
            rec.Largeur = 25;
            double surface =  rec.Surface();
            Console.WriteLine("Surface = " +surface);

            CompteBancaire cb = new CompteBancaire();
            cb.Numero = "aaaaaaa";
            cb.Solde = 1500;
            Console.WriteLine("Constructeur sans paramètre : " + cb.Numero);

            CompteBancaire cb2 = new CompteBancaire("bbbbbb", 220000);
            Console.WriteLine("Contructeur avec paramètre : " + cb2.Numero);

            CompteBancaire cb3 = new CompteBancaire("bbbbbb", 220000);

            //cb2 == cb3 ==> L'opérateur == utilisé entre les objets compare l'adresse des references 
            //ici cb2 et cb3 ne pointent pas sur les mêmes instances 
            //Ce qui implique que l'utilisation == sur deux instances distinctes sémantiquement 
            //equivalent retourne false
            Console.WriteLine(" L'utilisateur de l'opérateur : " + (cb2 == cb3)); //FALSE

            //Pour comparer sémantiquement deux instances on redifini la méthode Equals de la classe Object
            Console.WriteLine("Utilisation de la méthode Equals : " + cb2.Equals(cb3));

            Console.WriteLine(cb);  //ou  Console.WriteLine(cb.ToString());

            //HERITAGE
            Animal animal = new Animal("Boby", 14);
            Chat chat = new Chat();
            chat.Nom = "Minou";
            chat.Age = 7;
            chat.Identite();

            Chien chien = new Chien();
            chien.Nom = "Bobby";
            chien.Age = 3;
            chien.Identite();

            //POLYMORPHISME
            Animal[] animaux = new Animal[4];
            animaux[0] = new Chat();
            animaux[1] = new Chien();
            animaux[2] = new Chat();
            animaux[3] = new Chien();

            foreach (Animal animal1 in animaux)
            {
                animal1.Identite();
            }

            //ABSTRACTION
            Personne p1 = new Homme();
            Personne p2 = new Femme();

            //Association: La relation entre deux classe 
            //Le fait qu'un objet puisse faire partie des attributs d'un autre objet
            Client client = new Client();
            client.Nom = "nomClient";
            client.Prenom = "PrenomClient";

            //Comme on a pas definit de constructeur dans Adresse on peut initialiser les propriétés ainsi
            client.Adresse = new Adresse() { Num = 15, Street = "rue de Toulouse 31000" };

            Console.WriteLine(client);

            #endregion region

            #region Exception 
            //Une exception est une erreur qui provoque l'arrêt de l'application
            int val1 = 10;
            try
            {
                Console.WriteLine("Division par zéro : " + val1 / 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            CompteBancaire compteB = new CompteBancaire("cccc", 5800);

            try
            {
                compteB.Retrait(110000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

            Console.WriteLine("Continue....");
            #endregion

            #region Collection
            //Collections : Ce sont des tableaux dynamiques - leur taille n'est pas fixe 
            //2 type de collections : 
            
            //Collection faiblement typées - ArrayList, Stack , Queue 
           
            //ArrayList
            var myArrayList = new ArrayList();
            Console.WriteLine(myArrayList);
            Console.WriteLine("Taille du tableau : " + myArrayList.Count); //0
            myArrayList.Add(5);
            Console.WriteLine("Taille du tableau : " + myArrayList.Count); //1
            myArrayList.Add("test");
            Console.WriteLine("Index du chiffre 5 : " + myArrayList.IndexOf(5)); //position 0
            myArrayList.Insert(0, 20);
            Console.WriteLine("Index du chiffre 5 : " + myArrayList.IndexOf(5));  //position 1

            //Boucle for 
            for (int i10 = 0; i10 < myArrayList.Count; i10++)
            {
                Console.WriteLine(myArrayList[i10]);
            }

            //Boucle Foreach
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }

            //Stack - Pile - LIFO - Last In First Out
            Stack pile = new Stack();
            pile.Push(1);
            pile.Push(2);
            pile.Push("test");
            pile.Push(3);
            Console.WriteLine("Nombre éléments dans la pile :  " + pile.Count);
            Console.WriteLine("La pile contient le chiffre 3 ? " + pile.Contains(3)); //true
            pile.Pop();
            Console.WriteLine("La pile contient le chiffre 3 ? " + pile.Contains(3)); //false

            //Queue - FIFO - First In First Out
            Queue fifo = new Queue();
            fifo.Enqueue("Dawan");
            fifo.Enqueue("1");
            fifo.Enqueue(2);
            fifo.Enqueue(100);
            Console.WriteLine("Nombre éléments dans la collection :  " + fifo.Count);
            Console.WriteLine("La collection contient la chaine Dawan ? " + fifo.Contains("Dawan")); //true
            fifo.Dequeue();
            Console.WriteLine("La collection contient  la chaine Dawan ? " + fifo.Contains("Dawan")); //false

            //Collection Fortement 
            //List
            List<string> list = new List<string>();
            Console.WriteLine("La taille de liste : " + list.Count);
            list.Add("Dawan"); 
            list.Add("Jehann");
            Console.WriteLine("Taille de la liste après ajout d'éléments : " + list.Count);
            Console.WriteLine("Index de Dawan dans la liste : " + list.IndexOf("Dawan"));
            list.Insert(0, "test");
            Console.WriteLine("Index de Dawan après Insertion : " + list.IndexOf("Dawan"));
            list.Remove("Dawan");
            Console.WriteLine("La liste contient la chaine Dawan ? " + list.Contains("Dawan"));

            //Boucle For 
            for (int i11 = 0; i11 < list.Count; i11++)
            {
                Console.WriteLine("Avec ElementAt " + list.ElementAt(i11));
                Console.WriteLine("Avec crochet tableau " + list[i11]);
            }

            //Boucle foreach 
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Dictionnaire : Stockahe de type clé:valeur  "<clé, valeur>"
            Dictionary<int, string> dictionnaire = new Dictionary<int, string>();  
            Console.WriteLine("Taille du tableau : " + dictionnaire.Count);
            //Inserer  10 éléments 
            for (int i12 = 0; i12 < dictionnaire.Count; i12++)
            {
                dictionnaire.Add(i12, "chaine" + i12);
            }

            Console.WriteLine("Taille du dictionnaire :  " + dictionnaire.Count);

            foreach (var cle in dictionnaire.Keys)
            {
                Console.WriteLine("clé: {0} - valeur: {1}", cle, dictionnaire[cle]);
            }

            #region Interface 

            IProduct productFileImpl = new ProductBDDImpl();

            productFileImpl.AddProduct(new Product());

            #endregion


            #endregion

            #region Les fichiers
            /*
             * .NET fourni des classes qui permetetnt de manipuler des fichiers 
             * File et FileInfo 
             * Pour la classe File elles sont statiques - FileInfo elles sont d'instance
             */
            //Créer un repertoire 
            Directory.CreateDirectory("monDossier"); //Chemin relatif au .exe bin/debug
           // Directory.CreateDirectory("c:\\monDossier"); //Chemin absolu (1er solution)
            Directory.CreateDirectory(@"c:\monDossier"); //Chemin absolu (2ème solution)

            Console.WriteLine("************Lister les fichiers dans le repertoire**********************");
            string[] files =  Directory.GetFiles(@"c:\test\");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("Lister les fichiers du repertoire avec l'extension .bmp");
            string[] bmpFiles = Directory.GetFiles(@"c:\test\", "*.bmp");  //.bmp est un fichier d'image 
            foreach (string bmp in bmpFiles)
            {
                Console.WriteLine(bmp);
            }

            //Récuperer les fichiers d'un repertoire et des sous repertoires 
            Console.WriteLine("*************Fichiers contenu dans un repertoire et ses sous repertoires");
            string[] txtFiles = Directory.GetFiles(@"c:\test\", "*.txt", SearchOption.AllDirectories);
            foreach (string txt in txtFiles)
            {
                Console.WriteLine(txt);
            }

            //Suppression des fichiers d'un repertoire 
            string[] filesToDelete = Directory.GetFiles(@"c:\test\");
            foreach (string del in filesToDelete)
            {
                File.Delete(del);
            }

            //Méthodes de la classe FileInfos 
            FileInfo info = new FileInfo(@"c:\info\file1.txt");
            var dateCreation = info.CreationTime.ToLongDateString();
            Console.WriteLine("Date de réation du fichier file.txt " + dateCreation);



            /*
             *  Lecture - Ecriture de fichier 
             *  flux (stream) : canal intermediaire entre la source et la destination 
             *  1- Charger le fichier dans le flux (Lecture/Ecriture)
             *  2-Execution des opérations (Lecture/Ecriture)
             *  3-Fermeture du flux
             *  .Net fourni 2 classe pour la lecture et l'ecriture : StreamReader (lecture) - StreamWriter(Ecriture)
             */
            Console.WriteLine("*****************Lecture d'un fichier*******************");
            //1-Charger le fichier dans le flux 
            StreamReader sr = new StreamReader(@"c:\info\file1.txt");
            //2-Execution des opérations (en lecture)
            string contenu =  sr.ReadToEnd();
            //3-Fermeture du flux
            sr.Close();
            Console.WriteLine("Contenu du fichier file1.txt " + contenu);

            Console.WriteLine("*************Ecriture dans un fichier***********************");
            StreamWriter sw = new StreamWriter(@"c:\info\file1.txt", true);
            sw.WriteLine("Ecriture dans un fichier test2");
            sw.Close();

            //Using with resource - se charge de liberer les resources à la fin de l'éxecution des opération. 
            //Donc plus la peine de mettre Close() pour la liberer la ressource 
            using (StreamWriter sw2 = new StreamWriter(@"c:\info\file1.txt", true))
            {
                sw2.WriteLine("Ecriture dans un fichier test3");
            }


            #endregion

            #region Serialisation 
            //Mecanisme qui permet de sauvegarder l'état d'un objet en mémoire, dans un fichier 
            //3 types de sérialisation : Binaire, XML, JSON...
            List<CompteBancaire> listCB = new List<CompteBancaire>();
            listCB.Add(new CompteBancaire("aaaaa", 15000));
            listCB.Add(new CompteBancaire("bbbbb", 1000));
            listCB.Add(new CompteBancaire("ccccc", 65444));
            listCB.Add(new CompteBancaire("eeeee", 98525));

            //Export XML 
     //       Tools.ExportXML(@"c:\compte10\comptes.xml", listCB);

            //Import XML (lecture)
            try
            {
                List<CompteBancaire> listCB2 = Tools.ImportXML(@"c:\compte10\comptes.xml");
                foreach (CompteBancaire compte in listCB2)
                {
                    Console.WriteLine(compte);
                }
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
         

            #endregion


            /*                Console.WriteLine(MyMethods.Age20);

                        int ageVal =   TestAge20.UpdateAge20();
                        Console.WriteLine("Votre age est maintenant : " + ageVal);
            */
            Console.ReadLine();
        }

        enum Jours
        {
            LUNDI = 1, 
            MARDI, 
            MERCREDI,
            JEUDI,
            VENDREDI,
            SAMEDI,
            DIMANCHE
        }
    }
}
