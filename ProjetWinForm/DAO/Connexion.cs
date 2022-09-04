using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinForm.DAO
{
    public class Connexion
    {
        public static SqlConnection GetConnexion()
        {
            SqlConnection cnx = null;

            //Chemin d'accès à la base de données : ConnectionStrings 
            string ch = ConfigurationManager.ConnectionStrings["chConnexion"].ConnectionString;

            //Etablir la connexion 
            cnx = new SqlConnection(ch);

            cnx.Open();


            return cnx;
        }
    }
}
