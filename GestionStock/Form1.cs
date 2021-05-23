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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nouveauProduitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjoutProduit ajout = new AjoutProduit();
            ajout.ShowDialog();
        }

        private void nouveauProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockEnCours stockEnCours = new StockEnCours();
            stockEnCours.ShowDialog();
        }
    }
}
