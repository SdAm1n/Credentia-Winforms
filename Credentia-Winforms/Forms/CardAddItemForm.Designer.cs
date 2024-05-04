namespace Credentia_Winforms.Forms
{
    partial class CardAddItemForm
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
            SeureNoteAddItemPanel = new Panel();
            panel1 = new Panel();
            CardAddSecurityCodeBox = new Label();
            CardAddExYrName = new Label();
            CardAddExYrBox = new CustomControls.CustomTextBox();
            CardAddSecurityCode = new CustomControls.CustomTextBox();
            CardAddExMnthname = new Label();
            CardBrandAddName = new Label();
            ExMnAddTextBox = new CustomControls.CustomTextBox();
            CardBrandAddBox = new CustomControls.CustomTextBox();
            CardNumberAddName = new Label();
            CardNumberAddBox = new CustomControls.CustomTextBox();
            CardHolderAddName = new Label();
            CardAddHolderNameBox1 = new CustomControls.CustomTextBox();
            CardAddSubmitbtn = new CustomControls.CustomButton();
            CardAddName = new Label();
            CardAddNameBox = new CustomControls.CustomTextBox();
            SecureNoteSubmitbtn = new CustomControls.CustomButton();
            SecureNoteNoteName = new Label();
            CardAddFormName = new Label();
            CardAddNameBox1 = new CustomControls.CustomTextBox();
            SeureNoteAddItemPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SeureNoteAddItemPanel
            // 
            SeureNoteAddItemPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SeureNoteAddItemPanel.Controls.Add(panel1);
            SeureNoteAddItemPanel.Controls.Add(SecureNoteSubmitbtn);
            SeureNoteAddItemPanel.Controls.Add(SecureNoteNoteName);
            SeureNoteAddItemPanel.Controls.Add(CardAddFormName);
            SeureNoteAddItemPanel.Controls.Add(CardAddNameBox1);
            SeureNoteAddItemPanel.Location = new Point(0, -1);
            SeureNoteAddItemPanel.Name = "SeureNoteAddItemPanel";
            SeureNoteAddItemPanel.Size = new Size(838, 515);
            SeureNoteAddItemPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(CardAddSecurityCodeBox);
            panel1.Controls.Add(CardAddExYrName);
            panel1.Controls.Add(CardAddExYrBox);
            panel1.Controls.Add(CardAddSecurityCode);
            panel1.Controls.Add(CardAddExMnthname);
            panel1.Controls.Add(CardBrandAddName);
            panel1.Controls.Add(ExMnAddTextBox);
            panel1.Controls.Add(CardBrandAddBox);
            panel1.Controls.Add(CardNumberAddName);
            panel1.Controls.Add(CardNumberAddBox);
            panel1.Controls.Add(CardHolderAddName);
            panel1.Controls.Add(CardAddHolderNameBox1);
            panel1.Controls.Add(CardAddSubmitbtn);
            panel1.Controls.Add(CardAddName);
            panel1.Controls.Add(CardAddNameBox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 515);
            panel1.TabIndex = 9;
            // 
            // CardAddSecurityCodeBox
            // 
            CardAddSecurityCodeBox.AutoSize = true;
            CardAddSecurityCodeBox.Location = new Point(256, 399);
            CardAddSecurityCodeBox.Name = "CardAddSecurityCodeBox";
            CardAddSecurityCodeBox.Size = new Size(80, 15);
            CardAddSecurityCodeBox.TabIndex = 20;
            CardAddSecurityCodeBox.Text = "Security Code";
            // 
            // CardAddExYrName
            // 
            CardAddExYrName.AutoSize = true;
            CardAddExYrName.Location = new Point(257, 337);
            CardAddExYrName.Name = "CardAddExYrName";
            CardAddExYrName.Size = new Size(85, 15);
            CardAddExYrName.TabIndex = 19;
            CardAddExYrName.Text = "Expiration Year";
            // 
            // CardAddExYrBox
            // 
            CardAddExYrBox.BackColor = SystemColors.Window;
            CardAddExYrBox.BorderColor = Color.MediumSlateBlue;
            CardAddExYrBox.BorderFocusColor = Color.HotPink;
            CardAddExYrBox.BorderRadius = 10;
            CardAddExYrBox.BorderSize = 2;
            CardAddExYrBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardAddExYrBox.ForeColor = Color.DimGray;
            CardAddExYrBox.Location = new Point(246, 355);
            CardAddExYrBox.Multiline = false;
            CardAddExYrBox.Name = "CardAddExYrBox";
            CardAddExYrBox.Padding = new Padding(7);
            CardAddExYrBox.PasswordChar = false;
            CardAddExYrBox.PlaceholderColor = Color.DarkGray;
            CardAddExYrBox.PlaceholderText = "";
            CardAddExYrBox.Size = new Size(250, 32);
            CardAddExYrBox.TabIndex = 18;
            CardAddExYrBox.Texts = "";
            CardAddExYrBox.UnderlinedStyle = false;
            // 
            // CardAddSecurityCode
            // 
            CardAddSecurityCode.BackColor = SystemColors.Window;
            CardAddSecurityCode.BorderColor = Color.MediumSlateBlue;
            CardAddSecurityCode.BorderFocusColor = Color.HotPink;
            CardAddSecurityCode.BorderRadius = 10;
            CardAddSecurityCode.BorderSize = 2;
            CardAddSecurityCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardAddSecurityCode.ForeColor = Color.DimGray;
            CardAddSecurityCode.Location = new Point(246, 420);
            CardAddSecurityCode.Multiline = false;
            CardAddSecurityCode.Name = "CardAddSecurityCode";
            CardAddSecurityCode.Padding = new Padding(7);
            CardAddSecurityCode.PasswordChar = false;
            CardAddSecurityCode.PlaceholderColor = Color.DarkGray;
            CardAddSecurityCode.PlaceholderText = "";
            CardAddSecurityCode.Size = new Size(250, 32);
            CardAddSecurityCode.TabIndex = 17;
            CardAddSecurityCode.Texts = "";
            CardAddSecurityCode.UnderlinedStyle = false;
            // 
            // CardAddExMnthname
            // 
            CardAddExMnthname.AutoSize = true;
            CardAddExMnthname.Location = new Point(257, 270);
            CardAddExMnthname.Name = "CardAddExMnthname";
            CardAddExMnthname.Size = new Size(99, 15);
            CardAddExMnthname.TabIndex = 16;
            CardAddExMnthname.Text = "Expiration Month";
            // 
            // CardBrandAddName
            // 
            CardBrandAddName.AutoSize = true;
            CardBrandAddName.Location = new Point(257, 202);
            CardBrandAddName.Name = "CardBrandAddName";
            CardBrandAddName.Size = new Size(38, 15);
            CardBrandAddName.TabIndex = 15;
            CardBrandAddName.Text = "Brand";
            CardBrandAddName.Click += CardBrandAddName_Click;
            // 
            // ExMnAddTextBox
            // 
            ExMnAddTextBox.BackColor = SystemColors.Window;
            ExMnAddTextBox.BorderColor = Color.MediumSlateBlue;
            ExMnAddTextBox.BorderFocusColor = Color.HotPink;
            ExMnAddTextBox.BorderRadius = 10;
            ExMnAddTextBox.BorderSize = 2;
            ExMnAddTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExMnAddTextBox.ForeColor = Color.DimGray;
            ExMnAddTextBox.Location = new Point(246, 288);
            ExMnAddTextBox.Multiline = false;
            ExMnAddTextBox.Name = "ExMnAddTextBox";
            ExMnAddTextBox.Padding = new Padding(7);
            ExMnAddTextBox.PasswordChar = false;
            ExMnAddTextBox.PlaceholderColor = Color.DarkGray;
            ExMnAddTextBox.PlaceholderText = "";
            ExMnAddTextBox.Size = new Size(250, 32);
            ExMnAddTextBox.TabIndex = 14;
            ExMnAddTextBox.Texts = "";
            ExMnAddTextBox.UnderlinedStyle = false;
            // 
            // CardBrandAddBox
            // 
            CardBrandAddBox.BackColor = SystemColors.Window;
            CardBrandAddBox.BorderColor = Color.MediumSlateBlue;
            CardBrandAddBox.BorderFocusColor = Color.HotPink;
            CardBrandAddBox.BorderRadius = 10;
            CardBrandAddBox.BorderSize = 2;
            CardBrandAddBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardBrandAddBox.ForeColor = Color.DimGray;
            CardBrandAddBox.Location = new Point(246, 220);
            CardBrandAddBox.Multiline = false;
            CardBrandAddBox.Name = "CardBrandAddBox";
            CardBrandAddBox.Padding = new Padding(7);
            CardBrandAddBox.PasswordChar = false;
            CardBrandAddBox.PlaceholderColor = Color.DarkGray;
            CardBrandAddBox.PlaceholderText = "";
            CardBrandAddBox.Size = new Size(250, 32);
            CardBrandAddBox.TabIndex = 13;
            CardBrandAddBox.Texts = "";
            CardBrandAddBox.UnderlinedStyle = false;
            // 
            // CardNumberAddName
            // 
            CardNumberAddName.AutoSize = true;
            CardNumberAddName.Location = new Point(256, 138);
            CardNumberAddName.Name = "CardNumberAddName";
            CardNumberAddName.Size = new Size(79, 15);
            CardNumberAddName.TabIndex = 12;
            CardNumberAddName.Text = "Card Number";
            // 
            // CardNumberAddBox
            // 
            CardNumberAddBox.BackColor = SystemColors.Window;
            CardNumberAddBox.BorderColor = Color.MediumSlateBlue;
            CardNumberAddBox.BorderFocusColor = Color.HotPink;
            CardNumberAddBox.BorderRadius = 10;
            CardNumberAddBox.BorderSize = 2;
            CardNumberAddBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardNumberAddBox.ForeColor = Color.DimGray;
            CardNumberAddBox.Location = new Point(246, 156);
            CardNumberAddBox.Multiline = false;
            CardNumberAddBox.Name = "CardNumberAddBox";
            CardNumberAddBox.Padding = new Padding(7);
            CardNumberAddBox.PasswordChar = false;
            CardNumberAddBox.PlaceholderColor = Color.DarkGray;
            CardNumberAddBox.PlaceholderText = "";
            CardNumberAddBox.Size = new Size(250, 32);
            CardNumberAddBox.TabIndex = 11;
            CardNumberAddBox.Texts = "";
            CardNumberAddBox.UnderlinedStyle = false;
            // 
            // CardHolderAddName
            // 
            CardHolderAddName.AutoSize = true;
            CardHolderAddName.Location = new Point(256, 69);
            CardHolderAddName.Name = "CardHolderAddName";
            CardHolderAddName.Size = new Size(71, 15);
            CardHolderAddName.TabIndex = 10;
            CardHolderAddName.Text = "Card Holder";
            CardHolderAddName.Click += CardHolderAddName_Click;
            // 
            // CardAddHolderNameBox1
            // 
            CardAddHolderNameBox1.BackColor = SystemColors.Window;
            CardAddHolderNameBox1.BorderColor = Color.MediumSlateBlue;
            CardAddHolderNameBox1.BorderFocusColor = Color.HotPink;
            CardAddHolderNameBox1.BorderRadius = 10;
            CardAddHolderNameBox1.BorderSize = 2;
            CardAddHolderNameBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardAddHolderNameBox1.ForeColor = Color.DimGray;
            CardAddHolderNameBox1.Location = new Point(246, 87);
            CardAddHolderNameBox1.Multiline = false;
            CardAddHolderNameBox1.Name = "CardAddHolderNameBox1";
            CardAddHolderNameBox1.Padding = new Padding(7);
            CardAddHolderNameBox1.PasswordChar = false;
            CardAddHolderNameBox1.PlaceholderColor = Color.DarkGray;
            CardAddHolderNameBox1.PlaceholderText = "";
            CardAddHolderNameBox1.Size = new Size(250, 32);
            CardAddHolderNameBox1.TabIndex = 9;
            CardAddHolderNameBox1.Texts = "";
            CardAddHolderNameBox1.UnderlinedStyle = false;
            // 
            // CardAddSubmitbtn
            // 
            CardAddSubmitbtn.BackColor = Color.MediumSlateBlue;
            CardAddSubmitbtn.BackgroundColor = Color.MediumSlateBlue;
            CardAddSubmitbtn.BorderColor = Color.PaleVioletRed;
            CardAddSubmitbtn.BorderRadius = 10;
            CardAddSubmitbtn.BorderSize = 0;
            CardAddSubmitbtn.FlatAppearance.BorderSize = 0;
            CardAddSubmitbtn.FlatStyle = FlatStyle.Flat;
            CardAddSubmitbtn.ForeColor = Color.White;
            CardAddSubmitbtn.Location = new Point(335, 458);
            CardAddSubmitbtn.Name = "CardAddSubmitbtn";
            CardAddSubmitbtn.Size = new Size(79, 28);
            CardAddSubmitbtn.TabIndex = 8;
            CardAddSubmitbtn.Text = "Submit";
            CardAddSubmitbtn.TextColor = Color.White;
            CardAddSubmitbtn.UseVisualStyleBackColor = false;
            CardAddSubmitbtn.Click += CardAddSubmitbtn_Click;
            // 
            // CardAddName
            // 
            CardAddName.AutoSize = true;
            CardAddName.Location = new Point(257, 7);
            CardAddName.Name = "CardAddName";
            CardAddName.Size = new Size(39, 15);
            CardAddName.TabIndex = 1;
            CardAddName.Text = "Name";
            CardAddName.Click += CardAddName_Click;
            // 
            // CardAddNameBox
            // 
            CardAddNameBox.BackColor = SystemColors.Window;
            CardAddNameBox.BorderColor = Color.MediumSlateBlue;
            CardAddNameBox.BorderFocusColor = Color.HotPink;
            CardAddNameBox.BorderRadius = 10;
            CardAddNameBox.BorderSize = 2;
            CardAddNameBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardAddNameBox.ForeColor = Color.DimGray;
            CardAddNameBox.Location = new Point(246, 25);
            CardAddNameBox.Multiline = false;
            CardAddNameBox.Name = "CardAddNameBox";
            CardAddNameBox.Padding = new Padding(7);
            CardAddNameBox.PasswordChar = false;
            CardAddNameBox.PlaceholderColor = Color.DarkGray;
            CardAddNameBox.PlaceholderText = "";
            CardAddNameBox.Size = new Size(250, 32);
            CardAddNameBox.TabIndex = 0;
            CardAddNameBox.Texts = "";
            CardAddNameBox.UnderlinedStyle = false;
            // 
            // SecureNoteSubmitbtn
            // 
            SecureNoteSubmitbtn.BackColor = Color.MediumSlateBlue;
            SecureNoteSubmitbtn.BackgroundColor = Color.MediumSlateBlue;
            SecureNoteSubmitbtn.BorderColor = Color.PaleVioletRed;
            SecureNoteSubmitbtn.BorderRadius = 10;
            SecureNoteSubmitbtn.BorderSize = 0;
            SecureNoteSubmitbtn.FlatAppearance.BorderSize = 0;
            SecureNoteSubmitbtn.FlatStyle = FlatStyle.Flat;
            SecureNoteSubmitbtn.ForeColor = Color.White;
            SecureNoteSubmitbtn.Location = new Point(188, 374);
            SecureNoteSubmitbtn.Name = "SecureNoteSubmitbtn";
            SecureNoteSubmitbtn.Size = new Size(150, 40);
            SecureNoteSubmitbtn.TabIndex = 8;
            SecureNoteSubmitbtn.Text = "Submit";
            SecureNoteSubmitbtn.TextColor = Color.White;
            SecureNoteSubmitbtn.UseVisualStyleBackColor = false;
            // 
            // SecureNoteNoteName
            // 
            SecureNoteNoteName.AutoSize = true;
            SecureNoteNoteName.Location = new Point(188, 87);
            SecureNoteNoteName.Name = "SecureNoteNoteName";
            SecureNoteNoteName.Size = new Size(71, 15);
            SecureNoteNoteName.TabIndex = 3;
            SecureNoteNoteName.Text = "Secure Note";
            // 
            // CardAddFormName
            // 
            CardAddFormName.AutoSize = true;
            CardAddFormName.Location = new Point(188, 7);
            CardAddFormName.Name = "CardAddFormName";
            CardAddFormName.Size = new Size(39, 15);
            CardAddFormName.TabIndex = 1;
            CardAddFormName.Text = "Name";
            // 
            // CardAddNameBox1
            // 
            CardAddNameBox1.BackColor = SystemColors.Window;
            CardAddNameBox1.BorderColor = Color.MediumSlateBlue;
            CardAddNameBox1.BorderFocusColor = Color.HotPink;
            CardAddNameBox1.BorderRadius = 10;
            CardAddNameBox1.BorderSize = 2;
            CardAddNameBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardAddNameBox1.ForeColor = Color.DimGray;
            CardAddNameBox1.Location = new Point(188, 34);
            CardAddNameBox1.Multiline = false;
            CardAddNameBox1.Name = "CardAddNameBox1";
            CardAddNameBox1.Padding = new Padding(7);
            CardAddNameBox1.PasswordChar = false;
            CardAddNameBox1.PlaceholderColor = Color.DarkGray;
            CardAddNameBox1.PlaceholderText = "";
            CardAddNameBox1.Size = new Size(250, 32);
            CardAddNameBox1.TabIndex = 0;
            CardAddNameBox1.Texts = "";
            CardAddNameBox1.UnderlinedStyle = false;
            // 
            // CardAddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 514);
            Controls.Add(SeureNoteAddItemPanel);
            Name = "CardAddItemForm";
            Text = "CardAddItemForm";
            SeureNoteAddItemPanel.ResumeLayout(false);
            SeureNoteAddItemPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SeureNoteAddItemPanel;
        private Panel panel1;
        public CustomControls.CustomButton CardAddSubmitbtn;
        public Label CardAddName;
        public CustomControls.CustomTextBox CardAddNameBox;
        public CustomControls.CustomButton SecureNoteSubmitbtn;
        public Label SecureNoteNoteName;
        public Label CardAddFormName;
        public CustomControls.CustomTextBox CardAddNameBox1;
        public CustomControls.CustomTextBox CardAddHolderNameBox1;
        public CustomControls.CustomTextBox CardNumberAddBox;
        public Label CardHolderAddName;
        public Label CardNumberAddName;
        public CustomControls.CustomTextBox CardBrandAddBox;
        public CustomControls.CustomTextBox ExMnAddTextBox;
        public Label CardBrandAddName;
        public Label CardAddExMnthname;
        public Label CardAddSecurityCodeBox;
        public Label CardAddExYrName;
        public CustomControls.CustomTextBox CardAddExYrBox;
        public CustomControls.CustomTextBox CardAddSecurityCode;
    }
}