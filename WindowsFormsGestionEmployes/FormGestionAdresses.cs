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
    public partial class FormGestionAdresses : Form
    {
        public FormGestionAdresses()
        {
            InitializeComponent();
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            dataGridAdresses.DataSource = gestionEmployes.findAllAdresses();

            List<Ville> listeVilles = gestionEmployes.findAllVilles();
            foreach (Ville ville in listeVilles)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = ville.IdVille;
                item.Text = ville.CodeVille;

                comboBoxVille.Items.Add(item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxAttribut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAttribut.Text == "Ville")
            {
                comboBoxVille.Show();
            }
            else
            {
                comboBoxVille.Hide();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            if (comboBoxAttribut.Text == "Numéro de rue")
            {
                dataGridAdresses.DataSource = gestionEmployes.findAdressesByNumeroRue(textBoxSearch.Text);
            }
            else if (comboBoxAttribut.Text == "Nom de rue")
            {
                dataGridAdresses.DataSource = gestionEmployes.findAdressesByNomRue(textBoxSearch.Text);
            }
            else if (comboBoxAttribut.Text == "Code postal")
            {
                dataGridAdresses.DataSource = gestionEmployes.findAdressesByCodePostal(textBoxSearch.Text);
            }
            else if (comboBoxAttribut.Text == "Ville")
            {
                int IdVille = Convert.ToInt32((comboBoxVille.SelectedItem as ComboboxItem).Value);
                dataGridAdresses.DataSource = gestionEmployes.findAdressesByVille(IdVille);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            textBoxSearch.Text = "";
            dataGridAdresses.DataSource = gestionEmployes.findAllAdresses();
        }

        private void addAdresse_Click(object sender, EventArgs e)
        {
            FormAjoutEmploye form = new FormAjoutEmploye();
            this.Hide();
            form.Show();
        }

        private void btnModAdresse_Click(object sender, EventArgs e)
        {
            FormModificationEmploye form = new FormModificationEmploye();
            if (this.dataGridAdresses.SelectedRows.Count > 0)
            {
                int selectedRowIndex = this.dataGridAdresses.SelectedRows[0].Index;
                int IdUtilisateur = Convert.ToInt32(this.dataGridAdresses.Rows[selectedRowIndex].Cells["IdUtilisateur"].Value);
                form.LoadInfo(IdUtilisateur);
            }
            this.Hide();
            form.Show();
        }

        private void FormGestionAdresses_Load(object sender, EventArgs e)
        {
        }
    }
}
