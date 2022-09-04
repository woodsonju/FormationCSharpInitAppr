using ProjetWinForm.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetWinForm.DAO
{
    public class ContactDAO : IContactDAO
    {
        SqlConnection cnx;

        //CRUD : Create - Read - Update - Delete

        public void AddContact(Contact c)
        {
            try
            {
                cnx = Connexion.GetConnexion();

                //Créer la commade SQL : 
                string sql = "INSERT INTO contacts(nom, prenom, email, telephone) VALUES (" +
                    "@nom, @prenom, @email, @telephone)";

                //créer un objet SqlCommande 
                SqlCommand cmd = new SqlCommand(sql, cnx);

                cmd.Parameters.AddWithValue("@nom", c.Nom);
                cmd.Parameters.AddWithValue("@prenom", c.Prenom);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@telephone", c.Telephone);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);   
            } finally
            {
                cnx.Close();
            }
        }
    }
}
