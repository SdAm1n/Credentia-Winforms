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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace Credentia_Winforms.Forms
{
    public partial class SecureNoteUpdateForm : Form
    {
        private DataGridViewRow selectedRow;
        private DataGridView dataGridView;
        public string ActiveUserDB = LoginForm.ActiveUserDB;

        public SecureNoteUpdateForm(DataGridViewRow selectedRow, DataGridView dataGridView)
        {
            InitializeComponent();

            //Select Row to update from datagrid
            this.selectedRow = selectedRow;
            this.dataGridView = dataGridView;

            // Populate your form fields with the data from the selected row
            SecureUpdateNoteNameBox.Texts = selectedRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            SecureNoteUpdateTextBox.Texts = selectedRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
        }

        private void SeureNoteUpdateItemPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SecureNoteUpdateSubmitbtn_Click(object sender, EventArgs e)
        {
            // get id from secure_notes_table by name
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            int id = GetId(sql, selectedRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString(), ActiveUserDB);

            try
            {
                // update the database
                UpdateSecureNote(sql, id, SecureUpdateNoteNameBox.Texts, SecureNoteUpdateTextBox.Texts, ActiveUserDB);
                MessageBox.Show("Secure Note Updated Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Update the selected row with the new values
            selectedRow.Cells["dataGridViewTextBoxColumn1"].Value = SecureUpdateNoteNameBox.Texts;
            selectedRow.Cells["dataGridViewTextBoxColumn2"].Value = SecureNoteUpdateTextBox.Texts;

            // Update the DataGridView in SecureNoteForm
            dataGridView.Refresh(); // Refresh to reflect changes

            // Close the form
            this.Close();
        }


        // --------------------------- DATABASE ---------------------------- //


        // Get id from secure_notes_table
        private static int GetId(UsersDBCrud sql, string name, string userDatabase)
        {
            // Get the id of the Secure Note from the user's database's secure_notes_table
            int id = sql.GetSecureNoteId(name, userDatabase);

            return id;
        }


        // Update a Secure Note in the user's database's secure_notes_table

        private static void UpdateSecureNote(UsersDBCrud sql, int id, string name, string securenote, string userDatabase)
        {
            // Update a Secure Note in the user's database's secure_notes_table
            byte[] encrypted = AesHelper.Encrypt(securenote);

            sql.UpdateSecureNote(id, name, encrypted, userDatabase);
        }


        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }
    }
}
