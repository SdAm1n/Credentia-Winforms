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
    public partial class SecureNoteForm : Form
    {
        public SecureNoteForm()
        {
            InitializeComponent();
        }

        private void SecureNoteaddButton_Click(object sender, EventArgs e)
        {
            SecureNoteDetailsPanel.Visible = false;
            SecureNoteAddForm.Visible = true;

        }

        private void SecureNoteForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SecureNoteDetailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SecureAddFormDonebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SecureNameBox.Texts) || string.IsNullOrEmpty(SecureAddTextBox.Texts))
                return;

            ListViewItem item = new ListViewItem(SecureNameBox.Texts);
            item.SubItems.Add(SecureAddTextBox.Texts);
            listView.Items.Add(item);
            SecureNameBox.Texts = "";
            SecureAddTextBox.Texts = "";
            SecureNameBox.Focus();

            // Select the newly added item by default
            item.Selected = true;
            listView.Focus();
        }

        private void SecureNoteDeletebtn_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
                listView.Items.Remove(listView.SelectedItems[0]);
        }

        private void SecureNoteAddForm_Load(object sender, EventArgs e)
        {
            // Subscribe to the SelectedIndexChanged event of the listView
            listView.SelectedIndexChanged += listView_SelectedIndexChanged_1;
            // Check if there are items in the listView
        }


        private void listView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listView.SelectedItems.Count == 1)
            {
                // Display the details of the selected item in the SecureNoteDetailsPanel
                SecureNoteDetailsPanel.Visible = true;
                SecureDetailNameBox.PlaceholderText = listView.SelectedItems[0].Text;
                SecureNoteDetailText.PlaceholderText = listView.SelectedItems[0].SubItems[1].Text;
            }
            else
            {
                // Hide the SecureNoteDetailsPanel if no item is selected
                SecureNoteDetailsPanel.Visible = false;
            }
            
        }
    }
}
