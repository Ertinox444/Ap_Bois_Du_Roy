using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Bois_Du_Roy.Modele;
using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;

namespace App_Bois_Du_Roy.Controller
{
    public class Misc
    {
        public string login;
        public string mdp;
        public string todaydate;
        #region recup Login
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
        #endregion
        #region recup mdp
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
        #endregion
        #region Date Jour
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
        #endregion

        public int CheckCongesEnAttente()
        {
            Connexion conn = new Connexion();
            int nb_notif = 0;
          
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM DEMANDE_CONGE WHERE STATUT_DEMANDE_CONGE = 1", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        nb_notif = reader.GetInt32(0);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            

                return nb_notif;
    }

        public int UpdateLabelConge()
        {
            int hasCongesEnAttente = CheckCongesEnAttente();
            
            if (hasCongesEnAttente > 0)
            {
                return hasCongesEnAttente;
            }
            else
            {
                return 0;
            }
        }


        public string Birthday()
        {
            string employe_Birth = "";

            Connexion conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(EMPLOYE.PRENOM,' ',EMPLOYE.NOM) as nomEmploye FROM EMPLOYE WHERE MONTH(NOW()) = MONTH(EMPLOYE.DATE_NAISSANCE) AND DAY(NOW()) = DAY(EMPLOYE.DATE_NAISSANCE); ", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        employe_Birth = reader.GetString(0);
                    }
                    else
                    {
                        employe_Birth = "";
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            return employe_Birth;
        }
    } 
}
