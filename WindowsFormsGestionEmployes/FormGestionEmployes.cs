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
using System.IO;
using System.Diagnostics;
using sharpPDF;
using sharpPDF.Enumerators;
using System.Reflection;

namespace WindowsFormsGestionEmployes
{
    public partial class FormGestionEmployes : Form
    {
        public FormGestionEmployes()
        {
            InitializeComponent();
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            dataEmployes.DataSource = gestionEmployes.findAllUtilisateurs();

            List<Role> listeRoles = gestionEmployes.findAllRoles();
            foreach (Role role in listeRoles)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = role.IdRole;
                item.Text = role.CodeRole;

                comboBoxRole.Items.Add(item);
            }
        }

        private void buttonAddEmploye_Click(object sender, EventArgs e)
        {
            FormAjoutEmploye formAjoutEmploye = new FormAjoutEmploye();
            formAjoutEmploye.Show();
            this.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            if (this.dataEmployes.SelectedRows.Count > 0)
            {
                int selectedRowIndex = this.dataEmployes.SelectedRows[0].Index;
                int IdUtilisateur = Convert.ToInt32(this.dataEmployes.Rows[selectedRowIndex].Cells["IdUtilisateur"].Value);
                gestionEmployes.deleteUtilisateur(IdUtilisateur);
                dataEmployes.DataSource = gestionEmployes.findAllUtilisateurs();
            }
        }

        private void btnModUser_Click(object sender, EventArgs e)
        {
            if (this.dataEmployes.SelectedRows.Count > 0)
            {
                FormModificationEmploye form = new FormModificationEmploye();
                int selectedRowIndex = this.dataEmployes.SelectedRows[0].Index;
                int IdUtilisateur = Convert.ToInt32(this.dataEmployes.Rows[selectedRowIndex].Cells["IdUtilisateur"].Value);
                form.LoadInfo(IdUtilisateur);
            }
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();

            // Si un dossier a été choisi
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog.SelectedPath;
                StreamWriter fluxInfos = null;

                try
                {
                    // Création du fichier XML
                    using (fluxInfos = new StreamWriter(folderName + "\\exportEmployes.xml"))
                    {
                        fluxInfos.WriteLine("<employes>\n");
                        int rows = 0;
                        // Pour chaque ligne dans la grille des employés
                        foreach (DataGridViewRow row in dataEmployes.Rows)
                        {
                            fluxInfos.WriteLine("\t<employe>\n");
                            // Pour chaque cellule de la ligne
                            for (int i = 0; i < dataEmployes.Rows[rows].Cells.Count; i++)
                            {
                                string element = dataEmployes.Columns[i].Name;
                                string valeur = dataEmployes.Rows[rows].Cells[i].Value.ToString().Trim();

                                fluxInfos.WriteLine("\t\t<" + element + ">" + valeur + "</" + element + ">");
                            }
                            fluxInfos.WriteLine("\t</employe>\n");
                            rows ++;
                        }
                        fluxInfos.WriteLine("</employes>\n");
                    }
                    // Fin du fichier XML

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result2;
                    result2 = MessageBox.Show("Le fichier XML à été créé avec succès. Voulez-vous ouvrir le fichier avec Excel ?", 
                                              "Génération fichier XML", buttons);

                    // Si l'utilisateur choisi de lancer le fichier XML avec Excel
                    if (result2 == System.Windows.Forms.DialogResult.Yes)
                    {
                        string programFiles = Environment.GetEnvironmentVariable("ProgramFiles");
                        const string excelRelativePath = @"Microsoft Office\Office15\excel.exe";
                        string excel = Path.Combine(programFiles, excelRelativePath);
                        string xmlFile = folderName + "\\exportEmployes.xml";

                        ProcessStartInfo startInfo = new ProcessStartInfo(excel, xmlFile);
                        // Ouverture du fichier avec Excel
                        Process.Start(startInfo);
                    }
                }
                // Quand il y a une erreur
                catch (Exception exception)
                {
                    MessageBox.Show("L'erreur suivante s'est produite : " + exception.Message + "", "Erreur lors de l'éxécution");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAttribut.Text == "Rôle")
            {
                comboBoxStatut.Hide();
                comboBoxRole.Show();
            }
            else if (comboBoxAttribut.Text == "Statut")
            {
                comboBoxRole.Hide();
                comboBoxStatut.Show();
            }
            else
            {
                comboBoxRole.Hide();
                comboBoxStatut.Hide();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            switch (comboBoxAttribut.Text)
            {
                case "Nom":
                    dataEmployes.DataSource = gestionEmployes.findUsersByNom(textBoxSearch.Text);
                    break;

                case "Prénom":
                    dataEmployes.DataSource = gestionEmployes.findUsersByPrenom(textBoxSearch.Text);
                    break;

                case "Rôle":
                    int IdRole = Convert.ToInt32((comboBoxRole.SelectedItem as ComboboxItem).Value);
                    dataEmployes.DataSource = gestionEmployes.findUsersByRole(IdRole);
                    break;

                case "Date de début":
                    dataEmployes.DataSource = gestionEmployes.findUsersByDateDebut(textBoxSearch.Text);
                    break;

                case "Date de fin":
                    dataEmployes.DataSource = gestionEmployes.findUsersByDateFin(textBoxSearch.Text);
                    break;

                case "Statut":
                    bool status = Convert.ToBoolean(comboBoxStatut.Text);
                    dataEmployes.DataSource = gestionEmployes.findUsersByStatus(status);
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            IGestionEmployes
            gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

            dataEmployes.DataSource = gestionEmployes.findAllUtilisateurs();
            textBoxSearch.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            // Si un employé est sélectionné
            if (this.dataEmployes.SelectedRows.Count > 0)
            {
                FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    IGestionEmployes
                    gestionEmployes = GestionEmployesBuilderClassFactory.getInterface();

                    string folderName = folderBrowserDialog.SelectedPath;
                    int selectedRowIndex = this.dataEmployes.SelectedRows[0].Index;
                    int IdUtilisateur = Convert.ToInt32(this.dataEmployes.Rows[selectedRowIndex].Cells["IdUtilisateur"].Value);
                    object[] tabInfoUser = gestionEmployes.findUtilisateur(IdUtilisateur);
                    Utilisateur utilisateur = (Utilisateur)tabInfoUser[0];
                    Adresse adresse = (Adresse)tabInfoUser[1];
                    Societe societe = (Societe)tabInfoUser[2];
                    Role role = (Role)tabInfoUser[3];
                    Ville ville = (Ville)tabInfoUser[4];
                    FormModificationEmploye form = new FormModificationEmploye();

                    // Génération du fichier PDF
                    try
                    {
                        pdfDocument myDoc = new pdfDocument("Sample Application", "Me", false);
                        pdfPage myFirstPage = myDoc.addPage(700, 700);
                        myFirstPage.addText("Fiche d'information - " + utilisateur.Prenom.Trim() + " " + utilisateur.Nom.Trim(), 
                                            100, 630, predefinedFont.csHelvetica, 30, new pdfColor(predefinedColor.csBlack));
                        /*Table's creation*/
                        pdfTable myTable = new pdfTable();
                        //Set table's border
                        myTable.borderSize = 0;
                        myTable.borderColor = new pdfColor(predefinedColor.csBlack);
                        /*Create table's header*/
                        myTable.tableHeader.addColumn(new pdfTableColumn("Information", predefinedAlignment.csLeft, 150));
                        myTable.tableHeader.addColumn(new pdfTableColumn("Valeur", predefinedAlignment.csCenter, 250));

                        /*Create table's rows*/
                        pdfTableRow myRow = myTable.createRow();
                        myRow[0].columnValue = "Prénom";
                        myRow[1].columnValue = utilisateur.Prenom.Trim();
                        myTable.addRow(myRow);

                        myRow = myTable.createRow();
                        myRow[0].columnValue = "Nom";
                        myRow[1].columnValue = utilisateur.Nom.Trim();
                        myTable.addRow(myRow);

                        myRow = myTable.createRow();
                        myRow[0].columnValue = "Identifiant";
                        myRow[1].columnValue = utilisateur.Identifiant;
                        myTable.addRow(myRow);

                        myRow = myTable.createRow();
                        myRow[0].columnValue = "Mot de passe";
                        myRow[1].columnValue = utilisateur.MotPasse;
                        myTable.addRow(myRow);

                        myRow = myTable.createRow();
                        myRow[0].columnValue = "Rôle";
                        myRow[1].columnValue = role.CodeRole;
                        myTable.addRow(myRow);

                        myRow = myTable.createRow();
                        myRow[0].columnValue = "Date de début";
                        myRow[1].columnValue = utilisateur.DateDebut.ToShortDateString();
                        myTable.addRow(myRow);

                        myRow = myTable.createRow();
                        myRow[0].columnValue = "Date de fin";
                        myRow[1].columnValue = utilisateur.DateFin.ToShortDateString();
                        myTable.addRow(myRow);

                        myRow = myTable.createRow();
                        myRow[0].columnValue = "Adresse";
                        myRow[1].columnValue = adresse.NumeroRue + " " + adresse.NomRue + ", " + adresse.CodePostal + " " + 
                                               ville.CodeVille;
                        myTable.addRow(myRow);

                        myRow = myTable.createRow();
                        myRow[0].columnValue = "Nom de société";
                        myRow[1].columnValue = societe.NomSociete;
                        myTable.addRow(myRow);

                        myRow = myTable.createRow();
                        myRow[0].columnValue = "Description de société";
                        myRow[1].columnValue = societe.DescriptionSociete;
                        myTable.addRow(myRow);

                        myRow = myTable.createRow();
                        myRow[0].columnValue = "Numéro de siret";
                        myRow[1].columnValue = societe.NumeroSiret;
                        myTable.addRow(myRow);

                        /*Set Header's Style*/
                        myTable.tableHeaderStyle = new pdfTableRowStyle(predefinedFont.csHelveticaBold, 12, 
                                                   new pdfColor(predefinedColor.csWhite), new pdfColor(predefinedColor.csRed));
                        /*Set Row's Style*/
                        myTable.rowStyle = new pdfTableRowStyle(predefinedFont.csHelvetica, 10, new pdfColor(predefinedColor.csBlack), 
                                           new pdfColor(predefinedColor.csWhite));
                        /*Set Alternate Row's Style*/
                        myTable.alternateRowStyle = new pdfTableRowStyle(predefinedFont.csHelvetica, 10, 
                                                    new pdfColor(predefinedColor.csBlack), new pdfColor(predefinedColor.csLightGray));
                        /*Set Cellpadding*/
                        myTable.cellpadding = 10;
                        /*Put the table on the page object*/
                        myFirstPage.addTable(myTable, 150, 550);
                        myTable = null;
                        myDoc.createPDF(folderName + "\\FicheInformation.pdf");
                        MessageBox.Show("Le fichier PDF a bien été créé", "Génération de PDF");
                        Process.Start(folderName + "\\FicheInformation.pdf");
                        // Fin de génération du fichier PDF
                    }
                    // Quand il y a une erreur
                    catch (Exception exception)
                    {
                        MessageBox.Show("L'erreur suivante s'est produite : " + exception.Message + "", "Erreur lors de l'éxécution");
                    }
                }
            }
            // Si aucun employé n'est sélectionné
            else
            {
                MessageBox.Show("Sélectionnez un utilisateur.", "Génération fichier PDF");
            }
        }

        private void dataEmployes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormGestionEmployes_Load(object sender, EventArgs e)
        {

        }
    }
}
