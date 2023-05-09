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
    class Employe
    {


        Connexion conn = new Connexion();
        private string NameEmp;
        private string DateBirthEmp;
        private string NumSecuEmp;
        private string MatRespoEmp;
        private string DateEmbaucheEmp;
        private bool IsRespo = false;

        #region Méthode Employé
        #region Recup Liste Responable -> Comobobox
        public DataTable GetListeResponsableCB()
        {
            DataTable dtListeResponsable = new DataTable();
            dtListeResponsable.Columns.Add("RESPONSABLE");
            dtListeResponsable.Columns.Add("MATRICULE");



            try
            {
                conn.connection.Open();

                string query = "SELECT EMPLOYE.MATRICULE, concat(EMPLOYE.NOM,' ',EMPLOYE.PRENOM) as Employe FROM EMPLOYE INNER JOIN COMPTE ON EMPLOYE.MATRICULE = COMPTE.MATRICULE WHERE COMPTE.EST_RESPONSABLE = 1;   ";
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
                        if (!reader.IsDBNull(0)) // Vérifie que la valeur n'est pas NULL
                        {
                            MatRespoEmp = reader.GetString(0);
                        }
                        else
                        {
                            MatRespoEmp = "";
                        }
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
        #region Recup Liste Employe -> ComboBox
        public DataTable GetListeEmployeCB()
        {
            DataTable dtListeResponsable = new DataTable();
            dtListeResponsable.Columns.Add("EMPLOYE");
            dtListeResponsable.Columns.Add("MATRICULE");



            try
            {
                conn.connection.Open();

                string query = "SELECT EMPLOYE.MATRICULE, concat(EMPLOYE.NOM,' ',EMPLOYE.PRENOM) as Employe FROM EMPLOYE ;   ";
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    DataRow row = dtListeResponsable.NewRow();

                    row["EMPLOYE"] = dataReader["Employe"];
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
        #region Liste Employe
        public DataTable GetlisteEmploye()
        {
            DataTable dt_Employee_List = new DataTable();
    
            Connexion conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT EMPLOYE.MATRICULE AS Matricule, CONCAT(EMPLOYE.NOM, ' ', EMPLOYE.PRENOM) AS Nom,  SERVICE.NOM_SERVICE AS Service, FONCTION.NOM_FONCTION AS Fonction, CAST((CASE COUNT(DISTINCT DEMANDE_CONGE.ID_DEMANDE_CONGE) WHEN 0 THEN 'Aucun congé en attente' ELSE CONCAT(COUNT(DISTINCT DEMANDE_CONGE.ID_DEMANDE_CONGE), ' congé(s) en attente') END) AS CHAR) AS 'Congé en attente' FROM EMPLOYE INNER JOIN SERVICE ON EMPLOYE.ID_SERVICE = SERVICE.ID_SERVICE INNER JOIN FONCTION ON EMPLOYE.ID_FONCTION = FONCTION.ID_FONCTION LEFT JOIN DEMANDE_CONGE ON EMPLOYE.MATRICULE = DEMANDE_CONGE.MATRICULE AND DEMANDE_CONGE.STATUT_DEMANDE_CONGE = 1 GROUP BY EMPLOYE.MATRICULE ORDER BY EMPLOYE.MATRICULE; ", conn.connection))
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
        public bool InsertEmploye(string nom, string prenom, string service, string fonction, string nom_Responsable, string mail, string telephone, string numsecu, string dtBirth, string dtEmbauche, string matricule)
        {
            bool reponse = false;

            try
            {
                Connexion conn = new Connexion();

                int idService = 0;
                int idFonction = 0;
                string matricule_Responsable = "";



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

                string query3 = "SELECT MATRICULE FROM EMPLOYE WHERE CONCAT(EMPLOYE.NOM,' ',EMPLOYE.PRENOM) = '" + nom_Responsable + "';";
                using (MySqlCommand command = new MySqlCommand(query3, conn.connection))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        matricule_Responsable = reader.GetString(0);
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
                DataTable dtListeEmploye_User = new DataTable();


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
        #region Modifier Employer
        public bool ModifyEmploye(string nom, string prenom, string service, string fonction, string matricule_Responsable, string mail, string telephone, string numsecu, string dtBirth, string dtEmbauche, string matricule, string matricule_correspondant)
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

                if (nom != "" && prenom != "" && matricule_Responsable != "")
                {
                    if (service == "" && fonction == "")
                    {
                        rqtSql = "UPDATE EMPLOYE SET ";
                        rqtSql += "NOM ='" + nom + "', PRENOM ='" + prenom + "', NUM_SECU ='" + numsecu + "', TELEPHONE='" + telephone + "', DATE_NAISSANCE = '" + dtBirth + "', DATE_EMBAUCHE ='" + dtEmbauche + "', MATRICULE ='" + matricule + "', ID_FONCTION = NULL" +  ", ID_SERVICE = NULL" + ", MATRICULE_RESPONSABLE='" + matricule_Responsable + "', MAIL ='" + mail + "'";
                        rqtSql += " WHERE EMPLOYE.MATRICULE ='" + matricule_correspondant + "';";
                    }
                    if (service != "" && fonction != "")
                    {
                        rqtSql = "UPDATE EMPLOYE SET ";
                        rqtSql += "NOM ='" + nom + "', PRENOM ='" + prenom + "', NUM_SECU ='" + numsecu + "', TELEPHONE='" + telephone + "', DATE_NAISSANCE = '" + dtBirth + "', DATE_EMBAUCHE ='" + dtEmbauche + "', MATRICULE ='" + matricule + "', ID_FONCTION =" + idFonction + ", ID_SERVICE =" + idService + ", MATRICULE_RESPONSABLE='" + matricule_Responsable + "', MAIL ='" + mail + "'";
                        rqtSql += " WHERE EMPLOYE.MATRICULE ='" + matricule_correspondant + "';";
                    }
                    

                }
                else if (nom != "" && prenom != "" && matricule_Responsable == "")
                {
                    if (service == "" && fonction == "")
                    {
                        rqtSql = "UPDATE EMPLOYE SET ";
                        rqtSql += "NOM ='" + nom + "', PRENOM ='" + prenom + "', NUM_SECU ='" + numsecu + "', TELEPHONE='" + telephone + "', DATE_NAISSANCE = '" + dtBirth + "', DATE_EMBAUCHE ='" + dtEmbauche + "', MATRICULE ='" + matricule + "', ID_FONCTION = NULL" + ", ID_SERVICE = NULL" + ", MATRICULE_RESPONSABLE='" + matricule_Responsable + "', MAIL ='" + mail + "'";
                        rqtSql += " WHERE EMPLOYE.MATRICULE ='" + matricule_correspondant + "';";
                    }
                    if (service != "" && fonction != "")
                    {
                        rqtSql = "UPDATE EMPLOYE SET ";
                        rqtSql += "NOM ='" + nom + "', PRENOM ='" + prenom + "', NUM_SECU ='" + numsecu + "', TELEPHONE='" + telephone + "', DATE_NAISSANCE = '" + dtBirth + "', DATE_EMBAUCHE ='" + dtEmbauche + "', MATRICULE ='" + matricule + "', ID_FONCTION =" + idFonction + ", ID_SERVICE =" + idService + ", MATRICULE_RESPONSABLE='" + matricule_Responsable + "', MAIL ='" + mail + "'";
                        rqtSql += " WHERE EMPLOYE.MATRICULE ='" + matricule_correspondant + "';";
                    }
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


        #region Recup Etat Respo Employe
        public bool RecupIsRespoEmp(string matricule)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COMPTE.EST_RESPONSABLE FROM COMPTE WHERE COMPTE.MATRICULE ='" + matricule + "';", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        IsRespo = reader.GetBoolean(0);
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
            return IsRespo;

        }
        #endregion

        #endregion

        #region Méthode Compte Employé
        #region Insertion Compte
        public bool Insert_Compte(string mdp, string matricule, string nom, string prenom, int IsResponsable)
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

                string rqtSql = "INSERT INTO COMPTE (MATRICULE, NOM_UTILISATEUR, MOT_DE_PASSE, MOT_DE_PASSE_BACK, EST_RESPONSABLE) VALUES ";

                if (mdp != "" && matricule != "")
                {
                    if (IsResponsable == 0)
                    {
                        rqtSql += "('" + matricule + "', '" + username + "', '" + mdpHash + "', 1, 0 );";
                    }
                    if (IsResponsable == 1)
                    {
                        rqtSql += "('" + matricule + "', '" + username + "', '" + mdpHash + "', 1, 1 );";
                    }
                   

                }
                DataTable dtListeCompte_User = new DataTable();


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
        #region Modification Compte
        public bool Modify_Compte(string mdp, string matricule, string prenom, string nom, string matricule_correspondant, int IsResponsable)
        {
            bool reponse = false;
            try
            {
                Connexion conn = new Connexion();
                conn.connection.Open(); // Ouvrir la connexion ici

                string fullName = nom + " " + prenom;
                string username = fullName.ToLower().Replace(" ", "");

                // Ajouter la première lettre du prénom au nom de famille
                string[] parts = prenom.Split('-');
                string firstName = parts[0];
                if (parts.Length > 1)
                {
                    firstName = parts[0][0] + parts[1][0].ToString();
                }

                username = firstName.ToLower().Substring(0, 1) + nom.ToLower();

                // Supprimer les caractères spéciaux du nom d'utilisateur
                username = new string(username.Where(c => Char.IsLetterOrDigit(c)).ToArray());

                string rqtSql = "";

                if (mdp != "")
                {
                    string mdpHash = BC.HashPassword(mdp);
                    rqtSql += "UPDATE COMPTE SET MATRICULE ='" + matricule + "', NOM_UTILISATEUR='" + username + "', MOT_DE_PASSE ='" + mdpHash + "', MOT_DE_PASSE_BACK = 1, ";
                    
                }
                if (mdp == "")
                {
                    rqtSql += "UPDATE COMPTE SET MATRICULE ='" + matricule + "', NOM_UTILISATEUR='" + username + "', ";
                    
                }
                if (IsResponsable == 0)
                {
                    rqtSql += "EST_RESPONSABLE = 0";
                }
                if (IsResponsable == 1)
                {
                    rqtSql += "EST_RESPONSABLE = 1";
                }

                rqtSql += " WHERE MATRICULE ='" + matricule_correspondant + "';";
                DataTable dtListeCompte_User = new DataTable();


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









        #endregion
    }
}
/*SELECT EMPLOYE.MATRICULE AS Matricule, CONCAT(EMPLOYE.NOM, ' ', EMPLOYE.PRENOM) AS Nom, SERVICE.NOM_SERVICE AS Service, FONCTION.NOM_FONCTION AS Fonction, CASE COUNT(DISTINCT DEMANDE_CONGE.ID_DEMANDE_CONGE) WHEN 0 THEN 'Aucun congé en attente' ELSE CONCAT(COUNT(DISTINCT DEMANDE_CONGE.ID_DEMANDE_CONGE), ' congé(s) en attente') END AS `Congé en attente` FROM EMPLOYE INNER JOIN SERVICE ON EMPLOYE.ID_SERVICE = SERVICE.ID_SERVICE INNER JOIN FONCTION ON EMPLOYE.ID_FONCTION = FONCTION.ID_FONCTION LEFT JOIN DEMANDE_CONGE ON EMPLOYE.MATRICULE = DEMANDE_CONGE.MATRICULE AND DEMANDE_CONGE.STATUT_DEMANDE_CONGE = 1 GROUP BY EMPLOYE.MATRICULE ORDER BY EMPLOYE.MATRICULE;*/