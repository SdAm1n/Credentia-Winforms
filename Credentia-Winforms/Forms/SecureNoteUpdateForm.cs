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

namespace Credentia_Winforms.Forms
{
    public partial class SecureNoteUpdateForm : Form
    {
        private DataGridViewRow selectedRow;
        private DataGridView dataGridView;

        public SecureNoteUpdateForm(DataGridViewRow selectedRow, DataGridView dataGridView)
        {
            InitializeComponent();
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
            // Update the selected row with the new values
            selectedRow.Cells["dataGridViewTextBoxColumn1"].Value = SecureUpdateNoteNameBox.Texts;
            selectedRow.Cells["dataGridViewTextBoxColumn2"].Value = SecureNoteUpdateTextBox.Texts;

            // Update the DataGridView in SecureNoteForm
            dataGridView.Refresh(); // Refresh to reflect changes

            // Close the form
            this.Close();
        }
    }
}
