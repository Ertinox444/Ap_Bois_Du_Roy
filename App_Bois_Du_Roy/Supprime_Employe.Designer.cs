﻿
namespace App_Bois_Du_Roy
{
    partial class Supprime_Employe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV_Liste_Employe = new System.Windows.Forms.DataGridView();
            this.btnSupprimer_EMP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Service = new System.Windows.Forms.Label();
            this.lbl_Conge = new System.Windows.Forms.Label();
            this.lbl_lsEmploye = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ListeFonction = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste_Employe)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.DGV_Liste_Employe);
            this.panel2.Controls.Add(this.btnSupprimer_EMP);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(391, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1635, 1029);
            this.panel2.TabIndex = 6;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Liste_Employe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Liste_Employe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Liste_Employe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.DGV_Liste_Employe.Location = new System.Drawing.Point(37, 115);
            this.DGV_Liste_Employe.Name = "DGV_Liste_Employe";
            this.DGV_Liste_Employe.RowHeadersVisible = false;
            this.DGV_Liste_Employe.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.DGV_Liste_Employe.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Liste_Employe.RowTemplate.Height = 40;
            this.DGV_Liste_Employe.RowTemplate.ReadOnly = true;
            this.DGV_Liste_Employe.Size = new System.Drawing.Size(1021, 817);
            this.DGV_Liste_Employe.TabIndex = 10;
            // 
            // btnSupprimer_EMP
            // 
            this.btnSupprimer_EMP.Location = new System.Drawing.Point(1253, 379);
            this.btnSupprimer_EMP.Name = "btnSupprimer_EMP";
            this.btnSupprimer_EMP.Size = new System.Drawing.Size(165, 69);
            this.btnSupprimer_EMP.TabIndex = 4;
            this.btnSupprimer_EMP.Text = "Supprimer";
            this.btnSupprimer_EMP.UseVisualStyleBackColor = true;
            this.btnSupprimer_EMP.Click += new System.EventHandler(this.btnSupprimer_EMP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supprimer Employe : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.lbl_ListeFonction);
            this.panel1.Controls.Add(this.lbl_Service);
            this.panel1.Controls.Add(this.lbl_Conge);
            this.panel1.Controls.Add(this.lbl_lsEmploye);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 1083);
            this.panel1.TabIndex = 7;
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
            // Supprime_Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supprime_Employe";
            this.Text = "Supprime_Employe";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste_Employe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV_Liste_Employe;
        private System.Windows.Forms.Button btnSupprimer_EMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Service;
        private System.Windows.Forms.Label lbl_Conge;
        private System.Windows.Forms.Label lbl_lsEmploye;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ListeFonction;
    }
}