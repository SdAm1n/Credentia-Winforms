using Credentia_Winforms.Forms;
using DataAccessLibrary.Helpers;
using DataAccessLibrary.Models;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace Credentia_Winforms
{
    public partial class SecureNoteForm : Form
    {

        public string ActiveUserDB = LoginForm.ActiveUserDB;

        public SecureNoteForm()
        {
            InitializeComponent();

            // Bind the DataGridView to the Secure Notes Table on Form Load
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            BindGridView(sql);

            SecureNoteUpdateVisibility();
        }

        private void SecureNoteDeletebtn_Click(object sender, EventArgs e)
        {
            //Selected row deleted
            int rowIndex = dataGridView2.CurrentCell.RowIndex;

            // Get the selected row
            DataGridViewRow selectedRow = dataGridView2.Rows[rowIndex];

            // get id from secure_notes_table by name
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            int id = GetId(sql, selectedRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString(), ActiveUserDB);

            // Delete the Secure Note from the user's database's secure_notes_table
            DeleteSecureNote(sql, id, ActiveUserDB);

            dataGridView2.Rows.RemoveAt(rowIndex);

            SecureNoteUpdateVisibility();
        }


        private void SecureNoteDetailText__TextChanged(object sender, EventArgs e)
        {

        }


        private void SecureNoteEditbtn_Click(object sender, EventArgs e)
        {

            //Open Update Form to Change the value of selcted row
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[rowIndex];

            SecureNoteUpdateForm f2 = new SecureNoteUpdateForm(selectedRow, dataGridView2);
            f2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SecureNoteAddBtn_Click(object sender, EventArgs e)
        {
            // Open Add Form to insert value in dataGridView2
            SecureNoteAddItemForm addForm = new SecureNoteAddItemForm(this);
            addForm.Show();
            addForm.FormClosed += AddForm_FormClosed;


        }
        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SecureNoteUpdateVisibility();
            // Select the last row (newly added row) after the Add Form is closed
            dataGridView2.ClearSelection();
            int lastIndex = dataGridView2.Rows.Count - 1;
            if (lastIndex >= 0)
            {
                dataGridView2.Rows[lastIndex].Selected = true;
                dataGridView2.FirstDisplayedScrollingRowIndex = lastIndex;
            }
        }
        private void SecureNoteUpdateVisibility()
        {
            if (dataGridView2.Rows.Count == 0)
            {
                // Hide DataGridView and buttons
                dataGridView2.Visible = false;
                SecureNoteEditbtn.Visible = false;
                SecureNoteDeletebtn.Visible = false;

                // Show message indicating no items available
                SCNoItemsLabel.Visible = true;
            }
            else
            {
                // Show DataGridView and buttons
                dataGridView2.Visible = true;
                SecureNoteEditbtn.Visible = true;
                SecureNoteDeletebtn.Visible = true;

                // Hide message indicating no items available
                SCNoItemsLabel.Visible = false;
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        void BindGridView(UsersDBCrud sql)
        {
            dataGridView2.Rows.Clear();

            // Bind the DataGridView to the Secure Notes Table
            List<SecureNotesModel> Notes = sql.GetSecureNotes(ActiveUserDB);

            try
            {
                foreach (SecureNotesModel note in Notes)
                {
                    string decrypted = AesHelper.Decrypt(note.SecureNote);
                    dataGridView2.Rows.Add(note.Name, decrypted);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // ----------------- Database Operations ----------------- //


        // Get id from secure_notes_table
        private static int GetId(UsersDBCrud sql, string name, string userDatabase)
        {
            // Get the id of the Secure Note from the user's database's secure_notes_table
            int id = sql.GetSecureNoteId(name, userDatabase);

            return id;
        }

        // Delete a Secure Note from the user's database's secure_notes_table
        private static void DeleteSecureNote(UsersDBCrud sql, int id, string userDatabase)
        {
            sql.DeleteSecureNote(id, userDatabase);
        }



        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }

    }
}