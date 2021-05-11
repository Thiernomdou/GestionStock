using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class AjoutProduit : Form
    {
        public AjoutProduit()
        {
            InitializeComponent();
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

        private void AjoutProduit_Load(object sender, EventArgs e)
        {
            comboBoxEtat.SelectedIndex = 0;
        }

        private void textBoxEuros_TextChanged(object sender, EventArgs e)
        {
            conversionEuros_USD();
        }

        private void conversionEuros_USD()
        {
            if(textBoxEuros.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Le prix unitaire Euros est requis!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEuros.Focus();
            }
            else
            {
                int tempEuros;
                bool isDecimal = int.TryParse(textBoxEuros.Text.Trim(), out tempEuros);
                if(!isDecimal)
                {
                    MessageBox.Show("Valeur prix unitaire Euros est numérique. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEuros.Focus();
                }
            }
        }
    }
}
