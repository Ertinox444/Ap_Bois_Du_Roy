using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Bois_Du_Roy.Controller;
using App_Bois_Du_Roy.Modele;
using Newtonsoft.Json.Linq;

namespace App_Bois_Du_Roy
{
    public partial class TableauBord : Form
    {

        List<string> villes = new List<string>()
{
        "Paris",
        "Marseille",
        "Lyon",
        "Toulouse",
        "Nice",
        "Nantes",
        "Strasbourg",
        "Montpellier",
        "Bordeaux",
        "Lille",
        "Rennes",
        "Reims",
        "Saint-Etienne",
        "Toulon",
        "Grenoble",
        "Dijon",
        "Angers",
        "Nîmes",
        "Villeurbanne",
        "Le Mans"
    
            };
        Dictionary<string, string> MeteoENFR = new Dictionary<string, string>()
{
    {"clear sky", "dégagé"},
    {"few clouds", "peu nuageux"},
    {"scattered clouds", "assez nuagueux"},
    {"broken clouds", "plutôt nuageux"},
    {"shower rain", "assez pluvieux"},
    {"rain", "pluvieux"},
    {"thunderstorm", "orageux"},
    {"snow", "neigeux"},
    {"mist", "brumeux"},
};


        public TableauBord()
        {
            InitializeComponent();
            comboBoxVilles.DataSource = villes;
            comboBoxVilles.SelectedItem = "Angers";
            Conge dtviewLastRequest = new Conge();
            DataView dv = new DataView(dtviewLastRequest.LastRequest());
            DGV_Last_Request.DataSource = dv;

            if (DGV_Last_Request.Rows.Count == 1)
            {

                DGV_Last_Request.Visible = false;
                tb_NoData.Visible = true;
                tb_NoData.Text = "Aucun congé en attente";
            }
            else
            {
                DGV_Last_Request.Visible = true;
                tb_NoData.Visible = false;
                DGV_Last_Request.Columns["EMPLOYE"].Width = 205;
                DGV_Last_Request.Columns["CONGE"].Width = 205;
                DGV_Last_Request.Columns["DUREE"].Width = 205;
                DGV_Last_Request.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(87, 128, 64);
                DGV_Last_Request.DefaultCellStyle.ForeColor = Color.FromArgb(87, 128, 64);
            }

            Misc date_of_Today = new Misc();
            Misc date_Birth = new Misc();
            tb_Today_Date.Text = date_of_Today.TodayDate();
            if (date_Birth.Birthday() == "")
            {
                tb_Birthday.Text = "Aucun anniversaire aujourd'hui";

            }
            if (date_Birth.Birthday() != "")
            {
                tb_Birthday.Text = "Anniversaire de " + date_Birth.Birthday();
            }

            Misc Notif = new Misc();
            if (Notif.CheckCongesEnAttente() > 0)
            {
                pb_Notif.Visible = true;
                lbl_Notif.Visible = true;
                lbl_Notif.Text = Convert.ToString(Notif.CheckCongesEnAttente());
            }
            if (Notif.CheckCongesEnAttente() == 0)
            {
                pb_Notif.Visible = false;
                lbl_Notif.Visible = false;
            }




        }
       

   
        private void lbl_lsEmploye_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Employe());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new TableauBord());
        }

        private void lbl_Conge_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Conge());
        }

        private void lbl_Service_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Service());
        }

        private void lbl_ListeFonction_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Fonction());
        }

        private void pb_LogOut_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Page_Connection());
        }

       
        private void comboBoxVilles_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeatherService Meteo = new WeatherService();
            string ville = comboBoxVilles.SelectedItem.ToString();
            string meteoInfo = Meteo.GetMeteoInfo(ville);
            JObject json = JObject.Parse(meteoInfo);

            string iconCode = $"{json["weather"][0]["icon"]}";
            string imageUrl = $"http://openweathermap.org/img/w/{iconCode}.png";

            string conditionMeteoEnAnglais = $"{json["weather"][0]["description"]}";
            string conditionMeteoEnFrancais;
            string temperature = $"{json["main"]["temp"]} °C";
            string meteoActuelle = "";
            if (MeteoENFR.TryGetValue(conditionMeteoEnAnglais, out conditionMeteoEnFrancais))
            {
                meteoActuelle = conditionMeteoEnFrancais;
            }


            using (var webClient = new WebClient()) // Crée un WebClient pour télécharger l'image
            {
                byte[] imageBytes = webClient.DownloadData(imageUrl); // Télécharge l'image en tant qu'array de bytes
                using (var stream = new MemoryStream(imageBytes)) // Crée un MemoryStream à partir de l'array de bytes
                {
                    Image image = Image.FromStream(stream); // Crée une instance de Image à partir du MemoryStream
                    pb_Weather.Image = image; // Assigner l'image à la PictureBox
                }
            }

            textBox_TempsActuel.Text = "Sur " + ville + ", il fait actuellement " + temperature + ", le temps est " + meteoActuelle;
            textBox_TempFeeling.Text = $"{json["main"]["feels_like"]} °C";
            textBox_Humidite.Text = $"{json["main"]["humidity"]} %";
        }

        private void comboBoxVilles_KeyPress(object sender, KeyPressEventArgs e)
        {
            WeatherService Meteo = new WeatherService();
            string ville = comboBoxVilles.SelectedItem.ToString();
            string meteoInfo = Meteo.GetMeteoInfo(ville);
            JObject json = JObject.Parse(meteoInfo);

            string iconCode = $"{json["weather"][0]["icon"]}";
            string imageUrl = $"http://openweathermap.org/img/w/{iconCode}.png";

            string conditionMeteoEnAnglais = $"{json["weather"][0]["description"]}";
            string conditionMeteoEnFrancais;
            string temperature = $"{json["main"]["temp"]} °C";
            string meteoActuelle = "";
            if (MeteoENFR.TryGetValue(conditionMeteoEnAnglais, out conditionMeteoEnFrancais))
            {
                meteoActuelle = conditionMeteoEnFrancais;
            }


            using (var webClient = new WebClient()) // Crée un WebClient pour télécharger l'image
            {
                byte[] imageBytes = webClient.DownloadData(imageUrl); // Télécharge l'image en tant qu'array de bytes
                using (var stream = new MemoryStream(imageBytes)) // Crée un MemoryStream à partir de l'array de bytes
                {
                    Image image = Image.FromStream(stream); // Crée une instance de Image à partir du MemoryStream
                    pb_Weather.Image = image; // Assigner l'image à la PictureBox
                }
            }

            textBox_TempsActuel.Text = "Sur " + ville + ", il fait actuellement " + temperature + ", le temps est " + meteoActuelle;
            textBox_TempFeeling.Text = $"{json["main"]["feels_like"]} °C";
            textBox_Humidite.Text = $"{json["main"]["humidity"]} %";
        }

        private void DGV_Last_Request_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }
    }
}
