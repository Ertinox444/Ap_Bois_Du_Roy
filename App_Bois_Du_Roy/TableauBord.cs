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
    public partial class TableauBord : Form
    {
        public DataView dv;
        private Connect dtviewtest = new Connect();
        public Connect date_of_Today = new Connect();
        public TableauBord()
        {
            InitializeComponent();
            dtviewtest = new Connect();
            dv = new DataView(dtviewtest.LastRequest());
            DGV_Last_Request.DataSource = dv;
           
            DGV_Last_Request.Columns["EMPLOYE"].Width= 205;
            DGV_Last_Request.Columns["CONGE"].Width = 205;
            DGV_Last_Request.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(87, 128, 64);
            DGV_Last_Request.DefaultCellStyle.ForeColor = Color.FromArgb(87, 128, 64);
            date_of_Today = new Connect();
            tb_Today_Date.Text = date_of_Today.TodayDate();
         

        }

        private void lbl_lsEmploye_Click(object sender, EventArgs e)
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

     
    }
}
