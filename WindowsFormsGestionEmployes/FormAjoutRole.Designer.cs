namespace WindowsFormsGestionEmployes
{
    partial class FormAjoutRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutRole));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBoxDescriptionRole = new System.Windows.Forms.TextBox();
            this.textBoxCodeRole = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(45, 76);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Valider";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBoxDescriptionRole
            // 
            this.textBoxDescriptionRole.Location = new System.Drawing.Point(119, 39);
            this.textBoxDescriptionRole.Name = "textBoxDescriptionRole";
            this.textBoxDescriptionRole.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescriptionRole.TabIndex = 8;
            // 
            // textBoxCodeRole
            // 
            this.textBoxCodeRole.Location = new System.Drawing.Point(119, 12);
            this.textBoxCodeRole.Name = "textBoxCodeRole";
            this.textBoxCodeRole.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodeRole.TabIndex = 7;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(13, 42);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Description";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(14, 12);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(32, 13);
            this.labelCode.TabIndex = 5;
            this.labelCode.Text = "Code";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(126, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAjoutRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(246, 111);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBoxDescriptionRole);
            this.Controls.Add(this.textBoxCodeRole);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjoutRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'un rôle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAjoutRole_FormClosed);
            this.Load += new System.EventHandler(this.FormAjoutRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBoxDescriptionRole;
        private System.Windows.Forms.TextBox textBoxCodeRole;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Button btnCancel;
    }
}