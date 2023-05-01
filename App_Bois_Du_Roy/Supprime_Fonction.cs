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
    public partial class Supprime_Fonction : Form
    {
       
        private DataView dvFonction;
        public Supprime_Fonction()
        {
            InitializeComponent();
            #region Colonne Principal
            Fonction dtviewFonction = new Fonction();
            dvFonction = new DataView(dtviewFonction.GetListeFonction());
            DGV_Liste_Fonction.DataSource = dvFonction;
            DGV_Liste_Fonction.Columns["fonction"].Width = 200;
          
            DGV_Liste_Fonction.EnableHeadersVisualStyles = false;
            DGV_Liste_Fonction.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(87, 128, 64);
            #endregion

            #region ajout colonne checkbox
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "Sélectionner";
            chkbox.Name = "chkbox";
            DGV_Liste_Fonction.Columns.Insert(0, chkbox); // insérer la colonne en premier
            DGV_Liste_Fonction.Columns["chkbox"].Width = 100;
            DGV_Liste_Fonction.CellContentClick += new DataGridViewCellEventHandler(DGV_Liste_Fonction_CellContentClick);

            #endregion
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

        #region gestion des checkbox
        private void DGV_Liste_Fonction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // Vérifier si l'événement est déclenché dans la colonne de la case à cocher
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)DGV_Liste_Fonction.Rows[e.RowIndex].Cells[0];
                chk.Value = !Convert.ToBoolean(chk.Value); // Inverser l'état de la case à cocher
            }
        }
        #endregion

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Fonction Supp = new Fonction();

            List<string> fonctionSelectionnes = new List<string>();
            foreach (DataGridViewRow row in DGV_Liste_Fonction.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells["chkbox"] as DataGridViewCheckBoxCell;
                if (chk.Value != null && (bool)chk.Value)
                {
                    // Si la case est cochée, ajouter le nom du service à la liste des services sélectionnés
                    string nomService = row.Cells["fonction"].Value.ToString();
                    fonctionSelectionnes.Add(nomService);
                }
            }

            Supp.SuppressFonction(fonctionSelectionnes);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new TableauBord());
        }
    }
}
