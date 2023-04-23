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
    public partial class Details_Service : Form
    {
        private Service Respo = new Service();
        private Service NbEmploye = new Service();
        private Service dtviewEmployeService = new Service();
        private DataView dvEmployeService;
        public Details_Service(string nomService)
        {
            InitializeComponent();

            Respo = new Service();
            NbEmploye = new Service();

            if (Respo.RecupNameResponsable(nomService) == null)
            {
                tb_RespoService.Text = "Aucun Responsable défini";
            }
            else
            {
                tb_RespoService.Text = "Responsable : " + Respo.RecupNameResponsable(nomService);
            }
            
            tb_ServiceName.Text = "Service " + nomService;
            tb_NbEmploye.Text = "Nombre d'employé(s) dans le service : " + Convert.ToString(NbEmploye.RecupNbEmployeService(nomService));

            dtviewEmployeService = new Service();
            dvEmployeService = new DataView(dtviewEmployeService.GetlisteEmployeService(nomService));
            DGV_Liste_EmployeService.DataSource = dvEmployeService;
            DGV_Liste_EmployeService.Columns["Matricule"].Width = 150;
            DGV_Liste_EmployeService.Columns["Nom"].Width = 150;
            DGV_Liste_EmployeService.EnableHeadersVisualStyles = false;
            DGV_Liste_EmployeService.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(87, 128, 64);
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

        private void lbl_ListeFonction_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new Liste_Fonction());
        }

        private void lbl_ModifEmploye_Click(object sender, EventArgs e)
        {
            
            string NomService = tb_ServiceName.Text.Replace("Service ", "");
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
            SF.openChildForm(new ModifyServ(NomService));
        }
    }
}
