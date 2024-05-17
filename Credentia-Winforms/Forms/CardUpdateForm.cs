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

namespace Credentia_Winforms.Forms
{
    public partial class CardUpdateForm : Form
    {
        public string ActiveUserDB = LoginForm.ActiveUserDB;

        private DataGridViewRow selectedRow;
        private DataGridView dataGridView;
        public CardUpdateForm(DataGridViewRow selectedRow, DataGridView dataGridView)
        {
            InitializeComponent();
            // Populate CardBrandAddComboBox with specific items
            CardBrandUpComboBox.Items.Add("Visa");
            CardBrandUpComboBox.Items.Add("Mastercard");
            CardBrandUpComboBox.Items.Add("American Express (Amex)");
            CardBrandUpComboBox.Items.Add("UnionPay");
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

            // get id from cards_table by name and brand
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={ActiveUserDB};");
            int id = GetId(sql, selectedRow.Cells["CardNameBoxColumn"].Value.ToString(),
                               selectedRow.Cells["BrandColumn"].Value.ToString(), ActiveUserDB);

            try
            {
                // update the database
                UpdateCard(sql, id, CardUpNameBox.Texts, CardUpHolderNameBox1.Texts, CardNumberUpBox.Texts,
                                       CardBrandUpComboBox.Text, ExMnUpTextBox.Texts, CardUpExYrBox.Texts, 
                                       CardUpSecurityCode.Texts, ActiveUserDB);
                MessageBox.Show("Card Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        void BindGridView(UsersDBCrud sql)
        {
            dataGridView.Rows.Clear();

            List<CardsModel> cards = sql.GetCards(ActiveUserDB);

            foreach (CardsModel card in cards)
            {
                // Decrypt the Card Number, Expiration Month, Expiration Year, and CVV
                string decryptedCardNumber = AesHelper.Decrypt(card.CardNumber);
                string decryptedExpirationMonth = AesHelper.Decrypt(card.ExpirationMonth);
                string decryptedExpirationYear = AesHelper.Decrypt(card.ExpirationYear);
                string decryptedCVV = AesHelper.Decrypt(card.SecurityCode);

                dataGridView.Rows.Add(card.Name, card.CardholderName, decryptedCardNumber, card.Brand, 
                    decryptedExpirationMonth, decryptedExpirationYear, decryptedCVV);

            }
        }


        // -------------------------- DATABASE --------------------------//

        // Get id from cards_table
        private static int GetId(UsersDBCrud sql, string name, string brand, string userDatabase)
        {
            // Get the id of the Cards from the user's database's cards_table

            int id = sql.GetCardId(name, brand, userDatabase);

            return id;
        }

        // Update a Card in the cards_table
        private static void UpdateCard(UsersDBCrud sql, int id, string name, string cardHolderName, 
            string cardNumber, string brand, string expirationMonth, string expirationYear, string cvv, 
            string userDatabase)
        {
            // Update a Card in the cards_table
            byte[] encryptedCardNumber = AesHelper.Encrypt(cardNumber);
            byte[] encryptedExpirationMonth = AesHelper.Encrypt(expirationMonth);
            byte[] encryptedExpirationYear = AesHelper.Encrypt(expirationYear);
            byte[] encryptedCVV = AesHelper.Encrypt(cvv);

            sql.UpdateCard(id, name, cardHolderName, encryptedCardNumber, brand, encryptedExpirationMonth, 
                encryptedExpirationYear, encryptedCVV, userDatabase);
        }

        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }
    }
}
