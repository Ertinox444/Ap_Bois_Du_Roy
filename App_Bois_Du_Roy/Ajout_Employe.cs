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
        public DataView dvService, dvFonction;
        private Service dt_Service;
        private Fonction dt_Fonction;
        public Ajout_Employe()
        {
            InitializeComponent();
            dt_Service = new Service();
            cbAddEmp_Service.DataSource = dt_Service.GetListeService();
            cbAddEmp_Service.DisplayMember = "NOMSERVICE";
            cbAddEmp_Service.ValueMember = "IDSERVICE";


            dt_Fonction = new Fonction();
            cbAddEmp_Fonction.DataSource = dt_Fonction.GetListeFonction();
            cbAddEmp_Fonction.DisplayMember = "NOMFONCTION";
            cbAddEmp_Fonction.ValueMember = "IDFONCTION";

        }

        private void lbl_Employe_Click(object sender, EventArgs e)
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

        private void btn_AddEmp_Click(object sender, EventArgs e)
        {
            testBox.Text = "";
            if (tbAddEmp_Nom.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nom", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbAddEmp_Prenom.Text == "")
            {
                MessageBox.Show("Veuillez entrer un prénom", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                testBox.Text = "Le nom est : " + tbAddEmp_Nom.Text + "\r\n"
                             + "Le prénom est : " + tbAddEmp_Prenom.Text + "\r\n"
                             + "Le service sélectionné est : " + cbAddEmp_Service.Text + "\r\n"
                             + "La fonction sélectionnée est : " + cbAddEmp_Fonction.Text + "\r\n"
                             + "Le mot de passe est : " + tbAddEmp_MDP.Text;
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new TableauBord());
        }


      
    }
}
