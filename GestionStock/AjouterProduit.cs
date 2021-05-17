using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionStock
{
    class AjouterProduit
    {
        //importer la classe mère
        MYDATABASE db = new MYDATABASE();

        //Création de la fonction d'ajout de produit en stock
        public bool ajouterProduit(string designation, decimal pu_euros, decimal pu_usd, int stock, int qte_crit, int taux, Boolean etat)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `produits`(`Designation`, `PU_EUROS`, `PU_USD`, `Stock`, `QteCrit`, `Taux`, `isActive`) VALUES (@design, @euros, @usd, @stk, @QteCrit, @taux, @etat)", db.getConnection);

            //@design, @euros, @usd, @stk, @QteCrit, @taux, @etat
            command.Parameters.Add("@design", MySqlDbType.VarChar).Value = designation;
            command.Parameters.Add("@euros", MySqlDbType.Decimal).Value = pu_euros;
            command.Parameters.Add("@usd", MySqlDbType.Decimal).Value = pu_usd;
            command.Parameters.Add("@stk", MySqlDbType.Int32).Value = stock;
            command.Parameters.Add("@QteCrit", MySqlDbType.Int32).Value = qte_crit;
            command.Parameters.Add("@taux", MySqlDbType.Int32).Value = taux;
            command.Parameters.Add("@etat", MySqlDbType.Bit).Value = etat;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            } 
            else
            {
                db.closeConnection();
                return false;
            }
        }

        //Vérification d'un même produit en stock
        public bool VerifProduit(string designation)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `produits` WHERE `designation`=@design", db.getConnection);
            command.Parameters.Add("@design", MySqlDbType.VarChar).Value = designation;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        //fonction de chargement le combobox taux du jour au démarrage de l'application
        public DataTable ChargerTauxDuJour()
        {
            MySqlCommand command = new MySqlCommand("SELECT MAX(Taux) as taux FROM `produits`", db.getConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

    }
}
