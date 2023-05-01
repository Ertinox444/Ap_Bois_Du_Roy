using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Bois_Du_Roy.Modele;
using MySql.Data.MySqlClient;

namespace App_Bois_Du_Roy.Controller
{
    public class Fonction
    {

        Connexion conn = new Connexion();
        private string foncEmp;

        #region Recup liste fonction -> Combobox
        public DataTable GetListeFonctionCB()
        {
            DataTable dtListeFonction = new DataTable();
            dtListeFonction.Columns.Add("NOMFONCTION");
            dtListeFonction.Columns.Add("IDFONCTION");


            try
            {
                conn.connection.Open();

                string query = "SELECT FONCTION.ID_FONCTION, FONCTION.NOM_FONCTION FROM FONCTION;  ";
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    DataRow row = dtListeFonction.NewRow();

                    row["NOMFONCTION"] = dataReader["NOM_FONCTION"];
                    row["IDFONCTION"] = dataReader["ID_FONCTION"];
                    dtListeFonction.Rows.Add(row);

                }

                // Ajouter un enregistrement vide pour annuler le tri sur la difficulté
                DataRow workRow = dtListeFonction.NewRow();


                dtListeFonction.Rows.InsertAt(workRow, 0);

                dataReader.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeFonction;
        }
        #endregion
        #region Recup Fonction d'un employe
        public string RecupFoncEmploye(string matricule)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT NOM_FONCTION FROM EMPLOYE INNER JOIN FONCTION ON EMPLOYE.ID_FONCTION = FONCTION.ID_FONCTION WHERE MATRICULE ='" + matricule + "';", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        foncEmp = reader.GetString(0);
                    }
                    else
                    {
                        MessageBox.Show("Aucun résultat trouvé", "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return foncEmp;

        }
        #endregion
        #region Modifier fonction

        public bool ModifyFonction(string nomFonction, string nomServiceCorrespondant)
        {
            bool reponse = false;
            try
            {
                Connexion conn = new Connexion();

                string rqtSql = "";

                if (nomFonction != "")
                {
                    rqtSql = "UPDATE FONCTION SET ";
                    rqtSql += "NOM_FONCTION ='" + nomFonction + "'";
                    rqtSql += " WHERE NOM_FONCTION ='" + nomServiceCorrespondant + "';";

                }



                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.connection))
                {
                    conn.connection.Open();
                    cmd.ExecuteNonQuery();
                    reponse = true;
                    conn.connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return reponse;


        }
        #endregion
        #region Liste Fonction
        public DataTable GetListeFonction()
        {
            DataTable dt_Fonction_List = new DataTable();

            Connexion conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT FONCTION.NOM_FONCTION as Fonction FROM FONCTION ORDER BY ID_FONCTION;  ", conn.connection))
                {

                    {
                        conn.connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dt_Fonction_List.Load(reader);
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dt_Fonction_List;
        }
        #endregion
        #region Suppression Fonction
        public bool SuppressFonction(List<string> nomFonction)
        {
            bool reponse = false;
            try
            {
                Connexion conn = new Connexion();

                foreach (string fonction in nomFonction)
                {
                    string query = "DELETE FROM FONCTION WHERE NOM_FONCTION = '" + fonction + "';";
                    using (MySqlCommand command = new MySqlCommand(query, conn.connection))
                    {
                        conn.connection.Open();
                        command.ExecuteNonQuery();

                        reponse = true;
                        conn.connection.Close();
                    }



                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3 ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return reponse;
        }
        #endregion
        #region Insertion fonction
        public bool InsertFonction(string nom)
        {
            bool reponse = false;
            try
            {
                Connexion conn = new Connexion();
                conn.connection.Open(); // Ouvrir la connexion ici

                string rqtSql = "INSERT INTO FONCTION (NOM_FONCTION) VALUES ";

                if (nom != "")
                {
                    rqtSql += "('" + nom + "');";

                }
                DataTable dtListeFonction = new DataTable();


                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.connection))
                {

                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
                conn.connection.Close(); // Fermer la connexion ici
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return reponse;
        }
        #endregion
    }
}


