using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Addition_Graphique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Gestionnaire d'événement du bouton
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //sender : represente le contrôle qui déclenché l'évenement 
            //e : rassemble les paramètres liés à l'événement (les données de l'évenement) 
            int var1, var2, somme;
            var1 = Convert.ToInt32( textBox1.Text);
            var2 = Convert.ToInt32(textBox2.Text);

            somme = var1 + var2;

            MessageBox.Show("Somme = " + somme);

        }
    }
}
