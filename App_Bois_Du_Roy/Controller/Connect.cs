using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Bois_Du_Roy.Modele;
using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;

namespace App_Bois_Du_Roy.Controller
{
    public class Connect
    {
        public string login;
        public string mdp;
        public string todaydate;

        public string GetLogin()
        {


            Connexion conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COMPTE.NOM_UTILISATEUR from COMPTE where NOM_UTILISATEUR = \"cmonsard\"; ", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        login = reader.GetString(0);
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
            return login;
        }

        public string GetMdp()
        {


            Connexion conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COMPTE.MOT_DE_PASSE from COMPTE where NOM_UTILISATEUR = \"cmonsard\"; ", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        mdp = reader.GetString(0);
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
            return mdp;
        }

       public DataTable LastRequest()
        {
            DataTable dt_Last_Request = new DataTable();


            Connexion conn = new Connexion();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT concat(EMPLOYE.NOM,' ',EMPLOYE.PRENOM) AS EMPLOYE, TYPE_CONGE.NOM_TYPE_CONGE CONGE from VALIDER inner join TYPE_CONGE on VALIDER.TYPE_CONGE_DEMANDE = TYPE_CONGE.ID_TYPE_CONGE inner join EMPLOYE on VALIDER.MATRICULE = EMPLOYE.MATRICULE;", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt_Last_Request.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            return dt_Last_Request;
        }

        public string TodayDate()
        {


            Connexion conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT concat('Nous sommes le ',CONCAT(DATE_FORMAT(NOW(), '%e '), CASE MONTHNAME(NOW()) WHEN 'January' THEN 'Janvier' WHEN 'February' THEN 'Février' WHEN 'March' THEN 'Mars' WHEN 'April' THEN 'Avril' WHEN 'May' THEN 'Mai' WHEN 'June' THEN 'Juin'WHEN 'July' THEN 'Juillet'WHEN 'August' THEN 'Août' WHEN 'September' THEN 'Septembre' WHEN 'October' THEN 'Octobre' WHEN 'November' THEN 'Novembre'WHEN 'December' THEN 'Décembre'END, DATE_FORMAT(NOW(), ' %Y'))) AS Date; ", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        todaydate = reader.GetString(0);
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
            return todaydate;
        }

        public DataTable GetlisteEmploye()
        {
            DataTable dt_Employee_List = new DataTable();

            Connexion conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT EMPLOYE.MATRICULE as Matricule, concat(EMPLOYE.NOM,' ', EMPLOYE.PRENOM) as Nom, SERVICE.NOM_SERVICE as Service, FONCTION.NOM_FONCTION as Fonction FROM EMPLOYE inner JOIN SERVICE on EMPLOYE.ID_SERVICE = SERVICE.ID_SERVICE inner join FONCTION on EMPLOYE.ID_FONCTION = FONCTION.ID_FONCTION;  ", conn.connection))
                {
                   
                    {
                        conn.connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dt_Employee_List.Load(reader);
                    }
                   
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dt_Employee_List;
        }
    }
    }
/*SELECT 
  EMPLOYE.MATRICULE AS Matricule, 
  CONCAT(EMPLOYE.NOM, ' ', EMPLOYE.PRENOM) AS Nom, 
  SERVICE.NOM_SERVICE AS Service, 
  COALESCE(COUNT(CASE WHEN VALIDER.STATUT_DEMANDE_CONGE = 'en attente' THEN 1 END), 0) AS Conge_en_attente 
FROM 
  EMPLOYE 
  INNER JOIN SERVICE ON EMPLOYE.ID_SERVICE = SERVICE.ID_SERVICE 
  LEFT JOIN VALIDER ON EMPLOYE.MATRICULE = VALIDER.MATRICULE 
  inner join STATUT_DEMANDE on VALIDER.STATUT_DEMANDE_CONGE = STATUT_DEMANDE.id_Statut
  
GROUP BY 
  EMPLOYE.MATRICULE;*/