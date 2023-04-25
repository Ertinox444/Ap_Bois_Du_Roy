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
    public class Matricule
    {

        Connexion conn = new Connexion();
        private string matEmp;

        public DataTable GetListeMatriculeCB()
        {
            DataTable dtListeMatricule = new DataTable();
            dtListeMatricule.Columns.Add("MATRICULE");
          


            try
            {
                conn.connection.Open();

                string query = "SELECT EMPLOYE.MATRICULE as MATRICULE FROM EMPLOYE ORDER BY MATRICULE;  ";
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    DataRow row = dtListeMatricule.NewRow();

                    row["MATRICULE"] = dataReader["MATRICULE"];
               
                    dtListeMatricule.Rows.Add(row);

                }

                // Ajouter un enregistrement vide pour annuler le tri sur la difficulté
                DataRow workRow = dtListeMatricule.NewRow();


                dtListeMatricule.Rows.InsertAt(workRow, 0);

                dataReader.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeMatricule;
        }

        public string RecupMatEmploye(string nomPrenomEmp)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT MATRICULE FROM EMPLOYE WHERE CONCAT(EMPLOYE.NOM,' ',EMPLOYE.PRENOM) ='" + nomPrenomEmp + "';", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        matEmp = reader.GetString(0);
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
            return matEmp;
            
        }
    }
}
