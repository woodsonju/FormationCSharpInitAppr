using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Héritage
{
    public class Chien: Animal
    {
        public Chien() { }

        public Chien(string nom, int age) : base(nom, age)
        {

        }

        public override void Identite()
        {
            Console.WriteLine("Je suis un chien");
        }
    }
}
