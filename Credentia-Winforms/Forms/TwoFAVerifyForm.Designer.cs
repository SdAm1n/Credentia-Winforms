namespace Credentia_Winforms.Forms
{
    partial class TwoFAVerifyForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            DockPanel1 = new Panel();
            pictureBox1 = new PictureBox();
            DockPanel2 = new Panel();
            VerifyBtn = new CustomControls.CustomButton();
            CodeTextBox = new CustomControls.CustomTextBox();
            CodeLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            DockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            DockPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(238, 246, 247);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(DockPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1029, 630);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(DockPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 624);
            panel1.TabIndex = 0;
            // 
            // DockPanel1
            // 
            DockPanel1.BackColor = Color.FromArgb(248, 251, 252);
            DockPanel1.Controls.Add(pictureBox1);
            DockPanel1.Dock = DockStyle.Fill;
            DockPanel1.Location = new Point(0, 0);
            DockPanel1.Name = "DockPanel1";
            DockPanel1.Size = new Size(405, 624);
            DockPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo_no_background;
            pictureBox1.Location = new Point(52, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DockPanel2
            // 
            DockPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DockPanel2.Controls.Add(VerifyBtn);
            DockPanel2.Controls.Add(CodeTextBox);
            DockPanel2.Controls.Add(CodeLabel);
            DockPanel2.Location = new Point(414, 72);
            DockPanel2.Name = "DockPanel2";
            DockPanel2.Size = new Size(612, 485);
            DockPanel2.TabIndex = 1;
            // 
            // VerifyBtn
            // 
            VerifyBtn.BackColor = Color.FromArgb(238, 246, 247);
            VerifyBtn.BackgroundColor = Color.FromArgb(238, 246, 247);
            VerifyBtn.BorderColor = Color.FromArgb(251, 79, 54);
            VerifyBtn.BorderRadius = 20;
            VerifyBtn.BorderSize = 2;
            VerifyBtn.FlatAppearance.BorderSize = 0;
            VerifyBtn.FlatStyle = FlatStyle.Flat;
            VerifyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VerifyBtn.ForeColor = Color.FromArgb(251, 79, 54);
            VerifyBtn.Location = new Point(248, 280);
            VerifyBtn.Name = "VerifyBtn";
            VerifyBtn.Size = new Size(141, 40);
            VerifyBtn.TabIndex = 5;
            VerifyBtn.Text = "Verify";
            VerifyBtn.TextColor = Color.FromArgb(251, 79, 54);
            VerifyBtn.UseVisualStyleBackColor = false;
            VerifyBtn.Click += VerifyBtn_Click;
            // 
            // CodeTextBox
            // 
            CodeTextBox.BackColor = Color.FromArgb(217, 217, 217);
            CodeTextBox.BorderColor = Color.FromArgb(217, 217, 217);
            CodeTextBox.BorderFocusColor = Color.FromArgb(217, 217, 217);
            CodeTextBox.BorderRadius = 10;
            CodeTextBox.BorderSize = 2;
            CodeTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CodeTextBox.ForeColor = Color.DimGray;
            CodeTextBox.Location = new Point(223, 191);
            CodeTextBox.Multiline = false;
            CodeTextBox.Name = "CodeTextBox";
            CodeTextBox.Padding = new Padding(7);
            CodeTextBox.PasswordChar = false;
            CodeTextBox.PlaceholderColor = Color.DarkGray;
            CodeTextBox.PlaceholderText = "";
            CodeTextBox.Size = new Size(250, 32);
            CodeTextBox.TabIndex = 4;
            CodeTextBox.Texts = "";
            CodeTextBox.UnderlinedStyle = false;
            // 
            // CodeLabel
            // 
            CodeLabel.AutoSize = true;
            CodeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CodeLabel.Location = new Point(133, 198);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(46, 21);
            CodeLabel.TabIndex = 0;
            CodeLabel.Text = "Code";
            // 
            // TwoFAVerifyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tableLayoutPanel1);
            Name = "TwoFAVerifyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TwoFAVerifyForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            DockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            DockPanel2.ResumeLayout(false);
            DockPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel DockPanel1;
        private PictureBox pictureBox1;
        private Panel DockPanel2;
        private Label CodeLabel;
        private CustomControls.CustomButton VerifyBtn;
        private CustomControls.CustomTextBox CodeTextBox;
    }
}