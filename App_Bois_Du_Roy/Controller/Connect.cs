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
    public class Connect
    {
        public string login;
        public string mdp;
        public string todaydate;
        public DataTable dtListeEmploye_User, dtListeCompte_User, dtListeService, dtListeConge;
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

        #region Derniere demande
        public DataTable LastRequest()
        {
            DataTable dt_Last_Request = new DataTable();


            Connexion conn = new Connexion();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT concat(EMPLOYE.NOM,' ',EMPLOYE.PRENOM) AS EMPLOYE, TYPE_CONGE.NOM_TYPE_CONGE CONGE from DEMANDE_CONGE inner join TYPE_CONGE on DEMANDE_CONGE.TYPE_CONGE_DEMANDE = TYPE_CONGE.ID_TYPE_CONGE inner join EMPLOYE on DEMANDE_CONGE.MATRICULE = EMPLOYE.MATRICULE;", conn.connection))
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
        #region Liste Employe
        public DataTable GetlisteEmploye()
        {
            DataTable dt_Employee_List = new DataTable();

            Connexion conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT EMPLOYE.MATRICULE as Matricule, concat(EMPLOYE.NOM,' ', EMPLOYE.PRENOM) as Nom, SERVICE.NOM_SERVICE as Service, FONCTION.NOM_FONCTION as Fonction FROM EMPLOYE inner JOIN SERVICE on EMPLOYE.ID_SERVICE = SERVICE.ID_SERVICE inner join FONCTION on EMPLOYE.ID_FONCTION = FONCTION.ID_FONCTION ORDER BY MATRICULE;  ", conn.connection))
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
        #endregion
        #region Insertion Employe
        public bool InsertEmploye(string nom, string prenom, string service, string fonction, string matricule_Responsable, string mail, string telephone, string numsecu, string dtBirth, string dtEmbauche, string matricule)
        {
            bool reponse = false;
            try
            {
                Connexion conn = new Connexion();

                int idService = 0;
                int idFonction = 0;

                // Récupération de l'id correspondant au nom de service sélectionné
                string query = "SELECT ID_SERVICE FROM SERVICE WHERE NOM_SERVICE = '" + service + "';";
                using (MySqlCommand command = new MySqlCommand(query, conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        idService = reader.GetInt32(0);
                    }
                    reader.Close();
                }

                // Récupération de l'id correspondant au nom de fonction sélectionné
                string query2 = "SELECT ID_FONCTION FROM FONCTION WHERE NOM_FONCTION = '" + fonction + "';";
                using (MySqlCommand command = new MySqlCommand(query2, conn.connection))
                {

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        idFonction = reader.GetInt32(0);
                    }
                    reader.Close();
                }



                string rqtSql = "";

                if (nom != "" && prenom != "" && service != "" && fonction != "" && matricule_Responsable != "")
                {
                    rqtSql = "INSERT INTO EMPLOYE (MATRICULE, MATRICULE_RESPONSABLE, ID_SERVICE, ID_FONCTION, NOM, PRENOM, MAIL, TELEPHONE, NUM_SECU, DATE_NAISSANCE, DATE_EMBAUCHE) VALUES ";
                    rqtSql += " ('" + matricule + "', '" + matricule_Responsable + "', '" + idService + "', '" + idFonction + "', ' " + nom + "', '" + prenom + "', '" + mail + "', '" + telephone + "', '" + numsecu + "', '" + dtBirth + "', '" + dtEmbauche + "');";

                }
                else if (nom != "" && prenom != "" && service != "" && fonction != "" && matricule_Responsable == "")
                {
                    rqtSql = "INSERT INTO EMPLOYE (MATRICULE, ID_SERVICE, ID_FONCTION, NOM, PRENOM, MAIL, TELEPHONE, NUM_SECU, DATE_NAISSANCE, DATE_EMBAUCHE) VALUES ";
                    rqtSql += " ('" + matricule + "', '" + idService + "', '" + idFonction + "', ' " + nom + "', '" + prenom + "', '" + mail + "', '" + telephone + "', '" + numsecu + "', '" + dtBirth + "', '" + dtEmbauche + "');";
                }
                dtListeEmploye_User = new DataTable();


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
        #region Recup dernier Matricule
        public string GetDernierMatricule()
        {
            string dernierMatricule = "";

            Connexion conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT MAX(MATRICULE) FROM EMPLOYE", conn.connection))
                {
                    conn.connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        dernierMatricule = result.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            return dernierMatricule;
        }
        #endregion
        #region Insertion Compte
        public bool Insert_Compte(string mdp, string matricule, string nom, string prenom)
        {
            bool reponse = false;
            try
            {
                Connexion conn = new Connexion();
                conn.connection.Open(); // Ouvrir la connexion ici
                string mdpHash = BC.HashPassword(mdp);
                string fullName = nom + " " + prenom;
                string username = fullName.ToLower().Replace(" ", "");

                // Ajouter la première lettre du prénom au nom de famille
                string[] parts = prenom.Split('-');
                string firstName = parts[0];
                if (parts.Length > 1)
                {
                    firstName = parts[0][0] + parts[1][0].ToString();
                }

                username = firstName.ToLower() + nom.ToLower();

                // Supprimer les caractères spéciaux du nom d'utilisateur
                username = new string(username.Where(c => Char.IsLetterOrDigit(c)).ToArray());





                string rqtSql = "INSERT INTO COMPTE (MATRICULE, NOM_UTILISATEUR, MOT_DE_PASSE) VALUES ";

                if (mdp != "" && matricule != "")
                {
                    rqtSql += "('" + matricule + "', '" + username + "', '" + mdpHash + "');";

                }
                dtListeCompte_User = new DataTable();


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
        #region Liste Fonction
        public DataTable GetlisteConge()
        {
            DataTable dtListeConge = new DataTable();

            Connexion conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT concat(E.NOM,' ', E.PRENOM) as Employe, T.NOM_TYPE_CONGE AS 'Type Conge', concat(DATEDIFF( D.DATE_FIN,D.DATE_DEBUT ),' ', 'jours') AS Duree, S.libelle_Statut AS Statut, concat(V.NOM,' ',V.PRENOM) AS Valideur FROM DEMANDE_CONGE D JOIN EMPLOYE E ON D.MATRICULE = E.MATRICULE JOIN TYPE_CONGE T ON D.TYPE_CONGE_DEMANDE = T.ID_TYPE_CONGE JOIN STATUT_DEMANDE S ON D.STATUT_DEMANDE_CONGE = S.id_Statut LEFT JOIN EMPLOYE V ON D.VALIDATEUR = V.MATRICULE ; ", conn.connection))
                {

                    {
                        conn.connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeConge.Load(reader);
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeConge;
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
                    rqtSql += "'" + nom + "', '"+ matriculeRespo +"');";

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

        #region Suppression Employe
        public bool SuppressEmploye(List<string> matEmploye)
        {
            bool reponse = false;
            try
            {
                Connexion conn = new Connexion();

                foreach (string matricule in matEmploye)
                {
                    string query1 = "DELETE FROM COMPTE WHERE MATRICULE = '" + matricule + "';";
                    using (MySqlCommand command = new MySqlCommand(query1, conn.connection))
                    {
                        conn.connection.Open();
                        command.ExecuteNonQuery();

                        reponse = true;
                        conn.connection.Close();
                    }

                    string query2 = "UPDATE EMPLOYE SET MATRICULE_RESPONSABLE = NULL WHERE MATRICULE = '" + matricule + "';";
                    using (MySqlCommand command = new MySqlCommand(query2, conn.connection))
                    {
                        conn.connection.Open();
                        command.ExecuteNonQuery();

                        reponse = true;
                        conn.connection.Close();
                    }

                    string query3 = "DELETE FROM EMPLOYE WHERE MATRICULE = '" + matricule + "';";
                    using (MySqlCommand command = new MySqlCommand(query3, conn.connection))
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