namespace WindowsFormsGestionEmployes
{
    partial class FormGestionSocietes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionSocietes));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.comboBoxAttribut = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.addSociete = new System.Windows.Forms.Button();
            this.btnModSociete = new System.Windows.Forms.Button();
            this.btnDeleteSociete = new System.Windows.Forms.Button();
            this.dataGridSocietes = new System.Windows.Forms.DataGridView();
            this.comboBoxUtilisateur = new System.Windows.Forms.ComboBox();
            this.IdSociete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomSociete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionSociete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroSiret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSocietes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(331, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(111, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(22, 23);
            this.btnReset.TabIndex = 54;
            this.btnReset.Text = "X";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // comboBoxAttribut
            // 
            this.comboBoxAttribut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAttribut.FormattingEnabled = true;
            this.comboBoxAttribut.Items.AddRange(new object[] {
            "Nom",
            "Numéro de siret",
            "Utilisateur"});
            this.comboBoxAttribut.Location = new System.Drawing.Point(139, 44);
            this.comboBoxAttribut.Name = "comboBoxAttribut";
            this.comboBoxAttribut.Size = new System.Drawing.Size(101, 21);
            this.comboBoxAttribut.TabIndex = 53;
            this.comboBoxAttribut.SelectedIndexChanged += new System.EventHandler(this.comboBoxAttribut_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(13, 44);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 52;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(246, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // addSociete
            // 
            this.addSociete.Location = new System.Drawing.Point(12, 15);
            this.addSociete.Name = "addSociete";
            this.addSociete.Size = new System.Drawing.Size(75, 23);
            this.addSociete.TabIndex = 50;
            this.addSociete.Text = "Ajouter";
            this.addSociete.UseVisualStyleBackColor = true;
            this.addSociete.Click += new System.EventHandler(this.addSociete_Click);
            // 
            // btnModSociete
            // 
            this.btnModSociete.Location = new System.Drawing.Point(93, 15);
            this.btnModSociete.Name = "btnModSociete";
            this.btnModSociete.Size = new System.Drawing.Size(75, 23);
            this.btnModSociete.TabIndex = 49;
            this.btnModSociete.Text = "Modifier";
            this.btnModSociete.UseVisualStyleBackColor = true;
            this.btnModSociete.Click += new System.EventHandler(this.btnModSociete_Click);
            // 
            // btnDeleteSociete
            // 
            this.btnDeleteSociete.Location = new System.Drawing.Point(174, 15);
            this.btnDeleteSociete.Name = "btnDeleteSociete";
            this.btnDeleteSociete.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSociete.TabIndex = 48;
            this.btnDeleteSociete.Text = "Supprimer";
            this.btnDeleteSociete.UseVisualStyleBackColor = true;
            this.btnDeleteSociete.Click += new System.EventHandler(this.btnDeleteSociete_Click);
            // 
            // dataGridSocietes
            // 
            this.dataGridSocietes.AllowUserToAddRows = false;
            this.dataGridSocietes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridSocietes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSocietes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSociete,
            this.NomSociete,
            this.DescriptionSociete,
            this.NumeroSiret});
            this.dataGridSocietes.Location = new System.Drawing.Point(12, 72);
            this.dataGridSocietes.Name = "dataGridSocietes";
            this.dataGridSocietes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSocietes.Size = new System.Drawing.Size(394, 234);
            this.dataGridSocietes.TabIndex = 47;
            // 
            // comboBoxUtilisateur
            // 
            this.comboBoxUtilisateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUtilisateur.FormattingEnabled = true;
            this.comboBoxUtilisateur.Location = new System.Drawing.Point(13, 44);
            this.comboBoxUtilisateur.Name = "comboBoxUtilisateur";
            this.comboBoxUtilisateur.Size = new System.Drawing.Size(99, 21);
            this.comboBoxUtilisateur.TabIndex = 56;
            this.comboBoxUtilisateur.Visible = false;
            // 
            // IdSociete
            // 
            this.IdSociete.DataPropertyName = "IdSociete";
            this.IdSociete.HeaderText = "ID de la société";
            this.IdSociete.Name = "IdSociete";
            this.IdSociete.Visible = false;
            // 
            // NomSociete
            // 
            this.NomSociete.DataPropertyName = "NomSociete";
            this.NomSociete.HeaderText = "Nom de la société";
            this.NomSociete.Name = "NomSociete";
            // 
            // DescriptionSociete
            // 
            this.DescriptionSociete.DataPropertyName = "DescriptionSociete";
            this.DescriptionSociete.HeaderText = "Description de la société";
            this.DescriptionSociete.Name = "DescriptionSociete";
            this.DescriptionSociete.Width = 150;
            // 
            // NumeroSiret
            // 
            this.NumeroSiret.DataPropertyName = "NumeroSiret";
            this.NumeroSiret.HeaderText = "Numéro de siret";
            this.NumeroSiret.Name = "NumeroSiret";
            // 
            // FormGestionSocietes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(415, 343);
            this.Controls.Add(this.comboBoxUtilisateur);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBoxAttribut);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.addSociete);
            this.Controls.Add(this.btnModSociete);
            this.Controls.Add(this.btnDeleteSociete);
            this.Controls.Add(this.dataGridSocietes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionSocietes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des sociétés";
            this.Load += new System.EventHandler(this.FormGestionSocietes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSocietes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox comboBoxAttribut;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button addSociete;
        private System.Windows.Forms.Button btnModSociete;
        private System.Windows.Forms.Button btnDeleteSociete;
        public System.Windows.Forms.DataGridView dataGridSocietes;
        private System.Windows.Forms.ComboBox comboBoxUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSociete;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomSociete;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionSociete;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSiret;
    }
}