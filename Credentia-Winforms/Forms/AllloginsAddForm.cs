using DataAccessLibrary;
using DataAccessLibrary.Helpers;
using DataAccessLibrary.Models;
using Org.BouncyCastle.Asn1;
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
    public partial class AllloginsAddForm : Form
    {
        AllLoginsForm fgrid;
        public string ActiveUserDB = LoginForm.ActiveUserDB;
        public AllloginsAddForm(AllLoginsForm fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }

        private void AllloginsPassword_Click(object sender, EventArgs e)
        {

        }

        private void AllloginsAddSubmitbtn_Click(object sender, EventArgs e)
        {
            // Add the Login to the Database Logins Table
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");

            try
            {
                AddLogin(sql, AllloginsAddNameBox.Texts, AllloginsAddUsernameBox.Texts, AllloginsAddPasswordBox.Texts, AllloginsAddURlBox.Texts, ActiveUserDB);
                MessageBox.Show("Login Added Successfully");
                BindGridView(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Close the form and return DialogResult.OK to indicate success
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AllloginsAddURlBox__TextChanged(object sender, EventArgs e)
        {

        }

        // Bind the DataGridView to the All Logins Table
        void BindGridView(UsersDBCrud sql)
        {
            fgrid.AllloginsdataGridView.Rows.Clear();
            List<LoginsModel> logins = sql.GetLogins(ActiveUserDB);

            try
            {
                foreach (LoginsModel loginsModel in logins)
                {
                    string decryptedPassword = AesHelper.Decrypt(loginsModel.Password);

                    fgrid.AllloginsdataGridView.Rows.Add(loginsModel.Name, loginsModel.Username, decryptedPassword, loginsModel.URL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //-----------------------------------DATABASE---------------------------------------------//


        // Add a new Login to the logins_table
        private static void AddLogin(UsersDBCrud sql, string name, string username, string password,  
            string userURL, string userDatabase)
        {

            // Encrypt the Password
            byte[] encrypted = AesHelper.Encrypt(password);

            sql.AddLogin(name, username, encrypted, userURL, userDatabase);
        }


        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }
    }
}
