namespace WindowsFormsGestionEmployes
{
    partial class FormAuthentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthentification));
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxMotPasse = new System.Windows.Forms.TextBox();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelMotPasse = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(121, 29);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(125, 20);
            this.textBoxIdentifiant.TabIndex = 0;
            // 
            // textBoxMotPasse
            // 
            this.textBoxMotPasse.Location = new System.Drawing.Point(121, 62);
            this.textBoxMotPasse.Name = "textBoxMotPasse";
            this.textBoxMotPasse.PasswordChar = '*';
            this.textBoxMotPasse.Size = new System.Drawing.Size(125, 20);
            this.textBoxMotPasse.TabIndex = 1;
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelIdentifiant.Location = new System.Drawing.Point(27, 32);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.labelIdentifiant.TabIndex = 2;
            this.labelIdentifiant.Text = "Identifiant";
            // 
            // labelMotPasse
            // 
            this.labelMotPasse.AutoSize = true;
            this.labelMotPasse.Location = new System.Drawing.Point(24, 65);
            this.labelMotPasse.Name = "labelMotPasse";
            this.labelMotPasse.Size = new System.Drawing.Size(71, 13);
            this.labelMotPasse.TabIndex = 3;
            this.labelMotPasse.Text = "Mot de passe";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(63, 104);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Se connecter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(152, 104);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Fermer";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 139);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelMotPasse);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.textBoxMotPasse);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuthentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuthentification_FormClosed);
            this.Load += new System.EventHandler(this.FormAuthentification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxMotPasse;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelMotPasse;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
    }
}

