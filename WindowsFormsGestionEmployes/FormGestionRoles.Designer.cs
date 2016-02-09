namespace WindowsFormsGestionEmployes
{
    partial class FormGestionRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionRoles));
            this.dataGridRole = new System.Windows.Forms.DataGridView();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnModRole = new System.Windows.Forms.Button();
            this.addRole = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.comboBoxAttribut = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.IdRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRole)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRole
            // 
            this.dataGridRole.AllowUserToAddRows = false;
            this.dataGridRole.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRole,
            this.CodeRole,
            this.DescriptionRole});
            this.dataGridRole.Location = new System.Drawing.Point(12, 69);
            this.dataGridRole.Name = "dataGridRole";
            this.dataGridRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRole.Size = new System.Drawing.Size(309, 234);
            this.dataGridRole.TabIndex = 0;
            this.dataGridRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRole_CellContentClick);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(174, 12);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRole.TabIndex = 1;
            this.btnDeleteRole.Text = "Supprimer";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnModRole
            // 
            this.btnModRole.Location = new System.Drawing.Point(93, 12);
            this.btnModRole.Name = "btnModRole";
            this.btnModRole.Size = new System.Drawing.Size(75, 23);
            this.btnModRole.TabIndex = 2;
            this.btnModRole.Text = "Modifier";
            this.btnModRole.UseVisualStyleBackColor = true;
            this.btnModRole.Click += new System.EventHandler(this.btnModRole_Click);
            // 
            // addRole
            // 
            this.addRole.Location = new System.Drawing.Point(12, 12);
            this.addRole.Name = "addRole";
            this.addRole.Size = new System.Drawing.Size(75, 23);
            this.addRole.TabIndex = 3;
            this.addRole.Text = "Ajouter";
            this.addRole.UseVisualStyleBackColor = true;
            this.addRole.Click += new System.EventHandler(this.addRole_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(111, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(22, 21);
            this.btnReset.TabIndex = 16;
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
            this.comboBoxAttribut.Location = new System.Drawing.Point(139, 41);
            this.comboBoxAttribut.Name = "comboBoxAttribut";
            this.comboBoxAttribut.Size = new System.Drawing.Size(101, 21);
            this.comboBoxAttribut.TabIndex = 15;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 41);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(246, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(246, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // IdRole
            // 
            this.IdRole.DataPropertyName = "IdRole";
            this.IdRole.HeaderText = "ID du rôle";
            this.IdRole.Name = "IdRole";
            this.IdRole.Visible = false;
            // 
            // CodeRole
            // 
            this.CodeRole.DataPropertyName = "CodeRole";
            this.CodeRole.HeaderText = "Code du rôle";
            this.CodeRole.Name = "CodeRole";
            // 
            // DescriptionRole
            // 
            this.DescriptionRole.DataPropertyName = "DescriptionRole";
            this.DescriptionRole.HeaderText = "Description du rôle";
            this.DescriptionRole.Name = "DescriptionRole";
            this.DescriptionRole.Width = 150;
            // 
            // FormGestionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(335, 340);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBoxAttribut);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.addRole);
            this.Controls.Add(this.btnModRole);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.dataGridRole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des rôles";
            this.Load += new System.EventHandler(this.FormGestionRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnModRole;
        private System.Windows.Forms.Button addRole;
        public System.Windows.Forms.DataGridView dataGridRole;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox comboBoxAttribut;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionRole;

    }
}