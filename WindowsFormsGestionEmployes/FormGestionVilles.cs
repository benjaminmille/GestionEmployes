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
    public partial class FormGestionVilles : Form
    {
        public FormGestionVilles()
        {
            InitializeComponent();
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();
            dataGridVilles.DataSource = gestionEmployes.findAllVilles();
        }

        private void btnAddVille_Click(object sender, EventArgs e)
        {
            Form form = new FormAjoutVille();
            this.Hide();
            form.Show();
        }

        private void btnModVille_Click(object sender, EventArgs e)
        {
            FormModificationVille form = new FormModificationVille();
            form.Show();
            if (this.dataGridVilles.SelectedRows.Count > 0)
            {
                int selectedRowIndex = this.dataGridVilles.SelectedRows[0].Index;
                int IdVille = Convert.ToInt32(this.dataGridVilles.Rows[selectedRowIndex].Cells["IdVille"].Value);
                string CodeVille = this.dataGridVilles.Rows[selectedRowIndex].Cells["CodeVille"].Value.ToString();
                string DescriptionVille = this.dataGridVilles.Rows[selectedRowIndex].Cells["DescriptionVille"].Value.ToString();
                form.LoadInfo(IdVille, CodeVille, DescriptionVille);
            }
            this.Close();
        }

        private void btnDeleteVille_Click(object sender, EventArgs e)
        {
            if (this.dataGridVilles.SelectedRows.Count > 0)
            {
                int selectedRowIndex = this.dataGridVilles.SelectedRows[0].Index;
                int idVille = Convert.ToInt32(this.dataGridVilles.Rows[selectedRowIndex].Cells["IdVille"].Value);
                IGestionEmployes
                gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();
                gestionEmployes.deleteVille(idVille);
                dataGridVilles.DataSource = gestionEmployes.findAllVilles();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            if (comboBoxAttribut.Text == "Code")
            {
                dataGridVilles.DataSource = gestionEmployes.findVillesByCode(textBoxSearch.Text);
            }
            else if (comboBoxAttribut.Text == "Description")
            {
                dataGridVilles.DataSource = gestionEmployes.findVillesByDescription(textBoxSearch.Text);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();
            dataGridVilles.DataSource = gestionEmployes.findAllVilles();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridVilles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormGestionVille_Load(object sender, EventArgs e)
        {
        }
    }
}
