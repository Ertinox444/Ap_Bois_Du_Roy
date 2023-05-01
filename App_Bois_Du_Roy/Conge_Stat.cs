using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using App_Bois_Du_Roy.Modele;
using App_Bois_Du_Roy.Controller;
using MySql.Data.MySqlClient;

namespace App_Bois_Du_Roy.Controller
{
    public partial class Conge_Stat : Form
    {
       
        public Conge_Stat()
        {
            Conge result = new Conge();
            Conge PrctCongeRestant = new Conge();
            Conge PrctCongePris = new Conge();
            var tupleResult = result.RecupConge();
            List<string> mois = tupleResult.mois;
            List<double> RTT = tupleResult.RTT;
            List<double> CP = tupleResult.CP;

            InitializeComponent();
            // création de la première série pour les jours de congés payés
            Series seriesCongesPayes = new Series("Congés payés");
            seriesCongesPayes.ChartType = SeriesChartType.Line;
            for (int i = 0; i < mois.Count; i++)
            {
                seriesCongesPayes.Points.AddXY(mois[i], CP[i]);
            }

            // création de la deuxième série pour les jours de RTT
            Series seriesRTT = new Series("RTT");
            seriesRTT.ChartType = SeriesChartType.Line;
            for (int i = 0; i < mois.Count; i++)
            {
                seriesRTT.Points.AddXY(mois[i], RTT[i]);
            }

            // ajout des séries à la chart
            ch_StatConge.Series.Add(seriesCongesPayes);
            ch_StatConge.Series.Add(seriesRTT);

            seriesCongesPayes.BorderWidth = 3;
            seriesRTT.BorderWidth = 3;
           
            Color titleColor = Color.FromArgb(84, 128, 67);

            ch_StatConge.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            ch_StatConge.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            ch_StatConge.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.White;
            ch_StatConge.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.White;
            ch_StatConge.ChartAreas[0].AxisX.LineColor = Color.LightGray; // Change la couleur de l'axe X
          
            ch_StatConge.ChartAreas[0].AxisY.LineColor = Color.LightGray; // Change la couleur de l'axe Y
        

            // personnalisation de la chart
            ch_StatConge.Titles.Add(new Title("Jours pris en congés payés et en RTT", Docking.Top, new Font("Tahoma", 14, FontStyle.Bold), titleColor));

            ch_StatConge.ChartAreas[0].AxisX.Title = "Mois";
            ch_StatConge.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 14, FontStyle.Regular);
            ch_StatConge.ChartAreas[0].AxisX.TitleForeColor = titleColor;
            ch_StatConge.ChartAreas[0].AxisY.Title = "Nombre de jours";
            ch_StatConge.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 14, FontStyle.Regular);
            ch_StatConge.ChartAreas[0].AxisY.TitleForeColor = titleColor;
            ch_StatConge.ChartAreas[0].AxisX.Interval = 1;

            tb_Prct_CPRestant.Text = Convert.ToString(PrctCongeRestant.RecupPourcentageCongeRestant("Congé Payé")) + " %";
            tb_Prct_CPRestant.TextAlign = HorizontalAlignment.Center;
            tb_Prct_CPRestant.Multiline = true;
            tb_Prct_CPRestant.Height = 45;

            tb_Prct_RTTRestant.Text = Convert.ToString(PrctCongeRestant.RecupPourcentageCongeRestant("RTT")) + " %";
            tb_Prct_RTTRestant.TextAlign = HorizontalAlignment.Center;
            tb_Prct_RTTRestant.Multiline = true;
            tb_Prct_RTTRestant.Height = 45;

            List<Int32> mois_PremierTrimestre = new List<Int32>() { 1, 2, 3 };
            List<Int32> mois_DeuxiemeTrimestre = new List<Int32>() { 4, 5, 6 };
            List<Int32> mois_TroisiemeTrimestre = new List<Int32>() { 7, 8, 9 };
            List<Int32> mois_QuatriemeTrimestre = new List<Int32>() { 10, 11, 12 };
            tb_PremierTrmstr.Text = Convert.ToString(PrctCongePris.RecupPourcentageCongePris(mois_PremierTrimestre)) + " %";
            tb_SecondTrmstr.Text = Convert.ToString(PrctCongePris.RecupPourcentageCongePris(mois_DeuxiemeTrimestre)) + " %";
            tb_TroisiemeTrmstr.Text = Convert.ToString(PrctCongePris.RecupPourcentageCongePris(mois_TroisiemeTrimestre)) + " %";
            tb_QuatriemeTrmstr.Text = Convert.ToString(PrctCongePris.RecupPourcentageCongePris(mois_QuatriemeTrimestre)) + " %";


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new TableauBord());
        }

        private void lbl_lsEmploye_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Employe());
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
    }
}
