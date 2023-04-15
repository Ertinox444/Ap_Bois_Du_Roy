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
        }
    }


