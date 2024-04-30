namespace Credentia_Winforms
{
    public partial class LoginForm : Form
    {
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
    }
}
