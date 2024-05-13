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
    public partial class PasswordGeneratorForm : Form
    {
        public PasswordGeneratorForm()
        {
            InitializeComponent();
            numericUpDownlength.Minimum = 8;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OptionPanel_SizeChanged(object sender, EventArgs e)
        {

        }

        private void CancelPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PGGenerateBtn_Click(object sender, EventArgs e)
        {
            int length = (int)numericUpDownlength.Value;
            bool includeUpperCase = chkIncludeUppercase.Checked;
            bool includeLowercase = chkIncludeLowercase.Checked;
            bool includeNumbers = chkIncludeNumbers.Checked;
            bool includeSymbols = chkIncludeSymbols.Checked;

            string generatePassword = GeneratePassword(length, includeUpperCase, includeLowercase, includeNumbers, includeSymbols);
            textPassword.Texts = generatePassword;
        }

        private string GeneratePassword(int length, bool includeUpperCase, bool includeLowercase, bool includeNumbers, bool includeSymbols)
        {
            const string lowerCaseChar = "abcdefghijklmnopqrstuvwxyz";
            const string upperCaseChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbersChar = "0123456789";
            const string symbolsChar = "!@#$%^&*()_-+='?";

            StringBuilder password = new StringBuilder();
            string validChars = lowerCaseChar;

            if (includeUpperCase)
            {
                validChars += upperCaseChar;
            }
            if (includeLowercase)
            {
                validChars += lowerCaseChar;
            }
            if (includeNumbers)
            {
                validChars += numbersChar;
            }
            if (includeSymbols)
            {
                validChars += symbolsChar;
            }

            Random random = new Random();
            if (length == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    int index = random.Next(validChars.Length);
                    password.Append(validChars[index]);
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    int index = random.Next(validChars.Length);
                    password.Append(validChars[index]);
                }
            }

            return password.ToString();
        }

        private void PGCopybtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textPassword.Texts);
            textPassword.Select();
            MessageBox.Show("Password copied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numericUpDownlength_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
