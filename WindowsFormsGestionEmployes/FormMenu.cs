using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGestionEmployes
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonEmployes_Click(object sender, EventArgs e)
        {
            FormGestionEmployes form = new FormGestionEmployes();
            form.Show();
        }

        private void buttonEntites_Click(object sender, EventArgs e)
        {
            FormGestionRoles form = new FormGestionRoles();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGestionVilles form = new FormGestionVilles();
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormAuthentification form = new FormAuthentification();
            this.Hide();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormGestionAdresses form = new FormGestionAdresses();
            form.Show();
        }

        private void buttonGestionSocietes_Click(object sender, EventArgs e)
        {
            FormGestionSocietes form = new FormGestionSocietes();
            form.Show();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
