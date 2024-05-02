namespace Credentia_Winforms
{
    partial class AddItemAllLoginForm
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
            panel1 = new Panel();
            donebutton1 = new CustomControls.CustomButton();
            url = new Label();
            urlTextBox3 = new CustomControls.CustomTextBox();
            password = new Label();
            passwordTextBox2 = new CustomControls.CustomTextBox();
            username = new Label();
            usernameTextBox1 = new CustomControls.CustomTextBox();
            name = new Label();
            nameTextBox1 = new CustomControls.CustomTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(donebutton1);
            panel1.Controls.Add(url);
            panel1.Controls.Add(urlTextBox3);
            panel1.Controls.Add(password);
            panel1.Controls.Add(passwordTextBox2);
            panel1.Controls.Add(username);
            panel1.Controls.Add(usernameTextBox1);
            panel1.Controls.Add(name);
            panel1.Controls.Add(nameTextBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // donebutton1
            // 
            donebutton1.BackColor = Color.MediumSlateBlue;
            donebutton1.BackgroundColor = Color.MediumSlateBlue;
            donebutton1.BorderColor = Color.PaleVioletRed;
            donebutton1.BorderRadius = 10;
            donebutton1.BorderSize = 0;
            donebutton1.FlatAppearance.BorderSize = 0;
            donebutton1.FlatStyle = FlatStyle.Flat;
            donebutton1.ForeColor = Color.White;
            donebutton1.Location = new Point(316, 348);
            donebutton1.Name = "donebutton1";
            donebutton1.Size = new Size(150, 40);
            donebutton1.TabIndex = 8;
            donebutton1.Text = "Done";
            donebutton1.TextColor = Color.White;
            donebutton1.UseVisualStyleBackColor = false;
            donebutton1.Click += donebutton1_Click;
            // 
            // url
            // 
            url.AutoSize = true;
            url.Location = new Point(258, 258);
            url.Name = "url";
            url.Size = new Size(28, 15);
            url.TabIndex = 7;
            url.Text = "URL";
            // 
            // urlTextBox3
            // 
            urlTextBox3.BackColor = SystemColors.Window;
            urlTextBox3.BorderColor = Color.MediumSlateBlue;
            urlTextBox3.BorderFocusColor = Color.HotPink;
            urlTextBox3.BorderRadius = 10;
            urlTextBox3.BorderSize = 2;
            urlTextBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urlTextBox3.ForeColor = Color.DimGray;
            urlTextBox3.Location = new Point(258, 284);
            urlTextBox3.Multiline = false;
            urlTextBox3.Name = "urlTextBox3";
            urlTextBox3.Padding = new Padding(7);
            urlTextBox3.PasswordChar = false;
            urlTextBox3.PlaceholderColor = Color.DarkGray;
            urlTextBox3.PlaceholderText = "";
            urlTextBox3.Size = new Size(250, 32);
            urlTextBox3.TabIndex = 6;
            urlTextBox3.Texts = "";
            urlTextBox3.UnderlinedStyle = false;
            urlTextBox3._TextChanged += urlTextBox3__TextChanged;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(258, 179);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 5;
            password.Text = "Password";
            password.Click += password_Click;
            // 
            // passwordTextBox2
            // 
            passwordTextBox2.BackColor = SystemColors.Window;
            passwordTextBox2.BorderColor = Color.MediumSlateBlue;
            passwordTextBox2.BorderFocusColor = Color.HotPink;
            passwordTextBox2.BorderRadius = 10;
            passwordTextBox2.BorderSize = 2;
            passwordTextBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox2.ForeColor = Color.DimGray;
            passwordTextBox2.Location = new Point(258, 206);
            passwordTextBox2.Multiline = false;
            passwordTextBox2.Name = "passwordTextBox2";
            passwordTextBox2.Padding = new Padding(7);
            passwordTextBox2.PasswordChar = false;
            passwordTextBox2.PlaceholderColor = Color.DarkGray;
            passwordTextBox2.PlaceholderText = "";
            passwordTextBox2.Size = new Size(250, 32);
            passwordTextBox2.TabIndex = 4;
            passwordTextBox2.Texts = "";
            passwordTextBox2.UnderlinedStyle = false;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(258, 93);
            username.Name = "username";
            username.Size = new Size(60, 15);
            username.TabIndex = 3;
            username.Text = "Username";
            // 
            // usernameTextBox1
            // 
            usernameTextBox1.BackColor = SystemColors.Window;
            usernameTextBox1.BorderColor = Color.MediumSlateBlue;
            usernameTextBox1.BorderFocusColor = Color.HotPink;
            usernameTextBox1.BorderRadius = 10;
            usernameTextBox1.BorderSize = 2;
            usernameTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox1.ForeColor = Color.DimGray;
            usernameTextBox1.Location = new Point(258, 119);
            usernameTextBox1.Multiline = false;
            usernameTextBox1.Name = "usernameTextBox1";
            usernameTextBox1.Padding = new Padding(7);
            usernameTextBox1.PasswordChar = false;
            usernameTextBox1.PlaceholderColor = Color.DarkGray;
            usernameTextBox1.PlaceholderText = "";
            usernameTextBox1.Size = new Size(250, 32);
            usernameTextBox1.TabIndex = 2;
            usernameTextBox1.Texts = "";
            usernameTextBox1.UnderlinedStyle = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(258, 9);
            name.Name = "name";
            name.Size = new Size(39, 15);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // nameTextBox1
            // 
            nameTextBox1.BackColor = SystemColors.Window;
            nameTextBox1.BorderColor = Color.MediumSlateBlue;
            nameTextBox1.BorderFocusColor = Color.HotPink;
            nameTextBox1.BorderRadius = 10;
            nameTextBox1.BorderSize = 2;
            nameTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox1.ForeColor = Color.DimGray;
            nameTextBox1.Location = new Point(258, 35);
            nameTextBox1.Multiline = false;
            nameTextBox1.Name = "nameTextBox1";
            nameTextBox1.Padding = new Padding(7);
            nameTextBox1.PasswordChar = false;
            nameTextBox1.PlaceholderColor = Color.DarkGray;
            nameTextBox1.PlaceholderText = "";
            nameTextBox1.Size = new Size(250, 32);
            nameTextBox1.TabIndex = 0;
            nameTextBox1.Texts = "";
            nameTextBox1.UnderlinedStyle = false;
            // 
            // AddItemAllLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "AddItemAllLoginForm";
            Text = "AddItemAllLoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label url;
        public CustomControls.CustomTextBox urlTextBox3;
        public Label password;
        public CustomControls.CustomTextBox passwordTextBox2;
        public Label username;
        public CustomControls.CustomTextBox usernameTextBox1;
        public Label name;
        public CustomControls.CustomTextBox nameTextBox1;
        public CustomControls.CustomButton donebutton1;
    }
}