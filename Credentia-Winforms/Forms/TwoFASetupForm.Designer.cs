namespace Credentia_Winforms.Forms
{
    partial class TwoFASetupForm
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
            QrCodePictureBox = new PictureBox();
            CodeTextBox = new CustomControls.CustomTextBox();
            VerifyBtn = new CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)QrCodePictureBox).BeginInit();
            SuspendLayout();
            // 
            // QrCodePictureBox
            // 
            QrCodePictureBox.Location = new Point(209, 39);
            QrCodePictureBox.Name = "QrCodePictureBox";
            QrCodePictureBox.Size = new Size(367, 273);
            QrCodePictureBox.TabIndex = 0;
            QrCodePictureBox.TabStop = false;
            // 
            // CodeTextBox
            // 
            CodeTextBox.BackColor = Color.FromArgb(217, 217, 217);
            CodeTextBox.BorderColor = Color.FromArgb(217, 217, 217);
            CodeTextBox.BorderFocusColor = Color.HotPink;
            CodeTextBox.BorderRadius = 10;
            CodeTextBox.BorderSize = 2;
            CodeTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CodeTextBox.ForeColor = Color.DimGray;
            CodeTextBox.Location = new Point(209, 335);
            CodeTextBox.Multiline = false;
            CodeTextBox.Name = "CodeTextBox";
            CodeTextBox.Padding = new Padding(7);
            CodeTextBox.PasswordChar = false;
            CodeTextBox.PlaceholderColor = Color.DarkGray;
            CodeTextBox.PlaceholderText = "";
            CodeTextBox.Size = new Size(216, 32);
            CodeTextBox.TabIndex = 0;
            CodeTextBox.Texts = "";
            CodeTextBox.UnderlinedStyle = false;
            // 
            // VerifyBtn
            // 
            VerifyBtn.BackColor = Color.FromArgb(238, 246, 247);
            VerifyBtn.BackgroundColor = Color.FromArgb(238, 246, 247);
            VerifyBtn.BorderColor = Color.FromArgb(252, 92, 52);
            VerifyBtn.BorderRadius = 16;
            VerifyBtn.BorderSize = 2;
            VerifyBtn.FlatAppearance.BorderSize = 0;
            VerifyBtn.FlatStyle = FlatStyle.Flat;
            VerifyBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VerifyBtn.ForeColor = Color.Black;
            VerifyBtn.Location = new Point(495, 335);
            VerifyBtn.Name = "VerifyBtn";
            VerifyBtn.Size = new Size(81, 32);
            VerifyBtn.TabIndex = 2;
            VerifyBtn.Text = "Verify";
            VerifyBtn.TextColor = Color.Black;
            VerifyBtn.UseVisualStyleBackColor = false;
            VerifyBtn.Click += VerifyBtn_Click;
            // 
            // TwoFASetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VerifyBtn);
            Controls.Add(CodeTextBox);
            Controls.Add(QrCodePictureBox);
            Name = "TwoFASetupForm";
            Text = "TwoFASetupForm";
            ((System.ComponentModel.ISupportInitialize)QrCodePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox QrCodePictureBox;
        private CustomControls.CustomTextBox CodeTextBox;
        private CustomControls.CustomButton VerifyBtn;
    }
}