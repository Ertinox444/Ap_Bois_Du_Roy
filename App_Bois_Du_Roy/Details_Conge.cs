﻿using System;
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
    public partial class Details_Conge : Form
    {

        private bool rb_accept_checked = false;
        private int IDConge;
        private int TempsRestant;
        private int TempsDemande;
        private string TypeDemande;
        private string matEmpDemande;
        public Details_Conge(string employe, string tempsDemande, string typeDemande, int idConge, bool AlreadyDecision)
        {
            IDConge = idConge;

            Conge CongeRestant = new Conge();
            Matricule matEmp = new Matricule();
            Service servEmp = new Service();
            Conge motifDemande = new Conge();
            matEmpDemande = matEmp.RecupMatEmploye(employe);
            string servEmpDemande = servEmp.RecupServEmploye(matEmpDemande);
            TempsDemande = Convert.ToInt32(tempsDemande.Replace(" jours", ""));
            TempsRestant = CongeRestant.RecupCongeRestantEmploye(matEmpDemande, typeDemande);
            TypeDemande = typeDemande;
            InitializeComponent();
            lbl_CRestant.Text = typeDemande + " restant : " + Convert.ToString(TempsRestant) + " jours";
            lbl_NomPrenom.Text = employe;
            lbl_CongeDemande.Text = "Durée du " + typeDemande + " demandé : " + tempsDemande;
            lbl_NomService.Text = "Service : " + servEmpDemande;
            rtb_MotifDemande.Text = motifDemande.RecupMotifDemandeConge(IDConge);
            if (AlreadyDecision == true)
            {
                pnl_Decision.Enabled = false;
                btn_ValidDecision.Enabled = false;

                Conge MotifDecision = new Conge();
                Conge StautDecision = new Conge();

                if (StautDecision.RecupDecisionConge(IDConge) == 2)
                {
                    rb_Accept.CheckedChanged += new EventHandler(rb_CheckedChanged);
                }
                if (StautDecision.RecupDecisionConge(IDConge) == 3)
                {
                    rb_Refuse.CheckedChanged += new EventHandler(rb_CheckedChanged);
                }

                rtb_Justification.Text = MotifDecision.RecupMotifDecisionConge(IDConge);
            }

            if (TempsRestant < TempsDemande && AlreadyDecision == true)
            {
                lbl_CRestant.ForeColor = Color.Red;
          
            }

            rb_Accept.CheckedChanged += new EventHandler(rb_CheckedChanged);
            rb_Refuse.CheckedChanged += new EventHandler(rb_CheckedChanged);


        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                if (rb == rb_Accept)
                {
                    rb_Refuse.Checked = false;
                    rb_accept_checked = true;
                }
                else if (rb == rb_Refuse)
                {
                    rb_Accept.Checked = false;
                    rb_accept_checked = false;
                }
            }
        }
        // méthode pour récupérer la valeur sélectionnée
        public int GetAcceptation()
        {
            int id_Statue = 1;
            if (rb_accept_checked == true)
            {
                id_Statue = 2;
            }
            else
            {
                id_Statue = 3;
            }
            return id_Statue;
        }



    

    

        private void btn_ValidDecision_Click(object sender, EventArgs e)
        {

            if (TempsRestant < TempsDemande && GetAcceptation() == 2)
            {
                MessageBox.Show("Impossible le temps de "+ TypeDemande + " demandé est inférieure au temps restants" , "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else {
                Conge Envoie = new Conge();
                Envoie.DecisionConge(IDConge, rtb_Justification.Text, GetAcceptation(), TempsDemande, matEmpDemande, TypeDemande);
                SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
                SF.openChildForm(new Liste_Conge());
            }
            
        }

        private void lbl_Employe_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Employe());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new TableauBord());
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

        private void lbl_ListeFonction_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Fonction());
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Conge());
        }
    }
}
