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

        //Bouton ajouter produit
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //création des variables
            string designation = textBoxDesignation.Text.Trim();
            decimal euros = Convert.ToDecimal(textBoxEuros.Text.Trim());
            decimal usd = Convert.ToDecimal(textBoxUSD.Text.Trim());
            int stock = Convert.ToInt32(textBoxStock.Text.Trim());
            int qtecrit = Convert.ToInt32(textBoxQteCrit.Text.Trim());
            int taux = Convert.ToInt32(comboBoxTaux.Text.Trim());
            bool etat = true;

            //Vérification de l'index de comboboxEtatProduit
            if(comboBoxEtat.SelectedIndex == 0)
            {
                etat = true;
            }
            else
            {
                etat = false;
            }

            if(!produit.VerifProduit(designation))
            {

            
                //Insertion du produit en stock
                if(produit.ajouterProduit(designation, euros, usd, stock, qtecrit, taux, etat))
                {
                    MessageBox.Show("Produit ajouté en stock avec succès!", "Ajouter produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxEuros.Clear();
                    textBoxStock.Clear();
                    comboBoxEtat.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Erreur", "Ajouter produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ce nom de produit saisi existe déjà dans le stock, veuillez choisir un autre nom de produit", "Ancien produit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //importer la classe AjouterProduit
        AjouterProduit produit = new AjouterProduit();

        private void AjoutProduit_Load(object sender, EventArgs e)
        {
            //chargement de taux du jour
            comboBoxTaux.DataSource = produit.ChargerTauxDuJour();
            comboBoxTaux.DisplayMember = "taux";
            comboBoxTaux.ValueMember = "taux";

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

        private void comboBoxTaux_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Veuillez saisir seulement une valeur numérique !");
            }
        }

        private void comboBoxEtat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Veuillez saisir seulement une valeur numérique !");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            textBoxDesignation.Text = "";
            textBoxEuros.Text = "";
            textBoxUSD.Text = "";
            textBoxStock.Text = "";
            textBoxQteCrit.Text = "";
            comboBoxEtat.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
