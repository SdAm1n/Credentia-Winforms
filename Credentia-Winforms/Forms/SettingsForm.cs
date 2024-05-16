using Credentia_Winforms.CustomControls;
using DataAccessLibrary;
using DataAccessLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Credentia_Winforms
{
    public partial class SettingsForm : Form
    {


        public SettingsForm()
        {
            InitializeComponent();

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ActiveUsernameLabel.Text = LoginForm.ActiveUser;

        }

        private void SettingsConfirmbtn_Click(object sender, EventArgs e)
        {
            string currentPassword = CurrentPasswordTextBox.Texts;
            string newPassword = NewPasswordTextBox.Texts;
            string confirmPassword = ConfirmPasswordTextBox.Texts;

            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + "Database=users;");

            // Change Master Password
            try
            {
                ChangePassword(sql, currentPassword, newPassword, confirmPassword, LoginForm.ActiveUser);

                // Close all the forms and open the login form
                // Todo: Close all forms

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CurrentPasswordTextBox.Texts = "";
            NewPasswordTextBox.Texts = "";
            ConfirmPasswordTextBox.Texts = "";
        }

        private void SettingsDeletebtn_Click(object sender, EventArgs e)
        {
            string MasterPassword = DeleteMPTextBox.Texts;

            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + "Database=users;");

            // Verify Master Password
            try
            {
                var storedMasterPassword = sql.GetMasterPassword(LoginForm.ActiveUser);
                bool verified = MasterPasswordHelper
                                .VerifyMasterPassword(MasterPassword, storedMasterPassword);

                if (verified)
                {
                    // Delete the user
                    DeleteUser(sql, LoginForm.ActiveUser, storedMasterPassword);

                    // Close all the forms and open the login form
                    MessageBox.Show("User Deleted Successfully. Close The Application");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Incorrect Master Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ----------------- DATABASE -----------------//


        // Delete a user from the users database's user_table and their database
        private static void DeleteUser(UsersDBCrud sql, string username, string MasterPassword)
        {
            sql.DeleteUser(username, MasterPassword);
            DeleteUserDB($"{username}_credentia_db");
        }

        // Delete a user database
        private static void DeleteUserDB(string userDatabase)
        {
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + "Database=users;");

            // Delete a user database
            sql.DeleteDatabase(userDatabase);
        }

        // Change Master Password
        void ChangePassword(UsersDBCrud sql, string currentPassword, string newPassword, string confirmPassword, string ActiveUser)
        {
            var storedMasterPassword = sql.GetMasterPassword(LoginForm.ActiveUser);
            bool verified = MasterPasswordHelper
                            .VerifyMasterPassword(currentPassword, storedMasterPassword);

            if (verified)
            {
                // change the password
                if (newPassword == confirmPassword)
                {
                    var newMasterPassword = MasterPasswordHelper
                                            .HashMasterPassword(newPassword);
                    sql.UpdateMasterPassword(ActiveUser, newMasterPassword);
                    MessageBox.Show("Master Password Changed Successfully");
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }


        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }

    }
}
