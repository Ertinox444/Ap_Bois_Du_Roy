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
    public partial class Ajout_Employe : Form
    {
        public DataView dvService, dvFonction, dvMatricule;
        public Misc Envoie;
        private Service dt_Service;
        private Fonction dt_Fonction;
        private Employe dt_Matricule;
        public Ajout_Employe()
        {
            InitializeComponent();
            dt_Service = new Service();
            cbAddEmp_Service.DataSource = dt_Service.GetListeServiceCB();
            cbAddEmp_Service.DisplayMember = "NOMSERVICE";
            cbAddEmp_Service.ValueMember = "IDSERVICE";


            dt_Fonction = new Fonction();
            cbAddEmp_Fonction.DataSource = dt_Fonction.GetListeFonctionCB();
            cbAddEmp_Fonction.DisplayMember = "NOMFONCTION";
            cbAddEmp_Fonction.ValueMember = "IDFONCTION";

            dt_Matricule = new Employe();
            cbAddEmp_MatRespo.DataSource = dt_Matricule.GetListeResponsableCB();
            cbAddEmp_MatRespo.DisplayMember = "RESPONSABLE";
            cbAddEmp_MatRespo.ValueMember = "MATRICULE";

            Matricule lastMat = new Matricule();
            string derniermatricule = lastMat.GetDernierMatricule();
            tbAddEmp_LastMat.Text = derniermatricule;
            int nombre = int.Parse(derniermatricule.Substring(1)) + 1;
            tbAddEmp_Mat.Text = derniermatricule[0] + nombre.ToString().PadLeft(derniermatricule.Length - 1, '0');

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

        private void pb_LogOut_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Page_Connection());
        }

        private void lbl_Service_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Service());
        }

        private void btn_AddEmp_Click(object sender, EventArgs e)
        {
           
            dtP_Birth.Format = DateTimePickerFormat.Custom;
            dtP_Birth.CustomFormat = "yyyy-MM-dd";
            DateTime selectedDate_Birth = dtP_Birth.Value;
            string formattedDate_Birth = selectedDate_Birth.ToString(dtP_Birth.CustomFormat);

            dtP_Embauche.Format = DateTimePickerFormat.Custom;
            dtP_Embauche.CustomFormat = "yyyy-MM-dd";
            DateTime selectedDate_Embauche= dtP_Birth.Value;
            string formattedDate_Embauche = selectedDate_Embauche.ToString(dtP_Embauche.CustomFormat);

            string nomComplet = tbAddEmp_Nom.Text + " " + tbAddEmp_Prenom.Text;
            string prenom = nomComplet.Split(' ')[0]; // Récupère le prénom
            string nomFamille = nomComplet.Split(' ')[1]; // Récupère le nom de famille
            string adresseEmail = prenom.Substring(0, 1) + nomFamille + "@broy.com"; // Crée l'adresse e-mail


            if (tbAddEmp_Nom.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nom", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbAddEmp_Prenom.Text == "")
            {
                MessageBox.Show("Veuillez entrer un prénom", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbAddEmp_NumSec.Text == "")
            {
                MessageBox.Show("Veuillez entrer le numéro de sécurité social", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbAddEmp_Service.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un service", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbAddEmp_Fonction.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner une fonction", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbAddEmp_MDP.Text == "")
            {
                MessageBox.Show("Veuillez entrer un mot de passe", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int IsResponsable = 0;
                if (checkB_IsRespo.Checked)
                {
                    IsResponsable = 1;
                }
                Employe Envoie = new Employe();

                Envoie.InsertEmploye(tbAddEmp_Nom.Text, tbAddEmp_Prenom.Text, cbAddEmp_Service.Text, cbAddEmp_Fonction.Text, cbAddEmp_MatRespo.Text, adresseEmail, tbAddEmp_NumTel.Text, tbAddEmp_NumSec.Text, formattedDate_Birth, formattedDate_Embauche, tbAddEmp_Mat.Text);
                Envoie.Insert_Compte(tbAddEmp_MDP.Text, tbAddEmp_Mat.Text, tbAddEmp_Nom.Text, tbAddEmp_Prenom.Text,IsResponsable);
                this.Cursor = Cursors.WaitCursor;
                SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
                SF.openChildForm(new Liste_Employe());
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new TableauBord());
        }


      
    }
}
