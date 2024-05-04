using Credentia_Winforms.Forms;
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

namespace Credentia_Winforms
{
    public partial class SecureNoteForm : Form
    {
        public SecureNoteForm()
        {
            InitializeComponent();
            // Subscribe to the CellPainting event to customize row appearance
        }

        private void SecureNoteDeletebtn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(rowIndex);
        }


        private void SecureNoteDetailText__TextChanged(object sender, EventArgs e)
        {

        }


        private void SecureNoteEditbtn_Click(object sender, EventArgs e)
        {
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
            SecureNoteAddItemForm addForm = new SecureNoteAddItemForm(this);
            addForm.Show();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }
    }
}