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
using QRCoder;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Credentia_Winforms.Forms
{
    public partial class TwoFASetupForm : Form
    {
        private string _secretKey;

        public TwoFASetupForm()
        {
            InitializeComponent();
            setup2FA();
        }

        private void setup2FA()
        {
            _secretKey = TwoFAHelper.GenerateSecretKey();
            string issuer = "Credentia"; // Replace with your app's name
            string user = SignUpForm.createdUser; // Replace with the actual user's identifier
            string otpauthUrl = TwoFAHelper.GetOtpAuthUrl(issuer, user, _secretKey);



            // Generate the QR code
            using (var qrGenerator = new QRCodeGenerator())
            {
                var qrCodeData = qrGenerator.CreateQrCode(otpauthUrl, QRCodeGenerator.ECCLevel.Q);
                using (var qrCode = new QRCode(qrCodeData))
                {
                    var qrCodeImage = qrCode.GetGraphic(5);
                    QrCodePictureBox.Image = qrCodeImage;
                }
            }
            // setup key
            //testLabel.Text = $"Secret Key: {_secretKey}";
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {

            string userInputCode = CodeTextBox.Texts.Trim();
            bool isValid = TwoFAHelper.VerifyCode(_secretKey, userInputCode);

            if (isValid)
            {
                MessageBox.Show("Code is valid!", "2FA Verification", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                
                // save secret key to the database
                UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={SignUpForm.createdUserDB};");

                try
                {
                    AddSecretKey(sql, SignUpForm.createdUserDB, _secretKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // close this form and redirect to login form
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid code. Please try again.", "2FA Verification", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        // -------------------------------DATABASE-------------------------------- //

        // Add secret key to the database
        private void AddSecretKey(UsersDBCrud sql, string userDatabase, string secretKey)
        {
            byte[] encryptedSecretKey = AesHelper.Encrypt(secretKey);

            sql.AddSecretKey(userDatabase, encryptedSecretKey);
        }

        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }
    }
}
