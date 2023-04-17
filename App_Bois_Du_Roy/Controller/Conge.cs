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
    public class Conge
    {

        Connexion conn = new Connexion();
        private Int32 CongeRestant;

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
                        conn.connection.Close();
                    }
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return CongeRestant;

        }

    }
}
