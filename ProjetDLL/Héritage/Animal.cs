using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Héritage
{
    public class Animal
    {
        public string Nom { get; set; }
        public int Age { get; set; }


        public Animal() { }

        public Animal(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public virtual void Identite()
        {
            Console.WriteLine("Je suis Animal");
        }

        public override string ToString()
        {
            return "Nom : " + Nom + "Age: " + Age;
        }
    }
}
