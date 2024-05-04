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
    public partial class CardAddItemForm : Form
    {
        CardForm fgrid3;
        public CardAddItemForm(CardForm fg3)
        {
            InitializeComponent();
            this.fgrid3 = fg3;
        }

        private void CardAddName_Click(object sender, EventArgs e)
        {

        }

        private void CardHolderAddName_Click(object sender, EventArgs e)
        {

        }

        private void CardBrandAddName_Click(object sender, EventArgs e)
        {

        }

        private void CardAddSubmitbtn_Click(object sender, EventArgs e)
        {
            // Add a new row to the DataGridView
            fgrid3.CarddataGridView.Rows.Add(CardAddNameBox.Texts, CardAddHolderNameBox1.Texts, CardNumberAddBox.Texts, CardBrandAddBox.Texts, ExMnAddTextBox.Texts, CardAddExYrBox.Texts, CardAddSecurityCode.Texts);

            // Close the form and return DialogResult.OK to indicate success
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CardAddExMnthname_Click(object sender, EventArgs e)
        {

        }
    }
}
