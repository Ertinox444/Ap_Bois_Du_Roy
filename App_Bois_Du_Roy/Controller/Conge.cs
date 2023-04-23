using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Bois_Du_Roy.Modele;
using MySql.Data.MySqlClient;


namespace App_Bois_Du_Roy.Controller
{
    public class Conge
    {

        Connexion conn = new Connexion();
        private Int32 CongeRestant;

        #region Recup Historique Conge
        public DataTable GetHistoriqueConge(string matricule)
        {
            DataTable dtListeHistoryConge = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT TYPE_CONGE.NOM_TYPE_CONGE as Type, DATEDIFF(DEMANDE_CONGE.DATE_FIN,DEMANDE_CONGE.DATE_DEBUT) as Duree, STATUT_DEMANDE.libelle_Statut as Statut FROM DEMANDE_CONGE INNER JOIN TYPE_CONGE ON DEMANDE_CONGE.TYPE_CONGE_DEMANDE = TYPE_CONGE.ID_TYPE_CONGE INNER JOIN STATUT_DEMANDE ON DEMANDE_CONGE.STATUT_DEMANDE_CONGE = STATUT_DEMANDE.id_Statut WHERE DEMANDE_CONGE.MATRICULE ='" + matricule + "';", conn.connection))
                {

                    {
                        conn.connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeHistoryConge.Load(reader);

                        conn.connection.Close();
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeHistoryConge;
        }
        #endregion
        #region Recup Conge Restant Employe

        public Int32 RecupCongeRestantEmploye(string matricule, string type)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT CONGE_RESTANT FROM CONGE INNER JOIN EMPLOYE ON CONGE.MATRICULE = EMPLOYE.MATRICULE INNER JOIN TYPE_CONGE ON CONGE.ID_TYPE_CONGE = TYPE_CONGE.ID_TYPE_CONGE WHERE TYPE_CONGE.NOM_TYPE_CONGE ='" + type + "'AND EMPLOYE.MATRICULE ='"+ matricule+"';", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        CongeRestant = reader.GetInt32(0);
                     
                        
                    }
                    conn.connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return CongeRestant;

        }
        #endregion
        #region Recup les conges pour alimenter la table de statistiques
        public (List<string> mois, List<double> RTT, List<double> CP) RecupConge()
        {
            DataTable dtStatConge = new DataTable();
            // Créer les listes mois, RTT et CP
            List<string> mois = new List<string>() { "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "août", "septembre", "octobre", "novembre", "décembre" };
            List<double> RTT = new List<double>(new double[12]);
            List<double> CP = new List<double>(new double[12]);


            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT MONTHNAME(DEMANDE_CONGE.DATE_DEBUT) as Mois, DATEDIFF(DEMANDE_CONGE.DATE_FIN, DEMANDE_CONGE.DATE_DEBUT) as Duree, TYPE_CONGE.ID_TYPE_CONGE as Type_Conge FROM DEMANDE_CONGE INNER JOIN STATUT_DEMANDE ON DEMANDE_CONGE.STATUT_DEMANDE_CONGE = STATUT_DEMANDE.id_Statut INNER JOIN TYPE_CONGE ON DEMANDE_CONGE.TYPE_CONGE_DEMANDE = TYPE_CONGE.ID_TYPE_CONGE WHERE STATUT_DEMANDE.libelle_Statut = 'Validé' GROUP BY MONTHNAME(DEMANDE_CONGE.DATE_DEBUT), TYPE_CONGE.NOM_TYPE_CONGE;", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        dtStatConge.Load(reader);


                    }
                    conn.connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            // Remplir les listes RTT et CP à partir de la DataTable
            foreach (DataRow row in dtStatConge.Rows)
            {
                // Récupérer le mois (en anglais)
                string moisAnglais = row["Mois"].ToString();

                // Convertir le mois en français
                DateTime date = DateTime.ParseExact(moisAnglais, "MMMM", CultureInfo.InvariantCulture);
                string moisFrancais = date.ToString("MMMM", CultureInfo.GetCultureInfo("fr-FR"));

                // Récupérer la durée et le type de congé
                double duree = Convert.ToDouble(row["Duree"]);
                string typeConge = row["Type_Conge"].ToString();

                // Ajouter la durée à la liste RTT ou CP selon le type de congé
                if (typeConge == "1")
                {
                    RTT[mois.IndexOf(moisFrancais)] += duree;
                }
                else if (typeConge == "2")
                {
                    CP[mois.IndexOf(moisFrancais)] += duree;
                }
            }

            // Ajouter des zéros aux listes RTT et CP pour les mois sans congés
            for (int i = 0; i < 12; i++)
            {
                if (RTT[i] == 0)
                {
                    RTT[i] = 0;
                }
                if (CP[i] == 0)
                {
                    CP[i] = 0;
                }
            }

            

            return (mois, RTT, CP) ;


        }

        #endregion





        #region Recup pourcentage conge restant

        public double RecupPourcentageCongeRestant(string type_conge)
        {
            double CongeRestant = 0, CongeTotalAcquis = 0;
            // Récupération du nombre de Congé Payé restant
            string query1 = "SELECT SUM(CONGE.CONGE_RESTANT) as CP_Restant FROM CONGE INNER JOIN TYPE_CONGE ON CONGE.ID_TYPE_CONGE = TYPE_CONGE.ID_TYPE_CONGE WHERE TYPE_CONGE.NOM_TYPE_CONGE ='"+type_conge +"';";
            using (MySqlCommand command = new MySqlCommand(query1, conn.connection))
            {
                conn.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CongeRestant = reader.GetInt32(0);
                }
                reader.Close();
                conn.connection.Close();
            }

            // Récupération du nombre de Congé Payé Total Acquis
            string query2 = "SELECT SUM(CONGE.CONGE_ACQUIS) as CP_Restant FROM CONGE INNER JOIN TYPE_CONGE ON CONGE.ID_TYPE_CONGE = TYPE_CONGE.ID_TYPE_CONGE WHERE TYPE_CONGE.NOM_TYPE_CONGE ='" + type_conge + "';";
            using (MySqlCommand command = new MySqlCommand(query2, conn.connection))
            {
                conn.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CongeTotalAcquis = reader.GetInt32(0);
                }
                reader.Close();
                conn.connection.Close();
            }


            return Math.Round((CongeRestant * 100 / CongeTotalAcquis), 2);



        }
        #endregion

        public double RecupPourcentageCongePris(List<Int32> mois)
        {
            double CongeUtilise = 0, CongeTotalAcquis = 0;
           
            foreach (int nb_Mois in mois)
            {
                try
                {
                    string query1 = "SELECT COUNT(DEMANDE_CONGE.ID_VALIDATION_CONGE) FROM DEMANDE_CONGE INNER JOIN STATUT_DEMANDE ON DEMANDE_CONGE.STATUT_DEMANDE_CONGE = STATUT_DEMANDE.id_Statut WHERE MONTH(DEMANDE_CONGE.DATE_DEBUT) =" + nb_Mois + " AND STATUT_DEMANDE.libelle_Statut ='Validé'; ";
                    using (MySqlCommand command = new MySqlCommand(query1, conn.connection))
                    {
                        conn.connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            CongeUtilise += reader.GetInt32(0);
                        }
                        reader.Close();
                        conn.connection.Close();
                    }
                    
                }catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }


            // Récupération du nombre de congé Total Acquis
            try
            {
                string query2 = "SELECT COUNT(DEMANDE_CONGE.ID_VALIDATION_CONGE) FROM DEMANDE_CONGE INNER JOIN STATUT_DEMANDE ON DEMANDE_CONGE.STATUT_DEMANDE_CONGE = STATUT_DEMANDE.id_Statut WHERE STATUT_DEMANDE.libelle_Statut = 'Validé'; ";
                using (MySqlCommand command = new MySqlCommand(query2, conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        CongeTotalAcquis = reader.GetInt32(0);
                    }
                    reader.Close();
                    conn.connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            return Math.Round((CongeUtilise * 100 / CongeTotalAcquis), 2);



        }
    }
}
