using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Bois_Du_Roy.Modele;
using MySql.Data.MySqlClient;

namespace App_Bois_Du_Roy.Modele
{
    public class Service
    {
       
        Connexion conn = new Connexion();
        private string servEmp;
        private string respoServ;
        private int nbEmploye;
        public DataTable dtListeService;
        

        #region Recup liste service -> combobox
        public DataTable GetListeServiceCB()
        {
            DataTable dtListeService = new DataTable();
             dtListeService.Columns.Add("NOMSERVICE");
            dtListeService.Columns.Add("IDSERVICE");
 

            try
            {
                conn.connection.Open();

                string query = "SELECT SERVICE.ID_SERVICE ,SERVICE.NOM_SERVICE FROM SERVICE; ";
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    DataRow row = dtListeService.NewRow();
                   
                    row["NOMSERVICE"] = dataReader["NOM_SERVICE"];
                    row["IDSERVICE"] = dataReader["ID_SERVICE"];
                    dtListeService.Rows.Add(row);

                }

                // Ajouter un enregistrement vide pour annuler le tri sur la difficulté
                DataRow workRow = dtListeService.NewRow();

             
                dtListeService.Rows.InsertAt(workRow, 0);

                dataReader.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeService;
        }
        #endregion
        #region recup servic employe
        public string RecupServEmploye(string matricule)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT NOM_SERVICE FROM EMPLOYE INNER JOIN SERVICE ON EMPLOYE.ID_SERVICE = SERVICE.ID_SERVICE WHERE MATRICULE ='" + matricule + "';", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        servEmp = reader.GetString(0);
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
            return servEmp;

        }
        #endregion
        #region Recup Responsable Service
        public string RecupNameResponsable(string nomService)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT concat(EMPLOYE.NOM,' ', EMPLOYE.PRENOM) FROM EMPLOYE INNER JOIN SERVICE ON EMPLOYE.MATRICULE = SERVICE.MATRICULE_RESPONSABLE WHERE SERVICE.NOM_SERVICE = '" + nomService + "';", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        respoServ = reader.GetString(0);
                    }
                    conn.connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return respoServ;

        }
        #endregion
        #region Recup Nombre employé dans un service
        public int RecupNbEmployeService(string nomService)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(EMPLOYE.MATRICULE) FROM EMPLOYE INNER JOIN SERVICE ON EMPLOYE.ID_SERVICE = SERVICE.ID_SERVICE WHERE SERVICE.NOM_SERVICE ='" +nomService + "';", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        nbEmploye = reader.GetInt32(0);
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
            return nbEmploye;

        }
        #endregion
        #region recup liste employe d'un service
        public DataTable GetlisteEmployeService(string nomService)
        {
            DataTable dtListeEmployeService = new DataTable();

            Connexion conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(EMPLOYE.NOM, ' ', EMPLOYE.PRENOM) AS Nom, MATRICULE AS Matricule FROM EMPLOYE INNER JOIN SERVICE ON EMPLOYE.ID_SERVICE = SERVICE.ID_SERVICE WHERE NOM_SERVICE ='" + nomService + "';", conn.connection))
                {

                    {
                        conn.connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeEmployeService.Load(reader);
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeEmployeService;
        }
        #endregion
        #region Recup liste employe d'un service -> combobox
        public DataTable GetListeEmployeServiceCB(string nomService)
        {
            DataTable dtListeService = new DataTable();
            dtListeService.Columns.Add("NOMEMPLOYE");
            dtListeService.Columns.Add("MATRICULE");


            try
            {
                conn.connection.Open();

                string query = "SELECT EMPLOYE.MATRICULE, concat(EMPLOYE.NOM,' ',EMPLOYE.PRENOM) as Nom FROM EMPLOYE INNER JOIN SERVICE ON EMPLOYE.ID_SERVICE = SERVICE.ID_SERVICE WHERE SERVICE.NOM_SERVICE ='" + nomService + "';" ;
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    DataRow row = dtListeService.NewRow();

                    row["MATRICULE"] = dataReader["MATRICULE"];
                    row["NOMEMPLOYE"] = dataReader["NOM"];
                    dtListeService.Rows.Add(row);

                }

                // Ajouter un enregistrement vide pour annuler le tri sur la difficulté
                DataRow workRow = dtListeService.NewRow();


                dtListeService.Rows.InsertAt(workRow, 0);

                dataReader.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeService;
        }
        #endregion
        #region Modifier un service
        public bool ModifyService(string nomService, string employe, string nomServiceCorrespondant)
        {
            bool reponse = false;
            try
            {
                Connexion conn = new Connexion();

                string matricule = "";

                // Récupération du matricule correspondant a l'employé
                string query = "SELECT MATRICULE FROM EMPLOYE WHERE CONCAT(NOM, ' ', PRENOM) ='" + employe + "';";
                using (MySqlCommand command = new MySqlCommand(query, conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        matricule = reader.GetString(0);
                    }
                    reader.Close();
                }

                string rqtSql = "";

                if (nomService != "" && matricule != "")
                {
                    rqtSql = "UPDATE SERVICE SET ";
                    rqtSql += "NOM_SERVICE ='" + nomService + "', MATRICULE_RESPONSABLE ='" + matricule + "'";
                    rqtSql += " WHERE NOM_SERVICE ='" + nomServiceCorrespondant + "';";

                }
                else if (nomService != "" && matricule == "")
                {
                    rqtSql = "UPDATE SERVICE SET ";
                    rqtSql += "NOM_SERVICE ='" + nomService + "', MATRICULE_RESPONSABLE = NULL";
                    rqtSql += " WHERE NOM_SERVICE ='" + nomServiceCorrespondant + "';";
                }
   


                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.connection))
                {

                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return reponse;
        }
        #endregion
        #region Insertion Service
        public bool InsertService(string nom, string responsable)
        {
            bool reponse = false;
            try
            {
                Connexion conn = new Connexion();
                string matriculeRespo = "";

                string query = "SELECT MATRICULE FROM EMPLOYE WHERE CONCAT(NOM, ' ', PRENOM) = '" + responsable + "';";
                using (MySqlCommand command = new MySqlCommand(query, conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        matriculeRespo = reader.GetString(0);
                    }
                    reader.Close();
                }
                string rqtSql = "";



                if (nom != "" && responsable != "")
                {
                    rqtSql = "INSERT INTO SERVICE (NOM_SERVICE, MATRICULE_RESPONSABLE) VALUES (";
                    rqtSql += "'" + nom + "', '" + matriculeRespo + "');";

                }
                else if (nom != "" && responsable == "")
                {
                    rqtSql = "INSERT INTO SERVICE (NOM_SERVICE) VALUES (";
                    rqtSql += "'" + nom + "');";
                }
                dtListeService = new DataTable();





                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.connection))
                {

                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3 ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return reponse;
        }
        #endregion
        #region Suppression Service
        public bool SuppressService(List<string> nomService)
        {
            bool reponse = false;
            try
            {
                Connexion conn = new Connexion();

                foreach (string service in nomService)
                {
                    string query = "DELETE FROM SERVICE WHERE NOM_SERVICE = '" + service + "';";
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
        #region Liste Service
        public DataTable GetlisteService()
        {
            DataTable dtListeService = new DataTable();

            Connexion conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT s.NOM_SERVICE as Service, concat(e.NOM,' ', e.PRENOM) as Responsable FROM SERVICE s LEFT JOIN EMPLOYE e ON s.MATRICULE_RESPONSABLE = e.MATRICULE; ", conn.connection))
                {

                    {
                        conn.connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeService.Load(reader);
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeService;
        }
        #endregion
    }
}

