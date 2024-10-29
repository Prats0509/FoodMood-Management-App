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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project_OOP_2330506
{
    public partial class RegistrationForm : Form
    {
        //1. Allergies : none / 1 or more allergies
        //2. Dietary Restrictions : any one of the option
        //3. Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character.
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            string fullname = textBoxFullName.Text;
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string retypePassword = textBoxRetypePassword.Text;


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || password != retypePassword)
            {
                MessageBox.Show("Invalid input or passwords do not match. Please Try to register again.");
                return;
            }

            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).{8,}$";

            if (!Regex.IsMatch(password, passwordPattern))
            {
                MessageBox.Show("Password must be at least 8 characters long and \n" +
                    "include at least one uppercase letter, one lowercase letter, one number, and one special character.");

                return;
            }

            if (UserManager.AuthenticateUser(username, password))
            {
                MessageBox.Show("A user with this username already exists.");
                return;
            }

            List<string> allergies = checkedListBox1.CheckedItems.OfType<string>().ToList();

            
            List<string> dietaryRestrictions = checkedListBox2.CheckedItems.OfType<string>().ToList();

            UserManager.RegisterUser(username, password, fullname, dietaryRestrictions, allergies );
            MessageBox.Show("Registration successful!");

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
