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
    public partial class IdentityUpdateForm : Form
    {
        private DataGridViewRow selectedRow;
        private DataGridView dataGridView;
        public IdentityUpdateForm(DataGridViewRow selectedRow, DataGridView dataGridView)
        {
            InitializeComponent();
            //Select Row to update from datagrid
            this.selectedRow = selectedRow;
            this.dataGridView = dataGridView;

            // Populate your form fields with the data from the selected row
            IdentityUpNameBox.Texts = selectedRow.Cells["IdentityNameColumn"].Value.ToString();
            IdentityUpTittleBox.Texts = selectedRow.Cells["IdentityUserNameColumn"].Value.ToString();
            IdentityFNUpBox.Texts = selectedRow.Cells["IdentityTittleColumn"].Value.ToString();
            IdentityLNUpBox.Texts = selectedRow.Cells["IdentityFirstNColumn"].Value.ToString();
            IdentityUNUpTextBox.Texts = selectedRow.Cells["IdentityLastNColumn"].Value.ToString();
            IdentityUpCompanyBox.Texts = selectedRow.Cells["IdentityCompanyColumn"].Value.ToString();
            IdentityUpLCNBox.Texts = selectedRow.Cells["IdentityLNColumn"].Value.ToString();
            IdentityUpEmailBox.Texts = selectedRow.Cells["IdentityEmailColumn"].Value.ToString();
            IdentityUpPhoneBox.Texts = selectedRow.Cells["IdentityPhoneColumn"].Value.ToString();
            IdentityUpAddressBox.Texts = selectedRow.Cells["AddressColumn"].Value.ToString();
            IdentityUpZipBox.Texts = selectedRow.Cells["IdentityZipColumn"].Value.ToString();
            IdentityUpCountryBox.Texts = selectedRow.Cells["IdentityCountryColumn"].Value.ToString();
            IdentityNidUpBox.Texts = selectedRow.Cells["NIDColumn"].Value.ToString();
            IdentityPassportUpBox.Texts = selectedRow.Cells["PassportColumn"].Value.ToString();
        }

        private void IdentityUpSubmitbtn_Click(object sender, EventArgs e)
        {
            // Update the selected row with the new values
            selectedRow.Cells["IdentityNameColumn"].Value = IdentityUpNameBox.Texts;
            selectedRow.Cells["IdentityUserNameColumn"].Value = IdentityUpTittleBox.Texts;
            selectedRow.Cells["IdentityTittleColumn"].Value = IdentityFNUpBox.Texts;
            selectedRow.Cells["IdentityFirstNColumn"].Value = IdentityLNUpBox.Texts;
            selectedRow.Cells["IdentityLastNColumn"].Value = IdentityUNUpTextBox.Texts;
            selectedRow.Cells["IdentityCompanyColumn"].Value = IdentityUpCompanyBox.Texts;
            selectedRow.Cells["IdentityLNColumn"].Value = IdentityUpLCNBox.Texts;
            selectedRow.Cells["IdentityEmailColumn"].Value = IdentityUpEmailBox.Texts;
            selectedRow.Cells["IdentityPhoneColumn"].Value = IdentityUpPhoneBox.Texts;
            selectedRow.Cells["AddressColumn"].Value = IdentityUpAddressBox.Texts;
            selectedRow.Cells["IdentityZipColumn"].Value = IdentityUpZipBox.Texts;
            selectedRow.Cells["IdentityCountryColumn"].Value = IdentityUpCountryBox.Texts;
            selectedRow.Cells["NIDColumn"].Value = IdentityNidUpBox.Texts;
            selectedRow.Cells["PassportColumn"].Value = IdentityPassportUpBox.Texts;

            // Update the DataGridView in SecureNoteForm
            dataGridView.Refresh(); // Refresh to reflect changes

            // Close the form
            this.Close();
        }
    }
}
