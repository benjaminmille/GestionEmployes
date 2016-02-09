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
    public partial class FormGestionRoles : Form
    {
        public FormGestionRoles()
        {
            InitializeComponent();
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            dataGridRole.DataSource = gestionEmployes.findAllRoles();
        }

        private void addRole_Click(object sender, EventArgs e)
        {
            Form form = new FormAjoutRole();
            form.Show();
            this.Close();
        }

        private void btnModRole_Click(object sender, EventArgs e)
        {
            FormModificationRole form = new FormModificationRole();
            form.Show();
            if (this.dataGridRole.SelectedRows.Count > 0)
            {
                int selectedRowIndex = this.dataGridRole.SelectedRows[0].Index;
                int IdRole = Convert.ToInt32(this.dataGridRole.Rows[selectedRowIndex].Cells["IdRole"].Value);
                string CodeRole = this.dataGridRole.Rows[selectedRowIndex].Cells["CodeRole"].Value.ToString();
                string DescriptionRole = this.dataGridRole.Rows[selectedRowIndex].Cells["DescriptionRole"].Value.ToString();

                form.LoadInfo(IdRole, CodeRole, DescriptionRole);
            }
            this.Close();
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (this.dataGridRole.SelectedRows.Count > 0)
            {
                IGestionEmployes
                gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

                int selectedRowIndex = this.dataGridRole.SelectedRows[0].Index;
                int IdRole = Convert.ToInt32(this.dataGridRole.Rows[selectedRowIndex].Cells["IdRole"].Value);

                gestionEmployes.deleteRole(IdRole);
                dataGridRole.DataSource = gestionEmployes.findAllRoles();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            if (comboBoxAttribut.Text == "Code")
            {
                dataGridRole.DataSource = gestionEmployes.findRolesByCode(textBoxSearch.Text);
            }
            else if (comboBoxAttribut.Text == "Description")
            {
                dataGridRole.DataSource = gestionEmployes.findRolesByDescription(textBoxSearch.Text);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            textBoxSearch.Text = "";
            dataGridRole.DataSource = gestionEmployes.findAllRoles();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormGestionRole_Load(object sender, EventArgs e)
        {

        }
    }
}
