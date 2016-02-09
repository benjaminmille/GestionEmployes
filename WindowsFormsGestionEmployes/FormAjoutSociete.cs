using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaoGestionEmployes;

namespace WindowsFormsGestionEmployes
{
    public partial class FormAjoutSociete : Form
    {
        public FormAjoutSociete()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            Societe societe = new Societe(0, textBoxNomSociete.Text, textBoxDescSociete.Text, textBoxNumeroSiret.Text);

            gestionEmployes.createSociete(societe);

            this.Close();
        }

        private void FormAjoutSociete_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAjoutSociete_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormGestionSocietes form = new FormGestionSocietes();
            form.Show();
        }
    }
}
