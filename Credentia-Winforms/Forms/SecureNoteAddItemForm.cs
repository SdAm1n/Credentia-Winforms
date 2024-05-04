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

    public partial class SecureNoteAddItemForm : Form
    {
        SecureNoteForm fgrid1;
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
            // Add a new row to the DataGridView
            fgrid1.dataGridView2.Rows.Add(nameTextBox1.Texts, SecureNoteTextBox1.Texts);

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
    }
}
