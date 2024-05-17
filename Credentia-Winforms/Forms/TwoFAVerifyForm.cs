using DataAccessLibrary.Helpers;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credentia_Winforms.Forms
{
    public partial class TwoFAVerifyForm : Form
    {
        
        public TwoFAVerifyForm()
        {
            InitializeComponent();
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            // get the secret key from the database
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={LoginForm.ActiveUserDB};");
            string secretKey = GetSecretKey(sql, LoginForm.ActiveUserDB);

            string userInputCode = CodeTextBox.Texts.Trim();
            bool isValid = TwoFAHelper.VerifyCode(secretKey, userInputCode);

            if (isValid)
            {
                MessageBox.Show("Code is valid!", "2FA Verification", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // redirect to home form
                HomeForm homeForm = new HomeForm();
                this.Hide();
                homeForm.Show();

            }
            else
            {
                MessageBox.Show("Invalid code. Please try again.", "2FA Verification", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // --------------------------------DATABASE-------------------------------- //

        // get secret key from the database
        private static string GetSecretKey(UsersDBCrud sql, string userDatabase)
        {
            byte[] encryptedSecretKey = sql.GetSecretKey(userDatabase);

            return AesHelper.Decrypt(encryptedSecretKey);
        }

        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }
    }
}
