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
        // Forms
        AllLoginsForm allLoginsForm;
        CardForm cardForm;
        IdentityForm identityForm;
        SecureNoteForm secureNoteForm;
        PasswordGeneratorForm passwordGeneratorForm;
        SettingsForm settingsForm;

        // Currently selected menu button
        private Button selectedMenuButton;

        // Constructor
        public HomeForm()
        {
            InitializeComponent();
            mdiProp();

            // Make AllLoginsForm as default form
            LoginsMenuBtn_Click(null, null);
        }

        // MDI Properties
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.Green;

        }

        //bool sidebarExpand = true;
        //private void sidebarTransition_Tick(object sender, EventArgs e)
        //{
        //    if (sidebarExpand)
        //    {
        //        sidebarLayout.Width -= 10;
        //        if (sidebarLayout.Width <= 43)
        //        {
        //            sidebarExpand = false;
        //            sidebarTransition.Stop();
        //        }
        //        else
        //        {
        //            sidebarLayout.Width += 10;
        //            if (sidebarLayout.Width >= 251)
        //            {
        //                sidebarExpand = true;
        //                sidebarTransition.Stop();
        //            }
        //        }
        //    }
        //}

        // Menu Button Clicks
        private void MenuHamBtn_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        // Collapse Menu Function
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


        // All Menu Button Clicks and Page Routes
        private void LoginsMenuBtn_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(LoginsMenuBtn);
            if (allLoginsForm == null)
            {
                allLoginsForm = new AllLoginsForm();
                allLoginsForm.FormClosed += allLoginsForm_FormClosed;
                allLoginsForm.MdiParent = this;
                allLoginsForm.Dock = DockStyle.Fill;
                allLoginsForm.Show();

            }
            else
            {
                allLoginsForm.Activate();
            }
        }

        private void allLoginsForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            allLoginsForm = null;
        }

        private void CardMenuBtn_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(CardMenuBtn);
            if (cardForm == null)
            {
                cardForm = new CardForm();
                cardForm.FormClosed += cardForm_FormClosed;
                cardForm.MdiParent = this;
                cardForm.Dock = DockStyle.Fill;
                cardForm.Show();

            }
            else
            {
                cardForm.Activate();
            }
        }

        private void cardForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            cardForm = null;
        }

        private void IdentityMenuBtn_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(IdentityMenuBtn);
            if (identityForm == null)
            {
                identityForm = new IdentityForm();
                identityForm.FormClosed += identityForm_FormClosed;
                identityForm.MdiParent = this;
                identityForm.Dock = DockStyle.Fill;
                identityForm.Show();

            }
            else
            {
                identityForm.Activate();
            }
        }

        private void identityForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            identityForm = null;
        }

        private void SecureNoteMenuBtn_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(SecureNoteMenuBtn);
            if (secureNoteForm == null)
            {
                secureNoteForm = new SecureNoteForm();
                secureNoteForm.FormClosed += secureNoteForm_FormClosed;
                secureNoteForm.MdiParent = this;
                secureNoteForm.Dock = DockStyle.Fill;
                secureNoteForm.Show();

            }
            else
            {
                secureNoteForm.Activate();
            }
        }

        private void secureNoteForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            secureNoteForm = null;
        }

        private void PasswordGeneratorMenuBtn_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(PasswordGeneratorMenuBtn);
            if (passwordGeneratorForm == null)
            {
                passwordGeneratorForm = new PasswordGeneratorForm();
                passwordGeneratorForm.FormClosed += passwordGeneratorForm_FormClosed;
                passwordGeneratorForm.MdiParent = this;
                passwordGeneratorForm.Dock = DockStyle.Fill;
                passwordGeneratorForm.Show();

            }
            else
            {
                passwordGeneratorForm.Activate();
            }
        }

        private void passwordGeneratorForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            passwordGeneratorForm = null;
        }

        private void SettingsMenuBtn_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(SettingsMenuBtn);
            if (settingsForm == null)
            {
                settingsForm = new SettingsForm();
                settingsForm.FormClosed += settingsForm_FormClosed;
                settingsForm.MdiParent = this;
                settingsForm.Dock = DockStyle.Fill;
                settingsForm.Show();

            }
            else
            {
                settingsForm.Activate();
            }
        }

        private void settingsForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            settingsForm = null;
        }

        // Logout Button Click, Logout Logic
        private void LogoutMenuBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void sidebarLayout_Paint(object sender, PaintEventArgs e)
        {

        }
        // Function to activate menu button
        private void ActivateMenuButton(Button button)
        {
            // Deactivate previously selected button
            if (selectedMenuButton != null)
            {
                selectedMenuButton.BackColor = Color.Transparent; // Or any other color you prefer
            }
            // Activate the clicked button
            selectedMenuButton = button;
            selectedMenuButton.BackColor = Color.LightGray; // Or any other color you prefer
        }
    }
}