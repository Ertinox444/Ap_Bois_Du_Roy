
namespace App_Bois_Du_Roy
{
    partial class Liste_Conge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cB_Filtre = new System.Windows.Forms.ComboBox();
            this.lbl_Filtre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_FiltreType = new System.Windows.Forms.ComboBox();
            this.lbl_Export = new System.Windows.Forms.Label();
            this.lbl_StatConge = new System.Windows.Forms.Label();
            this.DGV_Liste_Conge = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Notif = new System.Windows.Forms.Label();
            this.pb_Notif = new System.Windows.Forms.PictureBox();
            this.pb_LogOut = new System.Windows.Forms.PictureBox();
            this.lbl_ListeFonction = new System.Windows.Forms.Label();
            this.lbl_Service = new System.Windows.Forms.Label();
            this.lbl_Conge = new System.Windows.Forms.Label();
            this.lbl_Employe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste_Conge)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Notif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.cB_Filtre);
            this.panel2.Controls.Add(this.lbl_Filtre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cB_FiltreType);
            this.panel2.Controls.Add(this.lbl_Export);
            this.panel2.Controls.Add(this.lbl_StatConge);
            this.panel2.Controls.Add(this.DGV_Liste_Conge);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(397, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1635, 1029);
            this.panel2.TabIndex = 3;
            // 
            // cB_Filtre
            // 
            this.cB_Filtre.FormattingEnabled = true;
            this.cB_Filtre.Location = new System.Drawing.Point(958, 775);
            this.cB_Filtre.Name = "cB_Filtre";
            this.cB_Filtre.Size = new System.Drawing.Size(197, 24);
            this.cB_Filtre.TabIndex = 12;
            this.cB_Filtre.SelectedIndexChanged += new System.EventHandler(this.cB_Filtre_SelectedIndexChanged);
            // 
            // lbl_Filtre
            // 
            this.lbl_Filtre.AutoSize = true;
            this.lbl_Filtre.Location = new System.Drawing.Point(852, 778);
            this.lbl_Filtre.Name = "lbl_Filtre";
            this.lbl_Filtre.Size = new System.Drawing.Size(39, 17);
            this.lbl_Filtre.TabIndex = 11;
            this.lbl_Filtre.Text = "Filtre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 778);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filtrer par :";
            // 
            // cB_FiltreType
            // 
            this.cB_FiltreType.FormattingEnabled = true;
            this.cB_FiltreType.Location = new System.Drawing.Point(543, 778);
            this.cB_FiltreType.Name = "cB_FiltreType";
            this.cB_FiltreType.Size = new System.Drawing.Size(197, 24);
            this.cB_FiltreType.TabIndex = 9;
            this.cB_FiltreType.SelectedIndexChanged += new System.EventHandler(this.cB_FiltreType_SelectedIndexChanged);
            // 
            // lbl_Export
            // 
            this.lbl_Export.AutoSize = true;
            this.lbl_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Export.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Export.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.lbl_Export.Location = new System.Drawing.Point(967, 50);
            this.lbl_Export.Name = "lbl_Export";
            this.lbl_Export.Size = new System.Drawing.Size(170, 38);
            this.lbl_Export.TabIndex = 8;
            this.lbl_Export.Text = "/ Exporter";
            this.lbl_Export.Click += new System.EventHandler(this.lbl_Export_Click);
            // 
            // lbl_StatConge
            // 
            this.lbl_StatConge.AutoSize = true;
            this.lbl_StatConge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_StatConge.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatConge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.lbl_StatConge.Location = new System.Drawing.Point(1216, 50);
            this.lbl_StatConge.Name = "lbl_StatConge";
            this.lbl_StatConge.Size = new System.Drawing.Size(220, 38);
            this.lbl_StatConge.TabIndex = 6;
            this.lbl_StatConge.Text = "/ Statistiques";
            this.lbl_StatConge.Click += new System.EventHandler(this.lbl_StatConge_Click);
            // 
            // DGV_Liste_Conge
            // 
            this.DGV_Liste_Conge.AllowUserToAddRows = false;
            this.DGV_Liste_Conge.AllowUserToDeleteRows = false;
            this.DGV_Liste_Conge.AllowUserToOrderColumns = true;
            this.DGV_Liste_Conge.AllowUserToResizeColumns = false;
            this.DGV_Liste_Conge.AllowUserToResizeRows = false;
            this.DGV_Liste_Conge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(209)))));
            this.DGV_Liste_Conge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Liste_Conge.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Liste_Conge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_Liste_Conge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Liste_Conge.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.DGV_Liste_Conge.Location = new System.Drawing.Point(21, 112);
            this.DGV_Liste_Conge.Name = "DGV_Liste_Conge";
            this.DGV_Liste_Conge.RowHeadersVisible = false;
            this.DGV_Liste_Conge.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.DGV_Liste_Conge.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_Liste_Conge.RowTemplate.Height = 40;
            this.DGV_Liste_Conge.RowTemplate.ReadOnly = true;
            this.DGV_Liste_Conge.Size = new System.Drawing.Size(1595, 622);
            this.DGV_Liste_Conge.TabIndex = 5;
            this.DGV_Liste_Conge.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Liste_Conge_CellClick);
            this.DGV_Liste_Conge.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Liste_Conge_CellMouseEnter);
            this.DGV_Liste_Conge.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Liste_Conge_CellMouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste Congé : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.lbl_Notif);
            this.panel1.Controls.Add(this.pb_Notif);
            this.panel1.Controls.Add(this.pb_LogOut);
            this.panel1.Controls.Add(this.lbl_ListeFonction);
            this.panel1.Controls.Add(this.lbl_Service);
            this.panel1.Controls.Add(this.lbl_Conge);
            this.panel1.Controls.Add(this.lbl_Employe);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 1083);
            this.panel1.TabIndex = 4;
            // 
            // lbl_Notif
            // 
            this.lbl_Notif.AutoSize = true;
            this.lbl_Notif.BackColor = System.Drawing.Color.Red;
            this.lbl_Notif.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notif.ForeColor = System.Drawing.Color.White;
            this.lbl_Notif.Location = new System.Drawing.Point(317, 436);
            this.lbl_Notif.Name = "lbl_Notif";
            this.lbl_Notif.Size = new System.Drawing.Size(31, 19);
            this.lbl_Notif.TabIndex = 39;
            this.lbl_Notif.Text = "Nb";
            // 
            // pb_Notif
            // 
            this.pb_Notif.Image = global::App_Bois_Du_Roy.Properties.Resources.notif_icon;
            this.pb_Notif.Location = new System.Drawing.Point(308, 425);
            this.pb_Notif.Name = "pb_Notif";
            this.pb_Notif.Size = new System.Drawing.Size(38, 40);
            this.pb_Notif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Notif.TabIndex = 38;
            this.pb_Notif.TabStop = false;
            // 
            // pb_LogOut
            // 
            this.pb_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_LogOut.Image = global::App_Bois_Du_Roy.Properties.Resources.log_out;
            this.pb_LogOut.Location = new System.Drawing.Point(12, 12);
            this.pb_LogOut.Name = "pb_LogOut";
            this.pb_LogOut.Size = new System.Drawing.Size(50, 57);
            this.pb_LogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_LogOut.TabIndex = 34;
            this.pb_LogOut.TabStop = false;
            this.pb_LogOut.Click += new System.EventHandler(this.pb_LogOut_Click);
            // 
            // lbl_ListeFonction
            // 
            this.lbl_ListeFonction.AutoSize = true;
            this.lbl_ListeFonction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ListeFonction.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_ListeFonction.ForeColor = System.Drawing.Color.White;
            this.lbl_ListeFonction.Location = new System.Drawing.Point(37, 601);
            this.lbl_ListeFonction.Name = "lbl_ListeFonction";
            this.lbl_ListeFonction.Size = new System.Drawing.Size(287, 46);
            this.lbl_ListeFonction.TabIndex = 8;
            this.lbl_ListeFonction.Text = "Liste Fonction";
            // 
            // lbl_Service
            // 
            this.lbl_Service.AutoSize = true;
            this.lbl_Service.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Service.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Service.ForeColor = System.Drawing.Color.White;
            this.lbl_Service.Location = new System.Drawing.Point(37, 510);
            this.lbl_Service.Name = "lbl_Service";
            this.lbl_Service.Size = new System.Drawing.Size(264, 46);
            this.lbl_Service.TabIndex = 6;
            this.lbl_Service.Text = "Liste Service";
            this.lbl_Service.Click += new System.EventHandler(this.lbl_Service_Click);
            // 
            // lbl_Conge
            // 
            this.lbl_Conge.AutoSize = true;
            this.lbl_Conge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Conge.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Conge.ForeColor = System.Drawing.Color.White;
            this.lbl_Conge.Location = new System.Drawing.Point(37, 419);
            this.lbl_Conge.Name = "lbl_Conge";
            this.lbl_Conge.Size = new System.Drawing.Size(245, 46);
            this.lbl_Conge.TabIndex = 5;
            this.lbl_Conge.Text = "Liste Congé";
            this.lbl_Conge.Click += new System.EventHandler(this.lbl_Conge_Click);
            // 
            // lbl_Employe
            // 
            this.lbl_Employe.AutoSize = true;
            this.lbl_Employe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Employe.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Employe.ForeColor = System.Drawing.Color.White;
            this.lbl_Employe.Location = new System.Drawing.Point(37, 328);
            this.lbl_Employe.Name = "lbl_Employe";
            this.lbl_Employe.Size = new System.Drawing.Size(289, 46);
            this.lbl_Employe.TabIndex = 4;
            this.lbl_Employe.Text = "Liste Employé";
            this.lbl_Employe.Click += new System.EventHandler(this.lbl_Employe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::App_Bois_Du_Roy.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(75, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Liste_Conge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liste_Conge";
            this.Text = "Liste_Conge";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste_Conge)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Notif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Service;
        private System.Windows.Forms.Label lbl_Conge;
        private System.Windows.Forms.Label lbl_Employe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGV_Liste_Conge;
        private System.Windows.Forms.Label lbl_ListeFonction;
        private System.Windows.Forms.Label lbl_StatConge;
        private System.Windows.Forms.PictureBox pb_LogOut;
        private System.Windows.Forms.Label lbl_Notif;
        private System.Windows.Forms.PictureBox pb_Notif;
        private System.Windows.Forms.Label lbl_Export;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_FiltreType;
        private System.Windows.Forms.Label lbl_Filtre;
        public System.Windows.Forms.ComboBox cB_Filtre;
    }
}