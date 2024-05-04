using Credentia_Winforms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dapper.SqlMapper;

namespace Credentia_Winforms
{
    public partial class IdentityForm : Form
    {
        public IdentityForm()
        {
            InitializeComponent();
            IdentityUpdateVisibility();
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void IdentityAddBtn_Click(object sender, EventArgs e)
        {
            IdentityAddItemForm identity = new IdentityAddItemForm(this);
            identity.Show();
            identity.FormClosed += identity_FormClosed;
        }
        private void identity_FormClosed(object sender, FormClosedEventArgs e)
        {
            IdentityUpdateVisibility();

            // Select the last row (newly added row) after the Add Form is closed
            IdentitydataGridView.ClearSelection();
            int lastIndex = IdentitydataGridView.Rows.Count - 1;
            if (lastIndex >= 0)
            {
                IdentitydataGridView.Rows[lastIndex].Selected = true;
                IdentitydataGridView.FirstDisplayedScrollingRowIndex = lastIndex;
            }
        }

        private void IdentityEditbtn_Click(object sender, EventArgs e)
        {
            // Open Update Form to Change the value of selected row
            int rowIndex = IdentitydataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = IdentitydataGridView.Rows[rowIndex];

            IdentityUpdateForm identityUpdateForm = new IdentityUpdateForm(selectedRow, IdentitydataGridView);
            identityUpdateForm.Show();
        }
        private void IdentityDeletebtn_Click(object sender, EventArgs e)
        {
            // Selected row deleted
            int rowIndex = IdentitydataGridView.CurrentCell.RowIndex;
            IdentitydataGridView.Rows.RemoveAt(rowIndex);
            IdentityUpdateVisibility();
        }
        private void IdentityUpdateVisibility()
        {
            if (IdentitydataGridView.Rows.Count == 0)
            {
                // Hide DataGridView and buttons
                IdentitydataGridView.Visible = false;
                IdentityEditbtn.Visible = false;
                IdentityDeletebtn.Visible = false;

                // Show message indicating no items available
                IdentityNoItems.Visible = true;
            }
            else
            {
                // Show DataGridView and buttons
                IdentitydataGridView.Visible = true;
                IdentityEditbtn.Visible = true;
                IdentityDeletebtn.Visible = true;

                // Hide message indicating no items available
                IdentityNoItems.Visible = false;
            }
        }
        private void IdentitydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
