namespace Credentia_Winforms
{
    public partial class LoginForm : Form
    {
        private string Password_Regex = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$";

        public LoginForm()
        {
            InitializeComponent();

            set_color();

        }

        private void set_color()
        {
            this.BackColor = Color.FromArgb(238, 246, 247); // Background Color
            DockPanel1.BackColor = Color.FromArgb(248, 251, 252); // DockPanel Color
            LoginBtn.BorderColor = Color.FromArgb(252, 150, 48); // Login Button Color
            LoginBtn.ForeColor = Color.FromArgb(252, 150, 48); // Login Button Text Color
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            //if (string.IsNullOrEmpty(UsernameTextBox.Text) == true)
            //{
            //    UsernameErrorProvider.SetError(UsernameTextBox, "Username is required");
            //}
            //else if (System.Text.RegularExpressions.Regex.IsMatch(PasswordTextBox.Texts, Password_Regex) == false)
            //{
            //    PasswordErrorProvider.SetError(PasswordTextBox, "Password must contain at least 8 characters, including UPPER & lowercase and numbers & special characters");
            //}

            HomeForm homeForm = new HomeForm();
            this.Hide();
            homeForm.Show();
        }

        private void CreateAccLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.Show();
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Texts) == true)
            {

                UsernameErrorProvider.SetError(UsernameTextBox, "Username is required");
            }
            else
            {
                UsernameErrorProvider.Clear();
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTextBox.Texts) == true)
            {
                PasswordErrorProvider.SetError(PasswordTextBox, "Master Password is required");
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(PasswordTextBox.Texts, Password_Regex) == false)
                {
                    PasswordErrorProvider.SetError(PasswordTextBox, "Password must contain at least 8 characters, including UPPER & lowercase and numbers & special characters");
                }
                else
                {
                    PasswordErrorProvider.Clear();
                }

            }
        }

        private void ShowPasswordToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordToggle.Checked == true)
            {
                PasswordTextBox.PasswordChar = false;
            }
            else
            {
                PasswordTextBox.PasswordChar = true;
            }
        }
    }
}
