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
    public partial class FormAjoutRole : Form
    {
        public FormAjoutRole()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            Role role = new Role(0, textBoxCodeRole.Text, textBoxDescriptionRole.Text);

            gestionEmployes.createRole(role);

            this.Close();
        }

        private void FormAjoutRole_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormGestionRoles form = new FormGestionRoles();
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAjoutRole_Load(object sender, EventArgs e)
        {

        }
    }
}
