namespace Credentia_Winforms
{
    partial class AllLoginsForm
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
            AllloginsPanel1 = new Panel();
            AllloginsSearchBox = new CustomControls.CustomTextBox();
            CardSearchBox = new CustomControls.CustomTextBox();
            AllloginsAddBtn = new CustomControls.CustomButton();
            AllloginsdataGridView = new DataGridView();
            AllloginsNameColumn = new DataGridViewTextBoxColumn();
            AllloginsUsernameColumn = new DataGridViewTextBoxColumn();
            AllloginsPasswordColumn = new DataGridViewTextBoxColumn();
            AllloginsURLColumn = new DataGridViewTextBoxColumn();
            AllloginPanel3 = new Panel();
            AllloginsDeletebtn = new CustomControls.CustomButton();
            AllloginsEditbtn = new CustomControls.CustomButton();
            CardEditBtn = new CustomControls.CustomButton();
            CardDeleteBtn = new CustomControls.CustomButton();
            SecureNoteEditbtn = new CustomControls.CustomButton();
            SecureNoteDeletebtn = new CustomControls.CustomButton();
            NoItemsLabel = new Label();
            AllloginsPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllloginsdataGridView).BeginInit();
            AllloginPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // AllloginsPanel1
            // 
            AllloginsPanel1.Controls.Add(AllloginsSearchBox);
            AllloginsPanel1.Controls.Add(CardSearchBox);
            AllloginsPanel1.Controls.Add(AllloginsAddBtn);
            AllloginsPanel1.Location = new Point(0, 0);
            AllloginsPanel1.Name = "AllloginsPanel1";
            AllloginsPanel1.Size = new Size(744, 51);
            AllloginsPanel1.TabIndex = 4;
            // 
            // AllloginsSearchBox
            // 
            AllloginsSearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AllloginsSearchBox.BackColor = Color.FromArgb(217, 217, 217);
            AllloginsSearchBox.BorderColor = Color.Transparent;
            AllloginsSearchBox.BorderFocusColor = Color.Transparent;
            AllloginsSearchBox.BorderRadius = 16;
            AllloginsSearchBox.BorderSize = 2;
            AllloginsSearchBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllloginsSearchBox.ForeColor = Color.DimGray;
            AllloginsSearchBox.Location = new Point(196, 9);
            AllloginsSearchBox.Multiline = false;
            AllloginsSearchBox.Name = "AllloginsSearchBox";
            AllloginsSearchBox.Padding = new Padding(7);
            AllloginsSearchBox.PasswordChar = false;
            AllloginsSearchBox.PlaceholderColor = Color.DarkGray;
            AllloginsSearchBox.PlaceholderText = "";
            AllloginsSearchBox.Size = new Size(353, 32);
            AllloginsSearchBox.TabIndex = 7;
            AllloginsSearchBox.Texts = "";
            AllloginsSearchBox.UnderlinedStyle = false;
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
            // AllloginsAddBtn
            // 
            AllloginsAddBtn.BackColor = Color.Transparent;
            AllloginsAddBtn.BackgroundColor = Color.Transparent;
            AllloginsAddBtn.BorderColor = Color.FromArgb(252, 92, 52);
            AllloginsAddBtn.BorderRadius = 16;
            AllloginsAddBtn.BorderSize = 2;
            AllloginsAddBtn.FlatAppearance.BorderSize = 0;
            AllloginsAddBtn.FlatStyle = FlatStyle.Flat;
            AllloginsAddBtn.ForeColor = Color.Black;
            AllloginsAddBtn.Location = new Point(665, 11);
            AllloginsAddBtn.Name = "AllloginsAddBtn";
            AllloginsAddBtn.Size = new Size(57, 32);
            AllloginsAddBtn.TabIndex = 6;
            AllloginsAddBtn.Text = "ADD";
            AllloginsAddBtn.TextColor = Color.Black;
            AllloginsAddBtn.UseVisualStyleBackColor = false;
            AllloginsAddBtn.Click += AllloginsAddBtn_Click;
            // 
            // AllloginsdataGridView
            // 
            AllloginsdataGridView.AllowUserToAddRows = false;
            AllloginsdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllloginsdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllloginsdataGridView.BackgroundColor = Color.FromArgb(238, 246, 247);
            AllloginsdataGridView.BorderStyle = BorderStyle.None;
            AllloginsdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllloginsdataGridView.Columns.AddRange(new DataGridViewColumn[] { AllloginsNameColumn, AllloginsUsernameColumn, AllloginsPasswordColumn, AllloginsURLColumn });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            AllloginsdataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            AllloginsdataGridView.GridColor = SystemColors.ScrollBar;
            AllloginsdataGridView.Location = new Point(12, 60);
            AllloginsdataGridView.Name = "AllloginsdataGridView";
            AllloginsdataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 217, 217);
            AllloginsdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            AllloginsdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllloginsdataGridView.Size = new Size(913, 425);
            AllloginsdataGridView.TabIndex = 8;
            // 
            // AllloginsNameColumn
            // 
            AllloginsNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            AllloginsNameColumn.FillWeight = 25F;
            AllloginsNameColumn.HeaderText = "Name";
            AllloginsNameColumn.Name = "AllloginsNameColumn";
            AllloginsNameColumn.Width = 200;
            // 
            // AllloginsUsernameColumn
            // 
            AllloginsUsernameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            AllloginsUsernameColumn.FillWeight = 25F;
            AllloginsUsernameColumn.HeaderText = "Username";
            AllloginsUsernameColumn.Name = "AllloginsUsernameColumn";
            AllloginsUsernameColumn.Width = 200;
            // 
            // AllloginsPasswordColumn
            // 
            AllloginsPasswordColumn.FillWeight = 25F;
            AllloginsPasswordColumn.HeaderText = "Password";
            AllloginsPasswordColumn.Name = "AllloginsPasswordColumn";
            // 
            // AllloginsURLColumn
            // 
            AllloginsURLColumn.FillWeight = 25F;
            AllloginsURLColumn.HeaderText = "URL";
            AllloginsURLColumn.Name = "AllloginsURLColumn";
            // 
            // AllloginPanel3
            // 
            AllloginPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllloginPanel3.BackColor = Color.FromArgb(238, 246, 247);
            AllloginPanel3.Controls.Add(AllloginsDeletebtn);
            AllloginPanel3.Controls.Add(AllloginsEditbtn);
            AllloginPanel3.Controls.Add(CardEditBtn);
            AllloginPanel3.Controls.Add(CardDeleteBtn);
            AllloginPanel3.Controls.Add(SecureNoteEditbtn);
            AllloginPanel3.Controls.Add(SecureNoteDeletebtn);
            AllloginPanel3.Location = new Point(0, 491);
            AllloginPanel3.Name = "AllloginPanel3";
            AllloginPanel3.Size = new Size(940, 53);
            AllloginPanel3.TabIndex = 9;
            // 
            // AllloginsDeletebtn
            // 
            AllloginsDeletebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AllloginsDeletebtn.BackColor = Color.Transparent;
            AllloginsDeletebtn.BackgroundColor = Color.Transparent;
            AllloginsDeletebtn.BorderColor = Color.FromArgb(252, 92, 52);
            AllloginsDeletebtn.BorderRadius = 16;
            AllloginsDeletebtn.BorderSize = 2;
            AllloginsDeletebtn.FlatAppearance.BorderSize = 0;
            AllloginsDeletebtn.FlatStyle = FlatStyle.Flat;
            AllloginsDeletebtn.ForeColor = Color.Black;
            AllloginsDeletebtn.Location = new Point(853, 5);
            AllloginsDeletebtn.Name = "AllloginsDeletebtn";
            AllloginsDeletebtn.Size = new Size(68, 37);
            AllloginsDeletebtn.TabIndex = 10;
            AllloginsDeletebtn.Text = "Delete";
            AllloginsDeletebtn.TextColor = Color.Black;
            AllloginsDeletebtn.UseVisualStyleBackColor = false;
            AllloginsDeletebtn.Click += AllloginsDeletebtn_Click;
            // 
            // AllloginsEditbtn
            // 
            AllloginsEditbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AllloginsEditbtn.BackColor = Color.Transparent;
            AllloginsEditbtn.BackgroundColor = Color.Transparent;
            AllloginsEditbtn.BorderColor = Color.FromArgb(252, 92, 52);
            AllloginsEditbtn.BorderRadius = 16;
            AllloginsEditbtn.BorderSize = 2;
            AllloginsEditbtn.FlatAppearance.BorderSize = 0;
            AllloginsEditbtn.FlatStyle = FlatStyle.Flat;
            AllloginsEditbtn.ForeColor = Color.Black;
            AllloginsEditbtn.Location = new Point(780, 5);
            AllloginsEditbtn.Name = "AllloginsEditbtn";
            AllloginsEditbtn.Size = new Size(67, 37);
            AllloginsEditbtn.TabIndex = 10;
            AllloginsEditbtn.Text = "Edit";
            AllloginsEditbtn.TextColor = Color.Black;
            AllloginsEditbtn.UseVisualStyleBackColor = false;
            AllloginsEditbtn.Click += AllloginsEditbtn_Click;
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
            // NoItemsLabel
            // 
            NoItemsLabel.AutoSize = true;
            NoItemsLabel.Location = new Point(402, 262);
            NoItemsLabel.Name = "NoItemsLabel";
            NoItemsLabel.Size = new Size(133, 21);
            NoItemsLabel.TabIndex = 10;
            NoItemsLabel.Text = "No Item Available";
            NoItemsLabel.Visible = false;
            // 
            // AllLoginsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 246, 247);
            ClientSize = new Size(937, 545);
            Controls.Add(NoItemsLabel);
            Controls.Add(AllloginPanel3);
            Controls.Add(AllloginsdataGridView);
            Controls.Add(AllloginsPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AllLoginsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "All Logins";
            Load += AllLoginsForm_Load;
            AllloginsPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllloginsdataGridView).EndInit();
            AllloginPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel AllloginsPanel1;
        private CustomControls.CustomTextBox CardSearchBox;
        public CustomControls.CustomButton AllloginsAddBtn;
        public DataGridView AllloginsdataGridView;
        private Panel AllloginPanel3;
        private CustomControls.CustomButton CardEditBtn;
        private CustomControls.CustomButton CardDeleteBtn;
        private CustomControls.CustomButton SecureNoteEditbtn;
        private CustomControls.CustomButton SecureNoteDeletebtn;
        private CustomControls.CustomButton AllloginsEditbtn;
        private CustomControls.CustomButton AllloginsDeletebtn;
        private DataGridViewTextBoxColumn AllloginsNameColumn;
        private DataGridViewTextBoxColumn AllloginsUsernameColumn;
        private DataGridViewTextBoxColumn AllloginsPasswordColumn;
        private DataGridViewTextBoxColumn AllloginsURLColumn;
        private CustomControls.CustomTextBox AllloginsSearchBox;
        public Label NoItemsLabel;
    }
}