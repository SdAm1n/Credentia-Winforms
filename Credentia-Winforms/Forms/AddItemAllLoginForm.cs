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

namespace Credentia_Winforms
{
    public partial class AddItemAllLoginForm : Form
    {
        AllLoginsForm fgrid;
        public AddItemAllLoginForm(AllLoginsForm fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void urlTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void donebutton1_Click(object sender, EventArgs e)
        {
            if (this.Tag != null && this.Tag.ToString() == "Update")
            {
                // Close the form and return DialogResult.OK to indicate success
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                // Add a new row to the DataGridView
                fgrid.dataGridView1.Rows.Add(nameTextBox1.Texts, usernameTextBox1.Texts, passwordTextBox2.Texts, urlTextBox3.Texts);

                // Close the form and return DialogResult.OK to indicate success
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        
        }
}
