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
            panel1 = new Panel();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            UsernameColumn = new DataGridViewTextBoxColumn();
            PasswordColumn = new DataGridViewTextBoxColumn();
            URLColumn = new DataGridViewTextBoxColumn();
            updateColumn = new DataGridViewButtonColumn();
            deleteColumn = new DataGridViewButtonColumn();
            label1 = new Label();
            panel3 = new Panel();
            addButton = new CustomControls.CustomButton();
            searchBox = new CustomControls.CustomTextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(238, 246, 247);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 497);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(0, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(567, 450);
            panel4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(238, 246, 247);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameColumn, UsernameColumn, PasswordColumn, URLColumn, updateColumn, deleteColumn });
            dataGridView1.Location = new Point(11, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(549, 412);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "nameColumn";
            // 
            // UsernameColumn
            // 
            UsernameColumn.HeaderText = "Username";
            UsernameColumn.Name = "UsernameColumn";
            // 
            // PasswordColumn
            // 
            PasswordColumn.HeaderText = "Password";
            PasswordColumn.Name = "PasswordColumn";
            // 
            // URLColumn
            // 
            URLColumn.HeaderText = "URL";
            URLColumn.Name = "URLColumn";
            // 
            // updateColumn
            // 
            updateColumn.HeaderText = "Update";
            updateColumn.Name = "updateColumn";
            updateColumn.Text = "Update";
            updateColumn.UseColumnTextForButtonValue = true;
            // 
            // deleteColumn
            // 
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Name = "deleteColumn";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 5);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 0;
            label1.Text = "All Passwords";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(addButton);
            panel3.Controls.Add(searchBox);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(567, 46);
            panel3.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.BackColor = Color.MediumSlateBlue;
            addButton.BackgroundColor = Color.MediumSlateBlue;
            addButton.BorderColor = Color.PaleVioletRed;
            addButton.BorderRadius = 10;
            addButton.BorderSize = 0;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(505, 6);
            addButton.Name = "addButton";
            addButton.Size = new Size(55, 32);
            addButton.TabIndex = 1;
            addButton.Text = "ADD";
            addButton.TextColor = Color.White;
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchBox.AutoScroll = true;
            searchBox.BackColor = SystemColors.Window;
            searchBox.BorderColor = Color.MediumSlateBlue;
            searchBox.BorderFocusColor = Color.HotPink;
            searchBox.BorderRadius = 0;
            searchBox.BorderSize = 2;
            searchBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.ForeColor = Color.DimGray;
            searchBox.Location = new Point(11, 6);
            searchBox.Margin = new Padding(3, 3, 20, 3);
            searchBox.Multiline = false;
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(7);
            searchBox.PasswordChar = false;
            searchBox.PlaceholderColor = Color.DarkGray;
            searchBox.PlaceholderText = "";
            searchBox.Size = new Size(485, 32);
            searchBox.TabIndex = 0;
            searchBox.Texts = "";
            searchBox.UnderlinedStyle = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(234, 238, 238);
            panel2.Location = new Point(567, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 497);
            panel2.TabIndex = 1;
            // 
            // AllLoginsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 495);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AllLoginsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "All Logins";
            Load += AllLoginsForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        public CustomControls.CustomTextBox searchBox;
        public CustomControls.CustomButton addButton;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn UsernameColumn;
        private DataGridViewTextBoxColumn PasswordColumn;
        private DataGridViewTextBoxColumn URLColumn;
        private DataGridViewButtonColumn updateColumn;
        private DataGridViewButtonColumn deleteColumn;
    }
}