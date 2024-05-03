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
            SecureNoteDetailsPanel = new Panel();
            SecureNoteDetailText = new CustomControls.CustomTextBox();
            SecureDetailNameBox = new CustomControls.CustomTextBox();
            SecureNotedetails = new Label();
            SecureNoteName = new Label();
            SecureNoteAddForm = new Panel();
            SecureAddFormDonebtn = new CustomControls.CustomButton();
            SecureAddNote = new Label();
            SecureAddTextBox = new CustomControls.CustomTextBox();
            SecureAddFormName = new Label();
            SecureNameBox = new CustomControls.CustomTextBox();
            SecureNotepanel1 = new Panel();
            panel1 = new Panel();
            SecureNoteDeletebtn = new CustomControls.CustomButton();
            panel5 = new Panel();
            listView = new ListView();
            NameColumnHeader1 = new ColumnHeader();
            NoteColumnHeader1 = new ColumnHeader();
            SecureNotepanel3 = new Panel();
            SecureNoteaddButton = new CustomControls.CustomButton();
            SecureNotesearchBox = new CustomControls.CustomTextBox();
            SecureNoteDetailsPanel.SuspendLayout();
            SecureNoteAddForm.SuspendLayout();
            SecureNotepanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SecureNotepanel3.SuspendLayout();
            SuspendLayout();
            // 
            // SecureNoteDetailsPanel
            // 
            SecureNoteDetailsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SecureNoteDetailsPanel.BackColor = Color.FromArgb(234, 238, 238);
            SecureNoteDetailsPanel.Controls.Add(SecureNoteDetailText);
            SecureNoteDetailsPanel.Controls.Add(SecureDetailNameBox);
            SecureNoteDetailsPanel.Controls.Add(SecureNotedetails);
            SecureNoteDetailsPanel.Controls.Add(SecureNoteName);
            SecureNoteDetailsPanel.Location = new Point(0, 0);
            SecureNoteDetailsPanel.Name = "SecureNoteDetailsPanel";
            SecureNoteDetailsPanel.Size = new Size(339, 537);
            SecureNoteDetailsPanel.TabIndex = 2;
            SecureNoteDetailsPanel.Paint += SecureNoteDetailsPanel_Paint;
            // 
            // SecureNoteDetailText
            // 
            SecureNoteDetailText.BackColor = SystemColors.Window;
            SecureNoteDetailText.BorderColor = Color.GhostWhite;
            SecureNoteDetailText.BorderFocusColor = Color.GhostWhite;
            SecureNoteDetailText.BorderRadius = 0;
            SecureNoteDetailText.BorderSize = 2;
            SecureNoteDetailText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecureNoteDetailText.ForeColor = Color.DimGray;
            SecureNoteDetailText.Location = new Point(29, 190);
            SecureNoteDetailText.Multiline = true;
            SecureNoteDetailText.Name = "SecureNoteDetailText";
            SecureNoteDetailText.Padding = new Padding(7);
            SecureNoteDetailText.PasswordChar = false;
            SecureNoteDetailText.PlaceholderColor = Color.DarkGray;
            SecureNoteDetailText.PlaceholderText = "";
            SecureNoteDetailText.Size = new Size(279, 243);
            SecureNoteDetailText.TabIndex = 3;
            SecureNoteDetailText.Texts = "";
            SecureNoteDetailText.UnderlinedStyle = false;
            // 
            // SecureDetailNameBox
            // 
            SecureDetailNameBox.BackColor = SystemColors.Window;
            SecureDetailNameBox.BorderColor = Color.GhostWhite;
            SecureDetailNameBox.BorderFocusColor = Color.GhostWhite;
            SecureDetailNameBox.BorderRadius = 0;
            SecureDetailNameBox.BorderSize = 2;
            SecureDetailNameBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecureDetailNameBox.ForeColor = Color.DimGray;
            SecureDetailNameBox.Location = new Point(29, 99);
            SecureDetailNameBox.Multiline = false;
            SecureDetailNameBox.Name = "SecureDetailNameBox";
            SecureDetailNameBox.Padding = new Padding(7);
            SecureDetailNameBox.PasswordChar = false;
            SecureDetailNameBox.PlaceholderColor = Color.DarkGray;
            SecureDetailNameBox.PlaceholderText = "";
            SecureDetailNameBox.Size = new Size(279, 32);
            SecureDetailNameBox.TabIndex = 2;
            SecureDetailNameBox.Texts = "";
            SecureDetailNameBox.UnderlinedStyle = false;
            // 
            // SecureNotedetails
            // 
            SecureNotedetails.AutoSize = true;
            SecureNotedetails.Location = new Point(29, 166);
            SecureNotedetails.Name = "SecureNotedetails";
            SecureNotedetails.Size = new Size(91, 21);
            SecureNotedetails.TabIndex = 1;
            SecureNotedetails.Text = "SecureNote";
            // 
            // SecureNoteName
            // 
            SecureNoteName.AutoSize = true;
            SecureNoteName.Location = new Point(29, 65);
            SecureNoteName.Name = "SecureNoteName";
            SecureNoteName.Size = new Size(52, 21);
            SecureNoteName.TabIndex = 0;
            SecureNoteName.Text = "Name";
            // 
            // SecureNoteAddForm
            // 
            SecureNoteAddForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SecureNoteAddForm.BackColor = Color.FromArgb(234, 238, 238);
            SecureNoteAddForm.Controls.Add(SecureNoteDetailsPanel);
            SecureNoteAddForm.Controls.Add(SecureAddFormDonebtn);
            SecureNoteAddForm.Controls.Add(SecureAddNote);
            SecureNoteAddForm.Controls.Add(SecureAddTextBox);
            SecureNoteAddForm.Controls.Add(SecureAddFormName);
            SecureNoteAddForm.Controls.Add(SecureNameBox);
            SecureNoteAddForm.Location = new Point(468, 0);
            SecureNoteAddForm.Name = "SecureNoteAddForm";
            SecureNoteAddForm.Size = new Size(339, 537);
            SecureNoteAddForm.TabIndex = 3;
            // 
            // SecureAddFormDonebtn
            // 
            SecureAddFormDonebtn.BackColor = Color.MediumSlateBlue;
            SecureAddFormDonebtn.BackgroundColor = Color.MediumSlateBlue;
            SecureAddFormDonebtn.BorderColor = Color.PaleVioletRed;
            SecureAddFormDonebtn.BorderRadius = 0;
            SecureAddFormDonebtn.BorderSize = 0;
            SecureAddFormDonebtn.FlatAppearance.BorderSize = 0;
            SecureAddFormDonebtn.FlatStyle = FlatStyle.Flat;
            SecureAddFormDonebtn.ForeColor = Color.White;
            SecureAddFormDonebtn.Location = new Point(151, 387);
            SecureAddFormDonebtn.Name = "SecureAddFormDonebtn";
            SecureAddFormDonebtn.Size = new Size(72, 29);
            SecureAddFormDonebtn.TabIndex = 4;
            SecureAddFormDonebtn.Text = "Done";
            SecureAddFormDonebtn.TextColor = Color.White;
            SecureAddFormDonebtn.UseVisualStyleBackColor = false;
            SecureAddFormDonebtn.Click += SecureAddFormDonebtn_Click;
            // 
            // SecureAddNote
            // 
            SecureAddNote.AutoSize = true;
            SecureAddNote.Location = new Point(58, 153);
            SecureAddNote.Name = "SecureAddNote";
            SecureAddNote.Size = new Size(95, 21);
            SecureAddNote.TabIndex = 3;
            SecureAddNote.Text = "Secure Note";
            SecureAddNote.Click += label1_Click;
            // 
            // SecureAddTextBox
            // 
            SecureAddTextBox.BackColor = SystemColors.Window;
            SecureAddTextBox.BorderColor = Color.MediumSlateBlue;
            SecureAddTextBox.BorderFocusColor = Color.HotPink;
            SecureAddTextBox.BorderRadius = 0;
            SecureAddTextBox.BorderSize = 2;
            SecureAddTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecureAddTextBox.ForeColor = Color.DimGray;
            SecureAddTextBox.Location = new Point(58, 182);
            SecureAddTextBox.Multiline = true;
            SecureAddTextBox.Name = "SecureAddTextBox";
            SecureAddTextBox.Padding = new Padding(7);
            SecureAddTextBox.PasswordChar = false;
            SecureAddTextBox.PlaceholderColor = Color.DarkGray;
            SecureAddTextBox.PlaceholderText = "";
            SecureAddTextBox.Size = new Size(250, 178);
            SecureAddTextBox.TabIndex = 2;
            SecureAddTextBox.Texts = "";
            SecureAddTextBox.UnderlinedStyle = false;
            // 
            // SecureAddFormName
            // 
            SecureAddFormName.AutoSize = true;
            SecureAddFormName.Location = new Point(59, 42);
            SecureAddFormName.Name = "SecureAddFormName";
            SecureAddFormName.Size = new Size(52, 21);
            SecureAddFormName.TabIndex = 1;
            SecureAddFormName.Text = "Name";
            // 
            // SecureNameBox
            // 
            SecureNameBox.BackColor = SystemColors.Window;
            SecureNameBox.BorderColor = Color.MediumSlateBlue;
            SecureNameBox.BorderFocusColor = Color.HotPink;
            SecureNameBox.BorderRadius = 0;
            SecureNameBox.BorderSize = 2;
            SecureNameBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecureNameBox.ForeColor = Color.DimGray;
            SecureNameBox.Location = new Point(58, 74);
            SecureNameBox.Multiline = false;
            SecureNameBox.Name = "SecureNameBox";
            SecureNameBox.Padding = new Padding(7);
            SecureNameBox.PasswordChar = false;
            SecureNameBox.PlaceholderColor = Color.DarkGray;
            SecureNameBox.PlaceholderText = "";
            SecureNameBox.Size = new Size(250, 32);
            SecureNameBox.TabIndex = 0;
            SecureNameBox.Texts = "";
            SecureNameBox.UnderlinedStyle = false;
            // 
            // SecureNotepanel1
            // 
            SecureNotepanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SecureNotepanel1.AutoScroll = true;
            SecureNotepanel1.BackColor = Color.FromArgb(238, 246, 247);
            SecureNotepanel1.Controls.Add(panel1);
            SecureNotepanel1.Controls.Add(panel5);
            SecureNotepanel1.Location = new Point(2, 0);
            SecureNotepanel1.Name = "SecureNotepanel1";
            SecureNotepanel1.Size = new Size(467, 537);
            SecureNotepanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(SecureNoteDeletebtn);
            panel1.Location = new Point(0, 500);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 37);
            panel1.TabIndex = 1;
            // 
            // SecureNoteDeletebtn
            // 
            SecureNoteDeletebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SecureNoteDeletebtn.BackColor = Color.MediumSlateBlue;
            SecureNoteDeletebtn.BackgroundColor = Color.MediumSlateBlue;
            SecureNoteDeletebtn.BorderColor = Color.PaleVioletRed;
            SecureNoteDeletebtn.BorderRadius = 0;
            SecureNoteDeletebtn.BorderSize = 0;
            SecureNoteDeletebtn.FlatAppearance.BorderSize = 0;
            SecureNoteDeletebtn.FlatStyle = FlatStyle.Flat;
            SecureNoteDeletebtn.ForeColor = Color.White;
            SecureNoteDeletebtn.Location = new Point(392, 5);
            SecureNoteDeletebtn.Name = "SecureNoteDeletebtn";
            SecureNoteDeletebtn.Size = new Size(68, 29);
            SecureNoteDeletebtn.TabIndex = 1;
            SecureNoteDeletebtn.Text = "Delete";
            SecureNoteDeletebtn.TextColor = Color.White;
            SecureNoteDeletebtn.UseVisualStyleBackColor = false;
            SecureNoteDeletebtn.Click += SecureNoteDeletebtn_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(listView);
            panel5.Location = new Point(0, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(467, 443);
            panel5.TabIndex = 0;
            // 
            // listView
            // 
            listView.BackColor = Color.FromArgb(238, 246, 247);
            listView.BorderStyle = BorderStyle.None;
            listView.Columns.AddRange(new ColumnHeader[] { NameColumnHeader1, NoteColumnHeader1 });
            listView.Dock = DockStyle.Fill;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(0, 0);
            listView.Name = "listView";
            listView.Size = new Size(467, 443);
            listView.TabIndex = 2;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged_1;
            // 
            // NameColumnHeader1
            // 
            NameColumnHeader1.Text = "Name";
            NameColumnHeader1.Width = 150;
            // 
            // NoteColumnHeader1
            // 
            NoteColumnHeader1.Text = "Secure Note";
            NoteColumnHeader1.Width = 150;
            // 
            // SecureNotepanel3
            // 
            SecureNotepanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SecureNotepanel3.BackColor = Color.FromArgb(238, 246, 247);
            SecureNotepanel3.Controls.Add(SecureNoteaddButton);
            SecureNotepanel3.Controls.Add(SecureNotesearchBox);
            SecureNotepanel3.Location = new Point(2, 0);
            SecureNotepanel3.Name = "SecureNotepanel3";
            SecureNotepanel3.Size = new Size(467, 50);
            SecureNotepanel3.TabIndex = 1;
            // 
            // SecureNoteaddButton
            // 
            SecureNoteaddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SecureNoteaddButton.BackColor = Color.MediumSlateBlue;
            SecureNoteaddButton.BackgroundColor = Color.MediumSlateBlue;
            SecureNoteaddButton.BorderColor = Color.PaleVioletRed;
            SecureNoteaddButton.BorderRadius = 10;
            SecureNoteaddButton.BorderSize = 0;
            SecureNoteaddButton.FlatAppearance.BorderSize = 0;
            SecureNoteaddButton.FlatStyle = FlatStyle.Flat;
            SecureNoteaddButton.ForeColor = Color.White;
            SecureNoteaddButton.Location = new Point(405, 7);
            SecureNoteaddButton.Name = "SecureNoteaddButton";
            SecureNoteaddButton.Size = new Size(55, 32);
            SecureNoteaddButton.TabIndex = 2;
            SecureNoteaddButton.Text = "ADD";
            SecureNoteaddButton.TextColor = Color.White;
            SecureNoteaddButton.UseVisualStyleBackColor = false;
            SecureNoteaddButton.Click += SecureNoteaddButton_Click;
            // 
            // SecureNotesearchBox
            // 
            SecureNotesearchBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SecureNotesearchBox.AutoScroll = true;
            SecureNotesearchBox.BackColor = SystemColors.Window;
            SecureNotesearchBox.BorderColor = Color.MediumSlateBlue;
            SecureNotesearchBox.BorderFocusColor = Color.HotPink;
            SecureNotesearchBox.BorderRadius = 0;
            SecureNotesearchBox.BorderSize = 2;
            SecureNotesearchBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecureNotesearchBox.ForeColor = Color.DimGray;
            SecureNotesearchBox.Location = new Point(3, 5);
            SecureNotesearchBox.Margin = new Padding(3, 3, 20, 3);
            SecureNotesearchBox.Multiline = false;
            SecureNotesearchBox.Name = "SecureNotesearchBox";
            SecureNotesearchBox.Padding = new Padding(7);
            SecureNotesearchBox.PasswordChar = false;
            SecureNotesearchBox.PlaceholderColor = Color.DarkGray;
            SecureNotesearchBox.PlaceholderText = "";
            SecureNotesearchBox.Size = new Size(380, 32);
            SecureNotesearchBox.TabIndex = 1;
            SecureNotesearchBox.Texts = "";
            SecureNotesearchBox.UnderlinedStyle = false;
            // 
            // SecureNoteForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 536);
            Controls.Add(SecureNoteAddForm);
            Controls.Add(SecureNotepanel3);
            Controls.Add(SecureNotepanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SecureNoteForm";
            Text = "SecureNoteForm";
            Load += SecureNoteForm_Load;
            SecureNoteDetailsPanel.ResumeLayout(false);
            SecureNoteDetailsPanel.PerformLayout();
            SecureNoteAddForm.ResumeLayout(false);
            SecureNoteAddForm.PerformLayout();
            SecureNotepanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            SecureNotepanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public Panel SecureNoteDetailsPanel;
        public Panel SecureNotepanel1;
        private Panel SecureNotepanel3;
        public CustomControls.CustomTextBox SecureNotesearchBox;
        public CustomControls.CustomButton SecureNoteaddButton;
        private Label SecureNotedetails;
        private Label SecureNoteName;
        public Panel SecureNoteAddForm;
        public CustomControls.CustomTextBox SecureNameBox;
        public CustomControls.CustomTextBox SecureAddTextBox;
        public Label SecureAddNote;
        public CustomControls.CustomButton SecureAddFormDonebtn;
        public Label SecureAddFormName;
        public ListView listView;
        public ColumnHeader NameColumnHeader1;
        public ColumnHeader NoteColumnHeader1;
        private Panel panel5;
        private CustomControls.CustomButton SecureNoteDeletebtn;
        private Panel panel1;
        public CustomControls.CustomTextBox SecureDetailNameBox;
        public CustomControls.CustomTextBox SecureNoteDetailText;
    }
}