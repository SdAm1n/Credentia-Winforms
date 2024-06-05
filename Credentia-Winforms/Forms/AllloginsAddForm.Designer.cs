namespace Credentia_Winforms.Forms
{
    partial class AllloginsAddForm
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
            AllloginsAddpanel = new Panel();
            AllloginsAddSubmitbtn = new CustomControls.CustomButton();
            AllloginsPassword = new Label();
            AllloginsAddname = new Label();
            AllloginsUrlBox = new Label();
            AllloginsAddPasswordBox = new CustomControls.CustomTextBox();
            AllloginsAddURlBox = new CustomControls.CustomTextBox();
            AllloginsAddUsername = new Label();
            AllloginsAddUsernameBox = new CustomControls.CustomTextBox();
            AllloginsAddNameBox = new CustomControls.CustomTextBox();
            AllloginsAddpanel.SuspendLayout();
            SuspendLayout();
            // 
            // AllloginsAddpanel
            // 
            AllloginsAddpanel.BackColor = Color.FromArgb(238, 246, 247);
            AllloginsAddpanel.Controls.Add(AllloginsAddSubmitbtn);
            AllloginsAddpanel.Controls.Add(AllloginsPassword);
            AllloginsAddpanel.Controls.Add(AllloginsAddname);
            AllloginsAddpanel.Controls.Add(AllloginsUrlBox);
            AllloginsAddpanel.Controls.Add(AllloginsAddPasswordBox);
            AllloginsAddpanel.Controls.Add(AllloginsAddURlBox);
            AllloginsAddpanel.Controls.Add(AllloginsAddUsername);
            AllloginsAddpanel.Controls.Add(AllloginsAddUsernameBox);
            AllloginsAddpanel.Controls.Add(AllloginsAddNameBox);
            AllloginsAddpanel.Location = new Point(0, -2);
            AllloginsAddpanel.Name = "AllloginsAddpanel";
            AllloginsAddpanel.Size = new Size(719, 458);
            AllloginsAddpanel.TabIndex = 10;
            // 
            // AllloginsAddSubmitbtn
            // 
            AllloginsAddSubmitbtn.BackColor = Color.FromArgb(238, 246, 247);
            AllloginsAddSubmitbtn.BackgroundColor = Color.FromArgb(238, 246, 247);
            AllloginsAddSubmitbtn.BorderColor = Color.FromArgb(252, 92, 52);
            AllloginsAddSubmitbtn.BorderRadius = 16;
            AllloginsAddSubmitbtn.BorderSize = 2;
            AllloginsAddSubmitbtn.FlatAppearance.BorderSize = 0;
            AllloginsAddSubmitbtn.FlatStyle = FlatStyle.Flat;
            AllloginsAddSubmitbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsAddSubmitbtn.ForeColor = Color.Black;
            AllloginsAddSubmitbtn.Location = new Point(303, 369);
            AllloginsAddSubmitbtn.Name = "AllloginsAddSubmitbtn";
            AllloginsAddSubmitbtn.Size = new Size(79, 33);
            AllloginsAddSubmitbtn.TabIndex = 4;
            AllloginsAddSubmitbtn.Text = "Submit";
            AllloginsAddSubmitbtn.TextColor = Color.Black;
            AllloginsAddSubmitbtn.UseVisualStyleBackColor = false;
            AllloginsAddSubmitbtn.Click += AllloginsAddSubmitbtn_Click;
            // 
            // AllloginsPassword
            // 
            AllloginsPassword.AutoSize = true;
            AllloginsPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsPassword.Location = new Point(123, 235);
            AllloginsPassword.Name = "AllloginsPassword";
            AllloginsPassword.Size = new Size(76, 21);
            AllloginsPassword.TabIndex = 22;
            AllloginsPassword.Text = "Password";
            AllloginsPassword.Click += AllloginsPassword_Click;
            // 
            // AllloginsAddname
            // 
            AllloginsAddname.AutoSize = true;
            AllloginsAddname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsAddname.Location = new Point(132, 51);
            AllloginsAddname.Name = "AllloginsAddname";
            AllloginsAddname.Size = new Size(52, 21);
            AllloginsAddname.TabIndex = 21;
            AllloginsAddname.Text = "Name";
            // 
            // AllloginsUrlBox
            // 
            AllloginsUrlBox.AutoSize = true;
            AllloginsUrlBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsUrlBox.Location = new Point(123, 331);
            AllloginsUrlBox.Name = "AllloginsUrlBox";
            AllloginsUrlBox.Size = new Size(39, 21);
            AllloginsUrlBox.TabIndex = 20;
            AllloginsUrlBox.Text = "URL";
            // 
            // AllloginsAddPasswordBox
            // 
            AllloginsAddPasswordBox.BackColor = Color.FromArgb(217, 217, 217);
            AllloginsAddPasswordBox.BorderColor = Color.FromArgb(217, 217, 217);
            AllloginsAddPasswordBox.BorderFocusColor = Color.HotPink;
            AllloginsAddPasswordBox.BorderRadius = 10;
            AllloginsAddPasswordBox.BorderSize = 2;
            AllloginsAddPasswordBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsAddPasswordBox.ForeColor = Color.Black;
            AllloginsAddPasswordBox.Location = new Point(215, 220);
            AllloginsAddPasswordBox.Multiline = false;
            AllloginsAddPasswordBox.Name = "AllloginsAddPasswordBox";
            AllloginsAddPasswordBox.Padding = new Padding(7);
            AllloginsAddPasswordBox.PasswordChar = false;
            AllloginsAddPasswordBox.PlaceholderColor = Color.DarkGray;
            AllloginsAddPasswordBox.PlaceholderText = "";
            AllloginsAddPasswordBox.Size = new Size(294, 36);
            AllloginsAddPasswordBox.TabIndex = 2;
            AllloginsAddPasswordBox.Texts = "";
            AllloginsAddPasswordBox.UnderlinedStyle = false;
            // 
            // AllloginsAddURlBox
            // 
            AllloginsAddURlBox.BackColor = Color.FromArgb(217, 217, 217);
            AllloginsAddURlBox.BorderColor = Color.FromArgb(217, 217, 217);
            AllloginsAddURlBox.BorderFocusColor = Color.HotPink;
            AllloginsAddURlBox.BorderRadius = 10;
            AllloginsAddURlBox.BorderSize = 2;
            AllloginsAddURlBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsAddURlBox.ForeColor = Color.Black;
            AllloginsAddURlBox.Location = new Point(215, 316);
            AllloginsAddURlBox.Multiline = false;
            AllloginsAddURlBox.Name = "AllloginsAddURlBox";
            AllloginsAddURlBox.Padding = new Padding(7);
            AllloginsAddURlBox.PasswordChar = false;
            AllloginsAddURlBox.PlaceholderColor = Color.DarkGray;
            AllloginsAddURlBox.PlaceholderText = "";
            AllloginsAddURlBox.Size = new Size(294, 36);
            AllloginsAddURlBox.TabIndex = 3;
            AllloginsAddURlBox.Texts = "";
            AllloginsAddURlBox.UnderlinedStyle = false;
            AllloginsAddURlBox._TextChanged += AllloginsAddURlBox__TextChanged;
            // 
            // AllloginsAddUsername
            // 
            AllloginsAddUsername.AutoSize = true;
            AllloginsAddUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsAddUsername.Location = new Point(118, 147);
            AllloginsAddUsername.Name = "AllloginsAddUsername";
            AllloginsAddUsername.Size = new Size(81, 21);
            AllloginsAddUsername.TabIndex = 16;
            AllloginsAddUsername.Text = "Username";
            // 
            // AllloginsAddUsernameBox
            // 
            AllloginsAddUsernameBox.BackColor = Color.FromArgb(217, 217, 217);
            AllloginsAddUsernameBox.BorderColor = Color.FromArgb(217, 217, 217);
            AllloginsAddUsernameBox.BorderFocusColor = Color.HotPink;
            AllloginsAddUsernameBox.BorderRadius = 10;
            AllloginsAddUsernameBox.BorderSize = 2;
            AllloginsAddUsernameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsAddUsernameBox.ForeColor = Color.Black;
            AllloginsAddUsernameBox.Location = new Point(215, 132);
            AllloginsAddUsernameBox.Multiline = false;
            AllloginsAddUsernameBox.Name = "AllloginsAddUsernameBox";
            AllloginsAddUsernameBox.Padding = new Padding(7);
            AllloginsAddUsernameBox.PasswordChar = false;
            AllloginsAddUsernameBox.PlaceholderColor = Color.DarkGray;
            AllloginsAddUsernameBox.PlaceholderText = "";
            AllloginsAddUsernameBox.Size = new Size(294, 36);
            AllloginsAddUsernameBox.TabIndex = 1;
            AllloginsAddUsernameBox.Texts = "";
            AllloginsAddUsernameBox.UnderlinedStyle = false;
            // 
            // AllloginsAddNameBox
            // 
            AllloginsAddNameBox.BackColor = Color.FromArgb(217, 217, 217);
            AllloginsAddNameBox.BorderColor = Color.FromArgb(217, 217, 217);
            AllloginsAddNameBox.BorderFocusColor = Color.HotPink;
            AllloginsAddNameBox.BorderRadius = 10;
            AllloginsAddNameBox.BorderSize = 2;
            AllloginsAddNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsAddNameBox.ForeColor = Color.Black;
            AllloginsAddNameBox.Location = new Point(215, 51);
            AllloginsAddNameBox.Multiline = false;
            AllloginsAddNameBox.Name = "AllloginsAddNameBox";
            AllloginsAddNameBox.Padding = new Padding(7);
            AllloginsAddNameBox.PasswordChar = false;
            AllloginsAddNameBox.PlaceholderColor = Color.DarkGray;
            AllloginsAddNameBox.PlaceholderText = "";
            AllloginsAddNameBox.Size = new Size(294, 36);
            AllloginsAddNameBox.TabIndex = 0;
            AllloginsAddNameBox.Texts = "";
            AllloginsAddNameBox.UnderlinedStyle = false;
            // 
            // AllloginsAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 454);
            Controls.Add(AllloginsAddpanel);
            Name = "AllloginsAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllloginsAddForm";
            AllloginsAddpanel.ResumeLayout(false);
            AllloginsAddpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AllloginsAddpanel;
        public Label AllloginsUrlBox;
        public CustomControls.CustomTextBox AllloginsAddPasswordBox;
        public CustomControls.CustomTextBox AllloginsAddURlBox;
        public Label AllloginsAddUsername;
        public CustomControls.CustomTextBox AllloginsAddUsernameBox;
        public CustomControls.CustomTextBox AllloginsAddNameBox;
        public Label AllloginsAddname;
        public Label AllloginsPassword;
        public CustomControls.CustomButton AllloginsAddSubmitbtn;
    }
}