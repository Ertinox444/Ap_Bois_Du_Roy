﻿using System;
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

        public DataTable GetListeService()
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
    }
}