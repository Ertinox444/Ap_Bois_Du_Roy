
namespace App_Bois_Du_Roy
{
    partial class Liste_Employe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Notif = new System.Windows.Forms.Label();
            this.pb_Notif = new System.Windows.Forms.PictureBox();
            this.pb_LogOut = new System.Windows.Forms.PictureBox();
            this.lbl_ListeFonction = new System.Windows.Forms.Label();
            this.lbl_Service = new System.Windows.Forms.Label();
            this.lbl_Conge = new System.Windows.Forms.Label();
            this.lbl_lsEmploye = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_SuppEmploye = new System.Windows.Forms.Label();
            this.lbl_AddEmploye = new System.Windows.Forms.Label();
            this.DGV_Liste_Employe = new System.Windows.Forms.DataGridView();
            this.lbl_TitleEmploye = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Notif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste_Employe)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.lbl_lsEmploye);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 1083);
            this.panel1.TabIndex = 1;
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
            this.lbl_Notif.TabIndex = 37;
            this.lbl_Notif.Text = "Nb";
            // 
            // pb_Notif
            // 
            this.pb_Notif.Image = global::App_Bois_Du_Roy.Properties.Resources.notif_icon;
            this.pb_Notif.Location = new System.Drawing.Point(308, 425);
            this.pb_Notif.Name = "pb_Notif";
            this.pb_Notif.Size = new System.Drawing.Size(38, 40);
            this.pb_Notif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Notif.TabIndex = 36;
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
            this.pb_LogOut.TabIndex = 35;
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
            this.lbl_ListeFonction.TabIndex = 5;
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
            this.panel2.Controls.Add(this.lbl_SuppEmploye);
            this.panel2.Controls.Add(this.lbl_AddEmploye);
            this.panel2.Controls.Add(this.DGV_Liste_Employe);
            this.panel2.Controls.Add(this.lbl_TitleEmploye);
            this.panel2.Location = new System.Drawing.Point(391, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1635, 1029);
            this.panel2.TabIndex = 3;
            // 
            // lbl_SuppEmploye
            // 
            this.lbl_SuppEmploye.AutoSize = true;
            this.lbl_SuppEmploye.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SuppEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_SuppEmploye.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SuppEmploye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.lbl_SuppEmploye.Location = new System.Drawing.Point(1328, 44);
            this.lbl_SuppEmploye.Name = "lbl_SuppEmploye";
            this.lbl_SuppEmploye.Size = new System.Drawing.Size(243, 46);
            this.lbl_SuppEmploye.TabIndex = 4;
            this.lbl_SuppEmploye.Text = "- Supprimer";
            this.lbl_SuppEmploye.Click += new System.EventHandler(this.lbl_SuppEmploye_Click);
            // 
            // lbl_AddEmploye
            // 
            this.lbl_AddEmploye.AutoSize = true;
            this.lbl_AddEmploye.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AddEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AddEmploye.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddEmploye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.lbl_AddEmploye.Location = new System.Drawing.Point(1082, 44);
            this.lbl_AddEmploye.Name = "lbl_AddEmploye";
            this.lbl_AddEmploye.Size = new System.Drawing.Size(189, 46);
            this.lbl_AddEmploye.TabIndex = 3;
            this.lbl_AddEmploye.Text = "+ Ajouter";
            this.lbl_AddEmploye.Click += new System.EventHandler(this.lbl_AddEmploye_Click);
            // 
            // DGV_Liste_Employe
            // 
            this.DGV_Liste_Employe.AllowUserToAddRows = false;
            this.DGV_Liste_Employe.AllowUserToDeleteRows = false;
            this.DGV_Liste_Employe.AllowUserToOrderColumns = true;
            this.DGV_Liste_Employe.AllowUserToResizeColumns = false;
            this.DGV_Liste_Employe.AllowUserToResizeRows = false;
            this.DGV_Liste_Employe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(209)))));
            this.DGV_Liste_Employe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Liste_Employe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Liste_Employe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Liste_Employe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Liste_Employe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGV_Liste_Employe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.DGV_Liste_Employe.Location = new System.Drawing.Point(51, 112);
            this.DGV_Liste_Employe.Name = "DGV_Liste_Employe";
            this.DGV_Liste_Employe.RowHeadersVisible = false;
            this.DGV_Liste_Employe.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.DGV_Liste_Employe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Liste_Employe.RowTemplate.Height = 40;
            this.DGV_Liste_Employe.RowTemplate.ReadOnly = true;
            this.DGV_Liste_Employe.Size = new System.Drawing.Size(1565, 817);
            this.DGV_Liste_Employe.TabIndex = 2;
            this.DGV_Liste_Employe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Liste_Employe_CellClick);
            this.DGV_Liste_Employe.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_Liste_Employe_CellFormatting);
            this.DGV_Liste_Employe.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Liste_Employe_CellMouseEnter);
            this.DGV_Liste_Employe.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Liste_Employe_CellMouseLeave);
            // 
            // lbl_TitleEmploye
            // 
            this.lbl_TitleEmploye.AutoSize = true;
            this.lbl_TitleEmploye.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TitleEmploye.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_TitleEmploye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.lbl_TitleEmploye.Location = new System.Drawing.Point(24, 19);
            this.lbl_TitleEmploye.Name = "lbl_TitleEmploye";
            this.lbl_TitleEmploye.Size = new System.Drawing.Size(564, 78);
            this.lbl_TitleEmploye.TabIndex = 1;
            this.lbl_TitleEmploye.Text = "Liste Employés :";
            // 
            // Liste_Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liste_Employe";
            this.Text = "Liste_Employe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Notif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste_Employe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Service;
        private System.Windows.Forms.Label lbl_Conge;
        private System.Windows.Forms.Label lbl_lsEmploye;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV_Liste_Employe;
        private System.Windows.Forms.Label lbl_TitleEmploye;
        private System.Windows.Forms.Label lbl_SuppEmploye;
        private System.Windows.Forms.Label lbl_AddEmploye;
        private System.Windows.Forms.Label lbl_ListeFonction;
        private System.Windows.Forms.PictureBox pb_LogOut;
        private System.Windows.Forms.PictureBox pb_Notif;
        private System.Windows.Forms.Label lbl_Notif;
    }
}