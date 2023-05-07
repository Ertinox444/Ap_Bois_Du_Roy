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
    public partial class Liste_Conge : Form
    {
        private Conge dtviewConge = new Conge();
        public DataView dvConge;
        private int IndiceType = 0;
        private void DGV_Liste_Conge_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DGV_Liste_Conge.Columns["Statut"].Index)
            {
                string statut = e.Value.ToString();
                if (statut == "En attente")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
        public Liste_Conge()
        {
            InitializeComponent();
            dtviewConge = new Conge();
            dvConge = new DataView(dtviewConge.GetlisteConge());
            DGV_Liste_Conge.DataSource = dvConge;
            DGV_Liste_Conge.Columns["Employe"].Width = 232;
            DGV_Liste_Conge.Columns["Type Conge"].Width = 232;
            DGV_Liste_Conge.Columns["Duree"].Width = 232;
            DGV_Liste_Conge.Columns["Statut"].Width = 232;
            DGV_Liste_Conge.Columns["Valideur"].Width = 232;
            DGV_Liste_Conge.Columns["ID_CONGE"].Visible = false;
            DGV_Liste_Conge.Columns["Date Debut"].Visible = false;
            DGV_Liste_Conge.Columns["Date Fin"].Visible = false;
            DGV_Liste_Conge.EnableHeadersVisualStyles = false;
            DGV_Liste_Conge.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(87, 128, 64);
            DGV_Liste_Conge.CellFormatting += DGV_Liste_Conge_CellFormatting;

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


            cB_FiltreType.Items.Add("Employe");
            cB_FiltreType.Items.Add("Service");
            cB_FiltreType.Items.Add("Fonction");

        }

        private void DGV_Liste_Conge_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_Liste_Conge.Rows[e.RowIndex];
                row.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);
            }
            
        }

        private void DGV_Liste_Conge_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_Liste_Conge.Rows[e.RowIndex];
                row.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular);
            }
        }

        private void DGV_Liste_Conge_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier que le clic est sur une cellule valide (et non sur l'en-tête)
            if (e.RowIndex >= 0) // Vérifier si l'utilisateur a cliqué sur une ligne valide
            {
                DataGridViewRow row = DGV_Liste_Conge.Rows[e.RowIndex];
                string duree = row.Cells["Duree"].Value.ToString();
                string employe = row.Cells["Employe"].Value.ToString();
                string typeConge = row.Cells["Type Conge"].Value.ToString();
                int idConge = Convert.ToInt32(row.Cells["ID_CONGE"].Value.ToString());
                bool AlreadyDecision = false;
                


                // Vérifie le statut du congé
                string statut = row.Cells["Statut"].Value.ToString();
                if (statut != "En attente")
                {
                    AlreadyDecision = true;
                }
                else
                {
                    AlreadyDecision = false;
                }
                this.Cursor = Cursors.WaitCursor;
                SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
                SF.openChildForm(new Details_Conge(employe, duree, typeConge, idConge, AlreadyDecision));
            }
        }

        private void lbl_Conge_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Conge());
        }

        private void lbl_Employe_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Employe());
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

        private void lbl_StatConge_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Conge_Stat());
        }

        private void pb_LogOut_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Page_Connection());
        }

        

        private void lbl_Export_Click(object sender, EventArgs e)
        {
            Misc ExportData = new Misc();
            ExportData.ExportDataGridView(DGV_Liste_Conge, cB_FiltreType.Text, cB_Filtre.Text);


        }

        private void cB_FiltreType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conge TypeConge = new Conge();
            cB_Filtre.DataSource = TypeConge.RenvoieFiltreConge(cB_FiltreType.Text);
            
            if (cB_FiltreType.Text == "Employe")
            {
                IndiceType = 1;
                cB_Filtre.DisplayMember = "EMPLOYE";
                cB_Filtre.ValueMember = "MATRICULE";
            }
            if (cB_FiltreType.Text == "Service")
            {
                IndiceType = 2;
                cB_Filtre.DisplayMember = "NOMSERVICE";
                cB_Filtre.ValueMember = "IDSERVICE";
            }
            if (cB_FiltreType.Text == "Fonction")
            {
                IndiceType = 3;
                cB_Filtre.DisplayMember = "NOMFONCTION";
                cB_Filtre.ValueMember = "IDFONCTION";
            }

            
        }

        private void cB_Filtre_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtviewConge = new Conge();
            if (cB_Filtre.Text != "")
            {
                if (IndiceType == 1)
                {
                    dvConge = new DataView(dtviewConge.GetlisteCongeFiltered(IndiceType, cB_Filtre.Text));
                }
                if (IndiceType == 2)
                {
                    dvConge = new DataView(dtviewConge.GetlisteCongeFiltered(IndiceType, cB_Filtre.Text));
                }
                if (IndiceType == 3)
                {
                    dvConge = new DataView(dtviewConge.GetlisteCongeFiltered(IndiceType, cB_Filtre.Text));
                }
                DGV_Liste_Conge.DataSource = dvConge;
            }
            if (cB_Filtre.Text == "")
            {
                dvConge = new DataView(dtviewConge.GetlisteConge());
                DGV_Liste_Conge.DataSource = dvConge;
            }

            

        }
    }
}
