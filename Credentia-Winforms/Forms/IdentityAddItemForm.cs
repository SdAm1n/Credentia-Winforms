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
    public partial class IdentityAddItemForm : Form
    {
        IdentityForm fgrid4;
        public IdentityAddItemForm(IdentityForm fg4)
        {
            InitializeComponent();
            this.fgrid4 = fg4;
        }

        private void IdentityFNAddName_Click(object sender, EventArgs e)
        {

        }

        private void IdentityAddLCNBox__TextChanged(object sender, EventArgs e)
        {

        }

        private void IdentityAddSubmitbtn_Click(object sender, EventArgs e)
        {
            // Add a new row to the DataGridView
            fgrid4.IdentitydataGridView.Rows.Add(IdentityAddNameBox.Texts,IdentityAddTittleBox.Texts,IdentityFNAddBox.Texts, IdentityLNAddBox.Texts, IdentityUNAddTextBox.Texts, CardAddCompanyBox.Texts, IdentityAddLCNBox.Texts, IdentityAddEmailBox.Texts, IdentityAddPhoneBox.Texts, IdentityAddAddressBox.Texts, IdentityAddZipBox.Texts, IdentityAddCountryBox.Texts, IdentityAddNidBox.Texts, IdentityAddPassportBox.Texts);

            // Close the form and return DialogResult.OK to indicate success
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
