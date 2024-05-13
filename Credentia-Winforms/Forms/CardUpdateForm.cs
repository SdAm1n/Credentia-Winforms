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
    public partial class CardUpdateForm : Form
    {

        private DataGridViewRow selectedRow;
        private DataGridView dataGridView;
        public CardUpdateForm(DataGridViewRow selectedRow, DataGridView dataGridView)
        {
            InitializeComponent();
            // Populate CardBrandAddComboBox with specific items
            CardBrandUpComboBox.Items.Add("Item 1");
            CardBrandUpComboBox.Items.Add("Item 2");
            CardBrandUpComboBox.Items.Add("Item 3");
            CardBrandUpComboBox.Items.Add("Item 4");
            //Select Row to update from datagrid
            this.selectedRow = selectedRow;
            this.dataGridView = dataGridView;

            // Populate your form fields with the data from the selected row
            CardUpNameBox.Texts = selectedRow.Cells["CardNameBoxColumn"].Value.ToString();
            CardUpHolderNameBox1.Texts = selectedRow.Cells["CardHolderBoxColumn"].Value.ToString();
            CardNumberUpBox.Texts = selectedRow.Cells["CardNumberColumn"].Value.ToString();
            CardBrandUpComboBox.Text = selectedRow.Cells["BrandColumn"].Value.ToString();
            ExMnUpTextBox.Texts = selectedRow.Cells["ExMonthColumn"].Value.ToString();
            CardUpExYrBox.Texts = selectedRow.Cells["ExYearColumn"].Value.ToString();
            CardUpSecurityCode.Texts = selectedRow.Cells["SecurityCodeColumn"].Value.ToString();
            
        }

        private void CardUpSubmitbtn_Click(object sender, EventArgs e)
        {
            // Update the selected row with the new values
            selectedRow.Cells["CardNameBoxColumn"].Value = CardUpNameBox.Texts;
            selectedRow.Cells["CardHolderBoxColumn"].Value = CardUpHolderNameBox1.Texts;
            selectedRow.Cells["CardNumberColumn"].Value = CardNumberUpBox.Texts;
            selectedRow.Cells["BrandColumn"].Value = CardBrandUpComboBox.Text;
            selectedRow.Cells["ExMonthColumn"].Value = ExMnUpTextBox.Texts;
            selectedRow.Cells["ExYearColumn"].Value = CardUpExYrBox.Texts;
            selectedRow.Cells["SecurityCodeColumn"].Value = CardUpSecurityCode.Texts;

            // Update the DataGridView in SecureNoteForm
            dataGridView.Refresh(); // Refresh to reflect changes

            // Close the form
            this.Close();
        }
    }
}
