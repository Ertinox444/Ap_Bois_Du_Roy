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
    public partial class ModifyEmp : Form
    {
    
        private Service Serv = new Service();
        private Employe Emp = new Employe();
        private Employe Birth = new Employe();
        private Fonction Fonc = new Fonction();
        private Contact Tel = new Contact();
        private Contact Mail = new Contact();
        private Employe NumSecu = new Employe();
        private Employe MatRespo = new Employe();
        private Employe Embauche = new Employe();

        private Service dt_Service;
        private Fonction dt_Fonction;
        private Matricule dt_Matricule;

        private string mat_recup;
        public ModifyEmp(string matricule)
        {
            mat_recup = matricule;
            InitializeComponent();
            Serv = new Service();
            Emp = new Employe();
            Fonc = new Fonction();
            Tel = new Contact();
            Mail = new Contact();
            Birth = new Employe();
            Fonc = new Fonction();
            NumSecu = new Employe();
            MatRespo = new Employe();
            Embauche = new Employe();



            string[] nomPrenom = Emp.RecupNameEmploye(matricule).Split(' ');
            tbModifEmp_Mat.Text = matricule;
            tbModifEmp_Nom.Text = nomPrenom[0];
            tbModifEmp_Prenom.Text = nomPrenom[1];
            tbModifEmp_NumTel.Text = Tel.RecupNumTelEmploye(matricule);
            
            dtP_Birth.Value = Convert.ToDateTime(Birth.RecupBirthEmploye(matricule));
            dtP_Embauche.Value = Convert.ToDateTime(Embauche.RecupEmbaucheEmploye(matricule));
            tbModifEmp_NumSec.Text = NumSecu.RecupNumSecu(matricule);

            dt_Service = new Service();
            cbModifEmp_Service.DataSource = dt_Service.GetListeServiceCB();
            cbModifEmp_Service.DisplayMember = "NOMSERVICE";
            cbModifEmp_Service.ValueMember = "IDSERVICE";

            dt_Fonction = new Fonction();
            cbModifEmp_Fonction.DataSource = dt_Fonction.GetListeFonctionCB();
            cbModifEmp_Fonction.DisplayMember = "NOMFONCTION";
            cbModifEmp_Fonction.ValueMember = "IDFONCTION";

            dt_Matricule = new Matricule();
            cbModifEmp_MatRespo.DataSource = dt_Matricule.GetListeMatriculeCB();
            cbModifEmp_MatRespo.DisplayMember = "MATRICULE";
            cbModifEmp_MatRespo.ValueMember = "MATRICULE";

            cbModifEmp_Fonction.Text = Fonc.RecupFoncEmploye(matricule);
            cbModifEmp_Service.Text = Serv.RecupServEmploye(matricule);
            cbModifEmp_MatRespo.Text = MatRespo.RecupRespoEmp(matricule);


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

        private void lbl_Employe_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new TableauBord());
        }

        private void btn_ModifEmp_Click(object sender, EventArgs e)
        {
            dtP_Birth.Format = DateTimePickerFormat.Custom;
            dtP_Birth.CustomFormat = "yyyy-MM-dd";
            DateTime selectedDate_Birth = dtP_Birth.Value;
            string formattedDate_Birth = selectedDate_Birth.ToString(dtP_Birth.CustomFormat);

            dtP_Embauche.Format = DateTimePickerFormat.Custom;
            dtP_Embauche.CustomFormat = "yyyy-MM-dd";
            DateTime selectedDate_Embauche = dtP_Embauche.Value;
            string formattedDate_Embauche = selectedDate_Embauche.ToString(dtP_Embauche.CustomFormat);

            string nomComplet = tbModifEmp_Nom.Text + " " + tbModifEmp_Prenom.Text;
            string prenom = nomComplet.Split(' ')[0]; // Récupère le prénom
            string nomFamille = nomComplet.Split(' ')[1]; // Récupère le nom de famille
            string adresseEmail = prenom.Substring(0, 1) + nomFamille + "@broy.com"; // Crée l'adresse e-mail


            if (tbModifEmp_Nom.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nom", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbModifEmp_Prenom.Text == "")
            {
                MessageBox.Show("Veuillez entrer un prénom", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbModifEmp_NumSec.Text == "")
            {
                MessageBox.Show("Veuillez entrer le numéro de sécurité social", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbModifEmp_Service.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un service", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbModifEmp_Fonction.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner une fonction", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Employe Envoie = new Employe();
                
                Envoie.ModifyEmploye(tbModifEmp_Nom.Text, tbModifEmp_Prenom.Text, cbModifEmp_Service.Text, cbModifEmp_Fonction.Text, cbModifEmp_MatRespo.Text, adresseEmail, tbModifEmp_NumTel.Text, tbModifEmp_NumSec.Text, formattedDate_Birth, formattedDate_Embauche, tbModifEmp_Mat.Text, mat_recup);
                Envoie.Modify_Compte(tbModifEmp_MDP.Text, tbModifEmp_Mat.Text, tbModifEmp_Nom.Text, tbModifEmp_Prenom.Text, mat_recup);
                this.Cursor = Cursors.WaitCursor;
                SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
                SF.openChildForm(new Liste_Employe());
            }
        }

        private void pb_LogOut_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Page_Connection());
        }
    }
}
