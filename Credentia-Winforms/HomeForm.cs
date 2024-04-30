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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }


        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarLayout.Width -= 10;
                if (sidebarLayout.Width <= 43)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
                else
                {
                    sidebarLayout.Width += 10;
                    if (sidebarLayout.Width >= 251)
                    {
                        sidebarExpand = true;
                        sidebarTransition.Stop();
                    }
                }
            }
        }

        private void MenuHamBtn_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.sidebarLayout.Width >= 251)
            {
                sidebarLayout.Width = 43;
                MenuHamBtn.Dock = DockStyle.Top;


            }
            else
            {
                sidebarLayout.Width = 251;
                MenuHamBtn.Dock = DockStyle.None;

            }
        }

        private void LoginsMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void CardMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void IdentityMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void SecureNoteMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void PasswordGeneratorMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void SettingsMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void LogoutMenuBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
