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

namespace Credentia_Winforms
{
    public partial class AllLoginsForm : Form
    {
        public string ActiveUserDB = LoginForm.ActiveUserDB;

        public AllLoginsForm()
        {
            InitializeComponent();

            // Bind the DataGridView to the Secure Notes Table on Form Load
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            BindGridView(sql);

            UpdateVisibility();

        }

        private void AllLoginsForm_Load(object sender, EventArgs e)
        {

        }
        private void AllloginsAddBtn_Click(object sender, EventArgs e)
        {
            AllloginsAddForm alllogins = new AllloginsAddForm(this);
            alllogins.Show();
            alllogins.FormClosed += alllogins_FormClosed;
        }

        private void alllogins_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateVisibility();

            // Select the last row (newly added row) after the Add Form is closed
            AllloginsdataGridView.ClearSelection();
            int lastIndex = AllloginsdataGridView.Rows.Count - 1;
            if (lastIndex >= 0)
            {
                AllloginsdataGridView.Rows[lastIndex].Selected = true;
                AllloginsdataGridView.FirstDisplayedScrollingRowIndex = lastIndex;
            }
        }

        private void AllloginsDeletebtn_Click(object sender, EventArgs e)
        {
            // Selected row deleted
            int rowIndex = AllloginsdataGridView.CurrentCell.RowIndex;
            
            
            // Get the selected row
            DataGridViewRow selectedRow = AllloginsdataGridView.Rows[rowIndex];

            // Get id from logins_table by name and username
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            int id = GetId(sql, selectedRow.Cells["AllloginsNameColumn"].Value.ToString(), selectedRow.Cells["AllloginsUsernameColumn"].Value.ToString(), ActiveUserDB);

            // Delete the Login from the user's database's logins_table
            DeleteLogin(sql, id, ActiveUserDB);

            // Remove the selected row from the DataGridView
            AllloginsdataGridView.Rows.RemoveAt(rowIndex);

            UpdateVisibility();
        }

        private void AllloginsEditbtn_Click(object sender, EventArgs e)
        {
            // Open Update Form to Change the value of selected row
            int rowIndex = AllloginsdataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = AllloginsdataGridView.Rows[rowIndex];

            AllloginsUpdateForm upform = new AllloginsUpdateForm(selectedRow, AllloginsdataGridView);
            upform.Show();
        }
        private void UpdateVisibility()
        {
            if (AllloginsdataGridView.Rows.Count == 0)
            {
                // Hide DataGridView and buttons
                AllloginsdataGridView.Visible = false;
                AllloginsEditbtn.Visible = false;
                AllloginsDeletebtn.Visible = false;

                // Show message indicating no items available
                NoItemsLabel.Visible = true;
            }
            else
            {
                // Show DataGridView and buttons
                AllloginsdataGridView.Visible = true;
                AllloginsEditbtn.Visible = true;
                AllloginsDeletebtn.Visible = true;

                // Hide message indicating no items available
                NoItemsLabel.Visible = false;
            }
        }


        // Bind the DataGridView to the All Logins Table
        void BindGridView(UsersDBCrud sql)
        {
            AllloginsdataGridView.Rows.Clear();
            List<LoginsModel> logins = sql.GetLogins(ActiveUserDB);

            try
            {
                foreach (LoginsModel loginsModel in logins)
                {
                    string decryptedPassword = AesHelper.Decrypt(loginsModel.Password);

                    AllloginsdataGridView.Rows.Add(loginsModel.Name, loginsModel.Username, decryptedPassword, loginsModel.URL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        // -------------------- Database Operations -------------------------- //

        // Get id from logins_table
        private static int GetId(UsersDBCrud sql, string name, string username, string userDatabase)
        {
            // Get the id of the Login from the user's database's logins_table
            int id = sql.GetLoginId(name, username, userDatabase);

            return id;
        }


        // Delete a Login from the logins_table
        private static void DeleteLogin(UsersDBCrud sql, int id, string userDatabase)
        {
            sql.DeleteLogin(id, userDatabase);
        }

        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }
    }
}
