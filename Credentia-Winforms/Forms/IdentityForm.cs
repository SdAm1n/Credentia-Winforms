using Credentia_Winforms.Forms;
using DataAccessLibrary.Helpers;
using DataAccessLibrary.Models;
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
using static Dapper.SqlMapper;

namespace Credentia_Winforms
{
    public partial class IdentityForm : Form
    {
        public string ActiveUserDB = LoginForm.ActiveUserDB;

        public IdentityForm()
        {
            InitializeComponent();

            // Bind the DataGridView to the Identities Table on Form Load
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            BindGridView(sql);

            IdentityUpdateVisibility();
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void IdentityAddBtn_Click(object sender, EventArgs e)
        {
            IdentityAddItemForm identity = new IdentityAddItemForm(this);
            identity.Show();
            identity.FormClosed += identity_FormClosed;
        }
        private void identity_FormClosed(object sender, FormClosedEventArgs e)
        {
            IdentityUpdateVisibility();

            // Select the last row (newly added row) after the Add Form is closed
            IdentitydataGridView.ClearSelection();
            int lastIndex = IdentitydataGridView.Rows.Count - 1;
            if (lastIndex >= 0)
            {
                IdentitydataGridView.Rows[lastIndex].Selected = true;
                IdentitydataGridView.FirstDisplayedScrollingRowIndex = lastIndex;
            }
        }

        private void IdentityEditbtn_Click(object sender, EventArgs e)
        {
            // Open Update Form to Change the value of selected row
            int rowIndex = IdentitydataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = IdentitydataGridView.Rows[rowIndex];

            IdentityUpdateForm identityUpdateForm = new IdentityUpdateForm(selectedRow, IdentitydataGridView);
            identityUpdateForm.Show();
        }
        private void IdentityDeletebtn_Click(object sender, EventArgs e)
        {
            // Selected row deleted
            int rowIndex = IdentitydataGridView.CurrentCell.RowIndex;

            // Get the selected row
            DataGridViewRow selectedRow = IdentitydataGridView.Rows[rowIndex];

            // get id from identities_table by name
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            int id = GetId(sql, selectedRow.Cells["IdentityNameColumn"].Value.ToString(), ActiveUserDB);

            // Delete the Identity from the user's database's identities_table
            try
            {
                DeleteIdentity(sql, id, ActiveUserDB);

                MessageBox.Show("Identity Deleted Successfully");

                IdentitydataGridView.Rows.RemoveAt(rowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            IdentityUpdateVisibility();
        }
        private void IdentityUpdateVisibility()
        {
            if (IdentitydataGridView.Rows.Count == 0)
            {
                // Hide DataGridView and buttons
                IdentitydataGridView.Visible = false;
                IdentityEditbtn.Visible = false;
                IdentityDeletebtn.Visible = false;

                // Show message indicating no items available
                IdentityNoItems.Visible = true;
            }
            else
            {
                // Show DataGridView and buttons
                IdentitydataGridView.Visible = true;
                IdentityEditbtn.Visible = true;
                IdentityDeletebtn.Visible = true;

                // Hide message indicating no items available
                IdentityNoItems.Visible = false;
            }
        }
        private void IdentitydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = IdentitySearchBox.Texts.Trim();
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            BindGridView(sql, searchQuery);
        }

        // Binding the DataGridView to the Identities Table
        private void BindGridView(UsersDBCrud sql, string searchQuery = "")
        {
            // Clear the DataGridView
            IdentitydataGridView.Rows.Clear();

            if (string.IsNullOrEmpty(searchQuery))
            {
                try
                {
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

                        IdentitydataGridView.Rows.Add(identity.Name, identity.Title, identity.FirstName,
                            identity.LastName, identity.Username, identity.Company, decryptedLicenseNumber,
                            identity.Email, decryptedPhone, decryptedAddress, decryptedZip, identity.Country,
                            decryptedNidNo, decryptedPassportNo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                List<IdentitiesModel> search = sql.SearchIdentities(searchQuery, ActiveUserDB);

                try
                {
                    foreach (IdentitiesModel identity in search)
                    {
                        // Decrypt the License Number, Phone, Address, Zip, and NID No
                        string decryptedLicenseNumber = AesHelper.Decrypt(identity.LicenseNumber);
                        string decryptedPhone = AesHelper.Decrypt(identity.Phone);
                        string decryptedAddress = AesHelper.Decrypt(identity.Address);
                        string decryptedZip = AesHelper.Decrypt(identity.Zip);
                        string decryptedNidNo = AesHelper.Decrypt(identity.NidNo);
                        string decryptedPassportNo = AesHelper.Decrypt(identity.PassportNo);

                        IdentitydataGridView.Rows.Add(identity.Name, identity.Title, identity.FirstName,
                                                      identity.LastName, identity.Username, identity.Company, 
                                                      decryptedLicenseNumber, identity.Email, decryptedPhone, 
                                                      decryptedAddress, decryptedZip, identity.Country,
                                                      decryptedNidNo, decryptedPassportNo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }


        // ---------------------------- DATABASE ---------------------------- //

        // Get id from identities_table
        private static int GetId(UsersDBCrud sql, string name, string userDatabase)
        {
            // Get the id of the Identity from the user's database's identities_table
            int id = sql.GetIdentityId(name, userDatabase);

            return id;
        }

        // Delete an Identity from the user's database's identities_table
        private static void DeleteIdentity(UsersDBCrud sql, int id, string userDatabase)
        {
            sql.DeleteIdentity(id, userDatabase);
        }

        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }

    }
}
