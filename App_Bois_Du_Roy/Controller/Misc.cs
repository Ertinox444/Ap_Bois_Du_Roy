using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Bois_Du_Roy.Modele;
using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using iTextSharp.text;
using iTextSharp.text.pdf;




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
        #region Vérifie si un conge est en attente
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
        #endregion

        #region permet de récupérer l'employe si son anniversaire est aujourd'hui
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
        #endregion
        #region Export au Format CSV
        public void ExportToCSV(DataGridView dataGridView, string TypeFiltre, string Filtre)
        {
            StringBuilder sb = new StringBuilder();

            // Écrit les en-têtes de colonne dans le fichier CSV
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (dataGridView.Columns[i].Name != "ID_CONGE") // vérifier si la colonne n'est pas "ID_CONGE"
                {
                    sb.Append(dataGridView.Columns[i].HeaderText);
                    sb.Append(",");
                }
            }

            sb.AppendLine();

            // Écrit chaque ligne de la DataGridView dans le fichier CSV
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    if (dataGridView.Columns[i].Name != "ID_CONGE") // vérifier si la colonne n'est pas "ID_CONGE"
                    {
                        sb.Append(row.Cells[i].Value.ToString());
                        sb.Append(",");
                    }
                }

                sb.AppendLine();
            }

            // Créer le dossier de sauvegarde si celui-ci n'existe pas
            string directoryPath = Path.Combine(Application.StartupPath, "Sauvegarde_Donnee_Conge");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Écrit le contenu du fichier CSV dans le fichier spécifié dans le dossier de sauvegarde
      
            string filePath = "";

            if (Filtre != "")
            {
                filePath = Path.Combine(directoryPath, "ListeConge_" + DateTime.Now.ToString("dd_MM_yyyy") + "_" + TypeFiltre + "[" + Filtre + "]" + "_CSV.csv");
            }
            if (Filtre == "")
            {
                filePath = Path.Combine(directoryPath, "ListeConge_" + DateTime.Now.ToString("dd_MM_yyyy") + "_CSV.csv");
            }

            File.WriteAllText(filePath, sb.ToString());

            // Affiche un message box pour indiquer que l'export est terminé
      
        }

        #endregion
        #region Export au Formal XLS
        public void ExportToXLS(DataGridView dataGridView, string TypeFiltre, string Filtre)
        {
            // Création d'un classeur
            XSSFWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Feuille1");

            // Écriture des en-têtes de colonne
            IRow headerRow = sheet.CreateRow(0);
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (dataGridView.Columns[i].Visible)
                {
                    ICell cell = headerRow.CreateCell(i - 3); // ajuster l'indice de colonne
                    cell.SetCellValue(dataGridView.Columns[i].HeaderText);
                }
            }

            // Écriture des données
            for (int rowIdx = 0; rowIdx < dataGridView.Rows.Count; rowIdx++)
            {
                DataGridViewRow row = dataGridView.Rows[rowIdx];
                IRow excelRow = sheet.CreateRow(rowIdx + 1);

                for (int cellIdx = 0; cellIdx < row.Cells.Count; cellIdx++)
                {
                    DataGridViewCell cell = row.Cells[cellIdx];
                    if (cell.Visible)
                    {
                        ICell excelCell = excelRow.CreateCell(cellIdx - 3); // ajuster l'indice de colonne
                        excelCell.SetCellValue(cell.Value.ToString());
                    }
                }
            }

            // Enregistrement du classeur en format ODS
            string directoryPath = Path.Combine(Application.StartupPath, "Sauvegarde_Donnee_Conge");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

          

            string filePath = "";

            if (Filtre != "")
            {
                filePath = Path.Combine(directoryPath, "ListeConge_" + DateTime.Now.ToString("dd_MM_yyyy") + "_" + TypeFiltre + "[" + Filtre + "]" + "_XLS.xls");
            }
            if (Filtre == "")
            {
                filePath = Path.Combine(directoryPath, "ListeConge_" + DateTime.Now.ToString("dd_MM_yyyy") + "_XLS.xls");
            }



            using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(file);
            }
        }
        #endregion
        #region Export au Format PDF

        public void ExportToPDF(DataGridView dataGridView, string TypeFiltre, string Filtre)
        {
            // Créer un document PDF avec une taille de page A4 et des marges de 10 mm
            Document document = new Document(PageSize.A4, 10, 10, 10, 10);

            // Créer un écrivain PDF pour écrire dans le document
            string directoryPath = Path.Combine(Application.StartupPath, "Sauvegarde_Donnee_Conge");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string filePath = "";

            if (Filtre != "")
            {
                filePath = Path.Combine(directoryPath, "ListeConge_" + DateTime.Now.ToString("dd_MM_yyyy") + "_" + TypeFiltre + "[" + Filtre + "]" + "_PDF.pdf");
            }
            if (Filtre == "")
            {
                filePath = Path.Combine(directoryPath, "ListeConge_" + DateTime.Now.ToString("dd_MM_yyyy") + "_PDF.pdf");
            }
            
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Ouvrir le document pour l'écriture
            document.Open();

            // Créer une table PDF avec le même nombre de colonnes que la DataGridView
            PdfPTable table = new PdfPTable((dataGridView.Columns.Count)-3);

            // Créer une police personnalisée pour l'en-tête avec une couleur de texte personnalisée
            BaseColor headerTextColor = new BaseColor(50, 50, 50); // exemple de couleur personnalisée
            Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, headerTextColor);

            // Ajouter les en-têtes de colonne à la table PDF
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (dataGridView.Columns[i].Visible)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataGridView.Columns[i].HeaderText, headerFont));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER; // Centrer horizontalement le texte
                    cell.BackgroundColor = new BaseColor(240, 240, 240);
                    table.AddCell(cell);
                }
            }

            // Ajouter les données à la table PDF
            for (int rowIdx = 0; rowIdx < dataGridView.Rows.Count; rowIdx++)
            {
                DataGridViewRow row = dataGridView.Rows[rowIdx];

                // Ajouter une nouvelle ligne dans la table PDF avant de commencer la nouvelle ligne de données
                table.CompleteRow();

                // Ajouter les cellules pour la nouvelle ligne de données
                for (int cellIdx = 0; cellIdx < row.Cells.Count; cellIdx++)
                {
                    DataGridViewCell cell = row.Cells[cellIdx];

                    if (cell.Visible)
                    {
                        // Créer une nouvelle cellule PDF avec l'alignement horizontal à gauche
                        PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value.ToString()));
                        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;

                        // Ajouter la cellule à la table PDF
                        table.AddCell(pdfCell);
                    }
                }
            }


            // Ajouter la table PDF au document
            document.Add(table);

            // Fermer le document
            document.Close();
        }
        #endregion

        #region Methode d'export selon le type choisi
        public void ExportDataGridView(DataGridView dataGridView, string TypeFiltre, string Filtre)
        {
            // Afficher la boîte de dialogue personnalisée pour choisir le format d'exportation
            ExportFormatDialog exportDialog = new ExportFormatDialog();
            if (exportDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string selectedFormat = exportDialog.SelectedFormat;

            // Si l'utilisateur a choisi un format valide, exporter la DataGridView
            if (selectedFormat != null)
            {
                switch (selectedFormat)
                {
                    case "CSV":
                        ExportToCSV(dataGridView, TypeFiltre, Filtre);
                        break;
                    case "XLS":
                        ExportToXLS(dataGridView, TypeFiltre, Filtre);
                        break;
                    case "PDF":
                        ExportToPDF(dataGridView, TypeFiltre, Filtre);
                        break;
                }

                // Afficher un message de confirmation à l'utilisateur
                MessageBox.Show("Export réussi au format " + selectedFormat + " !", "Export réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion






    }
}
