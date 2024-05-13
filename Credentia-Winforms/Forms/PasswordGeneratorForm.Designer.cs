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
            components = new System.ComponentModel.Container();
            textPassword = new CustomControls.CustomTextBox();
            OptionPanel = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            length = new Label();
            numericUpDownlength = new NumericUpDown();
            chkIncludeNumbers = new CheckBox();
            chkIncludeUppercase = new CheckBox();
            chkIncludeLowercase = new CheckBox();
            chkIncludeSymbols = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            CancelPanel = new Panel();
            PGGenerateBtn = new CustomControls.CustomButton();
            PGCopybtn = new CustomControls.CustomButton();
            OptionPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownlength).BeginInit();
            CancelPanel.SuspendLayout();
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
            textPassword.Location = new Point(159, 30);
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
            // OptionPanel
            // 
            OptionPanel.BackColor = Color.FromArgb(238, 246, 247);
            OptionPanel.Controls.Add(label3);
            OptionPanel.Controls.Add(panel4);
            OptionPanel.Location = new Point(159, 92);
            OptionPanel.MaximumSize = new Size(452, 400);
            OptionPanel.MinimumSize = new Size(452, 47);
            OptionPanel.Name = "OptionPanel";
            OptionPanel.Size = new Size(452, 400);
            OptionPanel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 14);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 7;
            label3.Text = "Options";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(238, 246, 247);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(0, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(452, 353);
            panel4.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 217, 217);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(length);
            panel2.Controls.Add(numericUpDownlength);
            panel2.Controls.Add(chkIncludeNumbers);
            panel2.Controls.Add(chkIncludeUppercase);
            panel2.Controls.Add(chkIncludeLowercase);
            panel2.Controls.Add(chkIncludeSymbols);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 350);
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
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // CancelPanel
            // 
            CancelPanel.Controls.Add(PGGenerateBtn);
            CancelPanel.Location = new Point(159, 525);
            CancelPanel.Name = "CancelPanel";
            CancelPanel.Size = new Size(452, 38);
            CancelPanel.TabIndex = 3;
            CancelPanel.Paint += CancelPanel_Paint;
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
            PGGenerateBtn.Location = new Point(356, 3);
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
            PGCopybtn.Location = new Point(530, 30);
            PGCopybtn.Name = "PGCopybtn";
            PGCopybtn.Size = new Size(81, 32);
            PGCopybtn.TabIndex = 8;
            PGCopybtn.Text = "Copy";
            PGCopybtn.TextColor = Color.Black;
            PGCopybtn.UseVisualStyleBackColor = false;
            PGCopybtn.Click += PGCopybtn_Click;
            // 
            // PasswordGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 246, 247);
            ClientSize = new Size(796, 600);
            Controls.Add(PGCopybtn);
            Controls.Add(CancelPanel);
            Controls.Add(OptionPanel);
            Controls.Add(textPassword);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "PasswordGeneratorForm";
            Text = "PasswordGeneratorForm";
            OptionPanel.ResumeLayout(false);
            OptionPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownlength).EndInit();
            CancelPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomTextBox textPassword;
        private Panel panel1;
        private RadioButton radioButton1;
        private Label label1;
        private Panel OptionPanel;
        private Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private Panel panel2;
        private Panel panel6;
        private Panel CancelPanel;
        private CheckBox chkIncludeUppercase;
        private CheckBox chkIncludeLowercase;
        private CheckBox chkIncludeSymbols;
        private CheckBox chkIncludeNumbers;
        public CustomControls.CustomButton PGGenerateBtn;
        private NumericUpDown numericUpDownlength;
        private Label length;
        public CustomControls.CustomButton PGCopybtn;
        private Label label2;
        private Label label3;
    }
}