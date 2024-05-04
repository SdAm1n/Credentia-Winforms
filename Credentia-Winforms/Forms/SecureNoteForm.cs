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
            SecureNoteUpdateVisibility();
        }

        private void SecureNoteDeletebtn_Click(object sender, EventArgs e)
        {
            //Selected row deleted
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
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

        private void SecureNoteForm_Load(object sender, EventArgs e)
        {

        }
    }
}