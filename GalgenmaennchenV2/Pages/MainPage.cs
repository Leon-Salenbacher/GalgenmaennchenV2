using GalgenmaennchenV2.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalgenmaennchenV2.Pages
{
    /*
     * Author: Jonas Tran
     * Anmeldefenster
     */
    public partial class MainPage : Form
    {
        private UserAdapter userAdapter = new UserAdapter();

        public MainPage()
        {
            InitializeComponent();
            //Verdeckte Passworteingabe
            txtboxPasswort.PasswordChar = '*';
            txtboxPasswort.MaxLength = 12;
        }

        private void signIn()
        {
            //Verarbeitet Anmeldedaten und lädt anschließend Dashboard oder gibt ein Fehler

            if (userAdapter.proofSignIn(txtName.Text, txtboxPasswort.Text))
            {
                Dashboard dashboard = new Dashboard(userAdapter.getUserByName(txtName.Text).getId());
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password wrong");
            }
        }

  
        private void btnAnmelden_Click(object sender, EventArgs e)
        {
            signIn();
        }
    }
}
