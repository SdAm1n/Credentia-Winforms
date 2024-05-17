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

namespace Credentia_Winforms.Forms
{
    public partial class IdentityUpdateForm : Form
    {
        private DataGridViewRow selectedRow;
        private DataGridView dataGridView;
        public IdentityUpdateForm(DataGridViewRow selectedRow, DataGridView dataGridView)
        {
            InitializeComponent();
            //Select Row to update from datagrid
            this.selectedRow = selectedRow;
            this.dataGridView = dataGridView;

            // Populate your form fields with the data from the selected row
            IdentityUpNameBox.Texts = selectedRow.Cells["IdentityNameColumn"].Value.ToString();
            IdentityUpTittleBox.Texts = selectedRow.Cells["IdentityUserNameColumn"].Value.ToString();
            IdentityFNUpBox.Texts = selectedRow.Cells["IdentityTittleColumn"].Value.ToString();
            IdentityLNUpBox.Texts = selectedRow.Cells["IdentityFirstNColumn"].Value.ToString();
            IdentityUNUpTextBox.Texts = selectedRow.Cells["IdentityLastNColumn"].Value.ToString();
            IdentityUpCompanyBox.Texts = selectedRow.Cells["IdentityCompanyColumn"].Value.ToString();
            IdentityUpLCNBox.Texts = selectedRow.Cells["IdentityLNColumn"].Value.ToString();
            IdentityUpEmailBox.Texts = selectedRow.Cells["IdentityEmailColumn"].Value.ToString();
            IdentityUpPhoneBox.Texts = selectedRow.Cells["IdentityPhoneColumn"].Value.ToString();
            IdentityUpAddressBox.Texts = selectedRow.Cells["AddressColumn"].Value.ToString();
            IdentityUpZipBox.Texts = selectedRow.Cells["IdentityZipColumn"].Value.ToString();
            IdentityUpCountryBox.Texts = selectedRow.Cells["IdentityCountryColumn"].Value.ToString();
            IdentityNidUpBox.Texts = selectedRow.Cells["NIDColumn"].Value.ToString();
            IdentityPassportUpBox.Texts = selectedRow.Cells["PassportColumn"].Value.ToString();
        }

        private void IdentityUpSubmitbtn_Click(object sender, EventArgs e)
        {
            // Get the id of the Identity from the user's database's identities_table
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={LoginForm.ActiveUserDB};");
            int id = GetId(sql, selectedRow.Cells["IdentityNameColumn"].Value.ToString(), LoginForm.ActiveUserDB);

            try
            {
                // Update an Identity in the user's database's identities_table
                UpdateIdentity(sql, id, IdentityUpNameBox.Texts, IdentityUpTittleBox.Texts, IdentityFNUpBox.Texts,
                                       IdentityLNUpBox.Texts, IdentityUNUpTextBox.Texts, IdentityUpCompanyBox.Texts, 
                                       IdentityUpLCNBox.Texts,IdentityUpEmailBox.Texts, IdentityUpPhoneBox.Texts, 
                                       IdentityUpAddressBox.Texts, IdentityUpZipBox.Texts,IdentityUpCountryBox.Texts, 
                                       IdentityNidUpBox.Texts, IdentityPassportUpBox.Texts, LoginForm.ActiveUserDB);
                
                MessageBox.Show("Identity Updated Successfully");

                // Update the selected row with the new values
                selectedRow.Cells["IdentityNameColumn"].Value = IdentityUpNameBox.Texts;
                selectedRow.Cells["IdentityUserNameColumn"].Value = IdentityUpTittleBox.Texts;
                selectedRow.Cells["IdentityTittleColumn"].Value = IdentityFNUpBox.Texts;
                selectedRow.Cells["IdentityFirstNColumn"].Value = IdentityLNUpBox.Texts;
                selectedRow.Cells["IdentityLastNColumn"].Value = IdentityUNUpTextBox.Texts;
                selectedRow.Cells["IdentityCompanyColumn"].Value = IdentityUpCompanyBox.Texts;
                selectedRow.Cells["IdentityLNColumn"].Value = IdentityUpLCNBox.Texts;
                selectedRow.Cells["IdentityEmailColumn"].Value = IdentityUpEmailBox.Texts;
                selectedRow.Cells["IdentityPhoneColumn"].Value = IdentityUpPhoneBox.Texts;
                selectedRow.Cells["AddressColumn"].Value = IdentityUpAddressBox.Texts;
                selectedRow.Cells["IdentityZipColumn"].Value = IdentityUpZipBox.Texts;
                selectedRow.Cells["IdentityCountryColumn"].Value = IdentityUpCountryBox.Texts;
                selectedRow.Cells["NIDColumn"].Value = IdentityNidUpBox.Texts;
                selectedRow.Cells["PassportColumn"].Value = IdentityPassportUpBox.Texts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Update the DataGridView in Identities form
            dataGridView.Refresh(); // Refresh to reflect changes

            // Close the form
            this.Close();
        }


        // -----------------------------------DATABASE----------------------------------- //

        // Get id from identities_table
        private static int GetId(UsersDBCrud sql, string name, string userDatabase)
        {
            // Get the id of the Identity from the user's database's identities_table
            int id = sql.GetIdentityId(name, userDatabase);

            return id;
        }

        // Update an Identity in the user's database's identities_table

        private static void UpdateIdentity(UsersDBCrud sql, int id, string name, string title, string firstName, 
            string lastName, string username, string company, string licenseNumber, string email, string phone, 
            string address, string zip, string country, string nidNo, string passportNo, string userDatabase)
        {
            // Update an Identity in the user's database's identities_table
            byte[] encryptedLicenseNumber = AesHelper.Encrypt(licenseNumber);
            byte[] encryptedPhone = AesHelper.Encrypt(phone);
            byte[] encryptedAddress = AesHelper.Encrypt(address);
            byte[] encryptedZip = AesHelper.Encrypt(zip);
            byte[] encryptedNidNo = AesHelper.Encrypt(nidNo);
            byte[] encryptedPassportNo = AesHelper.Encrypt(passportNo);

            sql.UpdateIdentity(id, name, title, firstName, lastName, username, company, encryptedLicenseNumber,
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

