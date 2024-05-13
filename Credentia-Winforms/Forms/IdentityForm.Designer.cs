namespace Credentia_Winforms
{
    partial class IdentityForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CardPanel1 = new Panel();
            IdentitySearchBox = new CustomControls.CustomTextBox();
            CardSearchBox = new CustomControls.CustomTextBox();
            IdentityAddBtn = new CustomControls.CustomButton();
            CardPanel3 = new Panel();
            IdentityDeletebtn = new CustomControls.CustomButton();
            IdentityEditbtn = new CustomControls.CustomButton();
            CardEditBtn = new CustomControls.CustomButton();
            CardDeleteBtn = new CustomControls.CustomButton();
            SecureNoteEditbtn = new CustomControls.CustomButton();
            SecureNoteDeletebtn = new CustomControls.CustomButton();
            IdentitydataGridView = new DataGridView();
            IdentityNameColumn = new DataGridViewTextBoxColumn();
            IdentityUserNameColumn = new DataGridViewTextBoxColumn();
            IdentityTittleColumn = new DataGridViewTextBoxColumn();
            IdentityFirstNColumn = new DataGridViewTextBoxColumn();
            IdentityLastNColumn = new DataGridViewTextBoxColumn();
            IdentityCompanyColumn = new DataGridViewTextBoxColumn();
            IdentityLNColumn = new DataGridViewTextBoxColumn();
            IdentityEmailColumn = new DataGridViewTextBoxColumn();
            IdentityPhoneColumn = new DataGridViewTextBoxColumn();
            AddressColumn = new DataGridViewTextBoxColumn();
            IdentityZipColumn = new DataGridViewTextBoxColumn();
            IdentityCountryColumn = new DataGridViewTextBoxColumn();
            NIDColumn = new DataGridViewTextBoxColumn();
            PassportColumn = new DataGridViewTextBoxColumn();
            IdentityNoItems = new Label();
            CardPanel1.SuspendLayout();
            CardPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IdentitydataGridView).BeginInit();
            SuspendLayout();
            // 
            // CardPanel1
            // 
            CardPanel1.Controls.Add(IdentitySearchBox);
            CardPanel1.Controls.Add(CardSearchBox);
            CardPanel1.Controls.Add(IdentityAddBtn);
            CardPanel1.Location = new Point(0, 0);
            CardPanel1.Name = "CardPanel1";
            CardPanel1.Size = new Size(744, 51);
            CardPanel1.TabIndex = 4;
            // 
            // IdentitySearchBox
            // 
            IdentitySearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IdentitySearchBox.BackColor = Color.FromArgb(217, 217, 217);
            IdentitySearchBox.BorderColor = Color.Transparent;
            IdentitySearchBox.BorderFocusColor = Color.Transparent;
            IdentitySearchBox.BorderRadius = 16;
            IdentitySearchBox.BorderSize = 2;
            IdentitySearchBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IdentitySearchBox.ForeColor = Color.DimGray;
            IdentitySearchBox.Location = new Point(220, 11);
            IdentitySearchBox.Multiline = false;
            IdentitySearchBox.Name = "IdentitySearchBox";
            IdentitySearchBox.Padding = new Padding(7);
            IdentitySearchBox.PasswordChar = false;
            IdentitySearchBox.PlaceholderColor = Color.DarkGray;
            IdentitySearchBox.PlaceholderText = "";
            IdentitySearchBox.Size = new Size(353, 32);
            IdentitySearchBox.TabIndex = 7;
            IdentitySearchBox.Texts = "";
            IdentitySearchBox.UnderlinedStyle = false;
            IdentitySearchBox._TextChanged += customTextBox1__TextChanged;
            // 
            // CardSearchBox
            // 
            CardSearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CardSearchBox.BackColor = Color.FromArgb(217, 217, 217);
            CardSearchBox.BorderColor = Color.Transparent;
            CardSearchBox.BorderFocusColor = Color.Transparent;
            CardSearchBox.BorderRadius = 16;
            CardSearchBox.BorderSize = 2;
            CardSearchBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardSearchBox.ForeColor = Color.DimGray;
            CardSearchBox.Location = new Point(764, 11);
            CardSearchBox.Multiline = false;
            CardSearchBox.Name = "CardSearchBox";
            CardSearchBox.Padding = new Padding(7);
            CardSearchBox.PasswordChar = false;
            CardSearchBox.PlaceholderColor = Color.DarkGray;
            CardSearchBox.PlaceholderText = "";
            CardSearchBox.Size = new Size(353, 32);
            CardSearchBox.TabIndex = 0;
            CardSearchBox.Texts = "";
            CardSearchBox.UnderlinedStyle = false;
            // 
            // IdentityAddBtn
            // 
            IdentityAddBtn.BackColor = Color.Transparent;
            IdentityAddBtn.BackgroundColor = Color.Transparent;
            IdentityAddBtn.BorderColor = Color.FromArgb(252, 92, 52);
            IdentityAddBtn.BorderRadius = 16;
            IdentityAddBtn.BorderSize = 2;
            IdentityAddBtn.FlatAppearance.BorderSize = 0;
            IdentityAddBtn.FlatStyle = FlatStyle.Flat;
            IdentityAddBtn.ForeColor = Color.Black;
            IdentityAddBtn.Location = new Point(665, 11);
            IdentityAddBtn.Name = "IdentityAddBtn";
            IdentityAddBtn.Size = new Size(57, 32);
            IdentityAddBtn.TabIndex = 6;
            IdentityAddBtn.Text = "ADD";
            IdentityAddBtn.TextColor = Color.Black;
            IdentityAddBtn.UseVisualStyleBackColor = false;
            IdentityAddBtn.Click += IdentityAddBtn_Click;
            // 
            // CardPanel3
            // 
            CardPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CardPanel3.BackColor = Color.FromArgb(238, 246, 247);
            CardPanel3.Controls.Add(IdentityDeletebtn);
            CardPanel3.Controls.Add(IdentityEditbtn);
            CardPanel3.Controls.Add(CardEditBtn);
            CardPanel3.Controls.Add(CardDeleteBtn);
            CardPanel3.Controls.Add(SecureNoteEditbtn);
            CardPanel3.Controls.Add(SecureNoteDeletebtn);
            CardPanel3.Location = new Point(0, 493);
            CardPanel3.Name = "CardPanel3";
            CardPanel3.Size = new Size(940, 53);
            CardPanel3.TabIndex = 5;
            // 
            // IdentityDeletebtn
            // 
            IdentityDeletebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            IdentityDeletebtn.BackColor = Color.Transparent;
            IdentityDeletebtn.BackgroundColor = Color.Transparent;
            IdentityDeletebtn.BorderColor = Color.FromArgb(252, 92, 52);
            IdentityDeletebtn.BorderRadius = 16;
            IdentityDeletebtn.BorderSize = 2;
            IdentityDeletebtn.FlatAppearance.BorderSize = 0;
            IdentityDeletebtn.FlatStyle = FlatStyle.Flat;
            IdentityDeletebtn.ForeColor = Color.Black;
            IdentityDeletebtn.Location = new Point(857, 3);
            IdentityDeletebtn.Name = "IdentityDeletebtn";
            IdentityDeletebtn.Size = new Size(68, 37);
            IdentityDeletebtn.TabIndex = 6;
            IdentityDeletebtn.Text = "Delete";
            IdentityDeletebtn.TextColor = Color.Black;
            IdentityDeletebtn.UseVisualStyleBackColor = false;
            IdentityDeletebtn.Click += IdentityDeletebtn_Click;
            // 
            // IdentityEditbtn
            // 
            IdentityEditbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            IdentityEditbtn.BackColor = Color.Transparent;
            IdentityEditbtn.BackgroundColor = Color.Transparent;
            IdentityEditbtn.BorderColor = Color.FromArgb(252, 92, 52);
            IdentityEditbtn.BorderRadius = 16;
            IdentityEditbtn.BorderSize = 2;
            IdentityEditbtn.FlatAppearance.BorderSize = 0;
            IdentityEditbtn.FlatStyle = FlatStyle.Flat;
            IdentityEditbtn.ForeColor = Color.Black;
            IdentityEditbtn.Location = new Point(784, 3);
            IdentityEditbtn.Name = "IdentityEditbtn";
            IdentityEditbtn.Size = new Size(67, 37);
            IdentityEditbtn.TabIndex = 6;
            IdentityEditbtn.Text = "Edit";
            IdentityEditbtn.TextColor = Color.Black;
            IdentityEditbtn.UseVisualStyleBackColor = false;
            IdentityEditbtn.Click += IdentityEditbtn_Click;
            // 
            // CardEditBtn
            // 
            CardEditBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CardEditBtn.BackColor = Color.Transparent;
            CardEditBtn.BackgroundColor = Color.Transparent;
            CardEditBtn.BorderColor = Color.FromArgb(252, 92, 52);
            CardEditBtn.BorderRadius = 16;
            CardEditBtn.BorderSize = 2;
            CardEditBtn.FlatAppearance.BorderSize = 0;
            CardEditBtn.FlatStyle = FlatStyle.Flat;
            CardEditBtn.ForeColor = Color.Black;
            CardEditBtn.Location = new Point(1507, -45);
            CardEditBtn.Name = "CardEditBtn";
            CardEditBtn.Size = new Size(67, 37);
            CardEditBtn.TabIndex = 4;
            CardEditBtn.Text = "Edit";
            CardEditBtn.TextColor = Color.Black;
            CardEditBtn.UseVisualStyleBackColor = false;
            // 
            // CardDeleteBtn
            // 
            CardDeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CardDeleteBtn.BackColor = Color.Transparent;
            CardDeleteBtn.BackgroundColor = Color.Transparent;
            CardDeleteBtn.BorderColor = Color.FromArgb(252, 92, 52);
            CardDeleteBtn.BorderRadius = 16;
            CardDeleteBtn.BorderSize = 2;
            CardDeleteBtn.FlatAppearance.BorderSize = 0;
            CardDeleteBtn.FlatStyle = FlatStyle.Flat;
            CardDeleteBtn.ForeColor = Color.Black;
            CardDeleteBtn.Location = new Point(1578, -45);
            CardDeleteBtn.Name = "CardDeleteBtn";
            CardDeleteBtn.Size = new Size(68, 37);
            CardDeleteBtn.TabIndex = 3;
            CardDeleteBtn.Text = "Delete";
            CardDeleteBtn.TextColor = Color.Black;
            CardDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // SecureNoteEditbtn
            // 
            SecureNoteEditbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SecureNoteEditbtn.BackColor = Color.Transparent;
            SecureNoteEditbtn.BackgroundColor = Color.Transparent;
            SecureNoteEditbtn.BorderColor = Color.FromArgb(252, 92, 52);
            SecureNoteEditbtn.BorderRadius = 16;
            SecureNoteEditbtn.BorderSize = 2;
            SecureNoteEditbtn.FlatAppearance.BorderSize = 0;
            SecureNoteEditbtn.FlatStyle = FlatStyle.Flat;
            SecureNoteEditbtn.ForeColor = Color.Black;
            SecureNoteEditbtn.Location = new Point(2231, -89);
            SecureNoteEditbtn.Name = "SecureNoteEditbtn";
            SecureNoteEditbtn.Size = new Size(69, 37);
            SecureNoteEditbtn.TabIndex = 2;
            SecureNoteEditbtn.Text = "Edit";
            SecureNoteEditbtn.TextColor = Color.Black;
            SecureNoteEditbtn.UseVisualStyleBackColor = false;
            // 
            // SecureNoteDeletebtn
            // 
            SecureNoteDeletebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SecureNoteDeletebtn.BackColor = Color.Transparent;
            SecureNoteDeletebtn.BackgroundColor = Color.Transparent;
            SecureNoteDeletebtn.BorderColor = Color.FromArgb(252, 92, 52);
            SecureNoteDeletebtn.BorderRadius = 16;
            SecureNoteDeletebtn.BorderSize = 2;
            SecureNoteDeletebtn.FlatAppearance.BorderSize = 0;
            SecureNoteDeletebtn.FlatStyle = FlatStyle.Flat;
            SecureNoteDeletebtn.ForeColor = Color.Black;
            SecureNoteDeletebtn.Location = new Point(2306, -89);
            SecureNoteDeletebtn.Name = "SecureNoteDeletebtn";
            SecureNoteDeletebtn.Size = new Size(68, 37);
            SecureNoteDeletebtn.TabIndex = 1;
            SecureNoteDeletebtn.Text = "Delete";
            SecureNoteDeletebtn.TextColor = Color.Black;
            SecureNoteDeletebtn.UseVisualStyleBackColor = false;
            // 
            // IdentitydataGridView
            // 
            IdentitydataGridView.AllowUserToAddRows = false;
            IdentitydataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IdentitydataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            IdentitydataGridView.BackgroundColor = Color.FromArgb(238, 246, 247);
            IdentitydataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            IdentitydataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            IdentitydataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IdentitydataGridView.Columns.AddRange(new DataGridViewColumn[] { IdentityNameColumn, IdentityUserNameColumn, IdentityTittleColumn, IdentityFirstNColumn, IdentityLastNColumn, IdentityCompanyColumn, IdentityLNColumn, IdentityEmailColumn, IdentityPhoneColumn, AddressColumn, IdentityZipColumn, IdentityCountryColumn, NIDColumn, PassportColumn });
            IdentitydataGridView.GridColor = SystemColors.ScrollBar;
            IdentitydataGridView.Location = new Point(0, 65);
            IdentitydataGridView.Name = "IdentitydataGridView";
            IdentitydataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IdentitydataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            IdentitydataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            IdentitydataGridView.Size = new Size(940, 425);
            IdentitydataGridView.TabIndex = 8;
            IdentitydataGridView.CellContentClick += IdentitydataGridView_CellContentClick;
            // 
            // IdentityNameColumn
            // 
            IdentityNameColumn.HeaderText = "Name";
            IdentityNameColumn.Name = "IdentityNameColumn";
            // 
            // IdentityUserNameColumn
            // 
            IdentityUserNameColumn.HeaderText = "Username";
            IdentityUserNameColumn.Name = "IdentityUserNameColumn";
            // 
            // IdentityTittleColumn
            // 
            IdentityTittleColumn.HeaderText = "Tittle";
            IdentityTittleColumn.Name = "IdentityTittleColumn";
            // 
            // IdentityFirstNColumn
            // 
            IdentityFirstNColumn.HeaderText = "First Name";
            IdentityFirstNColumn.Name = "IdentityFirstNColumn";
            // 
            // IdentityLastNColumn
            // 
            IdentityLastNColumn.HeaderText = "Last Name";
            IdentityLastNColumn.Name = "IdentityLastNColumn";
            // 
            // IdentityCompanyColumn
            // 
            IdentityCompanyColumn.HeaderText = "Company";
            IdentityCompanyColumn.Name = "IdentityCompanyColumn";
            // 
            // IdentityLNColumn
            // 
            IdentityLNColumn.HeaderText = "License Number";
            IdentityLNColumn.Name = "IdentityLNColumn";
            // 
            // IdentityEmailColumn
            // 
            IdentityEmailColumn.HeaderText = "Email";
            IdentityEmailColumn.Name = "IdentityEmailColumn";
            // 
            // IdentityPhoneColumn
            // 
            IdentityPhoneColumn.HeaderText = "Phone";
            IdentityPhoneColumn.Name = "IdentityPhoneColumn";
            // 
            // AddressColumn
            // 
            AddressColumn.HeaderText = "Address";
            AddressColumn.Name = "AddressColumn";
            // 
            // IdentityZipColumn
            // 
            IdentityZipColumn.HeaderText = "Zip";
            IdentityZipColumn.Name = "IdentityZipColumn";
            // 
            // IdentityCountryColumn
            // 
            IdentityCountryColumn.HeaderText = "Country";
            IdentityCountryColumn.Name = "IdentityCountryColumn";
            // 
            // NIDColumn
            // 
            NIDColumn.HeaderText = "NID no";
            NIDColumn.Name = "NIDColumn";
            // 
            // PassportColumn
            // 
            PassportColumn.HeaderText = "Passport no";
            PassportColumn.Name = "PassportColumn";
            // 
            // IdentityNoItems
            // 
            IdentityNoItems.AutoSize = true;
            IdentityNoItems.Location = new Point(390, 247);
            IdentityNoItems.Name = "IdentityNoItems";
            IdentityNoItems.Size = new Size(133, 21);
            IdentityNoItems.TabIndex = 9;
            IdentityNoItems.Text = "No Item Available";
            IdentityNoItems.Visible = false;
            // 
            // IdentityForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 246, 247);
            ClientSize = new Size(937, 545);
            Controls.Add(IdentityNoItems);
            Controls.Add(IdentitydataGridView);
            Controls.Add(CardPanel3);
            Controls.Add(CardPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "IdentityForm";
            Text = "IdentityForm";
            CardPanel1.ResumeLayout(false);
            CardPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IdentitydataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CardPanel1;
        private CustomControls.CustomTextBox CardSearchBox;
        public CustomControls.CustomButton IdentityAddBtn;
        private CustomControls.CustomTextBox IdentitySearchBox;
        private Panel CardPanel3;
        private CustomControls.CustomButton CardEditBtn;
        private CustomControls.CustomButton CardDeleteBtn;
        private CustomControls.CustomButton SecureNoteEditbtn;
        private CustomControls.CustomButton SecureNoteDeletebtn;
        private CustomControls.CustomButton IdentityEditbtn;
        private CustomControls.CustomButton IdentityDeletebtn;
        public DataGridView IdentitydataGridView;
        public Label IdentityNoItems;
        private DataGridViewTextBoxColumn IdentityNameColumn;
        private DataGridViewTextBoxColumn IdentityUserNameColumn;
        private DataGridViewTextBoxColumn IdentityTittleColumn;
        private DataGridViewTextBoxColumn IdentityFirstNColumn;
        private DataGridViewTextBoxColumn IdentityLastNColumn;
        private DataGridViewTextBoxColumn IdentityCompanyColumn;
        private DataGridViewTextBoxColumn IdentityLNColumn;
        private DataGridViewTextBoxColumn IdentityEmailColumn;
        private DataGridViewTextBoxColumn IdentityPhoneColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn IdentityZipColumn;
        private DataGridViewTextBoxColumn IdentityCountryColumn;
        private DataGridViewTextBoxColumn NIDColumn;
        private DataGridViewTextBoxColumn PassportColumn;
    }
}