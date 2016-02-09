namespace WindowsFormsGestionEmployes
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnGestionEmployes = new System.Windows.Forms.Button();
            this.btnGestionRole = new System.Windows.Forms.Button();
            this.btnGestionVilles = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGestionAdresses = new System.Windows.Forms.Button();
            this.buttonGestionSocietes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionEmployes
            // 
            this.btnGestionEmployes.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionEmployes.Image")));
            this.btnGestionEmployes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGestionEmployes.Location = new System.Drawing.Point(19, 12);
            this.btnGestionEmployes.Name = "btnGestionEmployes";
            this.btnGestionEmployes.Size = new System.Drawing.Size(151, 61);
            this.btnGestionEmployes.TabIndex = 0;
            this.btnGestionEmployes.Text = "Gérer les employés";
            this.btnGestionEmployes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionEmployes.UseVisualStyleBackColor = true;
            this.btnGestionEmployes.Click += new System.EventHandler(this.buttonEmployes_Click);
            // 
            // btnGestionRole
            // 
            this.btnGestionRole.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionRole.Image")));
            this.btnGestionRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionRole.Location = new System.Drawing.Point(176, 12);
            this.btnGestionRole.Name = "btnGestionRole";
            this.btnGestionRole.Size = new System.Drawing.Size(151, 61);
            this.btnGestionRole.TabIndex = 1;
            this.btnGestionRole.Text = "Gérer les rôles";
            this.btnGestionRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionRole.UseVisualStyleBackColor = true;
            this.btnGestionRole.Click += new System.EventHandler(this.buttonEntites_Click);
            // 
            // btnGestionVilles
            // 
            this.btnGestionVilles.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionVilles.Image")));
            this.btnGestionVilles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionVilles.Location = new System.Drawing.Point(19, 79);
            this.btnGestionVilles.Name = "btnGestionVilles";
            this.btnGestionVilles.Size = new System.Drawing.Size(151, 60);
            this.btnGestionVilles.TabIndex = 2;
            this.btnGestionVilles.Text = "Gérer les villes";
            this.btnGestionVilles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionVilles.UseVisualStyleBackColor = true;
            this.btnGestionVilles.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(176, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 59);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Déconnexion";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGestionAdresses
            // 
            this.btnGestionAdresses.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionAdresses.Image")));
            this.btnGestionAdresses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionAdresses.Location = new System.Drawing.Point(176, 79);
            this.btnGestionAdresses.Name = "btnGestionAdresses";
            this.btnGestionAdresses.Size = new System.Drawing.Size(151, 60);
            this.btnGestionAdresses.TabIndex = 37;
            this.btnGestionAdresses.Text = "Gérer les adresses";
            this.btnGestionAdresses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionAdresses.UseVisualStyleBackColor = true;
            this.btnGestionAdresses.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonGestionSocietes
            // 
            this.buttonGestionSocietes.Image = ((System.Drawing.Image)(resources.GetObject("buttonGestionSocietes.Image")));
            this.buttonGestionSocietes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGestionSocietes.Location = new System.Drawing.Point(19, 145);
            this.buttonGestionSocietes.Name = "buttonGestionSocietes";
            this.buttonGestionSocietes.Size = new System.Drawing.Size(151, 59);
            this.buttonGestionSocietes.TabIndex = 38;
            this.buttonGestionSocietes.Text = "Gérer les sociétés";
            this.buttonGestionSocietes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGestionSocietes.UseVisualStyleBackColor = true;
            this.buttonGestionSocietes.Click += new System.EventHandler(this.buttonGestionSocietes_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(346, 314);
            this.Controls.Add(this.buttonGestionSocietes);
            this.Controls.Add(this.btnGestionAdresses);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGestionVilles);
            this.Controls.Add(this.btnGestionRole);
            this.Controls.Add(this.btnGestionEmployes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionEmployes;
        private System.Windows.Forms.Button btnGestionRole;
        private System.Windows.Forms.Button btnGestionVilles;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGestionAdresses;
        private System.Windows.Forms.Button buttonGestionSocietes;
    }
}