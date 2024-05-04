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
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
            UpdateVisibility();
        }

        private void CardDetailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CardDetailsName_Click(object sender, EventArgs e)
        {

        }

        private void ExMonthDetails_Click(object sender, EventArgs e)
        {

        }

        private void CardAddBtn_Click(object sender, EventArgs e)
        {
            CardAddItemForm card = new CardAddItemForm(this);
            card.Show();
            card.FormClosed += card_FormClosed;
        }

        private void card_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateVisibility();

            // Select the last row (newly added row) after the Add Form is closed
            CarddataGridView.ClearSelection();
            int lastIndex = CarddataGridView.Rows.Count - 1;
            if (lastIndex >= 0)
            {
                CarddataGridView.Rows[lastIndex].Selected = true;
                CarddataGridView.FirstDisplayedScrollingRowIndex = lastIndex;
            }
        }

        private void CardDeleteBtn_Click(object sender, EventArgs e)
        {
            // Selected row deleted
            int rowIndex = CarddataGridView.CurrentCell.RowIndex;
            CarddataGridView.Rows.RemoveAt(rowIndex);
            UpdateVisibility();
        }

        private void CardEditBtn_Click(object sender, EventArgs e)
        {
            // Open Update Form to Change the value of selected row
            int rowIndex = CarddataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = CarddataGridView.Rows[rowIndex];

            CardUpdateForm cd = new CardUpdateForm(selectedRow, CarddataGridView);
            cd.Show();
        }

        private void UpdateVisibility()
        {
            if (CarddataGridView.Rows.Count == 0)
            {
                // Hide DataGridView and buttons
                CarddataGridView.Visible = false;
                CardEditBtn.Visible = false;
                CardDeleteBtn.Visible = false;

                // Show message indicating no items available
                NoItemsLabel.Visible = true;
            }
            else
            {
                // Show DataGridView and buttons
                CarddataGridView.Visible = true;
                CardEditBtn.Visible = true;
                CardDeleteBtn.Visible = true;

                // Hide message indicating no items available
                NoItemsLabel.Visible = false;
            }
        }

        private void CarddataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
