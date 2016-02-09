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
    public partial class FormModificationSociete : Form
    {
        public FormModificationSociete()
        {
            InitializeComponent();
        }

        private void FormModificationSociete_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            Societe societe = new Societe(Convert.ToInt32(textBoxIdSociete.Text), textBoxNomSociete.Text, textBoxDescSociete.Text, textBoxNumeroSiret.Text);

            gestionEmployes.updateSociete(societe);

            this.Close();
        }

        public void LoadInfo(int IdSociete, string NomSociete, string DescriptionSociete, string NumeroSiret)
        {
            textBoxIdSociete.Text = IdSociete.ToString();
            textBoxNomSociete.Text = NomSociete;
            textBoxDescSociete.Text = DescriptionSociete;
            textBoxNumeroSiret.Text = NumeroSiret;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModificationSociete_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormGestionSocietes form = new FormGestionSocietes();
            form.Show();
        }
    }
}
