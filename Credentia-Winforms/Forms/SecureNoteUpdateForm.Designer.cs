namespace Credentia_Winforms.Forms
{
    partial class SecureNoteUpdateForm
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
            SeureNoteUpdateItemPanel = new Panel();
            SecureNoteUpdateSubmitbtn = new CustomControls.CustomButton();
            SecureNoteUpdateNoteName = new Label();
            SecureNoteUpdateTextBox = new CustomControls.CustomTextBox();
            SecureNoteUpdateName = new Label();
            SecureUpdateNoteNameBox = new CustomControls.CustomTextBox();
            SeureNoteUpdateItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SeureNoteUpdateItemPanel
            // 
            SeureNoteUpdateItemPanel.Controls.Add(SecureNoteUpdateSubmitbtn);
            SeureNoteUpdateItemPanel.Controls.Add(SecureNoteUpdateNoteName);
            SeureNoteUpdateItemPanel.Controls.Add(SecureNoteUpdateTextBox);
            SeureNoteUpdateItemPanel.Controls.Add(SecureNoteUpdateName);
            SeureNoteUpdateItemPanel.Controls.Add(SecureUpdateNoteNameBox);
            SeureNoteUpdateItemPanel.Location = new Point(8, 8);
            SeureNoteUpdateItemPanel.Name = "SeureNoteUpdateItemPanel";
            SeureNoteUpdateItemPanel.Size = new Size(800, 450);
            SeureNoteUpdateItemPanel.TabIndex = 2;
            SeureNoteUpdateItemPanel.Paint += SeureNoteUpdateItemPanel_Paint;
            // 
            // SecureNoteUpdateSubmitbtn
            // 
            SecureNoteUpdateSubmitbtn.BackColor = Color.MediumSlateBlue;
            SecureNoteUpdateSubmitbtn.BackgroundColor = Color.MediumSlateBlue;
            SecureNoteUpdateSubmitbtn.BorderColor = Color.PaleVioletRed;
            SecureNoteUpdateSubmitbtn.BorderRadius = 10;
            SecureNoteUpdateSubmitbtn.BorderSize = 0;
            SecureNoteUpdateSubmitbtn.FlatAppearance.BorderSize = 0;
            SecureNoteUpdateSubmitbtn.FlatStyle = FlatStyle.Flat;
            SecureNoteUpdateSubmitbtn.ForeColor = Color.White;
            SecureNoteUpdateSubmitbtn.Location = new Point(188, 374);
            SecureNoteUpdateSubmitbtn.Name = "SecureNoteUpdateSubmitbtn";
            SecureNoteUpdateSubmitbtn.Size = new Size(150, 40);
            SecureNoteUpdateSubmitbtn.TabIndex = 8;
            SecureNoteUpdateSubmitbtn.Text = "Submit";
            SecureNoteUpdateSubmitbtn.TextColor = Color.White;
            SecureNoteUpdateSubmitbtn.UseVisualStyleBackColor = false;
            SecureNoteUpdateSubmitbtn.Click += SecureNoteUpdateSubmitbtn_Click;
            // 
            // SecureNoteUpdateNoteName
            // 
            SecureNoteUpdateNoteName.AutoSize = true;
            SecureNoteUpdateNoteName.Location = new Point(188, 87);
            SecureNoteUpdateNoteName.Name = "SecureNoteUpdateNoteName";
            SecureNoteUpdateNoteName.Size = new Size(71, 15);
            SecureNoteUpdateNoteName.TabIndex = 3;
            SecureNoteUpdateNoteName.Text = "Secure Note";
            // 
            // SecureNoteUpdateTextBox
            // 
            SecureNoteUpdateTextBox.BackColor = SystemColors.Window;
            SecureNoteUpdateTextBox.BorderColor = Color.MediumSlateBlue;
            SecureNoteUpdateTextBox.BorderFocusColor = Color.HotPink;
            SecureNoteUpdateTextBox.BorderRadius = 10;
            SecureNoteUpdateTextBox.BorderSize = 2;
            SecureNoteUpdateTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecureNoteUpdateTextBox.ForeColor = Color.DimGray;
            SecureNoteUpdateTextBox.Location = new Point(188, 119);
            SecureNoteUpdateTextBox.Multiline = true;
            SecureNoteUpdateTextBox.Name = "SecureNoteUpdateTextBox";
            SecureNoteUpdateTextBox.Padding = new Padding(7);
            SecureNoteUpdateTextBox.PasswordChar = false;
            SecureNoteUpdateTextBox.PlaceholderColor = Color.DarkGray;
            SecureNoteUpdateTextBox.PlaceholderText = "";
            SecureNoteUpdateTextBox.Size = new Size(477, 223);
            SecureNoteUpdateTextBox.TabIndex = 2;
            SecureNoteUpdateTextBox.Texts = "";
            SecureNoteUpdateTextBox.UnderlinedStyle = false;
            // 
            // SecureNoteUpdateName
            // 
            SecureNoteUpdateName.AutoSize = true;
            SecureNoteUpdateName.Location = new Point(188, 7);
            SecureNoteUpdateName.Name = "SecureNoteUpdateName";
            SecureNoteUpdateName.Size = new Size(39, 15);
            SecureNoteUpdateName.TabIndex = 1;
            SecureNoteUpdateName.Text = "Name";
            // 
            // SecureUpdateNoteNameBox
            // 
            SecureUpdateNoteNameBox.BackColor = SystemColors.Window;
            SecureUpdateNoteNameBox.BorderColor = Color.MediumSlateBlue;
            SecureUpdateNoteNameBox.BorderFocusColor = Color.HotPink;
            SecureUpdateNoteNameBox.BorderRadius = 10;
            SecureUpdateNoteNameBox.BorderSize = 2;
            SecureUpdateNoteNameBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecureUpdateNoteNameBox.ForeColor = Color.DimGray;
            SecureUpdateNoteNameBox.Location = new Point(188, 34);
            SecureUpdateNoteNameBox.Multiline = false;
            SecureUpdateNoteNameBox.Name = "SecureUpdateNoteNameBox";
            SecureUpdateNoteNameBox.Padding = new Padding(7);
            SecureUpdateNoteNameBox.PasswordChar = false;
            SecureUpdateNoteNameBox.PlaceholderColor = Color.DarkGray;
            SecureUpdateNoteNameBox.PlaceholderText = "";
            SecureUpdateNoteNameBox.Size = new Size(250, 32);
            SecureUpdateNoteNameBox.TabIndex = 0;
            SecureUpdateNoteNameBox.Texts = "";
            SecureUpdateNoteNameBox.UnderlinedStyle = false;
            // 
            // SecureNoteUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SeureNoteUpdateItemPanel);
            Name = "SecureNoteUpdateForm";
            Text = "SecureNoteUpdateForm";
            SeureNoteUpdateItemPanel.ResumeLayout(false);
            SeureNoteUpdateItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SeureNoteUpdateItemPanel;
        public CustomControls.CustomButton SecureNoteUpdateSubmitbtn;
        public Label SecureNoteUpdateNoteName;
        public CustomControls.CustomTextBox SecureNoteUpdateTextBox;
        public Label SecureNoteUpdateName;
        public CustomControls.CustomTextBox SecureUpdateNoteNameBox;
    }
}