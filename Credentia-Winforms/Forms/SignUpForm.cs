using DataAccessLibrary.Helpers;
using DataAccessLibrary;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credentia_Winforms
{
    public partial class SignUpForm : Form
    {
        
        private string Password_Regex = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        private string email_regex = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        public SignUpForm()
        {
            InitializeComponent();
            set_color();
        }

        private void set_color()
        {
            this.BackColor = Color.FromArgb(238, 246, 247); // Background Color
            DockPanel1.BackColor = Color.FromArgb(248, 251, 252); // DockPanel Color
            CancelBtn.BorderColor = Color.FromArgb(252, 150, 48); // Login Button Color
            CancelBtn.ForeColor = Color.FromArgb(252, 150, 48); // Login Button Text Color
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string DATABASE_NAME = "users";


            // Create an instance of the MySqlCrud class
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={DATABASE_NAME};");


            string username = UsernameTextBox.Texts.ToLower();
            string masterPassword = PasswordTextBox.Texts;
            string email = EmailTextBox.Texts;

            try
            {
                // check to see if any fields are empty
                if (!(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(masterPassword) || string.IsNullOrEmpty(email)))
                {

                    MessageBox.Show("User Created Successfully.", "Sign Up Completed", MessageBoxButtons.OK);
                    // Create a new user in the Users database's user_table
                    CreateUser(sql, username, masterPassword, email);


                    // Redirect to the Login Form
                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.");
                }
            }
            catch
            {
                MessageBox.Show("Error Occured.");
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString());

            // Create Users database if doesn't exist
           CreateUsersDB(sql);
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

        private void ConfirmPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ConfirmPasswordTextBox.Texts) == true)
            {
                ConfirmPasswordErrorProvider.SetError(ConfirmPasswordTextBox, "Confirm Password is required");
            }
            else
            {
                if(ConfirmPasswordTextBox.Texts != PasswordTextBox.Texts)
                {
                    ConfirmPasswordErrorProvider.SetError(ConfirmPasswordTextBox, "Password does not match");
                }
                else
                {
                    ConfirmPasswordErrorProvider.Clear();
                }
            }
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(EmailTextBox.Texts) == true)
            {
                EmailErrorProvider.SetError(EmailTextBox, "Email is required");
            }
            else
            {
                if(System.Text.RegularExpressions.Regex.IsMatch(EmailTextBox.Texts, email_regex) == false)
                {
                    EmailErrorProvider.SetError(EmailTextBox, "Email is not valid");
                }
                else
                {
                    EmailErrorProvider.Clear();
                }
            }
        }


        // ------------------ DATABASE ------------------ //

        // create users db and user_table if doesn't exist
        private static void CreateUsersDB(UsersDBCrud sql)
        {
            sql.CreateUsersDB();
        }


        // Create a new user database
        private static void CreateUserDB(UsersDBCrud sql, string userDatabase)
        {
            // Create a new user database
            sql.CreateUserDatabase(userDatabase);
            CreateUserTables(userDatabase);
        }

        // Create Tables for the user in their particular newly created database
        private static void CreateUserTables(string userDatabase)
        {
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={userDatabase};");

            // Create Tables for the user in their particular newly created database
            sql.CreateTables(userDatabase);
        }


        // Create a new user in the Users database's user_table
        private static void CreateUser(UsersDBCrud sql, string username, string masterPassword, string email)
        {

            var hashedMasterPassword = MasterPasswordHelper.HashMasterPassword(masterPassword);
 
            string userDatabase = $"{username}_credentia_db";

            sql.CreateUser(username, hashedMasterPassword, email, userDatabase);

            CreateUserDB(sql, userDatabase);
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
