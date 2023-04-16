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
    public partial class Details_Employe : Form
    {
        private photoProfil PP = new photoProfil();
        private Matricule Mat = new Matricule();
        private Service Serv = new Service();
        private Employe Emp = new Employe();
        private Employe Birth = new Employe();
        private Fonction Fonc = new Fonction();
        private Contact Tel = new Contact();
        private Contact Mail = new Contact();
       
        private Detail_Panel panel;
        public Details_Employe(string matricule)
        {
            InitializeComponent();
            panel = new Detail_Panel();
            panel.RoundCorners(panel3, 50);
            PP = new photoProfil();
            Mat = new Matricule();
            Serv = new Service();
            Emp = new Employe();
            Fonc = new Fonction();
            Tel = new Contact();
            Mail = new Contact();
            Birth = new Employe();

            
            tb_MatEmp.Text = matricule;
            tb_ServiceEmp.Text = "Service : " + Serv.RecupServEmploye(matricule); 
            tb_FonctionEmp.Text = "- " + Fonc.RecupFoncEmploye(matricule);
            tb_FullNameEmp.Text = Emp.RecupNameEmploye(matricule);
            tb_MailEmp.Text = "Mail : " + Mail.RecupMailEmploye(matricule);
            tb_TelEmp.Text = "Tel : " + Tel.RecupNumTelEmploye(matricule);
            tb_BirthEmp.Text = Birth.RecupBirthEmploye(matricule);
            

            if (PP.GetImage(matricule) != null)
          
            {
                pb_PP.Image = PP.Convertir(PP.GetImage(matricule));
            }

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
