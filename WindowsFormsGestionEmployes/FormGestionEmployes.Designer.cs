namespace WindowsFormsGestionEmployes
{
    partial class FormGestionEmployes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionEmployes));
            this.btnAddEmploye = new System.Windows.Forms.Button();
            this.dataEmployes = new System.Windows.Forms.DataGridView();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnModUser = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxAttribut = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.comboBoxStatut = new System.Windows.Forms.ComboBox();
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.IdUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotPasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSociete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEmploye
            // 
            this.btnAddEmploye.Location = new System.Drawing.Point(21, 9);
            this.btnAddEmploye.Name = "btnAddEmploye";
            this.btnAddEmploye.Size = new System.Drawing.Size(57, 23);
            this.btnAddEmploye.TabIndex = 0;
            this.btnAddEmploye.Text = "Ajouter";
            this.btnAddEmploye.UseVisualStyleBackColor = true;
            this.btnAddEmploye.Click += new System.EventHandler(this.buttonAddEmploye_Click);
            // 
            // dataEmployes
            // 
            this.dataEmployes.AllowUserToAddRows = false;
            this.dataEmployes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUtilisateur,
            this.IdRole,
            this.Prenom,
            this.Nom,
            this.Identifiant,
            this.MotPasse,
            this.DateDebut,
            this.DateFin,
            this.IdSociete});
            this.dataEmployes.Location = new System.Drawing.Point(28, 76);
            this.dataEmployes.Name = "dataEmployes";
            this.dataEmployes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEmployes.Size = new System.Drawing.Size(548, 231);
            this.dataEmployes.TabIndex = 1;
            this.dataEmployes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmployes_CellContentClick);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(146, 9);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(65, 23);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Supprimer";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnModUser
            // 
            this.btnModUser.Location = new System.Drawing.Point(84, 9);
            this.btnModUser.Name = "btnModUser";
            this.btnModUser.Size = new System.Drawing.Size(56, 23);
            this.btnModUser.TabIndex = 3;
            this.btnModUser.Text = "Modifier";
            this.btnModUser.UseVisualStyleBackColor = true;
            this.btnModUser.Click += new System.EventHandler(this.btnModUser_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(440, 9);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(127, 23);
            this.btnXML.TabIndex = 4;
            this.btnXML.Text = "Générer un fichier XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(359, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(125, 50);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 6;
            // 
            // comboBoxAttribut
            // 
            this.comboBoxAttribut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAttribut.FormattingEnabled = true;
            this.comboBoxAttribut.Items.AddRange(new object[] {
            "Nom",
            "Prénom",
            "Rôle",
            "Date de début",
            "Date de fin",
            "Statut"});
            this.comboBoxAttribut.Location = new System.Drawing.Point(252, 50);
            this.comboBoxAttribut.Name = "comboBoxAttribut";
            this.comboBoxAttribut.Size = new System.Drawing.Size(101, 21);
            this.comboBoxAttribut.TabIndex = 7;
            this.comboBoxAttribut.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(224, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(22, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "X";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(494, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(125, 50);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRole.TabIndex = 37;
            this.comboBoxRole.Visible = false;
            // 
            // comboBoxStatut
            // 
            this.comboBoxStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatut.FormattingEnabled = true;
            this.comboBoxStatut.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxStatut.Location = new System.Drawing.Point(125, 50);
            this.comboBoxStatut.Name = "comboBoxStatut";
            this.comboBoxStatut.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStatut.TabIndex = 38;
            this.comboBoxStatut.Visible = false;
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.Location = new System.Drawing.Point(307, 9);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(127, 23);
            this.btnGeneratePDF.TabIndex = 39;
            this.btnGeneratePDF.Text = "Générer un fichier PDF";
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
            this.btnGeneratePDF.Click += new System.EventHandler(this.btnGeneratePDF_Click);
            // 
            // IdUtilisateur
            // 
            this.IdUtilisateur.DataPropertyName = "IdUtilisateur";
            this.IdUtilisateur.HeaderText = "ID";
            this.IdUtilisateur.Name = "IdUtilisateur";
            this.IdUtilisateur.Visible = false;
            // 
            // IdRole
            // 
            this.IdRole.DataPropertyName = "IdRole";
            this.IdRole.HeaderText = "ID du Role";
            this.IdRole.Name = "IdRole";
            this.IdRole.Visible = false;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom";
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Identifiant
            // 
            this.Identifiant.DataPropertyName = "Identifiant";
            this.Identifiant.HeaderText = "Identifiant";
            this.Identifiant.Name = "Identifiant";
            // 
            // MotPasse
            // 
            this.MotPasse.DataPropertyName = "MotPasse";
            this.MotPasse.HeaderText = "Mot de passe";
            this.MotPasse.Name = "MotPasse";
            this.MotPasse.Visible = false;
            // 
            // DateDebut
            // 
            this.DateDebut.DataPropertyName = "DateDebut";
            this.DateDebut.HeaderText = "Date de début";
            this.DateDebut.Name = "DateDebut";
            // 
            // DateFin
            // 
            this.DateFin.DataPropertyName = "DateFin";
            this.DateFin.HeaderText = "Date de fin";
            this.DateFin.Name = "DateFin";
            // 
            // IdSociete
            // 
            this.IdSociete.DataPropertyName = "IdSociete";
            this.IdSociete.HeaderText = "ID de la société";
            this.IdSociete.Name = "IdSociete";
            this.IdSociete.Visible = false;
            // 
            // FormGestionEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 346);
            this.Controls.Add(this.btnGeneratePDF);
            this.Controls.Add(this.comboBoxStatut);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBoxAttribut);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnModUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.dataEmployes);
            this.Controls.Add(this.btnAddEmploye);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionEmployes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des employés";
            this.Load += new System.EventHandler(this.FormGestionEmployes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmploye;
        public System.Windows.Forms.DataGridView dataEmployes;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnModUser;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxAttribut;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.ComboBox comboBoxStatut;
        private System.Windows.Forms.Button btnGeneratePDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotPasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSociete;
    }
}