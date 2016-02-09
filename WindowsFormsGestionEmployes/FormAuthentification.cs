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
    public partial class FormAuthentification : Form
    {
        public FormAuthentification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            Boolean infoOk = gestionEmployes.checkAuthentification(textBoxIdentifiant.Text, textBoxMotPasse.Text);

            if (infoOk)
            {
                FormMenu form = new FormMenu();
                form.Show();
                this.Hide();
            }
            else if (!infoOk)
            {
                MessageBox.Show("L'identifiant ou le mot de passe entré est invalide.", "Erreur lors de l'authentification");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAuthentification_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormAuthentification_Load(object sender, EventArgs e)
        {

        }
    }
}
