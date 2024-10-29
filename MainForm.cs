namespace Project_OOP_2330506
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Login
        private void buttonLogin_Click_1(object sender, EventArgs e)
        {

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();

        }

        //Registration
        private void buttonGuestRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();

        }

       
    }
}
