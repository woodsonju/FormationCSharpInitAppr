using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetConsole
{
    public class TestAge20
    {
        public static int UpdateAge20()
        {
            int modif;
            Console.WriteLine("Veuillez modifier age20 : ");
            modif = Convert.ToInt32( Console.ReadLine());
            return modif;
        }
    }
}
