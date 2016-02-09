namespace WindowsFormsGestionEmployes
{
    partial class FormAjoutEmploye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutEmploye));
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxMotPasse = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelMotPasse = new System.Windows.Forms.Label();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.labelNumeroRue = new System.Windows.Forms.Label();
            this.labelNomRue = new System.Windows.Forms.Label();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.textBoxNumeroRue = new System.Windows.Forms.TextBox();
            this.textBoxNomRue = new System.Windows.Forms.TextBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.textBoxMotPasseConfirm = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelSociete = new System.Windows.Forms.Label();
            this.comboBoxSociete = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(108, 356);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Valider";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(148, 94);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(121, 20);
            this.textBoxIdentifiant.TabIndex = 2;
            // 
            // textBoxMotPasse
            // 
            this.textBoxMotPasse.Location = new System.Drawing.Point(148, 120);
            this.textBoxMotPasse.Name = "textBoxMotPasse";
            this.textBoxMotPasse.PasswordChar = '*';
            this.textBoxMotPasse.Size = new System.Drawing.Size(100, 20);
            this.textBoxMotPasse.TabIndex = 3;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(10, 17);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 7;
            this.labelRole.Text = "Rôle";
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(10, 97);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.labelIdentifiant.TabIndex = 8;
            this.labelIdentifiant.Text = "Identifiant";
            // 
            // labelMotPasse
            // 
            this.labelMotPasse.AutoSize = true;
            this.labelMotPasse.Location = new System.Drawing.Point(9, 124);
            this.labelMotPasse.Name = "labelMotPasse";
            this.labelMotPasse.Size = new System.Drawing.Size(71, 13);
            this.labelMotPasse.TabIndex = 9;
            this.labelMotPasse.Text = "Mot de passe";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Location = new System.Drawing.Point(9, 151);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(75, 13);
            this.labelDateDebut.TabIndex = 10;
            this.labelDateDebut.Text = "Date de début";
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Location = new System.Drawing.Point(9, 179);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(59, 13);
            this.labelDateFin.TabIndex = 11;
            this.labelDateFin.Text = "Date de fin";
            // 
            // labelNumeroRue
            // 
            this.labelNumeroRue.AutoSize = true;
            this.labelNumeroRue.Location = new System.Drawing.Point(9, 208);
            this.labelNumeroRue.Name = "labelNumeroRue";
            this.labelNumeroRue.Size = new System.Drawing.Size(77, 13);
            this.labelNumeroRue.TabIndex = 13;
            this.labelNumeroRue.Text = "Numéro de rue";
            // 
            // labelNomRue
            // 
            this.labelNomRue.AutoSize = true;
            this.labelNomRue.Location = new System.Drawing.Point(9, 236);
            this.labelNomRue.Name = "labelNomRue";
            this.labelNomRue.Size = new System.Drawing.Size(62, 13);
            this.labelNomRue.TabIndex = 14;
            this.labelNomRue.Text = "Nom de rue";
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(9, 263);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(63, 13);
            this.labelCodePostal.TabIndex = 15;
            this.labelCodePostal.Text = "Code postal";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(148, 14);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRole.TabIndex = 16;
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(9, 289);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(26, 13);
            this.labelVille.TabIndex = 17;
            this.labelVille.Text = "Ville";
            // 
            // textBoxNumeroRue
            // 
            this.textBoxNumeroRue.Location = new System.Drawing.Point(148, 205);
            this.textBoxNumeroRue.Name = "textBoxNumeroRue";
            this.textBoxNumeroRue.Size = new System.Drawing.Size(26, 20);
            this.textBoxNumeroRue.TabIndex = 21;
            // 
            // textBoxNomRue
            // 
            this.textBoxNomRue.Location = new System.Drawing.Point(148, 233);
            this.textBoxNomRue.Name = "textBoxNomRue";
            this.textBoxNomRue.Size = new System.Drawing.Size(187, 20);
            this.textBoxNomRue.TabIndex = 22;
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(148, 260);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(73, 20);
            this.textBoxCodePostal.TabIndex = 23;
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(148, 286);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(100, 21);
            this.comboBoxVille.TabIndex = 24;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(9, 42);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 28;
            this.labelPrenom.Text = "Prénom";
            this.labelPrenom.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(10, 70);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 29;
            this.labelNom.Text = "Nom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(148, 42);
            this.textBoxPrenom.Multiline = true;
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 19);
            this.textBoxPrenom.TabIndex = 30;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(148, 67);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 31;
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Location = new System.Drawing.Point(148, 150);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(187, 20);
            this.dateTimePickerDebut.TabIndex = 32;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(148, 178);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(187, 20);
            this.dateTimePickerFin.TabIndex = 33;
            // 
            // textBoxMotPasseConfirm
            // 
            this.textBoxMotPasseConfirm.Location = new System.Drawing.Point(254, 120);
            this.textBoxMotPasseConfirm.Name = "textBoxMotPasseConfirm";
            this.textBoxMotPasseConfirm.PasswordChar = '*';
            this.textBoxMotPasseConfirm.Size = new System.Drawing.Size(100, 20);
            this.textBoxMotPasseConfirm.TabIndex = 34;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelSociete
            // 
            this.labelSociete.AutoSize = true;
            this.labelSociete.Location = new System.Drawing.Point(9, 316);
            this.labelSociete.Name = "labelSociete";
            this.labelSociete.Size = new System.Drawing.Size(43, 13);
            this.labelSociete.TabIndex = 70;
            this.labelSociete.Text = "Société";
            // 
            // comboBoxSociete
            // 
            this.comboBoxSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSociete.FormattingEnabled = true;
            this.comboBoxSociete.Location = new System.Drawing.Point(148, 313);
            this.comboBoxSociete.Name = "comboBoxSociete";
            this.comboBoxSociete.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSociete.TabIndex = 69;
            // 
            // FormAjoutEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 391);
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
            this.Name = "FormAjoutEmploye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'un employé";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAjoutEmploye_FormClosed);
            this.Load += new System.EventHandler(this.FormAjoutEmploye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxMotPasse;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelMotPasse;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Label labelNumeroRue;
        private System.Windows.Forms.Label labelNomRue;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox textBoxNumeroRue;
        private System.Windows.Forms.TextBox textBoxNomRue;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.TextBox textBoxMotPasseConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelSociete;
        private System.Windows.Forms.ComboBox comboBoxSociete;
    }
}