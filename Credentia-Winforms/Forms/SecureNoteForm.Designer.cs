namespace Credentia_Winforms
{
    partial class SecureNoteForm
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
            panel1 = new Panel();
            SecureNoteEditbtn = new CustomControls.CustomButton();
            SecureNoteDeletebtn = new CustomControls.CustomButton();
            panel2 = new Panel();
            SearchBtn = new CustomControls.CustomButton();
            SecureNoteAddBtn = new CustomControls.CustomButton();
            NoteSearchBox = new CustomControls.CustomTextBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            SCNoItemsLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(SecureNoteEditbtn);
            panel1.Controls.Add(SecureNoteDeletebtn);
            panel1.Location = new Point(1, 493);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 50);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            SecureNoteEditbtn.Location = new Point(772, 8);
            SecureNoteEditbtn.Name = "SecureNoteEditbtn";
            SecureNoteEditbtn.Size = new Size(69, 37);
            SecureNoteEditbtn.TabIndex = 2;
            SecureNoteEditbtn.Text = "Edit";
            SecureNoteEditbtn.TextColor = Color.Black;
            SecureNoteEditbtn.UseVisualStyleBackColor = false;
            SecureNoteEditbtn.Click += SecureNoteEditbtn_Click;
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
            SecureNoteDeletebtn.Location = new Point(847, 8);
            SecureNoteDeletebtn.Name = "SecureNoteDeletebtn";
            SecureNoteDeletebtn.Size = new Size(68, 37);
            SecureNoteDeletebtn.TabIndex = 1;
            SecureNoteDeletebtn.Text = "Delete";
            SecureNoteDeletebtn.TextColor = Color.Black;
            SecureNoteDeletebtn.UseVisualStyleBackColor = false;
            SecureNoteDeletebtn.Click += SecureNoteDeletebtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(SearchBtn);
            panel2.Controls.Add(SecureNoteAddBtn);
            panel2.Controls.Add(NoteSearchBox);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(744, 51);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            SearchBtn.TabIndex = 5;
            SearchBtn.Text = "SEARCH";
            SearchBtn.TextColor = Color.Black;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SecureNoteAddBtn
            // 
            SecureNoteAddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SecureNoteAddBtn.BackColor = Color.Transparent;
            SecureNoteAddBtn.BackgroundColor = Color.Transparent;
            SecureNoteAddBtn.BorderColor = Color.FromArgb(252, 92, 52);
            SecureNoteAddBtn.BorderRadius = 16;
            SecureNoteAddBtn.BorderSize = 2;
            SecureNoteAddBtn.FlatAppearance.BorderSize = 0;
            SecureNoteAddBtn.FlatStyle = FlatStyle.Flat;
            SecureNoteAddBtn.ForeColor = Color.Black;
            SecureNoteAddBtn.Location = new Point(684, 11);
            SecureNoteAddBtn.Name = "SecureNoteAddBtn";
            SecureNoteAddBtn.Size = new Size(57, 32);
            SecureNoteAddBtn.TabIndex = 5;
            SecureNoteAddBtn.Text = "ADD";
            SecureNoteAddBtn.TextColor = Color.Black;
            SecureNoteAddBtn.UseVisualStyleBackColor = false;
            SecureNoteAddBtn.Click += SecureNoteAddBtn_Click;
            // 
            // NoteSearchBox
            // 
            NoteSearchBox.BackColor = Color.FromArgb(217, 217, 217);
            NoteSearchBox.BorderColor = Color.Transparent;
            NoteSearchBox.BorderFocusColor = Color.Transparent;
            NoteSearchBox.BorderRadius = 16;
            NoteSearchBox.BorderSize = 2;
            NoteSearchBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoteSearchBox.ForeColor = Color.DimGray;
            NoteSearchBox.Location = new Point(220, 11);
            NoteSearchBox.Multiline = false;
            NoteSearchBox.Name = "NoteSearchBox";
            NoteSearchBox.Padding = new Padding(7);
            NoteSearchBox.PasswordChar = false;
            NoteSearchBox.PlaceholderColor = Color.DarkGray;
            NoteSearchBox.PlaceholderText = "";
            NoteSearchBox.Size = new Size(353, 32);
            NoteSearchBox.TabIndex = 0;
            NoteSearchBox.Texts = "";
            NoteSearchBox.UnderlinedStyle = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(238, 246, 247);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView2.GridColor = SystemColors.ScrollBar;
            dataGridView2.Location = new Point(12, 72);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(217, 217, 217);
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(901, 423);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 40.07614F;
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 194.923859F;
            dataGridViewTextBoxColumn2.HeaderText = "SecureNote";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // SCNoItemsLabel
            // 
            SCNoItemsLabel.AutoSize = true;
            SCNoItemsLabel.Location = new Point(390, 247);
            SCNoItemsLabel.Name = "SCNoItemsLabel";
            SCNoItemsLabel.Size = new Size(133, 21);
            SCNoItemsLabel.TabIndex = 9;
            SCNoItemsLabel.Text = "No Item Available";
            SCNoItemsLabel.Visible = false;
            // 
            // SecureNoteForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 246, 247);
            ClientSize = new Size(928, 543);
            Controls.Add(SCNoItemsLabel);
            Controls.Add(dataGridView2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SecureNoteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecureNoteForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.CustomButton SecureNoteDeletebtn;
        private Panel panel1;
        public Panel secureNoteUpdateForm;
        public CustomControls.CustomButton SecureNoteUpdateDonebtn;
        public Label SecureNoteUpdateNote;
        public CustomControls.CustomTextBox SecureNoteUpdateNoteBox;
        public Label SecureNoteUpdateName;
        public CustomControls.CustomTextBox SecureNoteUpdateNameBox;
        private CustomControls.CustomButton SecureNoteEditbtn;
        private Panel panel2;
        public CustomControls.CustomButton SecureNoteAddBtn;
        public DataGridView dataGridView2;
        private CustomControls.CustomTextBox NoteSearchBox;
        public Label SCNoItemsLabel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public CustomControls.CustomButton SearchBtn;
    }
}