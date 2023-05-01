
namespace App_Bois_Du_Roy
{
    partial class Details_Conge
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_ValidDecision = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mc_DemandeConge = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_MotifDemande = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Decision = new System.Windows.Forms.Panel();
            this.rb_Refuse = new System.Windows.Forms.RadioButton();
            this.rb_Accept = new System.Windows.Forms.RadioButton();
            this.rtb_Justification = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_Historique_Conge = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_CRestant = new System.Windows.Forms.Label();
            this.lbl_CongeDemande = new System.Windows.Forms.Label();
            this.lbl_MatDemandeur = new System.Windows.Forms.Label();
            this.lbl_NomService = new System.Windows.Forms.Label();
            this.lbl_NomPrenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Title_Conge = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Notif = new System.Windows.Forms.Label();
            this.pb_LogOut = new System.Windows.Forms.PictureBox();
            this.pb_Notif = new System.Windows.Forms.PictureBox();
            this.lbl_ListeFonction = new System.Windows.Forms.Label();
            this.lbl_Service = new System.Windows.Forms.Label();
            this.lbl_Conge = new System.Windows.Forms.Label();
            this.lbl_Employe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnl_Decision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historique_Conge)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Notif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.btn_Return);
            this.panel2.Controls.Add(this.btn_ValidDecision);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.pnl_Decision);
            this.panel2.Controls.Add(this.DGV_Historique_Conge);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbl_Title_Conge);
            this.panel2.Location = new System.Drawing.Point(397, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1635, 1029);
            this.panel2.TabIndex = 4;
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(126)))), ((int)(((byte)(67)))));
            this.btn_Return.Location = new System.Drawing.Point(1230, 10);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(252, 42);
            this.btn_Return.TabIndex = 9;
            this.btn_Return.Text = "Retour à la liste";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_ValidDecision
            // 
            this.btn_ValidDecision.Location = new System.Drawing.Point(1369, 863);
            this.btn_ValidDecision.Name = "btn_ValidDecision";
            this.btn_ValidDecision.Size = new System.Drawing.Size(170, 67);
            this.btn_ValidDecision.TabIndex = 8;
            this.btn_ValidDecision.Text = "Valider";
            this.btn_ValidDecision.UseVisualStyleBackColor = true;
            this.btn_ValidDecision.Click += new System.EventHandler(this.btn_ValidDecision_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.mc_DemandeConge);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.rtb_MotifDemande);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(895, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(612, 388);
            this.panel5.TabIndex = 7;
            // 
            // mc_DemandeConge
            // 
            this.mc_DemandeConge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.mc_DemandeConge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mc_DemandeConge.ForeColor = System.Drawing.Color.White;
            this.mc_DemandeConge.Location = new System.Drawing.Point(155, 172);
            this.mc_DemandeConge.Name = "mc_DemandeConge";
            this.mc_DemandeConge.TabIndex = 16;
            this.mc_DemandeConge.TitleBackColor = System.Drawing.Color.White;
            this.mc_DemandeConge.TitleForeColor = System.Drawing.Color.White;
            this.mc_DemandeConge.TrailingForeColor = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date :";
            // 
            // rtb_MotifDemande
            // 
            this.rtb_MotifDemande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_MotifDemande.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_MotifDemande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.rtb_MotifDemande.Location = new System.Drawing.Point(19, 64);
            this.rtb_MotifDemande.Name = "rtb_MotifDemande";
            this.rtb_MotifDemande.Size = new System.Drawing.Size(590, 84);
            this.rtb_MotifDemande.TabIndex = 14;
            this.rtb_MotifDemande.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "Motif :";
            // 
            // pnl_Decision
            // 
            this.pnl_Decision.BackColor = System.Drawing.Color.White;
            this.pnl_Decision.Controls.Add(this.rb_Refuse);
            this.pnl_Decision.Controls.Add(this.rb_Accept);
            this.pnl_Decision.Controls.Add(this.rtb_Justification);
            this.pnl_Decision.Controls.Add(this.label4);
            this.pnl_Decision.Controls.Add(this.label2);
            this.pnl_Decision.Location = new System.Drawing.Point(16, 468);
            this.pnl_Decision.Name = "pnl_Decision";
            this.pnl_Decision.Size = new System.Drawing.Size(1523, 379);
            this.pnl_Decision.TabIndex = 3;
            // 
            // rb_Refuse
            // 
            this.rb_Refuse.AutoSize = true;
            this.rb_Refuse.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Refuse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(126)))), ((int)(((byte)(67)))));
            this.rb_Refuse.Location = new System.Drawing.Point(751, 65);
            this.rb_Refuse.Name = "rb_Refuse";
            this.rb_Refuse.Size = new System.Drawing.Size(147, 42);
            this.rb_Refuse.TabIndex = 14;
            this.rb_Refuse.TabStop = true;
            this.rb_Refuse.Text = "Refusé";
            this.rb_Refuse.UseVisualStyleBackColor = true;
            // 
            // rb_Accept
            // 
            this.rb_Accept.AutoSize = true;
            this.rb_Accept.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Accept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(126)))), ((int)(((byte)(67)))));
            this.rb_Accept.Location = new System.Drawing.Point(402, 65);
            this.rb_Accept.Name = "rb_Accept";
            this.rb_Accept.Size = new System.Drawing.Size(164, 42);
            this.rb_Accept.TabIndex = 13;
            this.rb_Accept.TabStop = true;
            this.rb_Accept.Text = "Accepté";
            this.rb_Accept.UseVisualStyleBackColor = true;
            // 
            // rtb_Justification
            // 
            this.rtb_Justification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_Justification.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Justification.Location = new System.Drawing.Point(21, 214);
            this.rtb_Justification.Name = "rtb_Justification";
            this.rtb_Justification.Size = new System.Drawing.Size(1456, 139);
            this.rtb_Justification.TabIndex = 12;
            this.rtb_Justification.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(3, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "Justification :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Avis :";
            // 
            // DGV_Historique_Conge
            // 
            this.DGV_Historique_Conge.AllowUserToAddRows = false;
            this.DGV_Historique_Conge.AllowUserToDeleteRows = false;
            this.DGV_Historique_Conge.AllowUserToOrderColumns = true;
            this.DGV_Historique_Conge.AllowUserToResizeColumns = false;
            this.DGV_Historique_Conge.AllowUserToResizeRows = false;
            this.DGV_Historique_Conge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(209)))));
            this.DGV_Historique_Conge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Historique_Conge.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Historique_Conge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Historique_Conge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Historique_Conge.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.DGV_Historique_Conge.Location = new System.Drawing.Point(971, 114);
            this.DGV_Historique_Conge.Name = "DGV_Historique_Conge";
            this.DGV_Historique_Conge.RowHeadersVisible = false;
            this.DGV_Historique_Conge.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.DGV_Historique_Conge.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Historique_Conge.RowTemplate.Height = 40;
            this.DGV_Historique_Conge.RowTemplate.ReadOnly = true;
            this.DGV_Historique_Conge.Size = new System.Drawing.Size(661, 363);
            this.DGV_Historique_Conge.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbl_CRestant);
            this.panel3.Controls.Add(this.lbl_CongeDemande);
            this.panel3.Controls.Add(this.lbl_MatDemandeur);
            this.panel3.Controls.Add(this.lbl_NomService);
            this.panel3.Controls.Add(this.lbl_NomPrenom);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(16, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 388);
            this.panel3.TabIndex = 2;
            // 
            // lbl_CRestant
            // 
            this.lbl_CRestant.AutoSize = true;
            this.lbl_CRestant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CRestant.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CRestant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.lbl_CRestant.Location = new System.Drawing.Point(3, 278);
            this.lbl_CRestant.Name = "lbl_CRestant";
            this.lbl_CRestant.Size = new System.Drawing.Size(0, 38);
            this.lbl_CRestant.TabIndex = 12;
            // 
            // lbl_CongeDemande
            // 
            this.lbl_CongeDemande.AutoSize = true;
            this.lbl_CongeDemande.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CongeDemande.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CongeDemande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.lbl_CongeDemande.Location = new System.Drawing.Point(3, 178);
            this.lbl_CongeDemande.Name = "lbl_CongeDemande";
            this.lbl_CongeDemande.Size = new System.Drawing.Size(497, 38);
            this.lbl_CongeDemande.TabIndex = 11;
            this.lbl_CongeDemande.Text = "Type Conge + Temps demande";
            // 
            // lbl_MatDemandeur
            // 
            this.lbl_MatDemandeur.AutoSize = true;
            this.lbl_MatDemandeur.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MatDemandeur.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatDemandeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.lbl_MatDemandeur.Location = new System.Drawing.Point(234, 10);
            this.lbl_MatDemandeur.Name = "lbl_MatDemandeur";
            this.lbl_MatDemandeur.Size = new System.Drawing.Size(162, 38);
            this.lbl_MatDemandeur.TabIndex = 10;
            this.lbl_MatDemandeur.Text = "Matricule";
            // 
            // lbl_NomService
            // 
            this.lbl_NomService.AutoSize = true;
            this.lbl_NomService.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomService.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.lbl_NomService.Location = new System.Drawing.Point(395, 91);
            this.lbl_NomService.Name = "lbl_NomService";
            this.lbl_NomService.Size = new System.Drawing.Size(134, 38);
            this.lbl_NomService.TabIndex = 9;
            this.lbl_NomService.Text = "Service";
            // 
            // lbl_NomPrenom
            // 
            this.lbl_NomPrenom.AutoSize = true;
            this.lbl_NomPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomPrenom.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.lbl_NomPrenom.Location = new System.Drawing.Point(3, 91);
            this.lbl_NomPrenom.Name = "lbl_NomPrenom";
            this.lbl_NomPrenom.Size = new System.Drawing.Size(219, 38);
            this.lbl_NomPrenom.TabIndex = 8;
            this.lbl_NomPrenom.Text = "Nom Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Demandeur :";
            // 
            // lbl_Title_Conge
            // 
            this.lbl_Title_Conge.AutoSize = true;
            this.lbl_Title_Conge.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title_Conge.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_Conge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.lbl_Title_Conge.Location = new System.Drawing.Point(9, 9);
            this.lbl_Title_Conge.Name = "lbl_Title_Conge";
            this.lbl_Title_Conge.Size = new System.Drawing.Size(216, 38);
            this.lbl_Title_Conge.TabIndex = 1;
            this.lbl_Title_Conge.Text = "Detail Conge";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.lbl_Notif);
            this.panel1.Controls.Add(this.pb_LogOut);
            this.panel1.Controls.Add(this.pb_Notif);
            this.panel1.Controls.Add(this.lbl_ListeFonction);
            this.panel1.Controls.Add(this.lbl_Service);
            this.panel1.Controls.Add(this.lbl_Conge);
            this.panel1.Controls.Add(this.lbl_Employe);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 1083);
            this.panel1.TabIndex = 5;
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
            // pb_LogOut
            // 
            this.pb_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_LogOut.Image = global::App_Bois_Du_Roy.Properties.Resources.log_out;
            this.pb_LogOut.Location = new System.Drawing.Point(12, 12);
            this.pb_LogOut.Name = "pb_LogOut";
            this.pb_LogOut.Size = new System.Drawing.Size(50, 57);
            this.pb_LogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_LogOut.TabIndex = 9;
            this.pb_LogOut.TabStop = false;
            this.pb_LogOut.Click += new System.EventHandler(this.pb_LogOut_Click);
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
            this.lbl_ListeFonction.Click += new System.EventHandler(this.lbl_ListeFonction_Click);
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
            // Details_Conge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Details_Conge";
            this.Text = "Details_Conge";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnl_Decision.ResumeLayout(false);
            this.pnl_Decision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historique_Conge)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Notif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Title_Conge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ListeFonction;
        private System.Windows.Forms.Label lbl_Service;
        private System.Windows.Forms.Label lbl_Conge;
        private System.Windows.Forms.Label lbl_Employe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_Decision;
        private System.Windows.Forms.DataGridView DGV_Historique_Conge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_CRestant;
        private System.Windows.Forms.Label lbl_CongeDemande;
        private System.Windows.Forms.Label lbl_MatDemandeur;
        private System.Windows.Forms.Label lbl_NomService;
        private System.Windows.Forms.Label lbl_NomPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_Justification;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox rtb_MotifDemande;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ValidDecision;
        private System.Windows.Forms.RadioButton rb_Refuse;
        private System.Windows.Forms.RadioButton rb_Accept;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.MonthCalendar mc_DemandeConge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_LogOut;
        private System.Windows.Forms.Label lbl_Notif;
        private System.Windows.Forms.PictureBox pb_Notif;
    }
}