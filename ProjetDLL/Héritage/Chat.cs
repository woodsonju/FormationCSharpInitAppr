using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Héritage
{
    public class Chat: Animal
    {
        public string Pelage { get; set; }

        public Chat() { }

        //base appel le constructeur de la classe parente (ici Animal)
        public Chat(string nom, int age, string Pelage) : base(nom, age)
        {
            this.Pelage = Pelage;
        }

        public override void Identite()
        {
            Console.WriteLine("Je suis un chat");
        }

    }
}
