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
    public partial class Liste_Employe : Form
    {

    
        private DataView dvEmploye;

        public Liste_Employe()
        {
            InitializeComponent();
            Employe dtviewEmploye = new Employe();

            dvEmploye = new DataView(dtviewEmploye.GetlisteEmploye());
            

            DGV_Liste_Employe.DataSource = dvEmploye;
            DGV_Liste_Employe.Columns["Matricule"].Width = 200;
            DGV_Liste_Employe.Columns["Nom"].Width = 200;
            DGV_Liste_Employe.Columns["Service"].Width = 200;
            DGV_Liste_Employe.Columns["Fonction"].Width = 200;
            DGV_Liste_Employe.Columns["Congé en attente"].Width = 200;
            DGV_Liste_Employe.EnableHeadersVisualStyles = false;
            DGV_Liste_Employe.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(87,128,64);
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
        private void DGV_Liste_Employe_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_Liste_Employe.Rows[e.RowIndex];
               
                Font myBoldFont = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                row.DefaultCellStyle.Font = myBoldFont;
            }
        }

        


        private void DGV_Liste_Employe_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_Liste_Employe.Rows[e.RowIndex];
                Font myFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                row.DefaultCellStyle.Font = myFont;
            }
        }


        private void DGV_Liste_Employe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier que le clic est sur une cellule valide (et non sur l'en-tête)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Récupérer l'employé correspondant à la ligne cliquée
                DataGridViewRow row = DGV_Liste_Employe.Rows[e.RowIndex];
                string matricule = row.Cells["Matricule"].Value.ToString();


                this.Cursor = Cursors.WaitCursor;
                // Ouvrir le formulaire Details_Employe avec les informations de l'employé
                SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
                SF.openChildForm(new Details_Employe(matricule));
            }
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

        private void lbl_lsEmploye_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Employe());
        }

        private void lbl_AddEmploye_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Ajout_Employe());
        }

        private void lbl_SuppEmploye_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Supprime_Employe());
        }

        private void pb_LogOut_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Page_Connection());
        }

        private void DGV_Liste_Employe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
                // Vérifier si la cellule correspond à la colonne "Conge"
                if (e.ColumnIndex == DGV_Liste_Employe.Columns["Congé en attente"].Index && e.Value != null)
                {
                    string value = e.Value.ToString();
                    if (!value.Contains("Aucun"))
                    {
                        // Appliquer la couleur rouge à la police de caractères
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    // Ajouter une pastille de couleur
                        e.CellStyle.Padding = new Padding(2);
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.SelectionBackColor = Color.Red;
                        e.CellStyle.SelectionForeColor = Color.Red;
                    }
                }
            }
        }
    }

