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
    public partial class BaseMenu : Form
    {

        public BaseMenu()
        {
            InitializeComponent();
            SousFormulaire SF = new SousFormulaire(pnl_Menu);
            SF.openChildForm(new Page_Connection());
        }

    }
}
