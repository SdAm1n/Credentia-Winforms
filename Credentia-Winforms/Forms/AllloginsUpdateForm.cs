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
    public partial class AllloginsUpdateForm : Form
    {

        private DataGridViewRow selectedRow;
        private DataGridView dataGridView;
        public AllloginsUpdateForm(DataGridViewRow selectedRow, DataGridView dataGridView)
        {
            InitializeComponent();
            //Select Row to update from datagrid
            this.selectedRow = selectedRow;
            this.dataGridView = dataGridView;

            // Populate your form fields with the data from the selected row
            AllloginsUpdateNameBox.Texts = selectedRow.Cells["AllloginsNameColumn"].Value.ToString();
            AllloginsUpdateUsernameBox.Texts = selectedRow.Cells["AllloginsUsernameColumn"].Value.ToString();
            AllloginsUpdatePasswordBox.Texts = selectedRow.Cells["AllloginsPasswordColumn"].Value.ToString();
            AllloginsUpdateURlBox.Texts = selectedRow.Cells["AllloginsURLColumn"].Value.ToString();
           
        }

        private void AllloginsUpSubmitbtn_Click(object sender, EventArgs e)
        {
            // Get the id of the Login from the user's database's logins_table
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={LoginForm.ActiveUserDB};");
            int id = GetId(sql, selectedRow.Cells["AllloginsNameColumn"].Value.ToString(), selectedRow.Cells["AllloginsUsernameColumn"].Value.ToString(), LoginForm.ActiveUserDB);


            try
            {
                // Update the database
                UpdateLogin(sql, id, AllloginsUpdateNameBox.Texts, AllloginsUpdateUsernameBox.Texts, AllloginsUpdatePasswordBox.Texts, AllloginsUpdateURlBox.Texts, LoginForm.ActiveUserDB);
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Update the selected row with the new values
            selectedRow.Cells["AllloginsNameColumn"].Value = AllloginsUpdateNameBox.Texts;
            selectedRow.Cells["AllloginsUsernameColumn"].Value = AllloginsUpdateUsernameBox.Texts;
            selectedRow.Cells["AllloginsPasswordColumn"].Value = AllloginsUpdatePasswordBox.Texts;
            selectedRow.Cells["AllloginsURLColumn"].Value = AllloginsUpdateURlBox.Texts;
           

            // Update the DataGridView in SecureNoteForm
            dataGridView.Refresh(); // Refresh to reflect changes

            // Close the form
            this.Close();
        }


        //--------------------------DATABASE----------------------------------------//

        // Get id from logins_table
        private static int GetId(UsersDBCrud sql, string name, string username, string userDatabase)
        {
            // Get the id of the Login from the user's database's logins_table
            int id = sql.GetLoginId(name, username, userDatabase);

            return id;
        }


        // Update a Login in the logins_table
        private static void UpdateLogin(UsersDBCrud sql, int id, string name, string username, string password, string userURL, string userDatabase)
        {
            // Update a Login in the logins_table
            byte[] encrypted = AesHelper.Encrypt(password);

            sql.UpdateLogin(id, name, username, encrypted, userURL, userDatabase);
        }

        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }
    }
}
