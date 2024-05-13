namespace Credentia_Winforms
{
    partial class PasswordGeneratorForm
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
            textPassword = new CustomControls.CustomTextBox();
            PGGenerateBtn = new CustomControls.CustomButton();
            PGCopybtn = new CustomControls.CustomButton();
            panel3 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            length = new Label();
            numericUpDownlength = new NumericUpDown();
            chkIncludeNumbers = new CheckBox();
            chkIncludeUppercase = new CheckBox();
            chkIncludeLowercase = new CheckBox();
            chkIncludeSymbols = new CheckBox();
            OptionPanel = new Panel();
            panel4 = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownlength).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(217, 217, 217);
            textPassword.BorderColor = Color.Transparent;
            textPassword.BorderFocusColor = Color.HotPink;
            textPassword.BorderRadius = 16;
            textPassword.BorderSize = 2;
            textPassword.Enabled = false;
            textPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.ForeColor = Color.DimGray;
            textPassword.Location = new Point(39, 12);
            textPassword.Multiline = false;
            textPassword.Name = "textPassword";
            textPassword.Padding = new Padding(7);
            textPassword.PasswordChar = false;
            textPassword.PlaceholderColor = Color.DarkGray;
            textPassword.PlaceholderText = "";
            textPassword.Size = new Size(365, 32);
            textPassword.TabIndex = 0;
            textPassword.Texts = "";
            textPassword.UnderlinedStyle = false;
            // 
            // PGGenerateBtn
            // 
            PGGenerateBtn.BackColor = Color.Transparent;
            PGGenerateBtn.BackgroundColor = Color.Transparent;
            PGGenerateBtn.BorderColor = Color.FromArgb(252, 92, 52);
            PGGenerateBtn.BorderRadius = 16;
            PGGenerateBtn.BorderSize = 2;
            PGGenerateBtn.FlatAppearance.BorderSize = 0;
            PGGenerateBtn.FlatStyle = FlatStyle.Flat;
            PGGenerateBtn.ForeColor = Color.Black;
            PGGenerateBtn.Location = new Point(253, 379);
            PGGenerateBtn.Name = "PGGenerateBtn";
            PGGenerateBtn.Size = new Size(81, 32);
            PGGenerateBtn.TabIndex = 8;
            PGGenerateBtn.Text = "Generate";
            PGGenerateBtn.TextColor = Color.Black;
            PGGenerateBtn.UseVisualStyleBackColor = false;
            PGGenerateBtn.Click += PGGenerateBtn_Click;
            // 
            // PGCopybtn
            // 
            PGCopybtn.BackColor = Color.Transparent;
            PGCopybtn.BackgroundColor = Color.Transparent;
            PGCopybtn.BorderColor = Color.FromArgb(252, 92, 52);
            PGCopybtn.BorderRadius = 16;
            PGCopybtn.BorderSize = 2;
            PGCopybtn.FlatAppearance.BorderSize = 0;
            PGCopybtn.FlatStyle = FlatStyle.Flat;
            PGCopybtn.ForeColor = Color.Black;
            PGCopybtn.Location = new Point(454, 12);
            PGCopybtn.Name = "PGCopybtn";
            PGCopybtn.Size = new Size(81, 32);
            PGCopybtn.TabIndex = 8;
            PGCopybtn.Text = "Copy";
            PGCopybtn.TextColor = Color.Black;
            PGCopybtn.UseVisualStyleBackColor = false;
            PGCopybtn.Click += PGCopybtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textPassword);
            panel3.Controls.Add(PGCopybtn);
            panel3.Location = new Point(110, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(567, 57);
            panel3.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 217, 217);
            panel2.Controls.Add(PGGenerateBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(length);
            panel2.Controls.Add(numericUpDownlength);
            panel2.Controls.Add(chkIncludeNumbers);
            panel2.Controls.Add(chkIncludeUppercase);
            panel2.Controls.Add(chkIncludeLowercase);
            panel2.Controls.Add(chkIncludeSymbols);
            panel2.Location = new Point(113, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 457);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 53);
            label2.Name = "label2";
            label2.Size = new Size(179, 21);
            label2.TabIndex = 7;
            label2.Text = "Minimum length           8";
            // 
            // length
            // 
            length.AutoSize = true;
            length.Location = new Point(34, 15);
            length.Name = "length";
            length.Size = new Size(58, 21);
            length.TabIndex = 6;
            length.Text = "Length";
            // 
            // numericUpDownlength
            // 
            numericUpDownlength.Location = new Point(98, 11);
            numericUpDownlength.Name = "numericUpDownlength";
            numericUpDownlength.Size = new Size(60, 29);
            numericUpDownlength.TabIndex = 5;
            numericUpDownlength.Value = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDownlength.ValueChanged += numericUpDownlength_ValueChanged;
            // 
            // chkIncludeNumbers
            // 
            chkIncludeNumbers.AutoSize = true;
            chkIncludeNumbers.Location = new Point(36, 146);
            chkIncludeNumbers.Name = "chkIncludeNumbers";
            chkIncludeNumbers.Size = new Size(53, 25);
            chkIncludeNumbers.TabIndex = 4;
            chkIncludeNumbers.Text = "0-9";
            chkIncludeNumbers.UseVisualStyleBackColor = true;
            // 
            // chkIncludeUppercase
            // 
            chkIncludeUppercase.AutoSize = true;
            chkIncludeUppercase.Location = new Point(36, 77);
            chkIncludeUppercase.Name = "chkIncludeUppercase";
            chkIncludeUppercase.Size = new Size(54, 25);
            chkIncludeUppercase.TabIndex = 3;
            chkIncludeUppercase.Text = "A-Z";
            chkIncludeUppercase.UseVisualStyleBackColor = true;
            // 
            // chkIncludeLowercase
            // 
            chkIncludeLowercase.AutoSize = true;
            chkIncludeLowercase.Location = new Point(36, 113);
            chkIncludeLowercase.Name = "chkIncludeLowercase";
            chkIncludeLowercase.Size = new Size(50, 25);
            chkIncludeLowercase.TabIndex = 2;
            chkIncludeLowercase.Text = "a-z";
            chkIncludeLowercase.UseVisualStyleBackColor = true;
            // 
            // chkIncludeSymbols
            // 
            chkIncludeSymbols.AutoSize = true;
            chkIncludeSymbols.Location = new Point(36, 182);
            chkIncludeSymbols.Name = "chkIncludeSymbols";
            chkIncludeSymbols.Size = new Size(98, 25);
            chkIncludeSymbols.TabIndex = 0;
            chkIncludeSymbols.Text = "!@#$%^&*";
            chkIncludeSymbols.UseVisualStyleBackColor = true;
            // 
            // OptionPanel
            // 
            OptionPanel.BackColor = Color.FromArgb(238, 246, 247);
            OptionPanel.Location = new Point(113, 96);
            OptionPanel.Name = "OptionPanel";
            OptionPanel.Size = new Size(566, 457);
            OptionPanel.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(OptionPanel);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(796, 600);
            panel4.TabIndex = 4;
            // 
            // PasswordGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 246, 247);
            ClientSize = new Size(796, 600);
            Controls.Add(panel4);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "PasswordGeneratorForm";
            Text = "PasswordGeneratorForm";
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownlength).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomTextBox textPassword;
        private Panel panel1;
        private RadioButton radioButton1;
        private Label label1;
        private Panel panel6;
        public CustomControls.CustomButton PGGenerateBtn;
        public CustomControls.CustomButton PGCopybtn;
        private Panel panel3;
        private Panel panel2;
        private Label label2;
        private Label length;
        private NumericUpDown numericUpDownlength;
        private CheckBox chkIncludeNumbers;
        private CheckBox chkIncludeUppercase;
        private CheckBox chkIncludeLowercase;
        private CheckBox chkIncludeSymbols;
        private Panel OptionPanel;
        private Panel panel4;
    }
}