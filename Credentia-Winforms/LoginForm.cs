using DataAccessLibrary;
using DataAccessLibrary.Helpers;
using Microsoft.Extensions.Configuration;

namespace Credentia_Winforms
{
    public partial class LoginForm : Form
    {
        public static string? ActiveUser;
        public static string? ActiveUserDB;
        private string Password_Regex = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$";

        public LoginForm()
        {
            InitializeComponent();

            set_color();

        }

        private void set_color()
        {
            this.BackColor = Color.FromArgb(238, 246, 247); // Background Color
            DockPanel1.BackColor = Color.FromArgb(248, 251, 252); // DockPanel Color
            LoginBtn.BorderColor = Color.FromArgb(252, 150, 48); // Login Button Color
            LoginBtn.ForeColor = Color.FromArgb(252, 150, 48); // Login Button Text Color
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            //if (string.IsNullOrEmpty(UsernameTextBox.Text) == true)
            //{
            //    UsernameErrorProvider.SetError(UsernameTextBox, "Username is required");
            //}
            //else if (System.Text.RegularExpressions.Regex.IsMatch(PasswordTextBox.Texts, Password_Regex) == false)
            //{
            //    PasswordErrorProvider.SetError(PasswordTextBox, "Password must contain at least 8 characters, including UPPER & lowercase and numbers & special characters");
            //}

            // Login Logic
            string DATABASE_NAME = "users";

            // Create an instance of the MySqlCrud class
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={DATABASE_NAME};");

            string username = UsernameTextBox.Texts.ToLower();
            string masterPassword = PasswordTextBox.Texts;
            var storedMasterPassword = sql.GetMasterPassword(username);
            try
            {
                bool verified = MasterPasswordHelper.VerifyMasterPassword(masterPassword, storedMasterPassword);
                if (verified)
                {
                    ActiveUser = username;
                    ActiveUserDB = username + "_credentia_db";
                    HomeForm homeForm = new HomeForm();
                    this.Hide();
                    homeForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error Occured During Hash Verification");
            }


        }

        private void CreateAccLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.Show();
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Texts) == true)
            {

                UsernameErrorProvider.SetError(UsernameTextBox, "Username is required");
            }
            else
            {
                UsernameErrorProvider.Clear();
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTextBox.Texts) == true)
            {
                PasswordErrorProvider.SetError(PasswordTextBox, "Master Password is required");
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(PasswordTextBox.Texts, Password_Regex) == false)
                {
                    PasswordErrorProvider.SetError(PasswordTextBox, "Password must contain at least 8 characters, including UPPER & lowercase and numbers & special characters");
                }
                else
                {
                    PasswordErrorProvider.Clear();
                }

            }
        }

        private void ShowPasswordToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordToggle.Checked == true)
            {
                PasswordTextBox.PasswordChar = false;
            }
            else
            {
                PasswordTextBox.PasswordChar = true;
            }
        }



        // ----------------- DATABASE FUNCTIONS ----------------- //

        // Get Master Password from the Users database's user_table
        private static string GetMasterPassword(UsersDBCrud sql, string username)
        {
            return sql.GetMasterPassword(username);
        }

        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json");

            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);

            return output;
        }
    }
}
