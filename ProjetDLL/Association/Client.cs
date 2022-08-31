﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Association
{
    public class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Adresse Adresse { get; set; }

        public override string ToString()
        {
            return Nom + "\n" + Prenom + "\n" + Adresse;
        }
    }
}
