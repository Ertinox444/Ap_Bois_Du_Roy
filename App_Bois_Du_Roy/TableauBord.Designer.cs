
namespace App_Bois_Du_Roy
{
    partial class TableauBord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Notif = new System.Windows.Forms.Label();
            this.pb_LogOut = new System.Windows.Forms.PictureBox();
            this.pb_Notif = new System.Windows.Forms.PictureBox();
            this.lbl_ListeFonction = new System.Windows.Forms.Label();
            this.lbl_Service = new System.Windows.Forms.Label();
            this.lbl_Conge = new System.Windows.Forms.Label();
            this.lbl_lsEmploye = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_Weather = new System.Windows.Forms.PictureBox();
            this.textBox_TempsActuel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Humidite = new System.Windows.Forms.TextBox();
            this.textBox_TempFeeling = new System.Windows.Forms.TextBox();
            this.comboBoxVilles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Birthday = new System.Windows.Forms.TextBox();
            this.tb_Today_Date = new System.Windows.Forms.TextBox();
            this.DGV_Last_Request = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NoData = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Notif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Weather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Last_Request)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.lbl_lsEmploye);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 1083);
            this.panel1.TabIndex = 0;
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
            this.pb_LogOut.TabIndex = 44;
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
            // lbl_lsEmploye
            // 
            this.lbl_lsEmploye.AutoSize = true;
            this.lbl_lsEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_lsEmploye.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_lsEmploye.ForeColor = System.Drawing.Color.White;
            this.lbl_lsEmploye.Location = new System.Drawing.Point(37, 328);
            this.lbl_lsEmploye.Name = "lbl_lsEmploye";
            this.lbl_lsEmploye.Size = new System.Drawing.Size(289, 46);
            this.lbl_lsEmploye.TabIndex = 4;
            this.lbl_lsEmploye.Text = "Liste Employé";
            this.lbl_lsEmploye.Click += new System.EventHandler(this.lbl_lsEmploye_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.tb_NoData);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tb_Birthday);
            this.panel2.Controls.Add(this.tb_Today_Date);
            this.panel2.Controls.Add(this.DGV_Last_Request);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(391, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1635, 1029);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pb_Weather);
            this.panel3.Controls.Add(this.textBox_TempsActuel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_Humidite);
            this.panel3.Controls.Add(this.textBox_TempFeeling);
            this.panel3.Controls.Add(this.comboBoxVilles);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1091, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 670);
            this.panel3.TabIndex = 5;
            // 
            // pb_Weather
            // 
            this.pb_Weather.Location = new System.Drawing.Point(147, 84);
            this.pb_Weather.Name = "pb_Weather";
            this.pb_Weather.Size = new System.Drawing.Size(150, 125);
            this.pb_Weather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Weather.TabIndex = 18;
            this.pb_Weather.TabStop = false;
            // 
            // textBox_TempsActuel
            // 
            this.textBox_TempsActuel.BackColor = System.Drawing.Color.White;
            this.textBox_TempsActuel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TempsActuel.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_TempsActuel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TempsActuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.textBox_TempsActuel.Location = new System.Drawing.Point(33, 234);
            this.textBox_TempsActuel.Multiline = true;
            this.textBox_TempsActuel.Name = "textBox_TempsActuel";
            this.textBox_TempsActuel.ReadOnly = true;
            this.textBox_TempsActuel.Size = new System.Drawing.Size(366, 113);
            this.textBox_TempsActuel.TabIndex = 17;
            this.textBox_TempsActuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label6.Location = new System.Drawing.Point(51, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ressenti :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(51, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Humidité :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ville :";
            // 
            // textBox_Humidite
            // 
            this.textBox_Humidite.Location = new System.Drawing.Point(264, 528);
            this.textBox_Humidite.Name = "textBox_Humidite";
            this.textBox_Humidite.Size = new System.Drawing.Size(100, 22);
            this.textBox_Humidite.TabIndex = 10;
            // 
            // textBox_TempFeeling
            // 
            this.textBox_TempFeeling.Location = new System.Drawing.Point(264, 401);
            this.textBox_TempFeeling.Name = "textBox_TempFeeling";
            this.textBox_TempFeeling.Size = new System.Drawing.Size(100, 22);
            this.textBox_TempFeeling.TabIndex = 8;
            // 
            // comboBoxVilles
            // 
            this.comboBoxVilles.FormattingEnabled = true;
            this.comboBoxVilles.Location = new System.Drawing.Point(7, 51);
            this.comboBoxVilles.Name = "comboBoxVilles";
            this.comboBoxVilles.Size = new System.Drawing.Size(105, 24);
            this.comboBoxVilles.TabIndex = 7;
            this.comboBoxVilles.SelectedIndexChanged += new System.EventHandler(this.comboBoxVilles_SelectedIndexChanged);
            this.comboBoxVilles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxVilles_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(135, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 70);
            this.label2.TabIndex = 6;
            this.label2.Text = "Meteo";
            // 
            // tb_Birthday
            // 
            this.tb_Birthday.BackColor = System.Drawing.Color.White;
            this.tb_Birthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Birthday.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Birthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(128)))), ((int)(((byte)(69)))));
            this.tb_Birthday.Location = new System.Drawing.Point(219, 798);
            this.tb_Birthday.Multiline = true;
            this.tb_Birthday.Name = "tb_Birthday";
            this.tb_Birthday.ReadOnly = true;
            this.tb_Birthday.Size = new System.Drawing.Size(717, 88);
            this.tb_Birthday.TabIndex = 4;
            this.tb_Birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Today_Date
            // 
            this.tb_Today_Date.BackColor = System.Drawing.Color.White;
            this.tb_Today_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Today_Date.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Today_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(128)))), ((int)(((byte)(69)))));
            this.tb_Today_Date.Location = new System.Drawing.Point(219, 704);
            this.tb_Today_Date.Multiline = true;
            this.tb_Today_Date.Name = "tb_Today_Date";
            this.tb_Today_Date.ReadOnly = true;
            this.tb_Today_Date.Size = new System.Drawing.Size(717, 88);
            this.tb_Today_Date.TabIndex = 3;
            this.tb_Today_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGV_Last_Request
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.DGV_Last_Request.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Last_Request.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Last_Request.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Last_Request.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(209)))));
            this.DGV_Last_Request.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Last_Request.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Last_Request.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Last_Request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 20F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Last_Request.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Last_Request.EnableHeadersVisualStyles = false;
            this.DGV_Last_Request.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.DGV_Last_Request.Location = new System.Drawing.Point(131, 142);
            this.DGV_Last_Request.Margin = new System.Windows.Forms.Padding(10);
            this.DGV_Last_Request.Name = "DGV_Last_Request";
            this.DGV_Last_Request.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Last_Request.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Last_Request.RowHeadersVisible = false;
            this.DGV_Last_Request.RowHeadersWidth = 51;
            this.DGV_Last_Request.RowTemplate.Height = 24;
            this.DGV_Last_Request.Size = new System.Drawing.Size(897, 511);
            this.DGV_Last_Request.TabIndex = 2;
            this.DGV_Last_Request.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_Last_Request_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tableau de Bord :";
            // 
            // tb_NoData
            // 
            this.tb_NoData.BackColor = System.Drawing.Color.White;
            this.tb_NoData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NoData.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NoData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(128)))), ((int)(((byte)(69)))));
            this.tb_NoData.Location = new System.Drawing.Point(219, 301);
            this.tb_NoData.Multiline = true;
            this.tb_NoData.Name = "tb_NoData";
            this.tb_NoData.ReadOnly = true;
            this.tb_NoData.Size = new System.Drawing.Size(717, 88);
            this.tb_NoData.TabIndex = 6;
            this.tb_NoData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TableauBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableauBord";
            this.Text = "TableauBord";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Notif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Weather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Last_Request)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Service;
        private System.Windows.Forms.Label lbl_Conge;
        private System.Windows.Forms.Label lbl_lsEmploye;
        private System.Windows.Forms.TextBox tb_Today_Date;
        private System.Windows.Forms.DataGridView DGV_Last_Request;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ListeFonction;
        private System.Windows.Forms.PictureBox pb_LogOut;
        private System.Windows.Forms.Label lbl_Notif;
        private System.Windows.Forms.PictureBox pb_Notif;
        private System.Windows.Forms.TextBox tb_Birthday;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVilles;
        private System.Windows.Forms.TextBox textBox_TempFeeling;
        private System.Windows.Forms.TextBox textBox_Humidite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TempsActuel;
        private System.Windows.Forms.PictureBox pb_Weather;
        private System.Windows.Forms.TextBox tb_NoData;
    }
}