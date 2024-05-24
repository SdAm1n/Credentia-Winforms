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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            CardPanel3 = new Panel();
            CardEditBtn = new CustomControls.CustomButton();
            CardDeleteBtn = new CustomControls.CustomButton();
            SecureNoteEditbtn = new CustomControls.CustomButton();
            SecureNoteDeletebtn = new CustomControls.CustomButton();
            CardPanel1 = new Panel();
            CardSearchBox = new CustomControls.CustomTextBox();
            CardAddBtn = new CustomControls.CustomButton();
            CarddataGridView = new DataGridView();
            CardNameBoxColumn = new DataGridViewTextBoxColumn();
            CardHolderBoxColumn = new DataGridViewTextBoxColumn();
            CardNumberColumn = new DataGridViewTextBoxColumn();
            BrandColumn = new DataGridViewTextBoxColumn();
            ExMonthColumn = new DataGridViewTextBoxColumn();
            ExYearColumn = new DataGridViewTextBoxColumn();
            SecurityCodeColumn = new DataGridViewTextBoxColumn();
            NoItemsLabel = new Label();
            SearchBtn = new CustomControls.CustomButton();
            CardPanel3.SuspendLayout();
            CardPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CarddataGridView).BeginInit();
            SuspendLayout();
            // 
            // CardPanel3
            // 
            CardPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CardPanel3.BackColor = Color.FromArgb(238, 246, 247);
            CardPanel3.Controls.Add(CardEditBtn);
            CardPanel3.Controls.Add(CardDeleteBtn);
            CardPanel3.Controls.Add(SecureNoteEditbtn);
            CardPanel3.Controls.Add(SecureNoteDeletebtn);
            CardPanel3.Location = new Point(-2, 493);
            CardPanel3.Name = "CardPanel3";
            CardPanel3.Size = new Size(940, 53);
            CardPanel3.TabIndex = 2;
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
            CardEditBtn.Location = new Point(780, 5);
            CardEditBtn.Name = "CardEditBtn";
            CardEditBtn.Size = new Size(67, 37);
            CardEditBtn.TabIndex = 4;
            CardEditBtn.Text = "Edit";
            CardEditBtn.TextColor = Color.Black;
            CardEditBtn.UseVisualStyleBackColor = false;
            CardEditBtn.Click += CardEditBtn_Click;
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
            CardDeleteBtn.Location = new Point(853, 5);
            CardDeleteBtn.Name = "CardDeleteBtn";
            CardDeleteBtn.Size = new Size(68, 37);
            CardDeleteBtn.TabIndex = 3;
            CardDeleteBtn.Text = "Delete";
            CardDeleteBtn.TextColor = Color.Black;
            CardDeleteBtn.UseVisualStyleBackColor = false;
            CardDeleteBtn.Click += CardDeleteBtn_Click;
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
            SecureNoteEditbtn.Location = new Point(1491, -42);
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
            SecureNoteDeletebtn.Location = new Point(1566, -42);
            SecureNoteDeletebtn.Name = "SecureNoteDeletebtn";
            SecureNoteDeletebtn.Size = new Size(68, 37);
            SecureNoteDeletebtn.TabIndex = 1;
            SecureNoteDeletebtn.Text = "Delete";
            SecureNoteDeletebtn.TextColor = Color.Black;
            SecureNoteDeletebtn.UseVisualStyleBackColor = false;
            // 
            // CardPanel1
            // 
            CardPanel1.Controls.Add(CardSearchBox);
            CardPanel1.Controls.Add(SearchBtn);
            CardPanel1.Controls.Add(CardAddBtn);
            CardPanel1.Location = new Point(0, 0);
            CardPanel1.Name = "CardPanel1";
            CardPanel1.Size = new Size(744, 51);
            CardPanel1.TabIndex = 3;
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
            CardSearchBox.Location = new Point(220, 11);
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
            // CardAddBtn
            // 
            CardAddBtn.BackColor = Color.Transparent;
            CardAddBtn.BackgroundColor = Color.Transparent;
            CardAddBtn.BorderColor = Color.FromArgb(252, 92, 52);
            CardAddBtn.BorderRadius = 16;
            CardAddBtn.BorderSize = 2;
            CardAddBtn.FlatAppearance.BorderSize = 0;
            CardAddBtn.FlatStyle = FlatStyle.Flat;
            CardAddBtn.ForeColor = Color.Black;
            CardAddBtn.Location = new Point(684, 11);
            CardAddBtn.Name = "CardAddBtn";
            CardAddBtn.Size = new Size(57, 32);
            CardAddBtn.TabIndex = 6;
            CardAddBtn.Text = "ADD";
            CardAddBtn.TextColor = Color.Black;
            CardAddBtn.UseVisualStyleBackColor = false;
            CardAddBtn.Click += CardAddBtn_Click;
            // 
            // CarddataGridView
            // 
            CarddataGridView.AllowUserToAddRows = false;
            CarddataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CarddataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CarddataGridView.BackgroundColor = Color.FromArgb(238, 246, 247);
            CarddataGridView.BorderStyle = BorderStyle.None;
            CarddataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarddataGridView.Columns.AddRange(new DataGridViewColumn[] { CardNameBoxColumn, CardHolderBoxColumn, CardNumberColumn, BrandColumn, ExMonthColumn, ExYearColumn, SecurityCodeColumn });
            CarddataGridView.GridColor = SystemColors.ScrollBar;
            CarddataGridView.Location = new Point(12, 67);
            CarddataGridView.Name = "CarddataGridView";
            CarddataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(217, 217, 217);
            CarddataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            CarddataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarddataGridView.Size = new Size(913, 425);
            CarddataGridView.TabIndex = 7;
            CarddataGridView.CellContentClick += CarddataGridView_CellContentClick;
            // 
            // CardNameBoxColumn
            // 
            CardNameBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CardNameBoxColumn.FillWeight = 30F;
            CardNameBoxColumn.HeaderText = "Name";
            CardNameBoxColumn.Name = "CardNameBoxColumn";
            CardNameBoxColumn.ReadOnly = true;
            // 
            // CardHolderBoxColumn
            // 
            CardHolderBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CardHolderBoxColumn.FillWeight = 65F;
            CardHolderBoxColumn.HeaderText = "Card Holder Name";
            CardHolderBoxColumn.Name = "CardHolderBoxColumn";
            CardHolderBoxColumn.ReadOnly = true;
            CardHolderBoxColumn.Width = 126;
            // 
            // CardNumberColumn
            // 
            CardNumberColumn.FillWeight = 2.32163739F;
            CardNumberColumn.HeaderText = "Card Number";
            CardNumberColumn.Name = "CardNumberColumn";
            CardNumberColumn.ReadOnly = true;
            // 
            // BrandColumn
            // 
            BrandColumn.FillWeight = 1F;
            BrandColumn.HeaderText = "Brand";
            BrandColumn.Name = "BrandColumn";
            BrandColumn.ReadOnly = true;
            // 
            // ExMonthColumn
            // 
            ExMonthColumn.FillWeight = 2.32163739F;
            ExMonthColumn.HeaderText = "Expiration Month";
            ExMonthColumn.Name = "ExMonthColumn";
            ExMonthColumn.ReadOnly = true;
            // 
            // ExYearColumn
            // 
            ExYearColumn.FillWeight = 2.32163739F;
            ExYearColumn.HeaderText = "Expiration Year";
            ExYearColumn.Name = "ExYearColumn";
            ExYearColumn.ReadOnly = true;
            // 
            // SecurityCodeColumn
            // 
            SecurityCodeColumn.FillWeight = 2.32163739F;
            SecurityCodeColumn.HeaderText = "Security Code";
            SecurityCodeColumn.Name = "SecurityCodeColumn";
            SecurityCodeColumn.ReadOnly = true;
            // 
            // NoItemsLabel
            // 
            NoItemsLabel.AutoSize = true;
            NoItemsLabel.Location = new Point(390, 247);
            NoItemsLabel.Name = "NoItemsLabel";
            NoItemsLabel.Size = new Size(133, 21);
            NoItemsLabel.TabIndex = 8;
            NoItemsLabel.Text = "No Item Available";
            NoItemsLabel.Visible = false;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Transparent;
            SearchBtn.BackgroundColor = Color.Transparent;
            SearchBtn.BorderColor = Color.FromArgb(252, 92, 52);
            SearchBtn.BorderRadius = 16;
            SearchBtn.BorderSize = 2;
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.ForeColor = Color.Black;
            SearchBtn.Location = new Point(579, 11);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(80, 32);
            SearchBtn.TabIndex = 6;
            SearchBtn.Text = "SEARCH";
            SearchBtn.TextColor = Color.Black;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // CardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 246, 247);
            ClientSize = new Size(937, 545);
            Controls.Add(NoItemsLabel);
            Controls.Add(CarddataGridView);
            Controls.Add(CardPanel1);
            Controls.Add(CardPanel3);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "CardForm";
            Text = "CardForm";
            CardPanel3.ResumeLayout(false);
            CardPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CarddataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CardPanel3;
        private CustomControls.CustomButton SecureNoteEditbtn;
        private CustomControls.CustomButton SecureNoteDeletebtn;
        private CustomControls.CustomButton CardDeleteBtn;
        private CustomControls.CustomButton CardEditBtn;
        private Panel CardPanel1;
        private CustomControls.CustomTextBox CardSearchBox;
        public CustomControls.CustomButton CardAddBtn;
        public DataGridView CarddataGridView;
        public Label NoItemsLabel;
        private DataGridViewTextBoxColumn CardNameBoxColumn;
        private DataGridViewTextBoxColumn CardHolderBoxColumn;
        private DataGridViewTextBoxColumn CardNumberColumn;
        private DataGridViewTextBoxColumn BrandColumn;
        private DataGridViewTextBoxColumn ExMonthColumn;
        private DataGridViewTextBoxColumn ExYearColumn;
        private DataGridViewTextBoxColumn SecurityCodeColumn;
        public CustomControls.CustomButton SearchBtn;
    }
}