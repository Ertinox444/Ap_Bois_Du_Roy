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
    class Employe
    {


        Connexion conn = new Connexion();
        private string NameEmp;
        private string DateBirthEmp;
        private string NumSecuEmp;
        private string MatRespoEmp;
        private string DateEmbaucheEmp;


        #region Recup Liste Responable -> Comobobox
        public DataTable GetListeResponsableCB()
        {
            DataTable dtListeResponsable = new DataTable();
            dtListeResponsable.Columns.Add("RESPONSABLE");
            dtListeResponsable.Columns.Add("MATRICULE");



            try
            {
                conn.connection.Open();

                string query = "SELECT MATRICULE, concat(EMPLOYE.NOM,' ',EMPLOYE.PRENOM) as Employe FROM EMPLOYE;  ";
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    DataRow row = dtListeResponsable.NewRow();

                    row["RESPONSABLE"] = dataReader["Employe"];
                    row["MATRICULE"] = dataReader["MATRICULE"];

                    dtListeResponsable.Rows.Add(row);

                }

                // Ajouter un enregistrement vide pour annuler le tri sur la difficulté
                DataRow workRow = dtListeResponsable.NewRow();


                dtListeResponsable.Rows.InsertAt(workRow, 0);

                dataReader.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeResponsable;
        }
        #endregion

        #region Recup Nom Employe
        public string RecupNameEmploye(string matricule)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT concat(NOM,' ',PRENOM) FROM EMPLOYE WHERE MATRICULE ='" + matricule + "';", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        NameEmp = reader.GetString(0);
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
            return NameEmp;

        }
        #endregion
        #region Recup Date Naissance Employe
        public string RecupBirthEmploye(string matricule)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT DATE_FORMAT(DATE_NAISSANCE, '%d/%m/%Y') FROM EMPLOYE WHERE MATRICULE ='" + matricule + "';", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        DateBirthEmp = reader.GetString(0);
                        conn.connection.Close();
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
            return DateBirthEmp;

        }
        #endregion

        #region Recup Numéro secu employe
        public string RecupNumSecu(string matricule)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT NUM_SECU FROM EMPLOYE WHERE MATRICULE ='"+matricule+"';", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        NumSecuEmp = reader.GetString(0);
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
            return NumSecuEmp;
        }
        #endregion

        #region recup Matricule Responsable employe
        public string RecupRespoEmp(string matricule)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT EMPLOYE.MATRICULE_RESPONSABLE FROM EMPLOYE WHERE MATRICULE ='" + matricule + "';", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        MatRespoEmp = reader.GetString(0);
                    }
                    else
                    {
                        MessageBox.Show("Aucun résultat trouvé", "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        MatRespoEmp = "";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return MatRespoEmp;
        }
        #endregion

        #region Recup Date Naissance Employe
        public string RecupEmbaucheEmploye(string matricule)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT DATE_FORMAT(DATE_EMBAUCHE, '%d/%m/%Y') FROM EMPLOYE WHERE MATRICULE ='" + matricule + "';", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        DateEmbaucheEmp = reader.GetString(0);
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
            return DateEmbaucheEmp;

        }
        #endregion



    }
}
