namespace Credentia_Winforms
{
    partial class CardForm
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
            CardDetailsPanel = new Panel();
            CardDetailNameBox = new CustomControls.CustomTextBox();
            CardHolderNameDetails = new Label();
            SecureNotepanel1 = new Panel();
            CardDetailsName = new Label();
            CardHolderNameTextBox = new CustomControls.CustomTextBox();
            BrandDetailsBox = new CustomControls.CustomTextBox();
            CardNumberDetail = new Label();
            CardNumberDetailBox = new CustomControls.CustomTextBox();
            BrandDetails = new Label();
            ExYearDetailBox = new CustomControls.CustomTextBox();
            ExMonthDetails = new Label();
            ExYearDetailsBox = new CustomControls.CustomTextBox();
            ExYearDetails = new Label();
            SecurityCodeDetails = new Label();
            SecurityCodeDetailsBox = new CustomControls.CustomTextBox();
            CardDetailsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CardDetailsPanel
            // 
            CardDetailsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CardDetailsPanel.BackColor = Color.FromArgb(234, 238, 238);
            CardDetailsPanel.Controls.Add(SecurityCodeDetails);
            CardDetailsPanel.Controls.Add(SecurityCodeDetailsBox);
            CardDetailsPanel.Controls.Add(ExYearDetailBox);
            CardDetailsPanel.Controls.Add(ExMonthDetails);
            CardDetailsPanel.Controls.Add(ExYearDetailsBox);
            CardDetailsPanel.Controls.Add(ExYearDetails);
            CardDetailsPanel.Controls.Add(BrandDetailsBox);
            CardDetailsPanel.Controls.Add(CardNumberDetail);
            CardDetailsPanel.Controls.Add(CardNumberDetailBox);
            CardDetailsPanel.Controls.Add(BrandDetails);
            CardDetailsPanel.Controls.Add(CardHolderNameTextBox);
            CardDetailsPanel.Controls.Add(CardDetailsName);
            CardDetailsPanel.Controls.Add(CardDetailNameBox);
            CardDetailsPanel.Controls.Add(CardHolderNameDetails);
            CardDetailsPanel.Location = new Point(469, 1);
            CardDetailsPanel.Name = "CardDetailsPanel";
            CardDetailsPanel.Size = new Size(335, 537);
            CardDetailsPanel.TabIndex = 3;
            CardDetailsPanel.Paint += CardDetailsPanel_Paint;
            // 
            // CardDetailNameBox
            // 
            CardDetailNameBox.BackColor = SystemColors.Window;
            CardDetailNameBox.BorderColor = Color.GhostWhite;
            CardDetailNameBox.BorderFocusColor = Color.GhostWhite;
            CardDetailNameBox.BorderRadius = 0;
            CardDetailNameBox.BorderSize = 2;
            CardDetailNameBox.Enabled = false;
            CardDetailNameBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardDetailNameBox.ForeColor = Color.DimGray;
            CardDetailNameBox.Location = new Point(29, 32);
            CardDetailNameBox.Multiline = false;
            CardDetailNameBox.Name = "CardDetailNameBox";
            CardDetailNameBox.Padding = new Padding(7);
            CardDetailNameBox.PasswordChar = false;
            CardDetailNameBox.PlaceholderColor = Color.DarkGray;
            CardDetailNameBox.PlaceholderText = "";
            CardDetailNameBox.Size = new Size(279, 32);
            CardDetailNameBox.TabIndex = 2;
            CardDetailNameBox.Texts = "";
            CardDetailNameBox.UnderlinedStyle = false;
            // 
            // CardHolderNameDetails
            // 
            CardHolderNameDetails.AutoSize = true;
            CardHolderNameDetails.Location = new Point(29, 74);
            CardHolderNameDetails.Name = "CardHolderNameDetails";
            CardHolderNameDetails.Size = new Size(140, 21);
            CardHolderNameDetails.TabIndex = 1;
            CardHolderNameDetails.Text = "Card Holder Name";
            // 
            // SecureNotepanel1
            // 
            SecureNotepanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SecureNotepanel1.AutoScroll = true;
            SecureNotepanel1.BackColor = Color.FromArgb(238, 246, 247);
            SecureNotepanel1.Location = new Point(2, 1);
            SecureNotepanel1.Name = "SecureNotepanel1";
            SecureNotepanel1.Size = new Size(467, 537);
            SecureNotepanel1.TabIndex = 4;
            // 
            // CardDetailsName
            // 
            CardDetailsName.AutoSize = true;
            CardDetailsName.Location = new Point(29, 8);
            CardDetailsName.Name = "CardDetailsName";
            CardDetailsName.Size = new Size(52, 21);
            CardDetailsName.TabIndex = 4;
            CardDetailsName.Text = "Name";
            CardDetailsName.Click += CardDetailsName_Click;
            // 
            // CardHolderNameTextBox
            // 
            CardHolderNameTextBox.BackColor = SystemColors.Window;
            CardHolderNameTextBox.BorderColor = Color.GhostWhite;
            CardHolderNameTextBox.BorderFocusColor = Color.GhostWhite;
            CardHolderNameTextBox.BorderRadius = 0;
            CardHolderNameTextBox.BorderSize = 2;
            CardHolderNameTextBox.Enabled = false;
            CardHolderNameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardHolderNameTextBox.ForeColor = Color.DimGray;
            CardHolderNameTextBox.Location = new Point(29, 98);
            CardHolderNameTextBox.Multiline = false;
            CardHolderNameTextBox.Name = "CardHolderNameTextBox";
            CardHolderNameTextBox.Padding = new Padding(7);
            CardHolderNameTextBox.PasswordChar = false;
            CardHolderNameTextBox.PlaceholderColor = Color.DarkGray;
            CardHolderNameTextBox.PlaceholderText = "";
            CardHolderNameTextBox.Size = new Size(279, 32);
            CardHolderNameTextBox.TabIndex = 5;
            CardHolderNameTextBox.Texts = "";
            CardHolderNameTextBox.UnderlinedStyle = false;
            // 
            // BrandDetailsBox
            // 
            BrandDetailsBox.BackColor = SystemColors.Window;
            BrandDetailsBox.BorderColor = Color.GhostWhite;
            BrandDetailsBox.BorderFocusColor = Color.GhostWhite;
            BrandDetailsBox.BorderRadius = 0;
            BrandDetailsBox.BorderSize = 2;
            BrandDetailsBox.Enabled = false;
            BrandDetailsBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BrandDetailsBox.ForeColor = Color.DimGray;
            BrandDetailsBox.Location = new Point(29, 232);
            BrandDetailsBox.Multiline = false;
            BrandDetailsBox.Name = "BrandDetailsBox";
            BrandDetailsBox.Padding = new Padding(7);
            BrandDetailsBox.PasswordChar = false;
            BrandDetailsBox.PlaceholderColor = Color.DarkGray;
            BrandDetailsBox.PlaceholderText = "";
            BrandDetailsBox.Size = new Size(279, 32);
            BrandDetailsBox.TabIndex = 9;
            BrandDetailsBox.Texts = "";
            BrandDetailsBox.UnderlinedStyle = false;
            // 
            // CardNumberDetail
            // 
            CardNumberDetail.AutoSize = true;
            CardNumberDetail.Location = new Point(29, 139);
            CardNumberDetail.Name = "CardNumberDetail";
            CardNumberDetail.Size = new Size(109, 21);
            CardNumberDetail.TabIndex = 8;
            CardNumberDetail.Text = "Card Number ";
            // 
            // CardNumberDetailBox
            // 
            CardNumberDetailBox.BackColor = SystemColors.Window;
            CardNumberDetailBox.BorderColor = Color.GhostWhite;
            CardNumberDetailBox.BorderFocusColor = Color.GhostWhite;
            CardNumberDetailBox.BorderRadius = 0;
            CardNumberDetailBox.BorderSize = 2;
            CardNumberDetailBox.Enabled = false;
            CardNumberDetailBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardNumberDetailBox.ForeColor = Color.DimGray;
            CardNumberDetailBox.Location = new Point(29, 163);
            CardNumberDetailBox.Multiline = false;
            CardNumberDetailBox.Name = "CardNumberDetailBox";
            CardNumberDetailBox.Padding = new Padding(7);
            CardNumberDetailBox.PasswordChar = false;
            CardNumberDetailBox.PlaceholderColor = Color.DarkGray;
            CardNumberDetailBox.PlaceholderText = "";
            CardNumberDetailBox.Size = new Size(279, 32);
            CardNumberDetailBox.TabIndex = 7;
            CardNumberDetailBox.Texts = "";
            CardNumberDetailBox.UnderlinedStyle = false;
            // 
            // BrandDetails
            // 
            BrandDetails.AutoSize = true;
            BrandDetails.Location = new Point(29, 208);
            BrandDetails.Name = "BrandDetails";
            BrandDetails.Size = new Size(51, 21);
            BrandDetails.TabIndex = 6;
            BrandDetails.Text = "Brand";
            // 
            // ExYearDetailBox
            // 
            ExYearDetailBox.BackColor = SystemColors.Window;
            ExYearDetailBox.BorderColor = Color.GhostWhite;
            ExYearDetailBox.BorderFocusColor = Color.GhostWhite;
            ExYearDetailBox.BorderRadius = 0;
            ExYearDetailBox.BorderSize = 2;
            ExYearDetailBox.Enabled = false;
            ExYearDetailBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExYearDetailBox.ForeColor = Color.DimGray;
            ExYearDetailBox.Location = new Point(29, 373);
            ExYearDetailBox.Multiline = false;
            ExYearDetailBox.Name = "ExYearDetailBox";
            ExYearDetailBox.Padding = new Padding(7);
            ExYearDetailBox.PasswordChar = false;
            ExYearDetailBox.PlaceholderColor = Color.DarkGray;
            ExYearDetailBox.PlaceholderText = "";
            ExYearDetailBox.Size = new Size(279, 32);
            ExYearDetailBox.TabIndex = 13;
            ExYearDetailBox.Texts = "";
            ExYearDetailBox.UnderlinedStyle = false;
            // 
            // ExMonthDetails
            // 
            ExMonthDetails.AutoSize = true;
            ExMonthDetails.Location = new Point(29, 280);
            ExMonthDetails.Name = "ExMonthDetails";
            ExMonthDetails.Size = new Size(129, 21);
            ExMonthDetails.TabIndex = 12;
            ExMonthDetails.Text = "Expiration Month";
            ExMonthDetails.Click += ExMonthDetails_Click;
            // 
            // ExYearDetailsBox
            // 
            ExYearDetailsBox.BackColor = SystemColors.Window;
            ExYearDetailsBox.BorderColor = Color.GhostWhite;
            ExYearDetailsBox.BorderFocusColor = Color.GhostWhite;
            ExYearDetailsBox.BorderRadius = 0;
            ExYearDetailsBox.BorderSize = 2;
            ExYearDetailsBox.Enabled = false;
            ExYearDetailsBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExYearDetailsBox.ForeColor = Color.DimGray;
            ExYearDetailsBox.Location = new Point(29, 304);
            ExYearDetailsBox.Multiline = false;
            ExYearDetailsBox.Name = "ExYearDetailsBox";
            ExYearDetailsBox.Padding = new Padding(7);
            ExYearDetailsBox.PasswordChar = false;
            ExYearDetailsBox.PlaceholderColor = Color.DarkGray;
            ExYearDetailsBox.PlaceholderText = "";
            ExYearDetailsBox.Size = new Size(279, 32);
            ExYearDetailsBox.TabIndex = 11;
            ExYearDetailsBox.Texts = "";
            ExYearDetailsBox.UnderlinedStyle = false;
            // 
            // ExYearDetails
            // 
            ExYearDetails.AutoSize = true;
            ExYearDetails.Location = new Point(29, 349);
            ExYearDetails.Name = "ExYearDetails";
            ExYearDetails.Size = new Size(113, 21);
            ExYearDetails.TabIndex = 10;
            ExYearDetails.Text = "Expiration Year";
            // 
            // SecurityCodeDetails
            // 
            SecurityCodeDetails.AutoSize = true;
            SecurityCodeDetails.Location = new Point(29, 416);
            SecurityCodeDetails.Name = "SecurityCodeDetails";
            SecurityCodeDetails.Size = new Size(106, 21);
            SecurityCodeDetails.TabIndex = 16;
            SecurityCodeDetails.Text = "Security Code";
            // 
            // SecurityCodeDetailsBox
            // 
            SecurityCodeDetailsBox.BackColor = SystemColors.Window;
            SecurityCodeDetailsBox.BorderColor = Color.GhostWhite;
            SecurityCodeDetailsBox.BorderFocusColor = Color.GhostWhite;
            SecurityCodeDetailsBox.BorderRadius = 0;
            SecurityCodeDetailsBox.BorderSize = 2;
            SecurityCodeDetailsBox.Enabled = false;
            SecurityCodeDetailsBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecurityCodeDetailsBox.ForeColor = Color.DimGray;
            SecurityCodeDetailsBox.Location = new Point(29, 440);
            SecurityCodeDetailsBox.Multiline = false;
            SecurityCodeDetailsBox.Name = "SecurityCodeDetailsBox";
            SecurityCodeDetailsBox.Padding = new Padding(7);
            SecurityCodeDetailsBox.PasswordChar = false;
            SecurityCodeDetailsBox.PlaceholderColor = Color.DarkGray;
            SecurityCodeDetailsBox.PlaceholderText = "";
            SecurityCodeDetailsBox.Size = new Size(279, 32);
            SecurityCodeDetailsBox.TabIndex = 15;
            SecurityCodeDetailsBox.Texts = "";
            SecurityCodeDetailsBox.UnderlinedStyle = false;
            // 
            // CardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 537);
            Controls.Add(SecureNotepanel1);
            Controls.Add(CardDetailsPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "CardForm";
            Text = "CardForm";
            CardDetailsPanel.ResumeLayout(false);
            CardDetailsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel CardDetailsPanel;
        public CustomControls.CustomTextBox CardDetailNameBox;
        private Label CardHolderNameDetails;
        public Panel SecureNotepanel1;
        private Label CardDetailsName;
        public CustomControls.CustomTextBox CardHolderNameTextBox;
        private Label SecurityCodeDetails;
        public CustomControls.CustomTextBox SecurityCodeDetailsBox;
        public CustomControls.CustomTextBox ExYearDetailBox;
        private Label ExMonthDetails;
        public CustomControls.CustomTextBox ExYearDetailsBox;
        private Label ExYearDetails;
        public CustomControls.CustomTextBox BrandDetailsBox;
        private Label CardNumberDetail;
        public CustomControls.CustomTextBox CardNumberDetailBox;
        private Label BrandDetails;
    }
}