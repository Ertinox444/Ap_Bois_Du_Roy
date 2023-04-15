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
using BC = BCrypt.Net.BCrypt;


namespace App_Bois_Du_Roy
{
    public partial class Page_Connection : Form
    {
        public Connect connecte = new Connect();


        public string mdp;
        public string mdp1;
        public string login1;
        public string login;
        
    

        public Page_Connection()
        {
            InitializeComponent();
            

        }





        private void btn_connect_Click(object sender, EventArgs e)
        {
            login = tb_login.Text;
            mdp = tb_mdp.Text;
            login1 = connecte.GetLogin();
            mdp1 = connecte.GetMdp();
            

            if ((login == login1)&& BC.Verify(mdp,mdp1))
            {
               
                SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
                SF.openChildForm(new TableauBord());
   
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrecte ", "Connexion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
