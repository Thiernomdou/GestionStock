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
using System.Windows.Forms.DataVisualization.Charting;

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

            //Afficher le nombre de produits dans le stock en cours 
            NombreProduitsEnStock();

            //Afficher la quantité de produits dans le stock en graphique 
            AfficherGraphiqueStock();
        }

        private void AfficherGraphiqueStock()
        {
            chart1.DataSource = getProduits();
            Series series1 = chart1.Series["Stock"];
            series1.ChartType = SeriesChartType.Pie;
            chart1.Series[series1.Name].XValueMember = "designation";
            chart1.Series[series1.Name].YValueMembers = "stock";

            var chart = chart1;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].LegendText = "#VALX (#PERCENT)";
            chart.Series[0]["PieLabelStyle"] = "Outside";
            chart.Series[0].BorderWidth = 1;
            chart.Series[0].BorderColor = Color.Black;
            chart.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart.DataBind();
        }

        private void NombreProduitsEnStock()
        {
            if(dataGridViewStock.Rows.Count > 0)
            {
                int nombre = Convert.ToInt32(dataGridViewStock.Rows.Count);
                if(nombre <= 1)
                {
                    labelNbreProd.Text = "Nombre total de produit : " + dataGridViewStock.Rows.Count.ToString();
                }
                else
                {
                    labelNbreProd.Text = "Nombre total des produits : " + dataGridViewStock.Rows.Count.ToString();
                }
            }
            else
            {
                labelNbreProd.Text = "Nombre total de produit : " + "0";
            }
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

        private void dataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
