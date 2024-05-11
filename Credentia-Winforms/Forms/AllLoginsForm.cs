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

namespace Credentia_Winforms
{
    public partial class AllLoginsForm : Form
    {

        public AllLoginsForm()
        {
            InitializeComponent();
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
    }
}
