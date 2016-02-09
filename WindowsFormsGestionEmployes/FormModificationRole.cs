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
    public partial class FormModificationRole : Form
    {
        public FormModificationRole()
        {
            InitializeComponent();
        }

        private void FormModificationRole_Load(object sender, EventArgs e)
        {

        }

        public void LoadInfo(int IdRole, string CodeRole, string DescriptionRole)
        {
            textBoxIdRole.Text = IdRole.ToString();
            textBoxCodeRole.Text = CodeRole;
            textBoxDescriptionRole.Text = DescriptionRole;
        }

        private void FormModificationRole_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormGestionRoles form = new FormGestionRoles();
            form.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            int IdRole = Convert.ToInt32(textBoxIdRole.Text);
            string CodeRole = textBoxCodeRole.Text;
            string DescriptionRole = textBoxDescriptionRole.Text;
            Role role = new Role(IdRole, CodeRole, DescriptionRole);

            gestionEmployes.updateRole(role);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
