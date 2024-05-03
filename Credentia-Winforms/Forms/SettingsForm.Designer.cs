namespace Credentia_Winforms
{
    partial class SettingsForm
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
            label1 = new Label();
            ActiveUserDBNameLabel = new Label();
            ActiveUsernameLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 180);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "Settings Form";
            label1.Click += label1_Click;
            // 
            // ActiveUserDBNameLabel
            // 
            ActiveUserDBNameLabel.AutoSize = true;
            ActiveUserDBNameLabel.Location = new Point(404, 280);
            ActiveUserDBNameLabel.Name = "ActiveUserDBNameLabel";
            ActiveUserDBNameLabel.Size = new Size(112, 21);
            ActiveUserDBNameLabel.TabIndex = 1;
            ActiveUserDBNameLabel.Text = "Active User DB";
            // 
            // ActiveUsernameLabel
            // 
            ActiveUsernameLabel.AutoSize = true;
            ActiveUsernameLabel.Location = new Point(404, 237);
            ActiveUsernameLabel.Name = "ActiveUsernameLabel";
            ActiveUsernameLabel.Size = new Size(88, 21);
            ActiveUsernameLabel.TabIndex = 2;
            ActiveUsernameLabel.Text = "Active User";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(ActiveUsernameLabel);
            Controls.Add(ActiveUserDBNameLabel);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ActiveUserDBNameLabel;
        private Label ActiveUsernameLabel;
    }
}