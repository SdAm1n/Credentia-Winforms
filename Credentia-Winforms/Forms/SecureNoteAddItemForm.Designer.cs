namespace Credentia_Winforms.Forms
{
    partial class SecureNoteAddItemForm
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
            SecureNoteSubmitbtn = new CustomControls.CustomButton();
            SecureNoteNoteName = new Label();
            SecureNoteTextBox1 = new CustomControls.CustomTextBox();
            SecureNoteName = new Label();
            nameTextBox1 = new CustomControls.CustomTextBox();
            SeureNoteAddItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SeureNoteAddItemPanel
            // 
            SeureNoteAddItemPanel.Controls.Add(SecureNoteSubmitbtn);
            SeureNoteAddItemPanel.Controls.Add(SecureNoteNoteName);
            SeureNoteAddItemPanel.Controls.Add(SecureNoteTextBox1);
            SeureNoteAddItemPanel.Controls.Add(SecureNoteName);
            SeureNoteAddItemPanel.Controls.Add(nameTextBox1);
            SeureNoteAddItemPanel.Location = new Point(1, 2);
            SeureNoteAddItemPanel.Name = "SeureNoteAddItemPanel";
            SeureNoteAddItemPanel.Size = new Size(800, 450);
            SeureNoteAddItemPanel.TabIndex = 1;
            SeureNoteAddItemPanel.Paint += SeureNoteAddItemPanel_Paint;
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
            SecureNoteSubmitbtn.Click += SecureNoteSubmitbtn_Click;
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
            // SecureNoteTextBox1
            // 
            SecureNoteTextBox1.BackColor = SystemColors.Window;
            SecureNoteTextBox1.BorderColor = Color.MediumSlateBlue;
            SecureNoteTextBox1.BorderFocusColor = Color.HotPink;
            SecureNoteTextBox1.BorderRadius = 10;
            SecureNoteTextBox1.BorderSize = 2;
            SecureNoteTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecureNoteTextBox1.ForeColor = Color.DimGray;
            SecureNoteTextBox1.Location = new Point(188, 119);
            SecureNoteTextBox1.Multiline = true;
            SecureNoteTextBox1.Name = "SecureNoteTextBox1";
            SecureNoteTextBox1.Padding = new Padding(7);
            SecureNoteTextBox1.PasswordChar = false;
            SecureNoteTextBox1.PlaceholderColor = Color.DarkGray;
            SecureNoteTextBox1.PlaceholderText = "";
            SecureNoteTextBox1.Size = new Size(477, 223);
            SecureNoteTextBox1.TabIndex = 2;
            SecureNoteTextBox1.Texts = "";
            SecureNoteTextBox1.UnderlinedStyle = false;
            SecureNoteTextBox1._TextChanged += SecureNoteTextBox1__TextChanged;
            // 
            // SecureNoteName
            // 
            SecureNoteName.AutoSize = true;
            SecureNoteName.Location = new Point(188, 7);
            SecureNoteName.Name = "SecureNoteName";
            SecureNoteName.Size = new Size(39, 15);
            SecureNoteName.TabIndex = 1;
            SecureNoteName.Text = "Name";
            // 
            // nameTextBox1
            // 
            nameTextBox1.BackColor = SystemColors.Window;
            nameTextBox1.BorderColor = Color.MediumSlateBlue;
            nameTextBox1.BorderFocusColor = Color.HotPink;
            nameTextBox1.BorderRadius = 10;
            nameTextBox1.BorderSize = 2;
            nameTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox1.ForeColor = Color.DimGray;
            nameTextBox1.Location = new Point(188, 34);
            nameTextBox1.Multiline = false;
            nameTextBox1.Name = "nameTextBox1";
            nameTextBox1.Padding = new Padding(7);
            nameTextBox1.PasswordChar = false;
            nameTextBox1.PlaceholderColor = Color.DarkGray;
            nameTextBox1.PlaceholderText = "";
            nameTextBox1.Size = new Size(250, 32);
            nameTextBox1.TabIndex = 0;
            nameTextBox1.Texts = "";
            nameTextBox1.UnderlinedStyle = false;
            nameTextBox1._TextChanged += nameTextBox1__TextChanged;
            // 
            // SecureNoteAddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SeureNoteAddItemPanel);
            Name = "SecureNoteAddItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecureNoteAddItemForm";
            SeureNoteAddItemPanel.ResumeLayout(false);
            SeureNoteAddItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SeureNoteAddItemPanel;
        public CustomControls.CustomButton SecureNoteSubmitbtn;
        public Label SecureNoteNoteName;
        public CustomControls.CustomTextBox SecureNoteTextBox1;
        public Label SecureNoteName;
        public CustomControls.CustomTextBox nameTextBox1;
    }
}