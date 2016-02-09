namespace WindowsFormsGestionEmployes
{
    partial class FormModificationVille
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificationVille));
            this.textBoxDescriptionVille = new System.Windows.Forms.TextBox();
            this.textBoxCodeVille = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdVille = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDescriptionVille
            // 
            this.textBoxDescriptionVille.Location = new System.Drawing.Point(156, 48);
            this.textBoxDescriptionVille.Name = "textBoxDescriptionVille";
            this.textBoxDescriptionVille.Size = new System.Drawing.Size(170, 20);
            this.textBoxDescriptionVille.TabIndex = 9;
            // 
            // textBoxCodeVille
            // 
            this.textBoxCodeVille.Location = new System.Drawing.Point(156, 19);
            this.textBoxCodeVille.Name = "textBoxCodeVille";
            this.textBoxCodeVille.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodeVille.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description de la ville";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Code de la ville";
            // 
            // textBoxIdVille
            // 
            this.textBoxIdVille.Location = new System.Drawing.Point(262, 19);
            this.textBoxIdVille.Name = "textBoxIdVille";
            this.textBoxIdVille.Size = new System.Drawing.Size(10, 20);
            this.textBoxIdVille.TabIndex = 10;
            this.textBoxIdVille.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(180, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormModificationVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(345, 121);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxIdVille);
            this.Controls.Add(this.textBoxDescriptionVille);
            this.Controls.Add(this.textBoxCodeVille);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificationVille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification d\'une ville";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormModificationVille_FormClosed);
            this.Load += new System.EventHandler(this.FormModificationVille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescriptionVille;
        private System.Windows.Forms.TextBox textBoxCodeVille;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdVille;
        private System.Windows.Forms.Button btnCancel;
    }
}