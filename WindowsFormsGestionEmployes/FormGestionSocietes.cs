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
    public partial class FormGestionSocietes : Form
    {
        public FormGestionSocietes()
        {
            InitializeComponent();
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            dataGridSocietes.DataSource = gestionEmployes.findAllSocietes();

            List<Utilisateur> listeUtilisateurs = gestionEmployes.findAllUtilisateurs();
            foreach (Utilisateur utilisateur in listeUtilisateurs)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = utilisateur.IdUtilisateur;
                item.Text = utilisateur.Prenom.Trim() + " " + utilisateur.Nom.Trim();

                comboBoxUtilisateur.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            if (comboBoxAttribut.Text == "Nom")
            {
                dataGridSocietes.DataSource = gestionEmployes.findSocietesByNom(textBoxSearch.Text);
            }
            else if (comboBoxAttribut.Text == "Numéro de siret")
            {
                dataGridSocietes.DataSource = gestionEmployes.findSocietesByNumeroSiret(textBoxSearch.Text);
            }
            else if (comboBoxAttribut.Text == "Utilisateur")
            {
                int IdUtilisateur = Convert.ToInt32((comboBoxUtilisateur.SelectedItem as ComboboxItem).Value);
                dataGridSocietes.DataSource = gestionEmployes.findSocietesByUtilisateur(IdUtilisateur);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            textBoxSearch.Text = "";
            dataGridSocietes.DataSource = gestionEmployes.findAllSocietes();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxAttribut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAttribut.Text == "Utilisateur")
            {
                comboBoxUtilisateur.Show();
            }
            else
            {
                comboBoxUtilisateur.Hide();
            }
        }

        private void addSociete_Click(object sender, EventArgs e)
        {
            FormAjoutSociete form = new FormAjoutSociete();
            this.Hide();
            form.Show();
        }

        private void btnModSociete_Click(object sender, EventArgs e)
        {
            FormModificationSociete form = new FormModificationSociete();
            if (this.dataGridSocietes.SelectedRows.Count > 0)
            {
                int selectedRowIndex = this.dataGridSocietes.SelectedRows[0].Index;
                int IdSociete = Convert.ToInt32(this.dataGridSocietes.Rows[selectedRowIndex].Cells["IdSociete"].Value);
                string NomSociete = this.dataGridSocietes.Rows[selectedRowIndex].Cells["NomSociete"].Value.ToString();
                string DescriptionSociete = this.dataGridSocietes.Rows[selectedRowIndex].Cells["DescriptionSociete"].Value.ToString();
                string NumeroSiret = this.dataGridSocietes.Rows[selectedRowIndex].Cells["NumeroSiret"].Value.ToString();

                form.LoadInfo(IdSociete, NomSociete, DescriptionSociete, NumeroSiret);
            }
            this.Hide();
            form.Show();
        }

        private void btnDeleteSociete_Click(object sender, EventArgs e)
        {
            if (this.dataGridSocietes.SelectedRows.Count > 0)
            {
                int selectedRowIndex = this.dataGridSocietes.SelectedRows[0].Index;
                int IdSociete = Convert.ToInt32(this.dataGridSocietes.Rows[selectedRowIndex].Cells["IdSociete"].Value);

                IGestionEmployes
                gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

                gestionEmployes.deleteSociete(IdSociete);
                dataGridSocietes.DataSource = gestionEmployes.findAllSocietes();
            }
        }

        private void FormGestionSocietes_Load(object sender, EventArgs e)
        {

        }
    }
}
