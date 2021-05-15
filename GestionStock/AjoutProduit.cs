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
                else
                {
                    try
                    {
                        int taux = Convert.ToInt32(comboBoxTaux.Text.Trim());
                        decimal usd = Convert.ToDecimal(textBoxEuros.Text.Trim()) / taux;
                        textBoxUSD.Text = Math.Round(usd, 2, MidpointRounding.AwayFromZero).ToString();

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Veuillez remplir le taux du jour");
                    }

                    
                }
            }
        }

        private void textBoxStock_TextChanged(object sender, EventArgs e)
        {
            conversion_Qte_QteCrit();
        }

        private void conversion_Qte_QteCrit()
        {
            if (textBoxStock.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantité produit est réquise!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxStock.Focus();
            }
            else
            {
                int tempProd;
                bool isNumeric = int.TryParse(textBoxStock.Text.Trim(), out tempProd);
                if (!isNumeric)
                {
                    MessageBox.Show("Quantité produit est réquise. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxStock.Focus();
                    textBoxStock.Clear();
                }
                else
                {
                    int qteProd = Convert.ToInt32(textBoxStock.Text.Trim());
                    int resultat = qteProd/100;
                    textBoxQteCrit.Text = resultat.ToString();
                }
            }
        }
    }
}
