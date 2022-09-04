using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validationFormulaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //validation.Show();
            //La même chose que la méthode Show sauf qu'elle est bloquante
            //Show affiche le formulaire de manière non modale.
            //ShowDialog affiche le formulaire de manière modale
            Validation validation = new Validation();
            validation.ShowDialog();
        }
    }
}
