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
        private Connect dtviewConge = new Connect();
        public DataView dvConge;
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
            dtviewConge = new Connect();
            dvConge = new DataView(dtviewConge.GetlisteConge());
            DGV_Liste_Conge.DataSource = dvConge;
            DGV_Liste_Conge.Columns["Employe"].Width = 232;
            DGV_Liste_Conge.Columns["Type Conge"].Width = 232;
            DGV_Liste_Conge.Columns["Duree"].Width = 232;
            DGV_Liste_Conge.Columns["Statut"].Width = 232;
            DGV_Liste_Conge.Columns["Valideur"].Width = 232;
            DGV_Liste_Conge.EnableHeadersVisualStyles = false;
            DGV_Liste_Conge.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(87, 128, 64);
            DGV_Liste_Conge.CellFormatting += DGV_Liste_Conge_CellFormatting;
        }

        private void lbl_Conge_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Conge());
        }

        private void lbl_Employe_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Employe());
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

        private void lbl_StatConge_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Conge_Stat());
        }
    }
}
