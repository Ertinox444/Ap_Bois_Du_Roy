using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Bois_Du_Roy
{
    public partial class ExportFormatDialog : Form
    {
        public ExportFormatDialog()
        {
            InitializeComponent();
            cB_FormatSelect.Items.Add("CSV");
            cB_FormatSelect.Items.Add("XLS");
            cB_FormatSelect.Items.Add("PDF");
        }

        public string SelectedFormat
        {
            get { return cB_FormatSelect.SelectedItem.ToString(); }
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

