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
            AllloginsAddpanel.Controls.Add(AllloginsAddSubmitbtn);
            AllloginsAddpanel.Controls.Add(AllloginsPassword);
            AllloginsAddpanel.Controls.Add(AllloginsAddname);
            AllloginsAddpanel.Controls.Add(AllloginsUrlBox);
            AllloginsAddpanel.Controls.Add(AllloginsAddPasswordBox);
            AllloginsAddpanel.Controls.Add(AllloginsAddURlBox);
            AllloginsAddpanel.Controls.Add(AllloginsAddUsername);
            AllloginsAddpanel.Controls.Add(AllloginsAddUsernameBox);
            AllloginsAddpanel.Controls.Add(AllloginsAddNameBox);
            AllloginsAddpanel.Location = new Point(0, -3);
            AllloginsAddpanel.Name = "AllloginsAddpanel";
            AllloginsAddpanel.Size = new Size(819, 478);
            AllloginsAddpanel.TabIndex = 10;
            // 
            // AllloginsAddSubmitbtn
            // 
            AllloginsAddSubmitbtn.BackColor = Color.MediumSlateBlue;
            AllloginsAddSubmitbtn.BackgroundColor = Color.MediumSlateBlue;
            AllloginsAddSubmitbtn.BorderColor = Color.PaleVioletRed;
            AllloginsAddSubmitbtn.BorderRadius = 10;
            AllloginsAddSubmitbtn.BorderSize = 0;
            AllloginsAddSubmitbtn.FlatAppearance.BorderSize = 0;
            AllloginsAddSubmitbtn.FlatStyle = FlatStyle.Flat;
            AllloginsAddSubmitbtn.ForeColor = Color.White;
            AllloginsAddSubmitbtn.Location = new Point(336, 375);
            AllloginsAddSubmitbtn.Name = "AllloginsAddSubmitbtn";
            AllloginsAddSubmitbtn.Size = new Size(79, 28);
            AllloginsAddSubmitbtn.TabIndex = 23;
            AllloginsAddSubmitbtn.Text = "Submit";
            AllloginsAddSubmitbtn.TextColor = Color.White;
            AllloginsAddSubmitbtn.UseVisualStyleBackColor = false;
            AllloginsAddSubmitbtn.Click += AllloginsAddSubmitbtn_Click;
            // 
            // AllloginsPassword
            // 
            AllloginsPassword.AutoSize = true;
            AllloginsPassword.Location = new Point(256, 202);
            AllloginsPassword.Name = "AllloginsPassword";
            AllloginsPassword.Size = new Size(57, 15);
            AllloginsPassword.TabIndex = 22;
            AllloginsPassword.Text = "Password";
            AllloginsPassword.Click += AllloginsPassword_Click;
            // 
            // AllloginsAddname
            // 
            AllloginsAddname.AutoSize = true;
            AllloginsAddname.Location = new Point(256, 33);
            AllloginsAddname.Name = "AllloginsAddname";
            AllloginsAddname.Size = new Size(39, 15);
            AllloginsAddname.TabIndex = 21;
            AllloginsAddname.Text = "Name";
            // 
            // AllloginsUrlBox
            // 
            AllloginsUrlBox.AutoSize = true;
            AllloginsUrlBox.Location = new Point(256, 281);
            AllloginsUrlBox.Name = "AllloginsUrlBox";
            AllloginsUrlBox.Size = new Size(28, 15);
            AllloginsUrlBox.TabIndex = 20;
            AllloginsUrlBox.Text = "URL";
            // 
            // AllloginsAddPasswordBox
            // 
            AllloginsAddPasswordBox.BackColor = SystemColors.Window;
            AllloginsAddPasswordBox.BorderColor = Color.MediumSlateBlue;
            AllloginsAddPasswordBox.BorderFocusColor = Color.HotPink;
            AllloginsAddPasswordBox.BorderRadius = 10;
            AllloginsAddPasswordBox.BorderSize = 2;
            AllloginsAddPasswordBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsAddPasswordBox.ForeColor = Color.DimGray;
            AllloginsAddPasswordBox.Location = new Point(246, 220);
            AllloginsAddPasswordBox.Multiline = false;
            AllloginsAddPasswordBox.Name = "AllloginsAddPasswordBox";
            AllloginsAddPasswordBox.Padding = new Padding(7);
            AllloginsAddPasswordBox.PasswordChar = false;
            AllloginsAddPasswordBox.PlaceholderColor = Color.DarkGray;
            AllloginsAddPasswordBox.PlaceholderText = "";
            AllloginsAddPasswordBox.Size = new Size(250, 32);
            AllloginsAddPasswordBox.TabIndex = 18;
            AllloginsAddPasswordBox.Texts = "";
            AllloginsAddPasswordBox.UnderlinedStyle = false;
            // 
            // AllloginsAddURlBox
            // 
            AllloginsAddURlBox.BackColor = SystemColors.Window;
            AllloginsAddURlBox.BorderColor = Color.MediumSlateBlue;
            AllloginsAddURlBox.BorderFocusColor = Color.HotPink;
            AllloginsAddURlBox.BorderRadius = 10;
            AllloginsAddURlBox.BorderSize = 2;
            AllloginsAddURlBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsAddURlBox.ForeColor = Color.DimGray;
            AllloginsAddURlBox.Location = new Point(246, 308);
            AllloginsAddURlBox.Multiline = false;
            AllloginsAddURlBox.Name = "AllloginsAddURlBox";
            AllloginsAddURlBox.Padding = new Padding(7);
            AllloginsAddURlBox.PasswordChar = false;
            AllloginsAddURlBox.PlaceholderColor = Color.DarkGray;
            AllloginsAddURlBox.PlaceholderText = "";
            AllloginsAddURlBox.Size = new Size(250, 32);
            AllloginsAddURlBox.TabIndex = 17;
            AllloginsAddURlBox.Texts = "";
            AllloginsAddURlBox.UnderlinedStyle = false;
            AllloginsAddURlBox._TextChanged += AllloginsAddURlBox__TextChanged;
            // 
            // AllloginsAddUsername
            // 
            AllloginsAddUsername.AutoSize = true;
            AllloginsAddUsername.Location = new Point(256, 114);
            AllloginsAddUsername.Name = "AllloginsAddUsername";
            AllloginsAddUsername.Size = new Size(60, 15);
            AllloginsAddUsername.TabIndex = 16;
            AllloginsAddUsername.Text = "Username";
            // 
            // AllloginsAddUsernameBox
            // 
            AllloginsAddUsernameBox.BackColor = SystemColors.Window;
            AllloginsAddUsernameBox.BorderColor = Color.MediumSlateBlue;
            AllloginsAddUsernameBox.BorderFocusColor = Color.HotPink;
            AllloginsAddUsernameBox.BorderRadius = 10;
            AllloginsAddUsernameBox.BorderSize = 2;
            AllloginsAddUsernameBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsAddUsernameBox.ForeColor = Color.DimGray;
            AllloginsAddUsernameBox.Location = new Point(246, 132);
            AllloginsAddUsernameBox.Multiline = false;
            AllloginsAddUsernameBox.Name = "AllloginsAddUsernameBox";
            AllloginsAddUsernameBox.Padding = new Padding(7);
            AllloginsAddUsernameBox.PasswordChar = false;
            AllloginsAddUsernameBox.PlaceholderColor = Color.DarkGray;
            AllloginsAddUsernameBox.PlaceholderText = "";
            AllloginsAddUsernameBox.Size = new Size(250, 32);
            AllloginsAddUsernameBox.TabIndex = 14;
            AllloginsAddUsernameBox.Texts = "";
            AllloginsAddUsernameBox.UnderlinedStyle = false;
            // 
            // AllloginsAddNameBox
            // 
            AllloginsAddNameBox.BackColor = SystemColors.Window;
            AllloginsAddNameBox.BorderColor = Color.MediumSlateBlue;
            AllloginsAddNameBox.BorderFocusColor = Color.HotPink;
            AllloginsAddNameBox.BorderRadius = 10;
            AllloginsAddNameBox.BorderSize = 2;
            AllloginsAddNameBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsAddNameBox.ForeColor = Color.DimGray;
            AllloginsAddNameBox.Location = new Point(246, 51);
            AllloginsAddNameBox.Multiline = false;
            AllloginsAddNameBox.Name = "AllloginsAddNameBox";
            AllloginsAddNameBox.Padding = new Padding(7);
            AllloginsAddNameBox.PasswordChar = false;
            AllloginsAddNameBox.PlaceholderColor = Color.DarkGray;
            AllloginsAddNameBox.PlaceholderText = "";
            AllloginsAddNameBox.Size = new Size(250, 32);
            AllloginsAddNameBox.TabIndex = 0;
            AllloginsAddNameBox.Texts = "";
            AllloginsAddNameBox.UnderlinedStyle = false;
            // 
            // AllloginsAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 411);
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