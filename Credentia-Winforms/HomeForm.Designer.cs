namespace Credentia_Winforms
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            LoginsMenuBtn = new Button();
            CardMenuBtn = new Button();
            IdentityMenuBtn = new Button();
            SecureNoteMenuBtn = new Button();
            PasswordGeneratorMenuBtn = new Button();
            SettingsMenuBtn = new Button();
            LogoutMenuBtn = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            sidebarLayout = new FlowLayoutPanel();
            MenuHamBtn = new Button();
            sidebarLayout.SuspendLayout();
            SuspendLayout();
            // 
            // LoginsMenuBtn
            // 
            LoginsMenuBtn.Anchor = AnchorStyles.Left;
            LoginsMenuBtn.BackColor = Color.FromArgb(248, 251, 252);
            LoginsMenuBtn.Image = (Image)resources.GetObject("LoginsMenuBtn.Image");
            LoginsMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LoginsMenuBtn.Location = new Point(3, 39);
            LoginsMenuBtn.Name = "LoginsMenuBtn";
            LoginsMenuBtn.Size = new Size(248, 43);
            LoginsMenuBtn.TabIndex = 0;
            LoginsMenuBtn.Tag = "Logins";
            LoginsMenuBtn.Text = "Logins";
            LoginsMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            LoginsMenuBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LoginsMenuBtn.UseVisualStyleBackColor = false;
            LoginsMenuBtn.Click += LoginsMenuBtn_Click;
            // 
            // CardMenuBtn
            // 
            CardMenuBtn.BackColor = Color.FromArgb(248, 251, 252);
            CardMenuBtn.Image = (Image)resources.GetObject("CardMenuBtn.Image");
            CardMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CardMenuBtn.Location = new Point(3, 88);
            CardMenuBtn.Name = "CardMenuBtn";
            CardMenuBtn.Size = new Size(248, 43);
            CardMenuBtn.TabIndex = 0;
            CardMenuBtn.Tag = "Card";
            CardMenuBtn.Text = "Card";
            CardMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            CardMenuBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CardMenuBtn.UseVisualStyleBackColor = false;
            CardMenuBtn.Click += CardMenuBtn_Click;
            // 
            // IdentityMenuBtn
            // 
            IdentityMenuBtn.BackColor = Color.FromArgb(248, 251, 252);
            IdentityMenuBtn.Image = (Image)resources.GetObject("IdentityMenuBtn.Image");
            IdentityMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            IdentityMenuBtn.Location = new Point(3, 137);
            IdentityMenuBtn.Name = "IdentityMenuBtn";
            IdentityMenuBtn.Size = new Size(248, 43);
            IdentityMenuBtn.TabIndex = 0;
            IdentityMenuBtn.Tag = "Identity";
            IdentityMenuBtn.Text = "Identity";
            IdentityMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            IdentityMenuBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            IdentityMenuBtn.UseVisualStyleBackColor = false;
            IdentityMenuBtn.Click += IdentityMenuBtn_Click;
            // 
            // SecureNoteMenuBtn
            // 
            SecureNoteMenuBtn.BackColor = Color.FromArgb(248, 251, 252);
            SecureNoteMenuBtn.Image = (Image)resources.GetObject("SecureNoteMenuBtn.Image");
            SecureNoteMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SecureNoteMenuBtn.Location = new Point(3, 186);
            SecureNoteMenuBtn.Name = "SecureNoteMenuBtn";
            SecureNoteMenuBtn.Size = new Size(248, 43);
            SecureNoteMenuBtn.TabIndex = 0;
            SecureNoteMenuBtn.Tag = "Secure Note";
            SecureNoteMenuBtn.Text = "Secure Note";
            SecureNoteMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            SecureNoteMenuBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SecureNoteMenuBtn.UseVisualStyleBackColor = false;
            SecureNoteMenuBtn.Click += SecureNoteMenuBtn_Click;
            // 
            // PasswordGeneratorMenuBtn
            // 
            PasswordGeneratorMenuBtn.BackColor = Color.FromArgb(248, 251, 252);
            PasswordGeneratorMenuBtn.Image = (Image)resources.GetObject("PasswordGeneratorMenuBtn.Image");
            PasswordGeneratorMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PasswordGeneratorMenuBtn.Location = new Point(3, 235);
            PasswordGeneratorMenuBtn.Name = "PasswordGeneratorMenuBtn";
            PasswordGeneratorMenuBtn.Size = new Size(248, 43);
            PasswordGeneratorMenuBtn.TabIndex = 0;
            PasswordGeneratorMenuBtn.Tag = "Password Generator";
            PasswordGeneratorMenuBtn.Text = "Password Generator";
            PasswordGeneratorMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            PasswordGeneratorMenuBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            PasswordGeneratorMenuBtn.UseVisualStyleBackColor = false;
            PasswordGeneratorMenuBtn.Click += PasswordGeneratorMenuBtn_Click;
            // 
            // SettingsMenuBtn
            // 
            SettingsMenuBtn.BackColor = Color.FromArgb(248, 251, 252);
            SettingsMenuBtn.Image = (Image)resources.GetObject("SettingsMenuBtn.Image");
            SettingsMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SettingsMenuBtn.Location = new Point(3, 284);
            SettingsMenuBtn.Name = "SettingsMenuBtn";
            SettingsMenuBtn.Size = new Size(248, 43);
            SettingsMenuBtn.TabIndex = 0;
            SettingsMenuBtn.Tag = "Settings";
            SettingsMenuBtn.Text = "Settings";
            SettingsMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            SettingsMenuBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SettingsMenuBtn.UseVisualStyleBackColor = false;
            SettingsMenuBtn.Click += SettingsMenuBtn_Click;
            // 
            // LogoutMenuBtn
            // 
            LogoutMenuBtn.BackColor = Color.FromArgb(248, 251, 252);
            LogoutMenuBtn.Image = (Image)resources.GetObject("LogoutMenuBtn.Image");
            LogoutMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutMenuBtn.Location = new Point(3, 333);
            LogoutMenuBtn.Name = "LogoutMenuBtn";
            LogoutMenuBtn.Size = new Size(248, 43);
            LogoutMenuBtn.TabIndex = 0;
            LogoutMenuBtn.Tag = "Logout";
            LogoutMenuBtn.Text = "Logout";
            LogoutMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            LogoutMenuBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutMenuBtn.UseVisualStyleBackColor = false;
            LogoutMenuBtn.Click += LogoutMenuBtn_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Enabled = true;
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // sidebarLayout
            // 
            sidebarLayout.BackColor = Color.FromArgb(248, 251, 252);
            sidebarLayout.Controls.Add(MenuHamBtn);
            sidebarLayout.Controls.Add(LoginsMenuBtn);
            sidebarLayout.Controls.Add(CardMenuBtn);
            sidebarLayout.Controls.Add(IdentityMenuBtn);
            sidebarLayout.Controls.Add(SecureNoteMenuBtn);
            sidebarLayout.Controls.Add(PasswordGeneratorMenuBtn);
            sidebarLayout.Controls.Add(SettingsMenuBtn);
            sidebarLayout.Controls.Add(LogoutMenuBtn);
            sidebarLayout.Dock = DockStyle.Left;
            sidebarLayout.Location = new Point(0, 0);
            sidebarLayout.Name = "sidebarLayout";
            sidebarLayout.Size = new Size(251, 630);
            sidebarLayout.TabIndex = 3;
            // 
            // MenuHamBtn
            // 
            MenuHamBtn.Image = Properties.Resources.Menu;
            MenuHamBtn.Location = new Point(3, 3);
            MenuHamBtn.Name = "MenuHamBtn";
            MenuHamBtn.Size = new Size(37, 30);
            MenuHamBtn.TabIndex = 4;
            MenuHamBtn.UseVisualStyleBackColor = true;
            MenuHamBtn.Click += MenuHamBtn_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(sidebarLayout);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "HomeForm";
            Text = "HomeForm";
            sidebarLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button LoginsMenuBtn;
        private Button CardMenuBtn;
        private Button IdentityMenuBtn;
        private Button SecureNoteMenuBtn;
        private Button PasswordGeneratorMenuBtn;
        private Button SettingsMenuBtn;
        private Button LogoutMenuBtn;
        private System.Windows.Forms.Timer sidebarTransition;
        private FlowLayoutPanel sidebarLayout;
        private Button MenuHamBtn;
    }
}