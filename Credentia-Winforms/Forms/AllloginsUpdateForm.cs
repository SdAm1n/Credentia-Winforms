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
    }
}
