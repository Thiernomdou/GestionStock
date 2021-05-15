using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionStock
{
    class MYDATABASE
    {
        //Connexion à la base de données
        private MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=gestionstock");

        //Visibilité de l'objet connection à la base de données
        public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        //Ouverture de la connexion à la base de données
        public void openConnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //Fermeture de connexion à la base de donnes
        public void closeConnection()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
