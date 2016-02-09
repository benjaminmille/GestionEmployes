namespace WindowsFormsGestionEmployes
{
    partial class FormAjoutVille
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutVille));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBoxCodeVille = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionVille = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code de la ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description de la ville";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(97, 86);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Valider";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBoxCodeVille
            // 
            this.textBoxCodeVille.Location = new System.Drawing.Point(148, 19);
            this.textBoxCodeVille.Name = "textBoxCodeVille";
            this.textBoxCodeVille.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodeVille.TabIndex = 3;
            // 
            // textBoxDescriptionVille
            // 
            this.textBoxDescriptionVille.Location = new System.Drawing.Point(148, 48);
            this.textBoxDescriptionVille.Name = "textBoxDescriptionVille";
            this.textBoxDescriptionVille.Size = new System.Drawing.Size(170, 20);
            this.textBoxDescriptionVille.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(178, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAjoutVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 121);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxDescriptionVille);
            this.Controls.Add(this.textBoxCodeVille);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjoutVille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'une ville";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAjoutVille_FormClosed);
            this.Load += new System.EventHandler(this.FormAjoutVille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBoxCodeVille;
        private System.Windows.Forms.TextBox textBoxDescriptionVille;
        private System.Windows.Forms.Button btnCancel;
    }
}