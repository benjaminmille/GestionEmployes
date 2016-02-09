namespace WindowsFormsGestionEmployes
{
    partial class FormGestionVilles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionVilles));
            this.btnModVille = new System.Windows.Forms.Button();
            this.btnDeleteVille = new System.Windows.Forms.Button();
            this.btnAddVille = new System.Windows.Forms.Button();
            this.dataGridVilles = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.comboBoxAttribut = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.idVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVilles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModVille
            // 
            this.btnModVille.Location = new System.Drawing.Point(93, 15);
            this.btnModVille.Name = "btnModVille";
            this.btnModVille.Size = new System.Drawing.Size(75, 23);
            this.btnModVille.TabIndex = 6;
            this.btnModVille.Text = "Modifier";
            this.btnModVille.UseVisualStyleBackColor = true;
            this.btnModVille.Click += new System.EventHandler(this.btnModVille_Click);
            // 
            // btnDeleteVille
            // 
            this.btnDeleteVille.Location = new System.Drawing.Point(174, 15);
            this.btnDeleteVille.Name = "btnDeleteVille";
            this.btnDeleteVille.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteVille.TabIndex = 5;
            this.btnDeleteVille.Text = "Supprimer";
            this.btnDeleteVille.UseVisualStyleBackColor = true;
            this.btnDeleteVille.Click += new System.EventHandler(this.btnDeleteVille_Click);
            // 
            // btnAddVille
            // 
            this.btnAddVille.Location = new System.Drawing.Point(12, 15);
            this.btnAddVille.Name = "btnAddVille";
            this.btnAddVille.Size = new System.Drawing.Size(75, 23);
            this.btnAddVille.TabIndex = 4;
            this.btnAddVille.Text = "Ajouter";
            this.btnAddVille.UseVisualStyleBackColor = true;
            this.btnAddVille.Click += new System.EventHandler(this.btnAddVille_Click);
            // 
            // dataGridVilles
            // 
            this.dataGridVilles.AllowUserToAddRows = false;
            this.dataGridVilles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridVilles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVilles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVille,
            this.CodeVille,
            this.DescriptionVille});
            this.dataGridVilles.Location = new System.Drawing.Point(12, 70);
            this.dataGridVilles.Name = "dataGridVilles";
            this.dataGridVilles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVilles.Size = new System.Drawing.Size(309, 234);
            this.dataGridVilles.TabIndex = 7;
            this.dataGridVilles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVilles_CellContentClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(111, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(22, 21);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "X";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // comboBoxAttribut
            // 
            this.comboBoxAttribut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAttribut.FormattingEnabled = true;
            this.comboBoxAttribut.Items.AddRange(new object[] {
            "Code",
            "Description"});
            this.comboBoxAttribut.Location = new System.Drawing.Point(139, 44);
            this.comboBoxAttribut.Name = "comboBoxAttribut";
            this.comboBoxAttribut.Size = new System.Drawing.Size(101, 21);
            this.comboBoxAttribut.TabIndex = 11;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 44);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(246, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(246, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // idVille
            // 
            this.idVille.DataPropertyName = "idVille";
            this.idVille.HeaderText = "ID de la ville";
            this.idVille.Name = "idVille";
            this.idVille.Visible = false;
            // 
            // CodeVille
            // 
            this.CodeVille.DataPropertyName = "codeVille";
            this.CodeVille.HeaderText = "Code de la ville";
            this.CodeVille.Name = "CodeVille";
            // 
            // DescriptionVille
            // 
            this.DescriptionVille.DataPropertyName = "descriptionVille";
            this.DescriptionVille.HeaderText = "Description de la ville";
            this.DescriptionVille.Name = "DescriptionVille";
            this.DescriptionVille.Width = 150;
            // 
            // FormGestionVilles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(336, 341);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBoxAttribut);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridVilles);
            this.Controls.Add(this.btnModVille);
            this.Controls.Add(this.btnDeleteVille);
            this.Controls.Add(this.btnAddVille);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionVilles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des villes";
            this.Load += new System.EventHandler(this.FormGestionVille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVilles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModVille;
        private System.Windows.Forms.Button btnDeleteVille;
        private System.Windows.Forms.Button btnAddVille;
        private System.Windows.Forms.DataGridView dataGridVilles;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox comboBoxAttribut;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionVille;
    }
}