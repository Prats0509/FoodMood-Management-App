using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project_OOP_2330506
{
    public partial class LoginForm : Form
    {
        // Default username : admin and password : Admin@123 for quick testing.
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLoginNow_Click_1(object sender, EventArgs e)
        {
            if (UserManager.AuthenticateUser(usernameTextBox.Text, passwordTextBox.Text))
            {
                MessageBox.Show("Login successful!");

                AfterLogin afterLoginForm = new AfterLogin(usernameTextBox.Text);
                afterLoginForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }
        }


        private void buttonGoBack_Click_1(object sender, EventArgs e)
        {

            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

       
    }
}
