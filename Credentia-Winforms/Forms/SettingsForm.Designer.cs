namespace Credentia_Winforms
{
    partial class SettingsForm
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
            SettingsPanel = new Panel();
            SettingsDeletebtn = new CustomControls.CustomButton();
            customTextBox6 = new CustomControls.CustomTextBox();
            label6 = new Label();
            DeleteMPTextBox = new CustomControls.CustomTextBox();
            SettingsConfirmbtn = new CustomControls.CustomButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ConfirmPasswordTextBox = new CustomControls.CustomTextBox();
            NewPasswordTextBox = new CustomControls.CustomTextBox();
            CurrentPasswordTextBox = new CustomControls.CustomTextBox();
            label2 = new Label();
            label1 = new Label();
            customTextBox2 = new CustomControls.CustomTextBox();
            customTextBox1 = new CustomControls.CustomTextBox();
            STusername = new Label();
            ActiveUsernameLabel = new Label();
            SettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsPanel
            // 
            SettingsPanel.Anchor = AnchorStyles.None;
            SettingsPanel.BackColor = Color.FromArgb(238, 246, 247);
            SettingsPanel.Controls.Add(SettingsDeletebtn);
            SettingsPanel.Controls.Add(customTextBox6);
            SettingsPanel.Controls.Add(label6);
            SettingsPanel.Controls.Add(DeleteMPTextBox);
            SettingsPanel.Controls.Add(SettingsConfirmbtn);
            SettingsPanel.Controls.Add(label5);
            SettingsPanel.Controls.Add(label4);
            SettingsPanel.Controls.Add(label3);
            SettingsPanel.Controls.Add(ConfirmPasswordTextBox);
            SettingsPanel.Controls.Add(NewPasswordTextBox);
            SettingsPanel.Controls.Add(CurrentPasswordTextBox);
            SettingsPanel.Controls.Add(label2);
            SettingsPanel.Controls.Add(label1);
            SettingsPanel.Controls.Add(customTextBox2);
            SettingsPanel.Controls.Add(customTextBox1);
            SettingsPanel.Controls.Add(STusername);
            SettingsPanel.Controls.Add(ActiveUsernameLabel);
            SettingsPanel.Location = new Point(0, 0);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(743, 540);
            SettingsPanel.TabIndex = 0;
            // 
            // SettingsDeletebtn
            // 
            SettingsDeletebtn.BackColor = Color.Transparent;
            SettingsDeletebtn.BackgroundColor = Color.Transparent;
            SettingsDeletebtn.BorderColor = Color.FromArgb(252, 92, 52);
            SettingsDeletebtn.BorderRadius = 16;
            SettingsDeletebtn.BorderSize = 2;
            SettingsDeletebtn.FlatAppearance.BorderSize = 0;
            SettingsDeletebtn.FlatStyle = FlatStyle.Flat;
            SettingsDeletebtn.ForeColor = Color.Black;
            SettingsDeletebtn.Location = new Point(324, 483);
            SettingsDeletebtn.Name = "SettingsDeletebtn";
            SettingsDeletebtn.Size = new Size(81, 32);
            SettingsDeletebtn.TabIndex = 17;
            SettingsDeletebtn.Text = "Delete";
            SettingsDeletebtn.TextColor = Color.Black;
            SettingsDeletebtn.UseVisualStyleBackColor = false;
            SettingsDeletebtn.Click += SettingsDeletebtn_Click;
            // 
            // customTextBox6
            // 
            customTextBox6.BackColor = Color.FromArgb(238, 246, 247);
            customTextBox6.BackgroundImageLayout = ImageLayout.None;
            customTextBox6.BorderColor = Color.Transparent;
            customTextBox6.BorderFocusColor = Color.HotPink;
            customTextBox6.BorderRadius = 0;
            customTextBox6.BorderSize = 2;
            customTextBox6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customTextBox6.ForeColor = Color.Firebrick;
            customTextBox6.ImeMode = ImeMode.NoControl;
            customTextBox6.Location = new Point(151, 380);
            customTextBox6.Multiline = true;
            customTextBox6.Name = "customTextBox6";
            customTextBox6.Padding = new Padding(7);
            customTextBox6.PasswordChar = false;
            customTextBox6.PlaceholderColor = Color.DarkGray;
            customTextBox6.PlaceholderText = "";
            customTextBox6.Size = new Size(385, 50);
            customTextBox6.TabIndex = 16;
            customTextBox6.Texts = "Warning!  Deleting your account is permanent. It cannot be undone.";
            customTextBox6.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 450);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 15;
            label6.Text = "Master Password";
            // 
            // DeleteMPTextBox
            // 
            DeleteMPTextBox.BackColor = Color.FromArgb(217, 217, 217);
            DeleteMPTextBox.BorderColor = Color.Transparent;
            DeleteMPTextBox.BorderFocusColor = Color.HotPink;
            DeleteMPTextBox.BorderRadius = 16;
            DeleteMPTextBox.BorderSize = 2;
            DeleteMPTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteMPTextBox.ForeColor = Color.DimGray;
            DeleteMPTextBox.Location = new Point(290, 445);
            DeleteMPTextBox.Multiline = false;
            DeleteMPTextBox.Name = "DeleteMPTextBox";
            DeleteMPTextBox.Padding = new Padding(7);
            DeleteMPTextBox.PasswordChar = false;
            DeleteMPTextBox.PlaceholderColor = Color.DarkGray;
            DeleteMPTextBox.PlaceholderText = "";
            DeleteMPTextBox.Size = new Size(290, 32);
            DeleteMPTextBox.TabIndex = 14;
            DeleteMPTextBox.Texts = "";
            DeleteMPTextBox.UnderlinedStyle = false;
            // 
            // SettingsConfirmbtn
            // 
            SettingsConfirmbtn.BackColor = Color.Transparent;
            SettingsConfirmbtn.BackgroundColor = Color.Transparent;
            SettingsConfirmbtn.BorderColor = Color.FromArgb(252, 92, 52);
            SettingsConfirmbtn.BorderRadius = 16;
            SettingsConfirmbtn.BorderSize = 2;
            SettingsConfirmbtn.FlatAppearance.BorderSize = 0;
            SettingsConfirmbtn.FlatStyle = FlatStyle.Flat;
            SettingsConfirmbtn.ForeColor = Color.Black;
            SettingsConfirmbtn.Location = new Point(324, 277);
            SettingsConfirmbtn.Name = "SettingsConfirmbtn";
            SettingsConfirmbtn.Size = new Size(81, 32);
            SettingsConfirmbtn.TabIndex = 13;
            SettingsConfirmbtn.Text = "Confirm";
            SettingsConfirmbtn.TextColor = Color.Black;
            SettingsConfirmbtn.UseVisualStyleBackColor = false;
            SettingsConfirmbtn.Click += SettingsConfirmbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 231);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 12;
            label5.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 184);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 11;
            label4.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 134);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 10;
            label3.Text = "Current Password";
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.BackColor = Color.FromArgb(217, 217, 217);
            ConfirmPasswordTextBox.BorderColor = Color.Transparent;
            ConfirmPasswordTextBox.BorderFocusColor = Color.HotPink;
            ConfirmPasswordTextBox.BorderRadius = 16;
            ConfirmPasswordTextBox.BorderSize = 2;
            ConfirmPasswordTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmPasswordTextBox.ForeColor = Color.DimGray;
            ConfirmPasswordTextBox.Location = new Point(290, 225);
            ConfirmPasswordTextBox.Multiline = false;
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Padding = new Padding(7);
            ConfirmPasswordTextBox.PasswordChar = false;
            ConfirmPasswordTextBox.PlaceholderColor = Color.DarkGray;
            ConfirmPasswordTextBox.PlaceholderText = "";
            ConfirmPasswordTextBox.Size = new Size(290, 32);
            ConfirmPasswordTextBox.TabIndex = 9;
            ConfirmPasswordTextBox.Texts = "";
            ConfirmPasswordTextBox.UnderlinedStyle = false;
            // 
            // NewPasswordTextBox
            // 
            NewPasswordTextBox.BackColor = Color.FromArgb(217, 217, 217);
            NewPasswordTextBox.BorderColor = Color.Transparent;
            NewPasswordTextBox.BorderFocusColor = Color.HotPink;
            NewPasswordTextBox.BorderRadius = 16;
            NewPasswordTextBox.BorderSize = 2;
            NewPasswordTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewPasswordTextBox.ForeColor = Color.DimGray;
            NewPasswordTextBox.Location = new Point(290, 180);
            NewPasswordTextBox.Multiline = false;
            NewPasswordTextBox.Name = "NewPasswordTextBox";
            NewPasswordTextBox.Padding = new Padding(7);
            NewPasswordTextBox.PasswordChar = false;
            NewPasswordTextBox.PlaceholderColor = Color.DarkGray;
            NewPasswordTextBox.PlaceholderText = "";
            NewPasswordTextBox.Size = new Size(290, 32);
            NewPasswordTextBox.TabIndex = 8;
            NewPasswordTextBox.Texts = "";
            NewPasswordTextBox.UnderlinedStyle = false;
            // 
            // CurrentPasswordTextBox
            // 
            CurrentPasswordTextBox.BackColor = Color.FromArgb(217, 217, 217);
            CurrentPasswordTextBox.BorderColor = Color.Transparent;
            CurrentPasswordTextBox.BorderFocusColor = Color.HotPink;
            CurrentPasswordTextBox.BorderRadius = 16;
            CurrentPasswordTextBox.BorderSize = 2;
            CurrentPasswordTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CurrentPasswordTextBox.ForeColor = Color.DimGray;
            CurrentPasswordTextBox.Location = new Point(290, 130);
            CurrentPasswordTextBox.Multiline = false;
            CurrentPasswordTextBox.Name = "CurrentPasswordTextBox";
            CurrentPasswordTextBox.Padding = new Padding(7);
            CurrentPasswordTextBox.PasswordChar = false;
            CurrentPasswordTextBox.PlaceholderColor = Color.DarkGray;
            CurrentPasswordTextBox.PlaceholderText = "";
            CurrentPasswordTextBox.Size = new Size(290, 32);
            CurrentPasswordTextBox.TabIndex = 7;
            CurrentPasswordTextBox.Texts = "";
            CurrentPasswordTextBox.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(122, 356);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 6;
            label2.Text = "Delete Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(122, 99);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 5;
            label1.Text = "Change Password";
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = Color.FromArgb(238, 246, 247);
            customTextBox2.BorderColor = Color.Gray;
            customTextBox2.BorderFocusColor = Color.HotPink;
            customTextBox2.BorderRadius = 0;
            customTextBox2.BorderSize = 2;
            customTextBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customTextBox2.ForeColor = Color.DimGray;
            customTextBox2.Location = new Point(113, 344);
            customTextBox2.Multiline = true;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(7);
            customTextBox2.PasswordChar = false;
            customTextBox2.PlaceholderColor = Color.DarkGray;
            customTextBox2.PlaceholderText = "";
            customTextBox2.Size = new Size(490, 184);
            customTextBox2.TabIndex = 4;
            customTextBox2.Texts = "";
            customTextBox2.UnderlinedStyle = false;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.FromArgb(238, 246, 247);
            customTextBox1.BorderColor = Color.Gray;
            customTextBox1.BorderFocusColor = Color.HotPink;
            customTextBox1.BorderRadius = 0;
            customTextBox1.BorderSize = 2;
            customTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(113, 89);
            customTextBox1.Multiline = true;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "";
            customTextBox1.Size = new Size(490, 236);
            customTextBox1.TabIndex = 3;
            customTextBox1.Texts = "";
            customTextBox1.UnderlinedStyle = false;
            // 
            // STusername
            // 
            STusername.AutoSize = true;
            STusername.Location = new Point(221, 36);
            STusername.Name = "STusername";
            STusername.Size = new Size(84, 21);
            STusername.TabIndex = 1;
            STusername.Text = "Username:";
            // 
            // ActiveUsernameLabel
            // 
            ActiveUsernameLabel.AutoSize = true;
            ActiveUsernameLabel.Location = new Point(311, 36);
            ActiveUsernameLabel.Name = "ActiveUsernameLabel";
            ActiveUsernameLabel.Size = new Size(127, 21);
            ActiveUsernameLabel.TabIndex = 0;
            ActiveUsernameLabel.Text = "Active Username";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 246, 247);
            ClientSize = new Size(743, 540);
            Controls.Add(SettingsPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            SettingsPanel.ResumeLayout(false);
            SettingsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CustomControls.CustomTextBox ComboBox;
        private Panel SettingsPanel;
        private Label ActiveUsernameLabel;
        private Label STusername;
        private CustomControls.CustomTextBox customTextBox2;
        private CustomControls.CustomTextBox customTextBox1;
        private Label label2;
        private Label label1;
        private CustomControls.CustomTextBox NewPasswordTextBox;
        private CustomControls.CustomTextBox CurrentPasswordTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private CustomControls.CustomTextBox ConfirmPasswordTextBox;
        public CustomControls.CustomButton SettingsConfirmbtn;
        private CustomControls.CustomTextBox customTextBox6;
        private Label label6;
        private CustomControls.CustomTextBox DeleteMPTextBox;
        public CustomControls.CustomButton SettingsDeletebtn;
    }
}