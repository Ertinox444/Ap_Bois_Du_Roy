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
            DGV_HistoryConge.EnableHeadersVisualStyles = false;
            DGV_HistoryConge.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            DGV_HistoryConge.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(87, 128, 64);
            DGV_HistoryConge.GridColor = Color.FromArgb(87, 128, 64);
            DGV_HistoryConge.CellBorderStyle = DataGridViewCellBorderStyle.Single;



            string name = Emp.RecupNameEmploye(matricule);
            tb_MatEmp.Text = matricule;
            tb_ServiceEmp.Text = "Service : " + Serv.RecupServEmploye(matricule); 
            tb_FonctionEmp.Text = "- " + Fonc.RecupFoncEmploye(matricule);
            tb_FullNameEmp.Text = name;
            tb_MailEmp.Text = "Mail : " + Mail.RecupMailEmploye(matricule);
            tb_TelEmp.Text = "Tel : " + Tel.RecupNumTelEmploye(matricule);
            tb_BirthEmp.Text = Birth.RecupBirthEmploye(matricule);
            tb_RTTRestant.Text = "RTT restant : " + CongeRestant.RecupCongeRestantEmploye(matricule, "RTT")+ " jours";
            tb_CongePayeRestant.Text = "Conge payé restant : " + CongeRestant.RecupCongeRestantEmploye(matricule,"Congé Payé") + " jours";

            
            string[] nameParts = name.Split(' '); // Séparation du nom complet en parties (prénom et nom)
            string initials = ""; // Initialisation de la variable contenant les initiales
            foreach (string part in nameParts)
            {
                if (part.Contains("-")) // Si le nom contient un trait d'union (prénom composé)
                {
                    string[] hyphenatedParts = part.Split('-'); // Séparation du nom en parties (par exemple "Jean-Michel" devient ["Jean", "Michel"])
                    foreach (string hyphenatedPart in hyphenatedParts)
                    {
                        initials += hyphenatedPart.Substring(0, 1).ToUpper(); // Ajout de la première lettre de chaque partie séparée par un trait d'union
                    }
                }
                else // Si le nom ne contient pas de trait d'union
                {
                    initials += part.Substring(0, 1).ToUpper(); // Ajout de la première lettre
                }
            }

            lbl_PP.Text = initials;

            if (PP.GetImage(matricule) != null)
          
            {
                lbl_PP.Text = "";
                pb_PP.Image = PP.Convertir(PP.GetImage(matricule));
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new TableauBord());
        }

        private void lbl_ModifEmploye_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new ModifyEmp(tb_MatEmp.Text));
        }

        private void pb_LogOut_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Page_Connection());
        }

        
    }
}
