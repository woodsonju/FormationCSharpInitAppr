using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinForm.Model
{
    public class Contact
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public long Telephone { get; set; }

        public Contact()
        {
        }

        public Contact(string nom, string prenom, string email, long telephone)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Telephone = telephone;
        }

        public Contact(int id, string nom, string prenom, string email, long telephone)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Telephone = telephone;
        }


        public override string ToString()
        {
            return "Nom: " + Nom + " Prenom: " + Prenom + " Email: " + Email + " Téléphone : " + Telephone;
        }
    }
}
