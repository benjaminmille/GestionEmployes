namespace WindowsFormsGestionEmployes
{
    partial class FormModificationRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificationRole));
            this.labelCode = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxCodeRole = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionRole = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBoxIdRole = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(13, 13);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(32, 13);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Code";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 43);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description";
            // 
            // textBoxCodeRole
            // 
            this.textBoxCodeRole.Location = new System.Drawing.Point(118, 13);
            this.textBoxCodeRole.Name = "textBoxCodeRole";
            this.textBoxCodeRole.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodeRole.TabIndex = 2;
            // 
            // textBoxDescriptionRole
            // 
            this.textBoxDescriptionRole.Location = new System.Drawing.Point(118, 40);
            this.textBoxDescriptionRole.Name = "textBoxDescriptionRole";
            this.textBoxDescriptionRole.Size = new System.Drawing.Size(190, 20);
            this.textBoxDescriptionRole.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(91, 80);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Enregistrer";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBoxIdRole
            // 
            this.textBoxIdRole.Location = new System.Drawing.Point(224, 13);
            this.textBoxIdRole.Name = "textBoxIdRole";
            this.textBoxIdRole.Size = new System.Drawing.Size(10, 20);
            this.textBoxIdRole.TabIndex = 5;
            this.textBoxIdRole.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormModificationRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(328, 115);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxIdRole);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBoxDescriptionRole);
            this.Controls.Add(this.textBoxCodeRole);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificationRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification d\'un rôle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormModificationRole_FormClosed);
            this.Load += new System.EventHandler(this.FormModificationRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxCodeRole;
        private System.Windows.Forms.TextBox textBoxDescriptionRole;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBoxIdRole;
        private System.Windows.Forms.Button btnCancel;
    }
}