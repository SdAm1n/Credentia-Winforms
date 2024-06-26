﻿namespace Credentia_Winforms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            DockPanel1 = new Panel();
            pictureBox1 = new PictureBox();
            DockPanel2 = new Panel();
            ShowPasswordLabel = new Label();
            ShowPasswordToggle = new CustomControls.CustomToggleButton();
            CreateAccLinkLabel = new LinkLabel();
            CreateAccLabel = new Label();
            LoginBtn = new CustomControls.CustomButton();
            PasswordTextBox = new CustomControls.CustomTextBox();
            UsernameTextBox = new CustomControls.CustomTextBox();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            UsernameErrorProvider = new ErrorProvider(components);
            PasswordErrorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            DockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            DockPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsernameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasswordErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(DockPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1029, 630);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(DockPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 624);
            panel1.TabIndex = 0;
            // 
            // DockPanel1
            // 
            DockPanel1.Controls.Add(pictureBox1);
            DockPanel1.Dock = DockStyle.Fill;
            DockPanel1.Location = new Point(0, 0);
            DockPanel1.Name = "DockPanel1";
            DockPanel1.Size = new Size(405, 624);
            DockPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo_no_background;
            pictureBox1.Location = new Point(52, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DockPanel2
            // 
            DockPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DockPanel2.Controls.Add(ShowPasswordLabel);
            DockPanel2.Controls.Add(ShowPasswordToggle);
            DockPanel2.Controls.Add(CreateAccLinkLabel);
            DockPanel2.Controls.Add(CreateAccLabel);
            DockPanel2.Controls.Add(LoginBtn);
            DockPanel2.Controls.Add(PasswordTextBox);
            DockPanel2.Controls.Add(UsernameTextBox);
            DockPanel2.Controls.Add(PasswordLabel);
            DockPanel2.Controls.Add(UsernameLabel);
            DockPanel2.Location = new Point(414, 72);
            DockPanel2.Name = "DockPanel2";
            DockPanel2.Size = new Size(612, 485);
            DockPanel2.TabIndex = 1;
            DockPanel2.Paint += DockPanel2_Paint;
            // 
            // ShowPasswordLabel
            // 
            ShowPasswordLabel.AutoSize = true;
            ShowPasswordLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordLabel.Location = new Point(507, 235);
            ShowPasswordLabel.Name = "ShowPasswordLabel";
            ShowPasswordLabel.Size = new Size(99, 17);
            ShowPasswordLabel.TabIndex = 5;
            ShowPasswordLabel.Text = "Show Password";
            // 
            // ShowPasswordToggle
            // 
            ShowPasswordToggle.AutoSize = true;
            ShowPasswordToggle.Location = new Point(463, 235);
            ShowPasswordToggle.MinimumSize = new Size(38, 20);
            ShowPasswordToggle.Name = "ShowPasswordToggle";
            ShowPasswordToggle.OffBackColor = Color.Gray;
            ShowPasswordToggle.OffToggleColor = Color.Gainsboro;
            ShowPasswordToggle.OnBackColor = Color.Crimson;
            ShowPasswordToggle.OnToggleColor = Color.WhiteSmoke;
            ShowPasswordToggle.Size = new Size(38, 20);
            ShowPasswordToggle.TabIndex = 4;
            ShowPasswordToggle.UseVisualStyleBackColor = true;
            ShowPasswordToggle.CheckedChanged += ShowPasswordToggle_CheckedChanged;
            // 
            // CreateAccLinkLabel
            // 
            CreateAccLinkLabel.AutoSize = true;
            CreateAccLinkLabel.Location = new Point(374, 404);
            CreateAccLinkLabel.Name = "CreateAccLinkLabel";
            CreateAccLinkLabel.Size = new Size(115, 21);
            CreateAccLinkLabel.TabIndex = 3;
            CreateAccLinkLabel.TabStop = true;
            CreateAccLinkLabel.Text = "Create Account";
            CreateAccLinkLabel.LinkClicked += CreateAccLinkLabel_LinkClicked;
            // 
            // CreateAccLabel
            // 
            CreateAccLabel.AutoSize = true;
            CreateAccLabel.Location = new Point(159, 404);
            CreateAccLabel.Name = "CreateAccLabel";
            CreateAccLabel.Size = new Size(209, 21);
            CreateAccLabel.TabIndex = 3;
            CreateAccLabel.Text = "Don’t you have any account?";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Transparent;
            LoginBtn.BackgroundColor = Color.Transparent;
            LoginBtn.BorderColor = Color.FromArgb(251, 79, 54);
            LoginBtn.BorderRadius = 20;
            LoginBtn.BorderSize = 2;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.FromArgb(251, 79, 54);
            LoginBtn.Location = new Point(251, 299);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(150, 40);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.TextColor = Color.FromArgb(251, 79, 54);
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(217, 217, 217);
            PasswordTextBox.BorderColor = Color.FromArgb(217, 217, 217);
            PasswordTextBox.BorderFocusColor = Color.FromArgb(217, 217, 217);
            PasswordTextBox.BorderRadius = 10;
            PasswordTextBox.BorderSize = 2;
            PasswordTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.ForeColor = Color.DimGray;
            PasswordTextBox.Location = new Point(251, 183);
            PasswordTextBox.Multiline = false;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Padding = new Padding(7);
            PasswordTextBox.PasswordChar = true;
            PasswordTextBox.PlaceholderColor = Color.DarkGray;
            PasswordTextBox.PlaceholderText = "";
            PasswordTextBox.Size = new Size(250, 32);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.Texts = "";
            PasswordTextBox.UnderlinedStyle = false;
            PasswordTextBox.Leave += PasswordTextBox_Leave;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BackColor = Color.FromArgb(217, 217, 217);
            UsernameTextBox.BorderColor = Color.FromArgb(217, 217, 217);
            UsernameTextBox.BorderFocusColor = Color.FromArgb(217, 217, 217);
            UsernameTextBox.BorderRadius = 10;
            UsernameTextBox.BorderSize = 2;
            UsernameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTextBox.ForeColor = Color.DimGray;
            UsernameTextBox.Location = new Point(251, 98);
            UsernameTextBox.Multiline = false;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Padding = new Padding(7);
            UsernameTextBox.PasswordChar = false;
            UsernameTextBox.PlaceholderColor = Color.DarkGray;
            UsernameTextBox.PlaceholderText = "";
            UsernameTextBox.Size = new Size(250, 32);
            UsernameTextBox.TabIndex = 0;
            UsernameTextBox.Texts = "";
            UsernameTextBox.UnderlinedStyle = false;
            UsernameTextBox.Leave += UsernameTextBox_Leave;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(103, 194);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(128, 21);
            PasswordLabel.TabIndex = 0;
            PasswordLabel.Text = "Master Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(103, 109);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(81, 21);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";
            // 
            // UsernameErrorProvider
            // 
            UsernameErrorProvider.ContainerControl = this;
            // 
            // PasswordErrorProvider
            // 
            PasswordErrorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Credentia";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            DockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            DockPanel2.ResumeLayout(false);
            DockPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsernameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasswordErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel DockPanel1;
        private PictureBox pictureBox1;
        private Panel DockPanel2;
        private CustomControls.CustomButton LoginBtn;
        private CustomControls.CustomTextBox UsernameTextBox;
        private Label UsernameLabel;
        private LinkLabel CreateAccLinkLabel;
        private Label CreateAccLabel;
        private CustomControls.CustomTextBox PasswordTextBox;
        private Label PasswordLabel;
        private ErrorProvider UsernameErrorProvider;
        private ErrorProvider PasswordErrorProvider;
        private CustomControls.CustomToggleButton ShowPasswordToggle;
        private Label ShowPasswordLabel;
    }
}
