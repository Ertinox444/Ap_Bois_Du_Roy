using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Bois_Du_Roy.Controller;
using App_Bois_Du_Roy.Modele;

namespace App_Bois_Du_Roy
{
    public partial class Details_Employe : Form
    {
        private photoProfil PP = new photoProfil();
        private Service Serv = new Service();
        private Employe Emp = new Employe();
        private Employe Birth = new Employe();
        private Fonction Fonc = new Fonction();
        private Contact Tel = new Contact();
        private Contact Mail = new Contact();
        private Conge CongeRestant = new Conge();

        private Conge dtviewHistoryConge = new Conge();
        private DataView dvHistoryConge;

        private Detail_Panel panel;
        public Details_Employe(string matricule)
        {
            InitializeComponent();
            panel = new Detail_Panel();
            panel.RoundCorners(panel3, 50);
            PP = new photoProfil();
            Serv = new Service();
            Emp = new Employe();
            Fonc = new Fonction();
            Tel = new Contact();
            Mail = new Contact();
            Birth = new Employe();
            CongeRestant = new Conge();

            dtviewHistoryConge = new Conge();
            dvHistoryConge = new DataView(dtviewHistoryConge.GetHistoriqueConge(matricule));
            DGV_HistoryConge.DataSource = dvHistoryConge;
            DGV_HistoryConge.Columns["Type"].Width = 150;
            DGV_HistoryConge.Columns["Duree"].Width = 150;
            DGV_HistoryConge.Columns["Statut"].Width = 150;
            DGV_HistoryConge.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(87, 128, 64);



            tb_MatEmp.Text = matricule;
            tb_ServiceEmp.Text = "Service : " + Serv.RecupServEmploye(matricule); 
            tb_FonctionEmp.Text = "- " + Fonc.RecupFoncEmploye(matricule);
            tb_FullNameEmp.Text = Emp.RecupNameEmploye(matricule);
            tb_MailEmp.Text = "Mail : " + Mail.RecupMailEmploye(matricule);
            tb_TelEmp.Text = "Tel : " + Tel.RecupNumTelEmploye(matricule);
            tb_BirthEmp.Text = Birth.RecupBirthEmploye(matricule);
            tb_RTTRestant.Text = "RTT restant : " + CongeRestant.RecupCongeRestantEmploye(matricule, "RTT");
            tb_CongePayeRestant.Text = "Conge payé restant : " + CongeRestant.RecupCongeRestantEmploye(matricule,"Congé Payé");
            

            if (PP.GetImage(matricule) != null)
          
            {
                pb_PP.Image = PP.Convertir(PP.GetImage(matricule));
            }

        }

        private void lbl_lsEmploye_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Employe());
        }

        private void lbl_Conge_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Conge());
        }

        private void lbl_Service_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Service());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new TableauBord());
        }

        private void lbl_ModifEmploye_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new ModifyEmp(tb_MatEmp.Text));
        }
    }
}
