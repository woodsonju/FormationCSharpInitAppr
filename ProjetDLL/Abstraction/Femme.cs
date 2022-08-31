﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Abstraction
{
    public class Femme : Personne
    {
        public Femme() { }

        public Femme(string nom, string prenom) : base(nom, prenom)
        {

        }

        public override void Indentite()
        {
            Console.WriteLine("Je suis une femme");
        }
    }
}
