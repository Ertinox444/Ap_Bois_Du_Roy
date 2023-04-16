using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Bois_Du_Roy.Modele;
using App_Bois_Du_Roy.Controller;
using MySql.Data.MySqlClient;
using System.IO;

namespace App_Bois_Du_Roy.Controller
{
    public class photoProfil
    {

        public byte[] GetImage(string matricule)
        {
            byte[] imageData = null;

            try
            {
                Connexion conn = new Connexion();
                conn.connection.Open();
                // Requête pour récupérer l'image à partir de son ID
                string query = "SELECT PHOTO_PROFIL FROM EMPLOYE WHERE MATRICULE = '" + matricule + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                // Si une image est trouvée, récupérer ses données
                if (dataReader.Read())
                {
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("PHOTO_PROFIL")))
                    {
                        imageData = (byte[])dataReader["PHOTO_PROFIL"];
                    }
                }

                // Fermer la connexion à la base de données

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            // Retourner les données de l'image
            return imageData;
        }

        // Fonction pour convertir les données de l'image en objet Image
        public Image Convertir(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
