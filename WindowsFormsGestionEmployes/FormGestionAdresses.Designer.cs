namespace WindowsFormsGestionEmployes
{
    partial class FormGestionAdresses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionAdresses));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.comboBoxAttribut = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridAdresses = new System.Windows.Forms.DataGridView();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.btnModAdresse = new System.Windows.Forms.Button();
            this.addAdresse = new System.Windows.Forms.Button();
            this.IdArdesse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroRue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomRue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdresses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(331, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(111, 41);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(22, 23);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "X";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // comboBoxAttribut
            // 
            this.comboBoxAttribut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAttribut.FormattingEnabled = true;
            this.comboBoxAttribut.Items.AddRange(new object[] {
            "Numéro de rue",
            "Nom de rue",
            "Code postal",
            "Ville"});
            this.comboBoxAttribut.Location = new System.Drawing.Point(139, 42);
            this.comboBoxAttribut.Name = "comboBoxAttribut";
            this.comboBoxAttribut.Size = new System.Drawing.Size(101, 21);
            this.comboBoxAttribut.TabIndex = 44;
            this.comboBoxAttribut.SelectedIndexChanged += new System.EventHandler(this.comboBoxAttribut_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 42);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 43;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(246, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridAdresses
            // 
            this.dataGridAdresses.AllowUserToAddRows = false;
            this.dataGridAdresses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridAdresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArdesse,
            this.NumeroRue,
            this.NomRue,
            this.CodePostal,
            this.IdVille,
            this.IdUtilisateur});
            this.dataGridAdresses.Location = new System.Drawing.Point(12, 70);
            this.dataGridAdresses.Name = "dataGridAdresses";
            this.dataGridAdresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAdresses.Size = new System.Drawing.Size(394, 234);
            this.dataGridAdresses.TabIndex = 38;
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(12, 42);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(100, 21);
            this.comboBoxVille.TabIndex = 47;
            this.comboBoxVille.Visible = false;
            // 
            // btnModAdresse
            // 
            this.btnModAdresse.Location = new System.Drawing.Point(93, 13);
            this.btnModAdresse.Name = "btnModAdresse";
            this.btnModAdresse.Size = new System.Drawing.Size(75, 23);
            this.btnModAdresse.TabIndex = 40;
            this.btnModAdresse.Text = "Modifier";
            this.btnModAdresse.UseVisualStyleBackColor = true;
            this.btnModAdresse.Click += new System.EventHandler(this.btnModAdresse_Click);
            // 
            // addAdresse
            // 
            this.addAdresse.Location = new System.Drawing.Point(12, 13);
            this.addAdresse.Name = "addAdresse";
            this.addAdresse.Size = new System.Drawing.Size(75, 23);
            this.addAdresse.TabIndex = 41;
            this.addAdresse.Text = "Ajouter";
            this.addAdresse.UseVisualStyleBackColor = true;
            this.addAdresse.Click += new System.EventHandler(this.addAdresse_Click);
            // 
            // IdArdesse
            // 
            this.IdArdesse.DataPropertyName = "IdAdresse";
            this.IdArdesse.HeaderText = "ID de l\'adresse";
            this.IdArdesse.Name = "IdArdesse";
            this.IdArdesse.Visible = false;
            // 
            // NumeroRue
            // 
            this.NumeroRue.DataPropertyName = "NumeroRue";
            this.NumeroRue.HeaderText = "Numéro de rue";
            this.NumeroRue.Name = "NumeroRue";
            // 
            // NomRue
            // 
            this.NomRue.DataPropertyName = "NomRue";
            this.NomRue.HeaderText = "Nom de rue";
            this.NomRue.Name = "NomRue";
            this.NomRue.Width = 150;
            // 
            // CodePostal
            // 
            this.CodePostal.DataPropertyName = "CodePostal";
            this.CodePostal.HeaderText = "Code postal";
            this.CodePostal.Name = "CodePostal";
            // 
            // IdVille
            // 
            this.IdVille.DataPropertyName = "IdVille";
            this.IdVille.HeaderText = "ID de la ville";
            this.IdVille.Name = "IdVille";
            this.IdVille.Visible = false;
            // 
            // IdUtilisateur
            // 
            this.IdUtilisateur.DataPropertyName = "IdUtilisateur";
            this.IdUtilisateur.HeaderText = "ID de l\'utilisateur";
            this.IdUtilisateur.Name = "IdUtilisateur";
            this.IdUtilisateur.Visible = false;
            // 
            // FormGestionAdresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 340);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBoxAttribut);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.addAdresse);
            this.Controls.Add(this.btnModAdresse);
            this.Controls.Add(this.dataGridAdresses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionAdresses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des adresses";
            this.Load += new System.EventHandler(this.FormGestionAdresses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdresses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox comboBoxAttribut;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.DataGridView dataGridAdresses;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.Button btnModAdresse;
        private System.Windows.Forms.Button addAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArdesse;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroRue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomRue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUtilisateur;
    }
}