namespace ProbaDiplom
{
    partial class StaffWindow
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
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            spravkaToolStripMenuItem = new ToolStripMenuItem();
            exsitToolStripMenuItem = new ToolStripMenuItem();
            backToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            passwordButton = new TextBox();
            loginButton = new TextBox();
            phoneButton = new TextBox();
            surnameButton = new TextBox();
            nameButton = new TextBox();
            label1 = new Label();
            deleteButton = new Button();
            safeButton = new Button();
            updateButton = new Button();
            dgvDataUsers = new DataGridView();
            label7 = new Label();
            staffComboBox = new ComboBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataUsers).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, spravkaToolStripMenuItem, exsitToolStripMenuItem, backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(966, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            mainMenuToolStripMenuItem.Size = new Size(99, 20);
            mainMenuToolStripMenuItem.Text = "Главное меню";
            mainMenuToolStripMenuItem.Click += mainMenuToolStripMenuItem_Click;
            // 
            // spravkaToolStripMenuItem
            // 
            spravkaToolStripMenuItem.Name = "spravkaToolStripMenuItem";
            spravkaToolStripMenuItem.Size = new Size(65, 20);
            spravkaToolStripMenuItem.Text = "Справка";
            // 
            // exsitToolStripMenuItem
            // 
            exsitToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            exsitToolStripMenuItem.Name = "exsitToolStripMenuItem";
            exsitToolStripMenuItem.Size = new Size(54, 20);
            exsitToolStripMenuItem.Text = "Выход";
            exsitToolStripMenuItem.Click += exsitToolStripMenuItem_Click;
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(51, 20);
            backToolStripMenuItem.Text = "Назад";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(642, 285);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 43;
            label6.Text = "Пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(650, 242);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 42;
            label5.Text = "Логин";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(591, 195);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 41;
            label4.Text = "Номер телефона";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(633, 156);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 40;
            label3.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(661, 112);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 39;
            label2.Text = "Имя";
            // 
            // passwordButton
            // 
            passwordButton.Enabled = false;
            passwordButton.Location = new Point(713, 272);
            passwordButton.Multiline = true;
            passwordButton.Name = "passwordButton";
            passwordButton.Size = new Size(201, 28);
            passwordButton.TabIndex = 38;
            // 
            // loginButton
            // 
            loginButton.Enabled = false;
            loginButton.Location = new Point(713, 229);
            loginButton.Multiline = true;
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(201, 28);
            loginButton.TabIndex = 37;
            // 
            // phoneButton
            // 
            phoneButton.Enabled = false;
            phoneButton.Location = new Point(713, 182);
            phoneButton.Multiline = true;
            phoneButton.Name = "phoneButton";
            phoneButton.Size = new Size(201, 28);
            phoneButton.TabIndex = 36;
            // 
            // surnameButton
            // 
            surnameButton.Enabled = false;
            surnameButton.Location = new Point(713, 143);
            surnameButton.Multiline = true;
            surnameButton.Name = "surnameButton";
            surnameButton.Size = new Size(201, 28);
            surnameButton.TabIndex = 35;
            // 
            // nameButton
            // 
            nameButton.Enabled = false;
            nameButton.Location = new Point(713, 99);
            nameButton.Multiline = true;
            nameButton.Name = "nameButton";
            nameButton.Size = new Size(201, 28);
            nameButton.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(235, 36);
            label1.Name = "label1";
            label1.Size = new Size(186, 31);
            label1.TabIndex = 33;
            label1.Text = "Пользователи";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.DarkSeaGreen;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.ForeColor = Color.Black;
            deleteButton.Location = new Point(408, 378);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(167, 36);
            deleteButton.TabIndex = 32;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // safeButton
            // 
            safeButton.BackColor = Color.DarkSeaGreen;
            safeButton.FlatStyle = FlatStyle.Popup;
            safeButton.ForeColor = Color.Black;
            safeButton.Location = new Point(235, 378);
            safeButton.Name = "safeButton";
            safeButton.Size = new Size(167, 36);
            safeButton.TabIndex = 31;
            safeButton.Text = "Сохранить";
            safeButton.UseVisualStyleBackColor = false;
            safeButton.Click += safeButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.DarkSeaGreen;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.ForeColor = Color.Black;
            updateButton.Location = new Point(62, 378);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(167, 36);
            updateButton.TabIndex = 30;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // dgvDataUsers
            // 
            dgvDataUsers.BackgroundColor = SystemColors.Control;
            dgvDataUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataUsers.Location = new Point(62, 82);
            dgvDataUsers.Name = "dgvDataUsers";
            dgvDataUsers.RowTemplate.Height = 25;
            dgvDataUsers.Size = new Size(513, 265);
            dgvDataUsers.TabIndex = 29;
            dgvDataUsers.CellClick += dgvDataUsers_CellClick;
            dgvDataUsers.CellContentClick += dgvDataUsers_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(625, 318);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 50;
            label7.Text = "Сотрудник";
            // 
            // staffComboBox
            // 
            staffComboBox.FormattingEnabled = true;
            staffComboBox.Location = new Point(713, 315);
            staffComboBox.Name = "staffComboBox";
            staffComboBox.Size = new Size(201, 23);
            staffComboBox.TabIndex = 49;
            staffComboBox.SelectedIndexChanged += staffComboBox_SelectedIndexChanged;
            // 
            // StaffWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 219, 173);
            ClientSize = new Size(966, 450);
            Controls.Add(label7);
            Controls.Add(staffComboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordButton);
            Controls.Add(loginButton);
            Controls.Add(phoneButton);
            Controls.Add(surnameButton);
            Controls.Add(nameButton);
            Controls.Add(label1);
            Controls.Add(deleteButton);
            Controls.Add(safeButton);
            Controls.Add(updateButton);
            Controls.Add(dgvDataUsers);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffWindow";
            Load += StaffWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem spravkaToolStripMenuItem;
        private ToolStripMenuItem exsitToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox passwordButton;
        private TextBox loginButton;
        private TextBox phoneButton;
        private TextBox surnameButton;
        private TextBox nameButton;
        private Label label1;
        private Button deleteButton;
        private Button safeButton;
        private Button updateButton;
        private DataGridView dgvDataUsers;
        private Label label7;
        private ComboBox staffComboBox;
    }
}