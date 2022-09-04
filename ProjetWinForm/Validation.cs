using ProjetWinForm.DAO;
using ProjetWinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetWinForm
{
    public partial class Validation : Form
    {
        private IContactDAO dao;

        public Validation()
        {
            InitializeComponent();
            dao = new ContactDAO();
        }

        //Expression regulière : Permet de definir un pattern (un format de donnée) à respecter 
        Regex regTelephone = new Regex("^[0-9]{10,13}$");   //ex: 0678984725
        Regex regNom = new Regex("[A-Z]{1}[a-zA-Z]*"); //Patrice 
        Regex regPrenom = new Regex("[A-Z]{1}[a-zA-Z]*");
        Regex regEmail = new Regex("^[a-zA-Z0-9]{1,30}@[a-zA-Z]{1,60}\\.[a-zA-Z]{2,10}$"); //dawan31@gmail.com

        private bool IsFormValid()
        {
            //Nom 
            if(!regNom.IsMatch(txtNom.Text))
            {
                MessageBox.Show("Le champs Nom n'est pas valide ", "Verification du Nom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNom.Focus();
                txtNom.BackColor = Color.Silver;
                return false;
            }else
            {
                txtNom.BackColor = Color.White;
            }
            //PreNom 
            if (!regPrenom.IsMatch(txtPrenom.Text))
            {
                MessageBox.Show("Le champs Prenom n'est pas valide ", "Verification du Prenom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrenom.Focus();
                txtPrenom.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtPrenom.BackColor = Color.White;
            }

            //Email 
            if (!regEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Le champs Email n'est pas valide ", "Verification du Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }

            //Email 
            if (!regTelephone.IsMatch(txtTelephone.Text))
            {
                MessageBox.Show("Le champs Telephone n'est pas valide ", "Verification du Telephone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelephone.Focus();
                txtTelephone.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtTelephone.BackColor = Color.White;
            }

            return true;
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            if(IsFormValid())
            {
                Contact c = new Contact(txtNom.Text, txtPrenom.Text, txtEmail.Text, Convert.ToInt64(txtTelephone.Text));
                dao.AddContact(c);
            //    this.Close();

                Remplir();

            } else
            {
                MessageBox.Show("Formulaire invalid!!");
            }
        }

        private void Validation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'winformbddDataSet.contacts'.
            // Vous pouvez la déplacer ou la supprimer selon les besoins.
            // this.contactsTableAdapter.Fill(this.winformbddDataSet.contacts);
            Remplir();
        }

        public void Remplir()
        {
            this.contactsTableAdapter.Fill(this.winformbddDataSet.contacts);
        }
    }
}
