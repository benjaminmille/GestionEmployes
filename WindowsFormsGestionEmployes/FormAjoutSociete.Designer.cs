namespace WindowsFormsGestionEmployes
{
    partial class FormAjoutSociete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutSociete));
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxNumeroSiret = new System.Windows.Forms.TextBox();
            this.textBoxDescSociete = new System.Windows.Forms.TextBox();
            this.textBoxNomSociete = new System.Windows.Forms.TextBox();
            this.labelNumeroSiret = new System.Windows.Forms.Label();
            this.labelDescSociete = new System.Windows.Forms.Label();
            this.labelNomSociete = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxNumeroSiret
            // 
            this.textBoxNumeroSiret.Location = new System.Drawing.Point(154, 66);
            this.textBoxNumeroSiret.Name = "textBoxNumeroSiret";
            this.textBoxNumeroSiret.Size = new System.Drawing.Size(222, 20);
            this.textBoxNumeroSiret.TabIndex = 42;
            // 
            // textBoxDescSociete
            // 
            this.textBoxDescSociete.Location = new System.Drawing.Point(154, 40);
            this.textBoxDescSociete.Name = "textBoxDescSociete";
            this.textBoxDescSociete.Size = new System.Drawing.Size(289, 20);
            this.textBoxDescSociete.TabIndex = 41;
            // 
            // textBoxNomSociete
            // 
            this.textBoxNomSociete.Location = new System.Drawing.Point(154, 12);
            this.textBoxNomSociete.Name = "textBoxNomSociete";
            this.textBoxNomSociete.Size = new System.Drawing.Size(133, 20);
            this.textBoxNomSociete.TabIndex = 40;
            // 
            // labelNumeroSiret
            // 
            this.labelNumeroSiret.AutoSize = true;
            this.labelNumeroSiret.Location = new System.Drawing.Point(15, 69);
            this.labelNumeroSiret.Name = "labelNumeroSiret";
            this.labelNumeroSiret.Size = new System.Drawing.Size(81, 13);
            this.labelNumeroSiret.TabIndex = 39;
            this.labelNumeroSiret.Text = "Numéro de siret";
            // 
            // labelDescSociete
            // 
            this.labelDescSociete.AutoSize = true;
            this.labelDescSociete.Location = new System.Drawing.Point(15, 43);
            this.labelDescSociete.Name = "labelDescSociete";
            this.labelDescSociete.Size = new System.Drawing.Size(123, 13);
            this.labelDescSociete.TabIndex = 38;
            this.labelDescSociete.Text = "Description de la société";
            // 
            // labelNomSociete
            // 
            this.labelNomSociete.AutoSize = true;
            this.labelNomSociete.Location = new System.Drawing.Point(15, 15);
            this.labelNomSociete.Name = "labelNomSociete";
            this.labelNomSociete.Size = new System.Drawing.Size(92, 13);
            this.labelNomSociete.TabIndex = 37;
            this.labelNomSociete.Text = "Nom de la société";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(154, 109);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 36;
            this.buttonSubmit.Text = "Valider";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormAjoutSociete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 144);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxNumeroSiret);
            this.Controls.Add(this.textBoxDescSociete);
            this.Controls.Add(this.textBoxNomSociete);
            this.Controls.Add(this.labelNumeroSiret);
            this.Controls.Add(this.labelDescSociete);
            this.Controls.Add(this.labelNomSociete);
            this.Controls.Add(this.buttonSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjoutSociete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'une société";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAjoutSociete_FormClosed);
            this.Load += new System.EventHandler(this.FormAjoutSociete_Load);
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
    }
}