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
using System.Text.RegularExpressions;

namespace WindowsFormsGestionEmployes
{
    public partial class FormModificationEmploye : Form
    {
        int IdUtilisateurMod = 0;

        public FormModificationEmploye()
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

        public void LoadInfo(int IdUtilisateur)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            IdUtilisateurMod = IdUtilisateur;
            object[] tabInfoUser = gestionEmployes.findUtilisateur(IdUtilisateur);
            Utilisateur utilisateur = (Utilisateur)tabInfoUser[0];
            Adresse adresse = (Adresse)tabInfoUser[1];

            comboBoxRole.SelectedIndex = utilisateur.IdRole - 1;
            textBoxPrenom.Text = utilisateur.Prenom.Trim();
            textBoxNom.Text = utilisateur.Nom.Trim();
            textBoxIdentifiant.Text = utilisateur.Identifiant;
            textBoxMotPasse.Text = utilisateur.MotPasse;
            textBoxMotPasseConfirm.Text = utilisateur.MotPasse;
            dateTimePickerDebut.Text = utilisateur.DateDebut.ToString();
            dateTimePickerFin.Text = utilisateur.DateFin.ToString();
            textBoxNumeroRue.Text = adresse.NumeroRue;
            textBoxNomRue.Text = adresse.NomRue;
            textBoxCodePostal.Text = adresse.CodePostal;
            comboBoxVille.SelectedIndex = adresse.IdVille - 1;
            textBoxNumeroRue.Text = adresse.NumeroRue;
            comboBoxSociete.SelectedIndex = utilisateur.IdSociete - 1;

            this.Show();
        }

        /*private bool ValidMail(string adresse)
        {
            System.Text.RegularExpressions.Regex myRegex = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");
            //([\w]+) ==> caractère alphanumérique apparaissant une fois ou plus 
            return myRegex.IsMatch(adresse); // retourne true ou false selon la vérification
        }*/

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxMotPasse.Text == textBoxMotPasseConfirm.Text)
            {
                /*Regex myRegex = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");*/
                /*myRegex.IsMatch(textBoxMotPasse.Text);*/
                /*bool mdpOk = ValidMail("benjamin.mille@hotmail.fr");*/
                
                /*if (mdpOk)
                {*/
                IGestionEmployes
                gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

                int IdRole = Convert.ToInt32((comboBoxRole.SelectedItem as ComboboxItem).Value);
                int IdVille = Convert.ToInt32((comboBoxVille.SelectedItem as ComboboxItem).Value);
                int IdSociete = Convert.ToInt32((comboBoxSociete.SelectedItem as ComboboxItem).Value);
                Utilisateur utilisateur = new Utilisateur(IdUtilisateurMod, IdRole, textBoxIdentifiant.Text, textBoxMotPasse.Text, Convert.ToDateTime(dateTimePickerDebut.Text), Convert.ToDateTime(dateTimePickerFin.Text), textBoxPrenom.Text, textBoxNom.Text, IdSociete);
                Adresse adresse = new Adresse(0, textBoxNumeroRue.Text, textBoxNomRue.Text, textBoxCodePostal.Text, IdVille, IdUtilisateurMod);

                gestionEmployes.updateUtilisateur(utilisateur);
                gestionEmployes.updateAdresse(adresse);

                this.Close();
                /*}
                else
                {
                    MessageBox.Show("Le mot de passe doit:\n- Contenir entre 8 et 15 caractères.\n- Contenir au moins une majuscule.\n- Contenir au moins un chiffre.", "Erreur lors de la création");
                }*/
            }
            else
            {
                MessageBox.Show("Les mots de passe entrés ne sont pas identiques.", "Erreur lors de la création");
            }
        }

        private void FormModificationEmploye_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            FormGestionEmployes form = new FormGestionEmployes();
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModificationEmploye_Load(object sender, EventArgs e)
        {

        }
    }
}
