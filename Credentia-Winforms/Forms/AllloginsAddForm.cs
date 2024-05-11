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
    public partial class AllloginsAddForm : Form
    {
        AllLoginsForm fgrid;
        public AllloginsAddForm(AllLoginsForm fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }

        private void AllloginsPassword_Click(object sender, EventArgs e)
        {

        }

        private void AllloginsAddSubmitbtn_Click(object sender, EventArgs e)
        {
            // Add a new row to the DataGridView
            fgrid.AllloginsdataGridView.Rows.Add(AllloginsAddNameBox.Texts, AllloginsAddUsernameBox.Texts, AllloginsAddPasswordBox.Texts, AllloginsAddURlBox.Texts);

            // Close the form and return DialogResult.OK to indicate success
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AllloginsAddURlBox__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
