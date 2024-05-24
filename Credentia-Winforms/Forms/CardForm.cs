using Credentia_Winforms.Forms;
using DataAccessLibrary;
using DataAccessLibrary.Helpers;
using DataAccessLibrary.Models;
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
        public string ActiveUserDB = LoginForm.ActiveUserDB;
        public CardForm()
        {
            InitializeComponent();

            // Bind the DataGridView to the Secure Notes Table on Form Load
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            BindGridView(sql);

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

            // Get the selected row
            DataGridViewRow selectedRow = CarddataGridView.Rows[rowIndex];

            // get id from cards_table
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            int id = GetId(sql, selectedRow.Cells["CardNameBoxColumn"].Value.ToString(),
                selectedRow.Cells["BrandColumn"].Value.ToString(), ActiveUserDB);

            try
            {
                // Delete the Card from the user's database's cards_table
                DeleteCard(sql, id, ActiveUserDB);

                MessageBox.Show("Card Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



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
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = CardSearchBox.Texts.Trim();
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            BindGridView(sql, searchQuery);
        }

        void BindGridView(UsersDBCrud sql, string searchQuery = "")
        {
            CarddataGridView.Rows.Clear();

            // if search is empty then show all cards
            if (string.IsNullOrEmpty(searchQuery))
            {
                List<CardsModel> cards = sql.GetCards(ActiveUserDB);

                try
                {
                    foreach (CardsModel card in cards)
                    {
                        // Decrypt the Card Number, Expiration Month, Expiration Year, and CVV
                        string decryptedCardNumber = AesHelper.Decrypt(card.CardNumber);
                        string decryptedExpirationMonth = AesHelper.Decrypt(card.ExpirationMonth);
                        string decryptedExpirationYear = AesHelper.Decrypt(card.ExpirationYear);
                        string decryptedCVV = AesHelper.Decrypt(card.SecurityCode);

                        CarddataGridView.Rows.Add(card.Name, card.CardholderName, decryptedCardNumber, card.Brand, decryptedExpirationMonth, decryptedExpirationYear, decryptedCVV);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // for search
            else
            {
                List<CardsModel> search = sql.SearchCards(searchQuery, ActiveUserDB);

                try
                {
                    foreach (CardsModel card in search)
                    {
                        // Decrypt the Card Number, Expiration Month, Expiration Year, and CVV
                        string decryptedCardNumber = AesHelper.Decrypt(card.CardNumber);
                        string decryptedExpirationMonth = AesHelper.Decrypt(card.ExpirationMonth);
                        string decryptedExpirationYear = AesHelper.Decrypt(card.ExpirationYear);
                        string decryptedCVV = AesHelper.Decrypt(card.SecurityCode);

                        CarddataGridView.Rows.Add(card.Name, card.CardholderName, decryptedCardNumber, card.Brand, decryptedExpirationMonth, decryptedExpirationYear, decryptedCVV);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        // ----------------------- DATABASE -----------------------//

        // Get id from cards_table
        private static int GetId(UsersDBCrud sql, string name, string brand, string userDatabase)
        {
            // Get the id of the Cards from the user's database's cards_table

            int id = sql.GetCardId(name, brand, userDatabase);

            return id;
        }

        // Delete a Card from the cards_table
        private static void DeleteCard(UsersDBCrud sql, int id, string userDatabase)
        {
            sql.DeleteCard(id, userDatabase);
        }

        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }

    }
}
