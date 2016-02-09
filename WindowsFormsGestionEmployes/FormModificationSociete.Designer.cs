namespace WindowsFormsGestionEmployes
{
    partial class FormModificationSociete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificationSociete));
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxNumeroSiret = new System.Windows.Forms.TextBox();
            this.textBoxDescSociete = new System.Windows.Forms.TextBox();
            this.textBoxNomSociete = new System.Windows.Forms.TextBox();
            this.labelNumeroSiret = new System.Windows.Forms.Label();
            this.labelDescSociete = new System.Windows.Forms.Label();
            this.labelNomSociete = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxIdSociete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(239, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxNumeroSiret
            // 
            this.textBoxNumeroSiret.Location = new System.Drawing.Point(158, 68);
            this.textBoxNumeroSiret.Name = "textBoxNumeroSiret";
            this.textBoxNumeroSiret.Size = new System.Drawing.Size(222, 20);
            this.textBoxNumeroSiret.TabIndex = 50;
            // 
            // textBoxDescSociete
            // 
            this.textBoxDescSociete.Location = new System.Drawing.Point(158, 42);
            this.textBoxDescSociete.Name = "textBoxDescSociete";
            this.textBoxDescSociete.Size = new System.Drawing.Size(289, 20);
            this.textBoxDescSociete.TabIndex = 49;
            // 
            // textBoxNomSociete
            // 
            this.textBoxNomSociete.Location = new System.Drawing.Point(158, 14);
            this.textBoxNomSociete.Name = "textBoxNomSociete";
            this.textBoxNomSociete.Size = new System.Drawing.Size(133, 20);
            this.textBoxNomSociete.TabIndex = 48;
            // 
            // labelNumeroSiret
            // 
            this.labelNumeroSiret.AutoSize = true;
            this.labelNumeroSiret.Location = new System.Drawing.Point(19, 71);
            this.labelNumeroSiret.Name = "labelNumeroSiret";
            this.labelNumeroSiret.Size = new System.Drawing.Size(81, 13);
            this.labelNumeroSiret.TabIndex = 47;
            this.labelNumeroSiret.Text = "Numéro de siret";
            // 
            // labelDescSociete
            // 
            this.labelDescSociete.AutoSize = true;
            this.labelDescSociete.Location = new System.Drawing.Point(19, 45);
            this.labelDescSociete.Name = "labelDescSociete";
            this.labelDescSociete.Size = new System.Drawing.Size(123, 13);
            this.labelDescSociete.TabIndex = 46;
            this.labelDescSociete.Text = "Description de la société";
            // 
            // labelNomSociete
            // 
            this.labelNomSociete.AutoSize = true;
            this.labelNomSociete.Location = new System.Drawing.Point(19, 17);
            this.labelNomSociete.Name = "labelNomSociete";
            this.labelNomSociete.Size = new System.Drawing.Size(92, 13);
            this.labelNomSociete.TabIndex = 45;
            this.labelNomSociete.Text = "Nom de la société";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(158, 111);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 44;
            this.buttonSubmit.Text = "Enregistrer";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxIdSociete
            // 
            this.textBoxIdSociete.Location = new System.Drawing.Point(298, 14);
            this.textBoxIdSociete.Name = "textBoxIdSociete";
            this.textBoxIdSociete.Size = new System.Drawing.Size(10, 20);
            this.textBoxIdSociete.TabIndex = 52;
            this.textBoxIdSociete.Visible = false;
            // 
            // FormModificationSociete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 144);
            this.Controls.Add(this.textBoxIdSociete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxNumeroSiret);
            this.Controls.Add(this.textBoxDescSociete);
            this.Controls.Add(this.textBoxNomSociete);
            this.Controls.Add(this.labelNumeroSiret);
            this.Controls.Add(this.labelDescSociete);
            this.Controls.Add(this.labelNomSociete);
            this.Controls.Add(this.buttonSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificationSociete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification d\'une société";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormModificationSociete_FormClosed);
            this.Load += new System.EventHandler(this.FormModificationSociete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxNumeroSiret;
        private System.Windows.Forms.TextBox textBoxDescSociete;
        private System.Windows.Forms.TextBox textBoxNomSociete;
        private System.Windows.Forms.Label labelNumeroSiret;
        private System.Windows.Forms.Label labelDescSociete;
        private System.Windows.Forms.Label labelNomSociete;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxIdSociete;
    }
}