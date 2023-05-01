
namespace App_Bois_Du_Roy
{
    partial class Liste_Service
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV_Liste_Service = new System.Windows.Forms.DataGridView();
            this.lbl_AddEmploye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_LogOut = new System.Windows.Forms.PictureBox();
            this.lbl_ListeFonction = new System.Windows.Forms.Label();
            this.lbl_Service = new System.Windows.Forms.Label();
            this.lbl_Conge = new System.Windows.Forms.Label();
            this.lbl_Employe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Notif = new System.Windows.Forms.Label();
            this.pb_Notif = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste_Service)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Notif)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.DGV_Liste_Service);
            this.panel2.Controls.Add(this.lbl_AddEmploye);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(391, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1635, 1029);
            this.panel2.TabIndex = 4;
            // 
            // DGV_Liste_Service
            // 
            this.DGV_Liste_Service.AllowUserToAddRows = false;
            this.DGV_Liste_Service.AllowUserToDeleteRows = false;
            this.DGV_Liste_Service.AllowUserToOrderColumns = true;
            this.DGV_Liste_Service.AllowUserToResizeColumns = false;
            this.DGV_Liste_Service.AllowUserToResizeRows = false;
            this.DGV_Liste_Service.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(209)))));
            this.DGV_Liste_Service.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Liste_Service.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Liste_Service.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Liste_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Liste_Service.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.DGV_Liste_Service.Location = new System.Drawing.Point(51, 112);
            this.DGV_Liste_Service.Name = "DGV_Liste_Service";
            this.DGV_Liste_Service.RowHeadersVisible = false;
            this.DGV_Liste_Service.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.DGV_Liste_Service.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Liste_Service.RowTemplate.Height = 40;
            this.DGV_Liste_Service.RowTemplate.ReadOnly = true;
            this.DGV_Liste_Service.Size = new System.Drawing.Size(1565, 817);
            this.DGV_Liste_Service.TabIndex = 9;
            this.DGV_Liste_Service.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Liste_Service_CellClick);
            this.DGV_Liste_Service.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Liste_Service_CellMouseEnter);
            this.DGV_Liste_Service.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Liste_Service_CellMouseLeave);
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
            this.lbl_AddEmploye.TabIndex = 7;
            this.lbl_AddEmploye.Text = "+ Ajouter";
            this.lbl_AddEmploye.Click += new System.EventHandler(this.lbl_AddEmploye_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(1328, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "- Supprimer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste Service : ";
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
            this.panel1.TabIndex = 5;
            // 
            // pb_LogOut
            // 
            this.pb_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_LogOut.Image = global::App_Bois_Du_Roy.Properties.Resources.log_out;
            this.pb_LogOut.Location = new System.Drawing.Point(12, 12);
            this.pb_LogOut.Name = "pb_LogOut";
            this.pb_LogOut.Size = new System.Drawing.Size(50, 57);
            this.pb_LogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_LogOut.TabIndex = 37;
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
            // Liste_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liste_Service";
            this.Text = "Liste_Service";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste_Service)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Notif)).EndInit();
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
        private System.Windows.Forms.Label lbl_AddEmploye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_Liste_Service;
        private System.Windows.Forms.Label lbl_ListeFonction;
        private System.Windows.Forms.PictureBox pb_LogOut;
        private System.Windows.Forms.Label lbl_Notif;
        private System.Windows.Forms.PictureBox pb_Notif;
    }
}