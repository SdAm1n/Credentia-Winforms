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
    public partial class CardAddItemForm : Form
    {
        CardForm fgrid;

        public CardAddItemForm(CardForm fg)
        {
            InitializeComponent();
            this.fgrid = fg;

            // Populate CardBrandAddComboBox with specific items
            CardBrandAddComboBox.Items.Add("Visa");
            CardBrandAddComboBox.Items.Add("Mastercard");
            CardBrandAddComboBox.Items.Add("American Express (Amex)");
            CardBrandAddComboBox.Items.Add("UnionPay");
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

            // Add the Card to the Database Cards Table
            UsersDBCrud sql = new UsersDBCrud(GetConnectionString() + $"Database={LoginForm.ActiveUserDB};");
            try
            {
                AddCard(sql, LoginForm.ActiveUserDB, CardAddNameBox.Texts, CardAddHolderNameBox1.Texts, CardNumberAddBox.Texts, CardBrandAddComboBox.Text, ExMnAddTextBox.Texts, CardAddExYrBox.Texts, CardAddSecurityCode.Texts);
                MessageBox.Show("Card Added Successfully");
                BindGridView(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //// Add a new row to the DataGridView
            //fgrid.CarddataGridView.Rows.Add(CardAddNameBox.Texts, CardAddHolderNameBox1.Texts, CardNumberAddBox.Texts, CardBrandAddComboBox.Text, ExMnAddTextBox.Texts, CardAddExYrBox.Texts, CardAddSecurityCode.Texts);

            // Close the form and return DialogResult.OK to indicate success
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CardAddExMnthname_Click(object sender, EventArgs e)
        {

        }

        private void CardBrandAddComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void BindGridView(UsersDBCrud sql)
        {
            fgrid.CarddataGridView.Rows.Clear();

            List<CardsModel> cards = sql.GetCards(LoginForm.ActiveUserDB);

            foreach (CardsModel card in cards)
            {
                // Decrypt the Card Number, Expiration Month, Expiration Year, and CVV
                string decryptedCardNumber = AesHelper.Decrypt(card.CardNumber);
                string decryptedExpirationMonth = AesHelper.Decrypt(card.ExpirationMonth);
                string decryptedExpirationYear = AesHelper.Decrypt(card.ExpirationYear);
                string decryptedCVV = AesHelper.Decrypt(card.SecurityCode);

                fgrid.CarddataGridView.Rows.Add(card.Name, card.CardholderName, decryptedCardNumber, card.Brand, decryptedExpirationMonth, decryptedExpirationYear, decryptedCVV);

            }
        }

        // ----------------------- DATABASE -----------------------//

        // Add a new Card to the cards_table
        private static void AddCard(UsersDBCrud sql, string userDatabase, string name, string cardHolderName, 
            string cardNumber, string brand, string expirationMonth, string expirationYear, string cvv)
        {
            // Encrypt the Card Number, Expiration Month, Expiration Year, and CVV
            byte[] encryptedCardNumber = AesHelper.Encrypt(cardNumber);
            byte[] encryptedExpirationMonth = AesHelper.Encrypt(expirationMonth);
            byte[] encryptedExpirationYear = AesHelper.Encrypt(expirationYear);
            byte[] encryptedCVV = AesHelper.Encrypt(cvv);

            sql.AddCard(name, cardHolderName, encryptedCardNumber, brand, encryptedExpirationMonth, encryptedExpirationYear, encryptedCVV, userDatabase);
        }

        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }
    }
}

