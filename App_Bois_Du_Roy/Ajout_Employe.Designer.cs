
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
            this.tbAddEmp_LastMat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAddEmp_Mat = new System.Windows.Forms.TextBox();
            this.tbAddEmp_NumTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAddEmp_MatRespo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtP_Embauche = new System.Windows.Forms.DateTimePicker();
            this.dtP_Birth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddEmp_NumSec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddEmp = new System.Windows.Forms.Button();
            this.tbAddEmp_MDP = new System.Windows.Forms.TextBox();
            this.cbAddEmp_Fonction = new System.Windows.Forms.ComboBox();
            this.cbAddEmp_Service = new System.Windows.Forms.ComboBox();
            this.tbAddEmp_Prenom = new System.Windows.Forms.TextBox();
            this.tbAddEmp_Nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbAddEmp_LastMat);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbAddEmp_Mat);
            this.panel2.Controls.Add(this.tbAddEmp_NumTel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbAddEmp_MatRespo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtP_Embauche);
            this.panel2.Controls.Add(this.dtP_Birth);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbAddEmp_NumSec);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_AddEmp);
            this.panel2.Controls.Add(this.tbAddEmp_MDP);
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
            // tbAddEmp_LastMat
            // 
            this.tbAddEmp_LastMat.Location = new System.Drawing.Point(414, 570);
            this.tbAddEmp_LastMat.Name = "tbAddEmp_LastMat";
            this.tbAddEmp_LastMat.ReadOnly = true;
            this.tbAddEmp_LastMat.Size = new System.Drawing.Size(100, 22);
            this.tbAddEmp_LastMat.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 576);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Le dernier matricule utilisé est celui-ci : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Matricule :";
            // 
            // tbAddEmp_Mat
            // 
            this.tbAddEmp_Mat.Location = new System.Drawing.Point(233, 501);
            this.tbAddEmp_Mat.MaxLength = 5;
            this.tbAddEmp_Mat.Multiline = true;
            this.tbAddEmp_Mat.Name = "tbAddEmp_Mat";
            this.tbAddEmp_Mat.Size = new System.Drawing.Size(281, 45);
            this.tbAddEmp_Mat.TabIndex = 22;
            // 
            // tbAddEmp_NumTel
            // 
            this.tbAddEmp_NumTel.Location = new System.Drawing.Point(233, 314);
            this.tbAddEmp_NumTel.MaxLength = 5;
            this.tbAddEmp_NumTel.Multiline = true;
            this.tbAddEmp_NumTel.Name = "tbAddEmp_NumTel";
            this.tbAddEmp_NumTel.Size = new System.Drawing.Size(281, 76);
            this.tbAddEmp_NumTel.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Num Telephone :";
            // 
            // cbAddEmp_MatRespo
            // 
            this.cbAddEmp_MatRespo.FormattingEnabled = true;
            this.cbAddEmp_MatRespo.Location = new System.Drawing.Point(907, 584);
            this.cbAddEmp_MatRespo.Name = "cbAddEmp_MatRespo";
            this.cbAddEmp_MatRespo.Size = new System.Drawing.Size(202, 24);
            this.cbAddEmp_MatRespo.TabIndex = 19;
            this.cbAddEmp_MatRespo.Text = "Responsable";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1109, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Date Embauche :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date Naissance :";
            // 
            // dtP_Embauche
            // 
            this.dtP_Embauche.Location = new System.Drawing.Point(1250, 344);
            this.dtP_Embauche.Name = "dtP_Embauche";
            this.dtP_Embauche.Size = new System.Drawing.Size(227, 22);
            this.dtP_Embauche.TabIndex = 16;
            // 
            // dtP_Birth
            // 
            this.dtP_Birth.Location = new System.Drawing.Point(711, 344);
            this.dtP_Birth.Name = "dtP_Birth";
            this.dtP_Birth.Size = new System.Drawing.Size(227, 22);
            this.dtP_Birth.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1141, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Num Sécu : ";
            // 
            // tbAddEmp_NumSec
            // 
            this.tbAddEmp_NumSec.Location = new System.Drawing.Point(1250, 158);
            this.tbAddEmp_NumSec.MaxLength = 15;
            this.tbAddEmp_NumSec.Multiline = true;
            this.tbAddEmp_NumSec.Name = "tbAddEmp_NumSec";
            this.tbAddEmp_NumSec.Size = new System.Drawing.Size(304, 76);
            this.tbAddEmp_NumSec.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 721);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom :";
            // 
            // btn_AddEmp
            // 
            this.btn_AddEmp.Location = new System.Drawing.Point(259, 833);
            this.btn_AddEmp.Name = "btn_AddEmp";
            this.btn_AddEmp.Size = new System.Drawing.Size(224, 79);
            this.btn_AddEmp.TabIndex = 9;
            this.btn_AddEmp.Text = "Ajouter";
            this.btn_AddEmp.UseVisualStyleBackColor = true;
            this.btn_AddEmp.Click += new System.EventHandler(this.btn_AddEmp_Click);
            // 
            // tbAddEmp_MDP
            // 
            this.tbAddEmp_MDP.Location = new System.Drawing.Point(233, 699);
            this.tbAddEmp_MDP.Multiline = true;
            this.tbAddEmp_MDP.Name = "tbAddEmp_MDP";
            this.tbAddEmp_MDP.PasswordChar = '*';
            this.tbAddEmp_MDP.Size = new System.Drawing.Size(242, 53);
            this.tbAddEmp_MDP.TabIndex = 7;
            // 
            // cbAddEmp_Fonction
            // 
            this.cbAddEmp_Fonction.FormattingEnabled = true;
            this.cbAddEmp_Fonction.Location = new System.Drawing.Point(907, 460);
            this.cbAddEmp_Fonction.Name = "cbAddEmp_Fonction";
            this.cbAddEmp_Fonction.Size = new System.Drawing.Size(202, 24);
            this.cbAddEmp_Fonction.TabIndex = 5;
            this.cbAddEmp_Fonction.Text = "Fonction";
            // 
            // cbAddEmp_Service
            // 
            this.cbAddEmp_Service.FormattingEnabled = true;
            this.cbAddEmp_Service.Location = new System.Drawing.Point(907, 522);
            this.cbAddEmp_Service.Name = "cbAddEmp_Service";
            this.cbAddEmp_Service.Size = new System.Drawing.Size(202, 24);
            this.cbAddEmp_Service.TabIndex = 4;
            this.cbAddEmp_Service.Text = "Service";
            // 
            // tbAddEmp_Prenom
            // 
            this.tbAddEmp_Prenom.Location = new System.Drawing.Point(711, 158);
            this.tbAddEmp_Prenom.Multiline = true;
            this.tbAddEmp_Prenom.Name = "tbAddEmp_Prenom";
            this.tbAddEmp_Prenom.Size = new System.Drawing.Size(304, 76);
            this.tbAddEmp_Prenom.TabIndex = 3;
            // 
            // tbAddEmp_Nom
            // 
            this.tbAddEmp_Nom.Location = new System.Drawing.Point(233, 158);
            this.tbAddEmp_Nom.Multiline = true;
            this.tbAddEmp_Nom.Name = "tbAddEmp_Nom";
            this.tbAddEmp_Nom.Size = new System.Drawing.Size(281, 76);
            this.tbAddEmp_Nom.TabIndex = 2;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(759, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Fonction :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(759, 525);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Service :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(759, 587);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Responsable :";
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
        private System.Windows.Forms.ComboBox cbAddEmp_Fonction;
        private System.Windows.Forms.ComboBox cbAddEmp_Service;
        private System.Windows.Forms.TextBox tbAddEmp_Prenom;
        private System.Windows.Forms.TextBox tbAddEmp_Nom;
        private System.Windows.Forms.Button btn_AddEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtP_Embauche;
        private System.Windows.Forms.DateTimePicker dtP_Birth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddEmp_NumSec;
        private System.Windows.Forms.ComboBox cbAddEmp_MatRespo;
        private System.Windows.Forms.TextBox tbAddEmp_NumTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAddEmp_Mat;
        private System.Windows.Forms.TextBox tbAddEmp_LastMat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}