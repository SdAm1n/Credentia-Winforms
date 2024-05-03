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
        int flag = -1;
        public AllLoginsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AllLoginsForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //To show AddItemAllLoginForm when Add button is clicked
            AddItemAllLoginForm f2 = new AddItemAllLoginForm(this);
            f2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                // Remove the row corresponding to the clicked button
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }

            // Check if the click is on a button cell and if that button cell has "Delete" as its value
            else if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Update")
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Open the AddItemAllLoginForm form for update
                AddItemAllLoginForm updateForm = new AddItemAllLoginForm(this);

                // Set the values of email and password in the update form
                updateForm.nameTextBox1.Texts = selectedRow.Cells["nameColumn"].Value.ToString();
                updateForm.usernameTextBox1.Texts = selectedRow.Cells["UsernameColumn"].Value.ToString();
                updateForm.passwordTextBox2.Texts = selectedRow.Cells["PasswordColumn"].Value.ToString();
                updateForm.urlTextBox3.Texts = selectedRow.Cells["URLColumn"].Value.ToString();

                // Set the Tag property to indicate update mode
                updateForm.Tag = "Update";

                // Show the update form as a dialog
                DialogResult result = updateForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Update the values in the selected row
                    selectedRow.Cells["nameColumn"].Value = updateForm.nameTextBox1.Texts;
                    selectedRow.Cells["UsernameColumn"].Value = updateForm.usernameTextBox1.Texts;
                    selectedRow.Cells["PasswordColumn"].Value = updateForm.passwordTextBox2.Texts;
                    selectedRow.Cells["URLColumn"].Value = updateForm.urlTextBox3.Texts;
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
