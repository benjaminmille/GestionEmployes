namespace WindowsFormsGestionEmployes
{
    partial class FormModificationEmploye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificationEmploye));
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.textBoxNomRue = new System.Windows.Forms.TextBox();
            this.textBoxNumeroRue = new System.Windows.Forms.TextBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.labelNomRue = new System.Windows.Forms.Label();
            this.labelNumeroRue = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.labelMotPasse = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxMotPasse = new System.Windows.Forms.TextBox();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.textBoxMotPasseConfirm = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBoxSociete = new System.Windows.Forms.ComboBox();
            this.labelSociete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(149, 67);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 62;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(149, 39);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 61;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(11, 70);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 60;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(10, 42);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 59;
            this.labelPrenom.Text = "Prénom";
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(149, 285);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(100, 21);
            this.comboBoxVille.TabIndex = 55;
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(149, 259);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(73, 20);
            this.textBoxCodePostal.TabIndex = 54;
            // 
            // textBoxNomRue
            // 
            this.textBoxNomRue.Location = new System.Drawing.Point(149, 232);
            this.textBoxNomRue.Name = "textBoxNomRue";
            this.textBoxNomRue.Size = new System.Drawing.Size(187, 20);
            this.textBoxNomRue.TabIndex = 53;
            // 
            // textBoxNumeroRue
            // 
            this.textBoxNumeroRue.Location = new System.Drawing.Point(149, 204);
            this.textBoxNumeroRue.Name = "textBoxNumeroRue";
            this.textBoxNumeroRue.Size = new System.Drawing.Size(26, 20);
            this.textBoxNumeroRue.TabIndex = 52;
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(10, 288);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(26, 13);
            this.labelVille.TabIndex = 48;
            this.labelVille.Text = "Ville";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(149, 14);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRole.TabIndex = 47;
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(10, 262);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(63, 13);
            this.labelCodePostal.TabIndex = 46;
            this.labelCodePostal.Text = "Code postal";
            // 
            // labelNomRue
            // 
            this.labelNomRue.AutoSize = true;
            this.labelNomRue.Location = new System.Drawing.Point(10, 235);
            this.labelNomRue.Name = "labelNomRue";
            this.labelNomRue.Size = new System.Drawing.Size(62, 13);
            this.labelNomRue.TabIndex = 45;
            this.labelNomRue.Text = "Nom de rue";
            // 
            // labelNumeroRue
            // 
            this.labelNumeroRue.AutoSize = true;
            this.labelNumeroRue.Location = new System.Drawing.Point(10, 207);
            this.labelNumeroRue.Name = "labelNumeroRue";
            this.labelNumeroRue.Size = new System.Drawing.Size(77, 13);
            this.labelNumeroRue.TabIndex = 44;
            this.labelNumeroRue.Text = "Numéro de rue";
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Location = new System.Drawing.Point(10, 179);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(59, 13);
            this.labelDateFin.TabIndex = 42;
            this.labelDateFin.Text = "Date de fin";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Location = new System.Drawing.Point(10, 151);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(75, 13);
            this.labelDateDebut.TabIndex = 41;
            this.labelDateDebut.Text = "Date de début";
            // 
            // labelMotPasse
            // 
            this.labelMotPasse.AutoSize = true;
            this.labelMotPasse.Location = new System.Drawing.Point(10, 124);
            this.labelMotPasse.Name = "labelMotPasse";
            this.labelMotPasse.Size = new System.Drawing.Size(71, 13);
            this.labelMotPasse.TabIndex = 40;
            this.labelMotPasse.Text = "Mot de passe";
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(11, 97);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.labelIdentifiant.TabIndex = 39;
            this.labelIdentifiant.Text = "Identifiant";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(11, 17);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 38;
            this.labelRole.Text = "Rôle";
            // 
            // textBoxMotPasse
            // 
            this.textBoxMotPasse.Location = new System.Drawing.Point(149, 120);
            this.textBoxMotPasse.Name = "textBoxMotPasse";
            this.textBoxMotPasse.PasswordChar = '*';
            this.textBoxMotPasse.Size = new System.Drawing.Size(100, 20);
            this.textBoxMotPasse.TabIndex = 34;
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(149, 94);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(133, 20);
            this.textBoxIdentifiant.TabIndex = 33;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(110, 357);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 32;
            this.buttonSubmit.Text = "Enregistrer";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Location = new System.Drawing.Point(149, 150);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(177, 20);
            this.dateTimePickerDebut.TabIndex = 63;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(149, 177);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(177, 20);
            this.dateTimePickerFin.TabIndex = 64;
            // 
            // textBoxMotPasseConfirm
            // 
            this.textBoxMotPasseConfirm.Location = new System.Drawing.Point(255, 120);
            this.textBoxMotPasseConfirm.Name = "textBoxMotPasseConfirm";
            this.textBoxMotPasseConfirm.PasswordChar = '*';
            this.textBoxMotPasseConfirm.Size = new System.Drawing.Size(100, 20);
            this.textBoxMotPasseConfirm.TabIndex = 65;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboBoxSociete
            // 
            this.comboBoxSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSociete.FormattingEnabled = true;
            this.comboBoxSociete.Location = new System.Drawing.Point(149, 313);
            this.comboBoxSociete.Name = "comboBoxSociete";
            this.comboBoxSociete.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSociete.TabIndex = 67;
            // 
            // labelSociete
            // 
            this.labelSociete.AutoSize = true;
            this.labelSociete.Location = new System.Drawing.Point(10, 316);
            this.labelSociete.Name = "labelSociete";
            this.labelSociete.Size = new System.Drawing.Size(43, 13);
            this.labelSociete.TabIndex = 68;
            this.labelSociete.Text = "Société";
            // 
            // FormModificationEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 392);
            this.Controls.Add(this.labelSociete);
            this.Controls.Add(this.comboBoxSociete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxMotPasseConfirm);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.textBoxNomRue);
            this.Controls.Add(this.textBoxNumeroRue);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.labelCodePostal);
            this.Controls.Add(this.labelNomRue);
            this.Controls.Add(this.labelNumeroRue);
            this.Controls.Add(this.labelDateFin);
            this.Controls.Add(this.labelDateDebut);
            this.Controls.Add(this.labelMotPasse);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.textBoxMotPasse);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.buttonSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificationEmploye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification d\'un employé";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormModificationEmploye_FormClosed_1);
            this.Load += new System.EventHandler(this.FormModificationEmploye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.TextBox textBoxNomRue;
        private System.Windows.Forms.TextBox textBoxNumeroRue;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.Label labelNomRue;
        private System.Windows.Forms.Label labelNumeroRue;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.Label labelMotPasse;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox textBoxMotPasse;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.TextBox textBoxMotPasseConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBoxSociete;
        private System.Windows.Forms.Label labelSociete;

    }
}