using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DaoGestionEmployes;
using System.Text.RegularExpressions;

namespace WindowsFormsGestionEmployes
{
    public partial class FormAjoutEmploye : Form
    {
        public FormAjoutEmploye()
        {
            InitializeComponent();
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            List<Role> listeRoles = gestionEmployes.findAllRoles();
            List<Ville> listeVilles = gestionEmployes.findAllVilles();
            List<Societe> listeSocietes = gestionEmployes.findAllSocietes();

            foreach (Role role in listeRoles)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = role.IdRole;
                item.Text = role.CodeRole;

                comboBoxRole.Items.Add(item);
            }
            foreach (Ville ville in listeVilles)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = ville.IdVille;
                item.Text = ville.CodeVille;

                comboBoxVille.Items.Add(item);
            }
            foreach (Societe societe in listeSocietes)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = societe.IdSociete;
                item.Text = societe.NomSociete;

                comboBoxSociete.Items.Add(item);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxMotPasse.Text != textBoxMotPasseConfirm.Text)
            {
                MessageBox.Show("Les mots de passe entrés ne sont pas identiques.", "Erreur lors de la création");
            }
            else
            {
                IGestionEmployes
                gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

                int IdRole = Convert.ToInt32((comboBoxRole.SelectedItem as ComboboxItem).Value);
                int IdVille = Convert.ToInt32((comboBoxVille.SelectedItem as ComboboxItem).Value);
                int IdSociete = Convert.ToInt32((comboBoxSociete.SelectedItem as ComboboxItem).Value);
                Utilisateur utilisateur = new Utilisateur(0, IdRole, textBoxIdentifiant.Text, textBoxMotPasse.Text, Convert.ToDateTime(dateTimePickerDebut.Text), Convert.ToDateTime(dateTimePickerFin.Text), textBoxPrenom.Text, textBoxNom.Text, IdSociete);
                Adresse adresse = new Adresse(0, textBoxNumeroRue.Text, textBoxNomRue.Text, textBoxCodePostal.Text, IdVille, 0);

                gestionEmployes.createUtilisateur(utilisateur);
                gestionEmployes.createAdresse(adresse);

                this.Close();
            }
        }

        private void FormAjoutEmploye_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormGestionEmployes form = new FormGestionEmployes();
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDateFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNomSociete_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAjoutEmploye_Load(object sender, EventArgs e)
        {

        }
    }
}
