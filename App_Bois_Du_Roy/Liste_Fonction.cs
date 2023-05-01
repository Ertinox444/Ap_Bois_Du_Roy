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
    public partial class Liste_Fonction : Form
    {
       
        private DataView dvFonction;
        public Liste_Fonction()
        {
            InitializeComponent();

            Fonction dtviewFonction = new Fonction();
            dvFonction = new DataView(dtviewFonction.GetListeFonction());

            DGV_Liste_Fonction.DataSource = dvFonction;
            DGV_Liste_Fonction.Columns["fonction"].Width = 290;
           
            DGV_Liste_Fonction.EnableHeadersVisualStyles = false;
            DGV_Liste_Fonction.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(87, 128, 64);

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

        private void DGV_Liste_Fonction_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_Liste_Fonction.Rows[e.RowIndex];
                row.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == DGV_Liste_Fonction.Columns["Fonction"].Index)
            {
                string message = "Cliquez sur une des fonction pour la modifier";
                DataGridViewCell cell = DGV_Liste_Fonction.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = message;
            }
        }

        private void DGV_Liste_Fonction_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_Liste_Fonction.Rows[e.RowIndex];
                row.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular);
            }
        }

        private void DGV_Liste_Fonction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier que le clic est sur une cellule valide (et non sur l'en-tête)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Récupérer l'employé correspondant à la ligne cliquée
                DataGridViewRow row = DGV_Liste_Fonction.Rows[e.RowIndex];
                string nomFonction = row.Cells["Fonction"].Value.ToString();



                // Ouvrir le formulaire Details_Employe avec les informations de l'employé
                this.Cursor = Cursors.WaitCursor;
                SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
                SF.openChildForm(new ModifyFonction(nomFonction));
            }
        }

        private void lbl_Service_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Service());
        }

        private void lbl_Conge_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Conge());
        }

        private void lbl_lsEmploye_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Employe());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new TableauBord());
        }

        private void lbl_ListeFonction_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Fonction());
        }

        private void lbl_AddEmploye_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Ajout_Fonction());
        }

        private void lbl_SuppEmploye_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Supprime_Fonction());
        }

        private void pb_LogOut_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Page_Connection());
        }
    }
}
