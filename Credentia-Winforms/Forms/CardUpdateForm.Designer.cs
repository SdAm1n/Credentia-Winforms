namespace Credentia_Winforms.Forms
{
    partial class CardUpdateForm
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
            CardUpdatePanel = new Panel();
            CardBrandUpComboBox = new ComboBox();
            CardUpSecurityCodeBox = new Label();
            CardUpExYrName = new Label();
            CardUpExYrBox = new CustomControls.CustomTextBox();
            CardUpSecurityCode = new CustomControls.CustomTextBox();
            CardUpExMnthname = new Label();
            CardBrandUpName = new Label();
            ExMnUpTextBox = new CustomControls.CustomTextBox();
            CardNumberUpName = new Label();
            CardNumberUpBox = new CustomControls.CustomTextBox();
            CardHolderUpName = new Label();
            CardUpHolderNameBox1 = new CustomControls.CustomTextBox();
            CardUpSubmitbtn = new CustomControls.CustomButton();
            CardUpName = new Label();
            CardUpNameBox = new CustomControls.CustomTextBox();
            CardUpdatePanel.SuspendLayout();
            SuspendLayout();
            // 
            // CardUpdatePanel
            // 
            CardUpdatePanel.Controls.Add(CardBrandUpComboBox);
            CardUpdatePanel.Controls.Add(CardUpSecurityCodeBox);
            CardUpdatePanel.Controls.Add(CardUpExYrName);
            CardUpdatePanel.Controls.Add(CardUpExYrBox);
            CardUpdatePanel.Controls.Add(CardUpSecurityCode);
            CardUpdatePanel.Controls.Add(CardUpExMnthname);
            CardUpdatePanel.Controls.Add(CardBrandUpName);
            CardUpdatePanel.Controls.Add(ExMnUpTextBox);
            CardUpdatePanel.Controls.Add(CardNumberUpName);
            CardUpdatePanel.Controls.Add(CardNumberUpBox);
            CardUpdatePanel.Controls.Add(CardHolderUpName);
            CardUpdatePanel.Controls.Add(CardUpHolderNameBox1);
            CardUpdatePanel.Controls.Add(CardUpSubmitbtn);
            CardUpdatePanel.Controls.Add(CardUpName);
            CardUpdatePanel.Controls.Add(CardUpNameBox);
            CardUpdatePanel.Location = new Point(-8, -1);
            CardUpdatePanel.Name = "CardUpdatePanel";
            CardUpdatePanel.Size = new Size(832, 500);
            CardUpdatePanel.TabIndex = 10;
            // 
            // CardBrandUpComboBox
            // 
            CardBrandUpComboBox.FormattingEnabled = true;
            CardBrandUpComboBox.Location = new Point(246, 232);
            CardBrandUpComboBox.Name = "CardBrandUpComboBox";
            CardBrandUpComboBox.Size = new Size(250, 23);
            CardBrandUpComboBox.TabIndex = 23;
            // 
            // CardUpSecurityCodeBox
            // 
            CardUpSecurityCodeBox.AutoSize = true;
            CardUpSecurityCodeBox.Location = new Point(256, 399);
            CardUpSecurityCodeBox.Name = "CardUpSecurityCodeBox";
            CardUpSecurityCodeBox.Size = new Size(80, 15);
            CardUpSecurityCodeBox.TabIndex = 20;
            CardUpSecurityCodeBox.Text = "Security Code";
            // 
            // CardUpExYrName
            // 
            CardUpExYrName.AutoSize = true;
            CardUpExYrName.Location = new Point(257, 337);
            CardUpExYrName.Name = "CardUpExYrName";
            CardUpExYrName.Size = new Size(85, 15);
            CardUpExYrName.TabIndex = 19;
            CardUpExYrName.Text = "Expiration Year";
            // 
            // CardUpExYrBox
            // 
            CardUpExYrBox.BackColor = SystemColors.Window;
            CardUpExYrBox.BorderColor = Color.MediumSlateBlue;
            CardUpExYrBox.BorderFocusColor = Color.HotPink;
            CardUpExYrBox.BorderRadius = 10;
            CardUpExYrBox.BorderSize = 2;
            CardUpExYrBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardUpExYrBox.ForeColor = Color.DimGray;
            CardUpExYrBox.Location = new Point(246, 355);
            CardUpExYrBox.Multiline = false;
            CardUpExYrBox.Name = "CardUpExYrBox";
            CardUpExYrBox.Padding = new Padding(7);
            CardUpExYrBox.PasswordChar = false;
            CardUpExYrBox.PlaceholderColor = Color.DarkGray;
            CardUpExYrBox.PlaceholderText = "";
            CardUpExYrBox.Size = new Size(250, 32);
            CardUpExYrBox.TabIndex = 18;
            CardUpExYrBox.Texts = "";
            CardUpExYrBox.UnderlinedStyle = false;
            // 
            // CardUpSecurityCode
            // 
            CardUpSecurityCode.BackColor = SystemColors.Window;
            CardUpSecurityCode.BorderColor = Color.MediumSlateBlue;
            CardUpSecurityCode.BorderFocusColor = Color.HotPink;
            CardUpSecurityCode.BorderRadius = 10;
            CardUpSecurityCode.BorderSize = 2;
            CardUpSecurityCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardUpSecurityCode.ForeColor = Color.DimGray;
            CardUpSecurityCode.Location = new Point(246, 420);
            CardUpSecurityCode.Multiline = false;
            CardUpSecurityCode.Name = "CardUpSecurityCode";
            CardUpSecurityCode.Padding = new Padding(7);
            CardUpSecurityCode.PasswordChar = false;
            CardUpSecurityCode.PlaceholderColor = Color.DarkGray;
            CardUpSecurityCode.PlaceholderText = "";
            CardUpSecurityCode.Size = new Size(250, 32);
            CardUpSecurityCode.TabIndex = 17;
            CardUpSecurityCode.Texts = "";
            CardUpSecurityCode.UnderlinedStyle = false;
            // 
            // CardUpExMnthname
            // 
            CardUpExMnthname.AutoSize = true;
            CardUpExMnthname.Location = new Point(257, 270);
            CardUpExMnthname.Name = "CardUpExMnthname";
            CardUpExMnthname.Size = new Size(99, 15);
            CardUpExMnthname.TabIndex = 16;
            CardUpExMnthname.Text = "Expiration Month";
            // 
            // CardBrandUpName
            // 
            CardBrandUpName.AutoSize = true;
            CardBrandUpName.Location = new Point(257, 202);
            CardBrandUpName.Name = "CardBrandUpName";
            CardBrandUpName.Size = new Size(38, 15);
            CardBrandUpName.TabIndex = 15;
            CardBrandUpName.Text = "Brand";
            // 
            // ExMnUpTextBox
            // 
            ExMnUpTextBox.BackColor = SystemColors.Window;
            ExMnUpTextBox.BorderColor = Color.MediumSlateBlue;
            ExMnUpTextBox.BorderFocusColor = Color.HotPink;
            ExMnUpTextBox.BorderRadius = 10;
            ExMnUpTextBox.BorderSize = 2;
            ExMnUpTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExMnUpTextBox.ForeColor = Color.DimGray;
            ExMnUpTextBox.Location = new Point(246, 288);
            ExMnUpTextBox.Multiline = false;
            ExMnUpTextBox.Name = "ExMnUpTextBox";
            ExMnUpTextBox.Padding = new Padding(7);
            ExMnUpTextBox.PasswordChar = false;
            ExMnUpTextBox.PlaceholderColor = Color.DarkGray;
            ExMnUpTextBox.PlaceholderText = "";
            ExMnUpTextBox.Size = new Size(250, 32);
            ExMnUpTextBox.TabIndex = 14;
            ExMnUpTextBox.Texts = "";
            ExMnUpTextBox.UnderlinedStyle = false;
            // 
            // CardNumberUpName
            // 
            CardNumberUpName.AutoSize = true;
            CardNumberUpName.Location = new Point(256, 138);
            CardNumberUpName.Name = "CardNumberUpName";
            CardNumberUpName.Size = new Size(79, 15);
            CardNumberUpName.TabIndex = 12;
            CardNumberUpName.Text = "Card Number";
            // 
            // CardNumberUpBox
            // 
            CardNumberUpBox.BackColor = SystemColors.Window;
            CardNumberUpBox.BorderColor = Color.MediumSlateBlue;
            CardNumberUpBox.BorderFocusColor = Color.HotPink;
            CardNumberUpBox.BorderRadius = 10;
            CardNumberUpBox.BorderSize = 2;
            CardNumberUpBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardNumberUpBox.ForeColor = Color.DimGray;
            CardNumberUpBox.Location = new Point(246, 156);
            CardNumberUpBox.Multiline = false;
            CardNumberUpBox.Name = "CardNumberUpBox";
            CardNumberUpBox.Padding = new Padding(7);
            CardNumberUpBox.PasswordChar = false;
            CardNumberUpBox.PlaceholderColor = Color.DarkGray;
            CardNumberUpBox.PlaceholderText = "";
            CardNumberUpBox.Size = new Size(250, 32);
            CardNumberUpBox.TabIndex = 11;
            CardNumberUpBox.Texts = "";
            CardNumberUpBox.UnderlinedStyle = false;
            // 
            // CardHolderUpName
            // 
            CardHolderUpName.AutoSize = true;
            CardHolderUpName.Location = new Point(256, 69);
            CardHolderUpName.Name = "CardHolderUpName";
            CardHolderUpName.Size = new Size(71, 15);
            CardHolderUpName.TabIndex = 10;
            CardHolderUpName.Text = "Card Holder";
            // 
            // CardUpHolderNameBox1
            // 
            CardUpHolderNameBox1.BackColor = SystemColors.Window;
            CardUpHolderNameBox1.BorderColor = Color.MediumSlateBlue;
            CardUpHolderNameBox1.BorderFocusColor = Color.HotPink;
            CardUpHolderNameBox1.BorderRadius = 10;
            CardUpHolderNameBox1.BorderSize = 2;
            CardUpHolderNameBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardUpHolderNameBox1.ForeColor = Color.DimGray;
            CardUpHolderNameBox1.Location = new Point(246, 87);
            CardUpHolderNameBox1.Multiline = false;
            CardUpHolderNameBox1.Name = "CardUpHolderNameBox1";
            CardUpHolderNameBox1.Padding = new Padding(7);
            CardUpHolderNameBox1.PasswordChar = false;
            CardUpHolderNameBox1.PlaceholderColor = Color.DarkGray;
            CardUpHolderNameBox1.PlaceholderText = "";
            CardUpHolderNameBox1.Size = new Size(250, 32);
            CardUpHolderNameBox1.TabIndex = 9;
            CardUpHolderNameBox1.Texts = "";
            CardUpHolderNameBox1.UnderlinedStyle = false;
            // 
            // CardUpSubmitbtn
            // 
            CardUpSubmitbtn.BackColor = Color.MediumSlateBlue;
            CardUpSubmitbtn.BackgroundColor = Color.MediumSlateBlue;
            CardUpSubmitbtn.BorderColor = Color.PaleVioletRed;
            CardUpSubmitbtn.BorderRadius = 10;
            CardUpSubmitbtn.BorderSize = 0;
            CardUpSubmitbtn.FlatAppearance.BorderSize = 0;
            CardUpSubmitbtn.FlatStyle = FlatStyle.Flat;
            CardUpSubmitbtn.ForeColor = Color.White;
            CardUpSubmitbtn.Location = new Point(335, 458);
            CardUpSubmitbtn.Name = "CardUpSubmitbtn";
            CardUpSubmitbtn.Size = new Size(79, 28);
            CardUpSubmitbtn.TabIndex = 8;
            CardUpSubmitbtn.Text = "Submit";
            CardUpSubmitbtn.TextColor = Color.White;
            CardUpSubmitbtn.UseVisualStyleBackColor = false;
            CardUpSubmitbtn.Click += CardUpSubmitbtn_Click;
            // 
            // CardUpName
            // 
            CardUpName.AutoSize = true;
            CardUpName.Location = new Point(257, 7);
            CardUpName.Name = "CardUpName";
            CardUpName.Size = new Size(39, 15);
            CardUpName.TabIndex = 1;
            CardUpName.Text = "Name";
            // 
            // CardUpNameBox
            // 
            CardUpNameBox.BackColor = SystemColors.Window;
            CardUpNameBox.BorderColor = Color.MediumSlateBlue;
            CardUpNameBox.BorderFocusColor = Color.HotPink;
            CardUpNameBox.BorderRadius = 10;
            CardUpNameBox.BorderSize = 2;
            CardUpNameBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardUpNameBox.ForeColor = Color.DimGray;
            CardUpNameBox.Location = new Point(246, 25);
            CardUpNameBox.Multiline = false;
            CardUpNameBox.Name = "CardUpNameBox";
            CardUpNameBox.Padding = new Padding(7);
            CardUpNameBox.PasswordChar = false;
            CardUpNameBox.PlaceholderColor = Color.DarkGray;
            CardUpNameBox.PlaceholderText = "";
            CardUpNameBox.Size = new Size(250, 32);
            CardUpNameBox.TabIndex = 0;
            CardUpNameBox.Texts = "";
            CardUpNameBox.UnderlinedStyle = false;
            // 
            // CardUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 495);
            Controls.Add(CardUpdatePanel);
            Name = "CardUpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CardUpdateForm";
            CardUpdatePanel.ResumeLayout(false);
            CardUpdatePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel CardUpdatePanel;
        public Label CardUpSecurityCodeBox;
        public Label CardUpExYrName;
        public CustomControls.CustomTextBox CardUpExYrBox;
        public CustomControls.CustomTextBox CardUpSecurityCode;
        public Label CardUpExMnthname;
        public Label CardBrandUpName;
        public CustomControls.CustomTextBox ExMnUpTextBox;
        public Label CardNumberUpName;
        public CustomControls.CustomTextBox CardNumberUpBox;
        public Label CardHolderUpName;
        public CustomControls.CustomTextBox CardUpHolderNameBox1;
        public CustomControls.CustomButton CardUpSubmitbtn;
        public Label CardUpName;
        public CustomControls.CustomTextBox CardUpNameBox;
        private ComboBox CardBrandUpComboBox;
    }
}