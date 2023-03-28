
namespace App_Bois_Du_Roy
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.title_login = new System.Windows.Forms.Label();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(957, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 1080);
            this.panel1.TabIndex = 1;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.White;
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Controls.Add(this.panel1);
            this.panel_logo.Location = new System.Drawing.Point(0, -4);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(960, 1080);
            this.panel_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Bois_Du_Roy.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 1032);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(199)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.tb_mdp);
            this.panel2.Controls.Add(this.tb_login);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.login_lbl);
            this.panel2.Controls.Add(this.title_login);
            this.panel2.Location = new System.Drawing.Point(1124, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 760);
            this.panel2.TabIndex = 1;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(72, 496);
            this.tb_mdp.Multiline = true;
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.Size = new System.Drawing.Size(522, 53);
            this.tb_mdp.TabIndex = 4;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(81, 268);
            this.tb_login.Multiline = true;
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(522, 53);
            this.tb_login.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mot de Passe :";
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.ForeColor = System.Drawing.Color.White;
            this.login_lbl.Location = new System.Drawing.Point(75, 220);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(167, 33);
            this.login_lbl.TabIndex = 1;
            this.login_lbl.Text = "Identifiant :";
            // 
            // title_login
            // 
            this.title_login.AutoSize = true;
            this.title_login.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_login.ForeColor = System.Drawing.Color.White;
            this.title_login.Location = new System.Drawing.Point(71, 58);
            this.title_login.Name = "title_login";
            this.title_login.Size = new System.Drawing.Size(532, 56);
            this.title_login.TabIndex = 0;
            this.title_login.Text = "Connexion au Portail :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(128)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.TextBox tb_login;
    }
}

