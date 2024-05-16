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
using Microsoft.Extensions.Configuration;
using DataAccessLibrary.Models;

namespace Credentia_Winforms.Forms
{

    public partial class SecureNoteAddItemForm : Form
    {
        SecureNoteForm fgrid1;
        public string ActiveUserDB = LoginForm.ActiveUserDB;

        public SecureNoteAddItemForm(SecureNoteForm fg1)
        {
            InitializeComponent();
            this.fgrid1 = fg1;
        }

        private void SeureNoteAddItemPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SecureNoteSubmitbtn_Click(object sender, EventArgs e)
        {
            // Add the Secure Note to the Database SecureNote Table
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            try
            {
                AddSecureNote(sql, ActiveUserDB, nameTextBox1.Texts, SecureNoteTextBox1.Texts);
                MessageBox.Show("Secure Note Added Successfully");
                BindGridView(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //// Add a new row to the DataGridView
            //fgrid1.dataGridView2.Rows.Add(nameTextBox1.Texts, SecureNoteTextBox1.Texts);

            // Close the form and return DialogResult.OK to indicate success
            DialogResult = DialogResult.OK;
            Close();
        }

        private void nameTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void SecureNoteTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        // Bind the DataGridView to the Secure Notes Table
        void BindGridView(UsersDBCrud sql)
        {
            fgrid1.dataGridView2.Rows.Clear();
            // Bind the DataGridView to the Secure Notes Table
            List<SecureNotesModel> secureNotes = sql.GetSecureNotes(ActiveUserDB);
            foreach (SecureNotesModel note in secureNotes)
            {
                string decrypted = AesHelper.Decrypt(note.SecureNote);
                fgrid1.dataGridView2.Rows.Add(note.Name, decrypted);
            }
        }


        // -------------------- Database Operations -------------------------- //
        // -------------------- Secure Notes Table Operations -------------------------- //


        // Add a new Secure Note to the user's database's secure_notes_table
        private static void AddSecureNote(UsersDBCrud sql, string userDatabase, string name, string secureNote)
        {
            // Encrypt the Secure Note
            byte[] encrypted = AesHelper.Encrypt(secureNote);

            sql.AddSecureNote(name, encrypted, userDatabase);
        }

        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }
    }
}
