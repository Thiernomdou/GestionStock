using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class StockEnCours : Form
    {
        public StockEnCours()
        {
            InitializeComponent();
        }

        //Importer la classe de connexion
        MYDATABASE db = new MYDATABASE();

        private void StockEnCours_Load(object sender, EventArgs e)
        {
            //Importer la fonction d'affichage de stock en cours
            AfficherProduitEnStock();
        }
        
        //Création de la fonction d'affichage de stock en cours
        private void AfficherProduitEnStock()
        {
            dataGridViewStock.DataSource = getProduits();
        }

        private object getProduits()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `produits`", db.getConnection);

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }
    }
}
