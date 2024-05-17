using DataAccessLibrary;
using DataAccessLibrary.Helpers;
using DataAccessLibrary.Models;
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
    public partial class IdentityAddItemForm : Form
    {
        IdentityForm fgrid;
        public string ActiveUserDB = LoginForm.ActiveUserDB;
        public IdentityAddItemForm(IdentityForm fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }

        private void IdentityFNAddName_Click(object sender, EventArgs e)
        {

        }

        private void IdentityAddLCNBox__TextChanged(object sender, EventArgs e)
        {

        }

        private void IdentityAddSubmitbtn_Click(object sender, EventArgs e)
        {
            // Add the Identity to the Database Identities Table
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            try
            {
                AddIdentity(sql, ActiveUserDB, IdentityAddNameBox.Texts, IdentityAddTittleBox.Texts,
                            IdentityFNAddBox.Texts, IdentityLNAddBox.Texts, IdentityUNAddTextBox.Texts,
                            CardAddCompanyBox.Texts, IdentityAddLCNBox.Texts, IdentityAddEmailBox.Texts,
                            IdentityAddPhoneBox.Texts, IdentityAddAddressBox.Texts, IdentityAddZipBox.Texts,
                            IdentityAddCountryBox.Texts, IdentityAddNidBox.Texts, IdentityAddPassportBox.Texts);
                
                MessageBox.Show("Identity Added Successfully");
                
                // Bind the DataGridView to the Identities Table
                BindGridView(sql);

                // Close the form and return DialogResult.OK to indicate success
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            Close();
        }

        // Binding the DataGridView to the Identities Table
        private void BindGridView(UsersDBCrud sql)
        {
            // Clear the DataGridView
            fgrid.IdentitydataGridView.Rows.Clear();

            // Get the Identities from the user's database's identities_table
            List<IdentitiesModel> identities = sql.GetIdentities(ActiveUserDB);

            // Add the Identities to the DataGridView
            foreach (IdentitiesModel identity in identities)
            {
                // Decrypt the License Number, Phone, Address, Zip, and NID No
                string decryptedLicenseNumber = AesHelper.Decrypt(identity.LicenseNumber);
                string decryptedPhone = AesHelper.Decrypt(identity.Phone);
                string decryptedAddress = AesHelper.Decrypt(identity.Address);
                string decryptedZip = AesHelper.Decrypt(identity.Zip);
                string decryptedNidNo = AesHelper.Decrypt(identity.NidNo);
                string decryptedPassportNo = AesHelper.Decrypt(identity.PassportNo);

                fgrid.IdentitydataGridView.Rows.Add(identity.Name, identity.Title, identity.FirstName, 
                    identity.LastName, identity.Username, identity.Company, decryptedLicenseNumber, 
                    identity.Email, decryptedPhone, decryptedAddress, decryptedZip, identity.Country, 
                    decryptedNidNo, decryptedPassportNo);
            }
        }


        // ---------------------------- DATABASE ---------------------------- //


        // Add a new Identity to the user's database's identities_table

        private static void AddIdentity(UsersDBCrud sql, string userDatabase, string name, string title,
             string firstName, string lastName, string username, string company, string licenseNumber,
             string email, string phone, string address, string zip, string country, string nidNo, 
             string passportNo)
        {
            // Encrypt the License Number, Phone, Address, Zip, and NID No
            byte[] encryptedLicenseNumber = AesHelper.Encrypt(licenseNumber);
            byte[] encryptedPhone = AesHelper.Encrypt(phone);
            byte[] encryptedAddress = AesHelper.Encrypt(address);
            byte[] encryptedZip = AesHelper.Encrypt(zip);
            byte[] encryptedNidNo = AesHelper.Encrypt(nidNo);
            byte[] encryptedPassportNo = AesHelper.Encrypt(passportNo);

            sql.AddIdentity(name, title, firstName, lastName, username, company, encryptedLicenseNumber,
                email, encryptedPhone, encryptedAddress, encryptedZip, country, encryptedNidNo,
                encryptedPassportNo, userDatabase);
        }


        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }
    }
}
