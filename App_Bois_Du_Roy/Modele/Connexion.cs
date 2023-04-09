using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace App_Bois_Du_Roy.Modele
{
    public class Connexion
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string login;
        private string mot_De_Passe;

        private void Initialise()
        {
            server = "192.168.61.69";
            database = "bdd_Bois_Du_Roy";
            login = "serveur";
            mot_De_Passe = "S€Rv3ur";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + login + ";" + "PASSWORD=" + mot_De_Passe + ";";

            connection = new MySqlConnection(connectionString);
        }

        public Connexion()
        {
            Initialise();
        }
    }


}
