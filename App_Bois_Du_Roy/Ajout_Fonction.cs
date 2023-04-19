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
    public partial class Ajout_Fonction : Form
    {
        public Ajout_Fonction()
        {
            InitializeComponent();
        }

        private void btn_AddFonc_Click(object sender, EventArgs e)
        {
            if (tbAddFonc_Nom.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nom", "!!! ERREUR !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Connect Envoie = new Connect();

                Envoie.InsertFonction(tbAddFonc_Nom.Text);

                SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["BaseMenu"] as BaseMenu).pnl_Menu);
                SF.openChildForm(new Liste_Fonction());
            }
        }
    }
}