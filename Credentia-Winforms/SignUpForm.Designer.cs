namespace Credentia_Winforms
{
    partial class SignUpForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            DockPanel1 = new Panel();
            LogoPictureBox = new PictureBox();
            DockPanel2 = new Panel();
            SignUpBtn = new CustomControls.CustomButton();
            CancelBtn = new CustomControls.CustomButton();
            EmailTextBox = new CustomControls.CustomTextBox();
            PasswordTextBox = new CustomControls.CustomTextBox();
            ConfirmPasswordTextBox = new CustomControls.CustomTextBox();
            UsernameTextBox = new CustomControls.CustomTextBox();
            EmailLabel = new Label();
            ConfirmPasswordLabel = new Label();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            DockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            DockPanel2.SuspendLayout();
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
            tableLayoutPanel1.TabIndex = 1;
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
            DockPanel1.Controls.Add(LogoPictureBox);
            DockPanel1.Dock = DockStyle.Fill;
            DockPanel1.Location = new Point(0, 0);
            DockPanel1.Name = "DockPanel1";
            DockPanel1.Size = new Size(405, 624);
            DockPanel1.TabIndex = 0;
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LogoPictureBox.Image = Properties.Resources.logo_no_background;
            LogoPictureBox.Location = new Point(27, 197);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(378, 230);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPictureBox.TabIndex = 0;
            LogoPictureBox.TabStop = false;
            // 
            // DockPanel2
            // 
            DockPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DockPanel2.Controls.Add(SignUpBtn);
            DockPanel2.Controls.Add(CancelBtn);
            DockPanel2.Controls.Add(EmailTextBox);
            DockPanel2.Controls.Add(PasswordTextBox);
            DockPanel2.Controls.Add(ConfirmPasswordTextBox);
            DockPanel2.Controls.Add(UsernameTextBox);
            DockPanel2.Controls.Add(EmailLabel);
            DockPanel2.Controls.Add(ConfirmPasswordLabel);
            DockPanel2.Controls.Add(PasswordLabel);
            DockPanel2.Controls.Add(UsernameLabel);
            DockPanel2.Location = new Point(414, 70);
            DockPanel2.Name = "DockPanel2";
            DockPanel2.Size = new Size(612, 490);
            DockPanel2.TabIndex = 1;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.Transparent;
            SignUpBtn.BackgroundColor = Color.Transparent;
            SignUpBtn.BorderColor = Color.Crimson;
            SignUpBtn.BorderRadius = 20;
            SignUpBtn.BorderSize = 2;
            SignUpBtn.FlatAppearance.BorderSize = 0;
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.ForeColor = Color.Black;
            SignUpBtn.Location = new Point(271, 364);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(150, 40);
            SignUpBtn.TabIndex = 4;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.TextColor = Color.Black;
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.Transparent;
            CancelBtn.BackgroundColor = Color.Transparent;
            CancelBtn.BorderColor = Color.Crimson;
            CancelBtn.BorderRadius = 20;
            CancelBtn.BorderSize = 2;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.ForeColor = Color.Black;
            CancelBtn.Location = new Point(271, 434);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(150, 40);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Cancel";
            CancelBtn.TextColor = Color.Black;
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = SystemColors.Window;
            EmailTextBox.BorderColor = Color.Crimson;
            EmailTextBox.BorderFocusColor = Color.HotPink;
            EmailTextBox.BorderRadius = 10;
            EmailTextBox.BorderSize = 2;
            EmailTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTextBox.ForeColor = Color.DimGray;
            EmailTextBox.Location = new Point(271, 285);
            EmailTextBox.Multiline = false;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Padding = new Padding(7);
            EmailTextBox.PasswordChar = false;
            EmailTextBox.PlaceholderColor = Color.DarkGray;
            EmailTextBox.PlaceholderText = "";
            EmailTextBox.Size = new Size(250, 32);
            EmailTextBox.TabIndex = 3;
            EmailTextBox.Texts = "";
            EmailTextBox.UnderlinedStyle = false;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = SystemColors.Window;
            PasswordTextBox.BorderColor = Color.Crimson;
            PasswordTextBox.BorderFocusColor = Color.HotPink;
            PasswordTextBox.BorderRadius = 10;
            PasswordTextBox.BorderSize = 2;
            PasswordTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.ForeColor = Color.DimGray;
            PasswordTextBox.Location = new Point(271, 119);
            PasswordTextBox.Multiline = false;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Padding = new Padding(7);
            PasswordTextBox.PasswordChar = false;
            PasswordTextBox.PlaceholderColor = Color.DarkGray;
            PasswordTextBox.PlaceholderText = "";
            PasswordTextBox.Size = new Size(250, 32);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.Texts = "";
            PasswordTextBox.UnderlinedStyle = false;
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.BackColor = SystemColors.Window;
            ConfirmPasswordTextBox.BorderColor = Color.Crimson;
            ConfirmPasswordTextBox.BorderFocusColor = Color.HotPink;
            ConfirmPasswordTextBox.BorderRadius = 10;
            ConfirmPasswordTextBox.BorderSize = 2;
            ConfirmPasswordTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmPasswordTextBox.ForeColor = Color.DimGray;
            ConfirmPasswordTextBox.Location = new Point(271, 200);
            ConfirmPasswordTextBox.Multiline = false;
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Padding = new Padding(7);
            ConfirmPasswordTextBox.PasswordChar = false;
            ConfirmPasswordTextBox.PlaceholderColor = Color.DarkGray;
            ConfirmPasswordTextBox.PlaceholderText = "";
            ConfirmPasswordTextBox.Size = new Size(250, 32);
            ConfirmPasswordTextBox.TabIndex = 2;
            ConfirmPasswordTextBox.Texts = "";
            ConfirmPasswordTextBox.UnderlinedStyle = false;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BackColor = SystemColors.Window;
            UsernameTextBox.BorderColor = Color.Crimson;
            UsernameTextBox.BorderFocusColor = Color.HotPink;
            UsernameTextBox.BorderRadius = 10;
            UsernameTextBox.BorderSize = 2;
            UsernameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTextBox.ForeColor = Color.DimGray;
            UsernameTextBox.Location = new Point(271, 34);
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
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(106, 296);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(48, 21);
            EmailLabel.TabIndex = 0;
            EmailLabel.Text = "Email";
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Location = new Point(106, 211);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(137, 21);
            ConfirmPasswordLabel.TabIndex = 0;
            ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(106, 130);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(128, 21);
            PasswordLabel.TabIndex = 0;
            PasswordLabel.Text = "Master Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(106, 45);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(81, 21);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            Load += SignUpForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            DockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            DockPanel2.ResumeLayout(false);
            DockPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel DockPanel1;
        private PictureBox LogoPictureBox;
        private Panel DockPanel2;
        private CustomControls.CustomButton CancelBtn;
        private CustomControls.CustomTextBox PasswordTextBox;
        private CustomControls.CustomTextBox UsernameTextBox;
        private Label PasswordLabel;
        private Label UsernameLabel;
        private CustomControls.CustomButton SignUpBtn;
        private CustomControls.CustomTextBox EmailTextBox;
        private CustomControls.CustomTextBox ConfirmPasswordTextBox;
        private Label EmailLabel;
        private Label ConfirmPasswordLabel;
    }
}