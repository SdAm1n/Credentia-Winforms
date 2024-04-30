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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            set_color();
        }

        private void set_color()
        {
            this.BackColor = Color.FromArgb(238, 246, 247); // Background Color
            DockPanel1.BackColor = Color.FromArgb(248, 251, 252); // DockPanel Color
            CancelBtn.BorderColor = Color.FromArgb(252, 150, 48); // Login Button Color
            CancelBtn.ForeColor = Color.FromArgb(252, 150, 48); // Login Button Text Color
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
