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
    public partial class Supprime_Employe : Form
    {
        private Connect dtviewEmploye = new Connect();
        private DataView dvEmploye;
        public Supprime_Employe()
        {
            InitializeComponent();
            #region Colonne Principale
            dtviewEmploye = new Connect();
            dvEmploye = new DataView(dtviewEmploye.GetlisteEmploye());
            DGV_Liste_Employe.DataSource = dvEmploye;
            DGV_Liste_Employe.Columns["Matricule"].Width = 265;
            DGV_Liste_Employe.Columns["Nom"].Width = 265;
            DGV_Liste_Employe.Columns["Service"].Width = 265;
            DGV_Liste_Employe.Columns["Fonction"].Width = 265;
            DGV_Liste_Employe.EnableHeadersVisualStyles = false;
            DGV_Liste_Employe.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(87, 128, 64);
            #endregion

            #region ajout colonne checkbox
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "Sélectionner";
            chkbox.Name = "chkbox";
            DGV_Liste_Employe.Columns.Insert(0, chkbox); // insérer la colonne en premier
            DGV_Liste_Employe.Columns["chkbox"].Width = 100;
            DGV_Liste_Employe.CellContentClick += new DataGridViewCellEventHandler(DGV_Liste_Employe_CellContentClick);

            #endregion
            
        }
        #region gestion des checkbox
        private void DGV_Liste_Employe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // Vérifier si l'événement est déclenché dans la colonne de la case à cocher
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)DGV_Liste_Employe.Rows[e.RowIndex].Cells[0];
                chk.Value = !Convert.ToBoolean(chk.Value); // Inverser l'état de la case à cocher
            }
        }
        #endregion
        private void btnSupprimer_EMP_Click(object sender, EventArgs e)
        {
            Connect Supp = new Connect();

            List<string> employeSelectionnes = new List<string>();
            foreach (DataGridViewRow row in DGV_Liste_Employe.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells["chkbox"] as DataGridViewCheckBoxCell;
                if (chk.Value != null && (bool)chk.Value)
                {
                    // Si la case est cochée, ajouter le nom du service à la liste des services sélectionnés
                    string matEmploye = row.Cells["Matricule"].Value.ToString();
                    employeSelectionnes.Add(matEmploye);
                }
            }

            Supp.SuppressEmploye(employeSelectionnes);
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Employe());
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

        
    }
}