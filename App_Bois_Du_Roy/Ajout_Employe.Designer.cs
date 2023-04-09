
namespace App_Bois_Du_Roy
{
    partial class Ajout_Employe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Service = new System.Windows.Forms.Label();
            this.lbl_Conge = new System.Windows.Forms.Label();
            this.lbl_Employe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbAddEmp_MDP = new System.Windows.Forms.TextBox();
            this.tbAddEmpl_Matricule = new System.Windows.Forms.TextBox();
            this.cbAddEmp_Fonction = new System.Windows.Forms.ComboBox();
            this.cbAddEmp_Service = new System.Windows.Forms.ComboBox();
            this.tbAddEmp_Prenom = new System.Windows.Forms.TextBox();
            this.tbAddEmp_Nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testBox = new System.Windows.Forms.TextBox();
            this.btn_AddEmp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.lbl_Service);
            this.panel1.Controls.Add(this.lbl_Conge);
            this.panel1.Controls.Add(this.lbl_Employe);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 1083);
            this.panel1.TabIndex = 5;
            // 
            // lbl_Service
            // 
            this.lbl_Service.AutoSize = true;
            this.lbl_Service.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Service.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Service.ForeColor = System.Drawing.Color.White;
            this.lbl_Service.Location = new System.Drawing.Point(37, 714);
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
            this.lbl_Conge.Location = new System.Drawing.Point(56, 579);
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
            this.lbl_Employe.Location = new System.Drawing.Point(37, 439);
            this.lbl_Employe.Name = "lbl_Employe";
            this.lbl_Employe.Size = new System.Drawing.Size(289, 46);
            this.lbl_Employe.TabIndex = 4;
            this.lbl_Employe.Text = "Liste Employé";
            this.lbl_Employe.Click += new System.EventHandler(this.lbl_Employe_Click);
            // 
            // pictureBox1
            // 
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.btn_AddEmp);
            this.panel2.Controls.Add(this.testBox);
            this.panel2.Controls.Add(this.tbAddEmp_MDP);
            this.panel2.Controls.Add(this.tbAddEmpl_Matricule);
            this.panel2.Controls.Add(this.cbAddEmp_Fonction);
            this.panel2.Controls.Add(this.cbAddEmp_Service);
            this.panel2.Controls.Add(this.tbAddEmp_Prenom);
            this.panel2.Controls.Add(this.tbAddEmp_Nom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(397, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1635, 1029);
            this.panel2.TabIndex = 7;
            // 
            // tbAddEmp_MDP
            // 
            this.tbAddEmp_MDP.Location = new System.Drawing.Point(304, 433);
            this.tbAddEmp_MDP.Multiline = true;
            this.tbAddEmp_MDP.Name = "tbAddEmp_MDP";
            this.tbAddEmp_MDP.PasswordChar = '*';
            this.tbAddEmp_MDP.Size = new System.Drawing.Size(242, 53);
            this.tbAddEmp_MDP.TabIndex = 7;
            this.tbAddEmp_MDP.Text = "MDP";
            // 
            // tbAddEmpl_Matricule
            // 
            this.tbAddEmpl_Matricule.Location = new System.Drawing.Point(1004, 206);
            this.tbAddEmpl_Matricule.Multiline = true;
            this.tbAddEmpl_Matricule.Name = "tbAddEmpl_Matricule";
            this.tbAddEmpl_Matricule.Size = new System.Drawing.Size(242, 53);
            this.tbAddEmpl_Matricule.TabIndex = 6;
            this.tbAddEmpl_Matricule.Text = "Matricule";
            // 
            // cbAddEmp_Fonction
            // 
            this.cbAddEmp_Fonction.FormattingEnabled = true;
            this.cbAddEmp_Fonction.Location = new System.Drawing.Point(727, 329);
            this.cbAddEmp_Fonction.Name = "cbAddEmp_Fonction";
            this.cbAddEmp_Fonction.Size = new System.Drawing.Size(202, 24);
            this.cbAddEmp_Fonction.TabIndex = 5;
            this.cbAddEmp_Fonction.Text = "Fonction";
            // 
            // cbAddEmp_Service
            // 
            this.cbAddEmp_Service.FormattingEnabled = true;
            this.cbAddEmp_Service.Location = new System.Drawing.Point(344, 329);
            this.cbAddEmp_Service.Name = "cbAddEmp_Service";
            this.cbAddEmp_Service.Size = new System.Drawing.Size(202, 24);
            this.cbAddEmp_Service.TabIndex = 4;
            this.cbAddEmp_Service.Text = "Service";
            // 
            // tbAddEmp_Prenom
            // 
            this.tbAddEmp_Prenom.Location = new System.Drawing.Point(687, 206);
            this.tbAddEmp_Prenom.Multiline = true;
            this.tbAddEmp_Prenom.Name = "tbAddEmp_Prenom";
            this.tbAddEmp_Prenom.Size = new System.Drawing.Size(242, 53);
            this.tbAddEmp_Prenom.TabIndex = 3;
            this.tbAddEmp_Prenom.Text = "Prénom";
            // 
            // tbAddEmp_Nom
            // 
            this.tbAddEmp_Nom.Location = new System.Drawing.Point(304, 206);
            this.tbAddEmp_Nom.Multiline = true;
            this.tbAddEmp_Nom.Name = "tbAddEmp_Nom";
            this.tbAddEmp_Nom.Size = new System.Drawing.Size(242, 53);
            this.tbAddEmp_Nom.TabIndex = 2;
            this.tbAddEmp_Nom.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter Employé : ";
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(344, 588);
            this.testBox.Multiline = true;
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(323, 97);
            this.testBox.TabIndex = 8;
            // 
            // btn_AddEmp
            // 
            this.btn_AddEmp.Location = new System.Drawing.Point(819, 463);
            this.btn_AddEmp.Name = "btn_AddEmp";
            this.btn_AddEmp.Size = new System.Drawing.Size(75, 23);
            this.btn_AddEmp.TabIndex = 9;
            this.btn_AddEmp.Text = "Ajouter";
            this.btn_AddEmp.UseVisualStyleBackColor = true;
            this.btn_AddEmp.Click += new System.EventHandler(this.btn_AddEmp_Click);
            // 
            // Ajout_Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajout_Employe";
            this.Text = "Ajout_Employe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Service;
        private System.Windows.Forms.Label lbl_Conge;
        private System.Windows.Forms.Label lbl_Employe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddEmp_MDP;
        private System.Windows.Forms.TextBox tbAddEmpl_Matricule;
        private System.Windows.Forms.ComboBox cbAddEmp_Fonction;
        private System.Windows.Forms.ComboBox cbAddEmp_Service;
        private System.Windows.Forms.TextBox tbAddEmp_Prenom;
        private System.Windows.Forms.TextBox tbAddEmp_Nom;
        private System.Windows.Forms.TextBox testBox;
        private System.Windows.Forms.Button btn_AddEmp;
    }
}