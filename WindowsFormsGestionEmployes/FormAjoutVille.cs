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
    public partial class FormAjoutVille : Form
    {
        public FormAjoutVille()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            Ville ville = new Ville(0, textBoxCodeVille.Text, textBoxDescriptionVille.Text);

            gestionEmployes.createVille(ville);

            this.Close();
        }

        private void FormAjoutVille_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormGestionVilles form = new FormGestionVilles();
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAjoutVille_Load(object sender, EventArgs e)
        {

        }
    }
}
