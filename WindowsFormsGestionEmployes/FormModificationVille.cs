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
    public partial class FormModificationVille : Form
    {
        public FormModificationVille()
        {
            InitializeComponent();
        }

        private void FormModificationVille_Load(object sender, EventArgs e)
        {

        }

        public void LoadInfo(int IdVille, string CodeVille, string DescriptionVille)
        {
            textBoxIdVille.Text = IdVille.ToString();
            textBoxCodeVille.Text = CodeVille;
            textBoxDescriptionVille.Text = DescriptionVille;
        }

        private void FormModificationVille_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormGestionVilles form = new FormGestionVilles();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            int IdVille = Convert.ToInt32(textBoxIdVille.Text);
            string CodeVille = textBoxCodeVille.Text;
            string DescriptionVille = textBoxDescriptionVille.Text;
            Ville ville = new Ville(IdVille, CodeVille, DescriptionVille);

            gestionEmployes.updateVille(ville);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
