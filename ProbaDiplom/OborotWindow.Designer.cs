namespace ProbaDiplom
{
    partial class OborotWindow
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
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            spravkaToolStripMenuItem = new ToolStripMenuItem();
            exsitToolStripMenuItem = new ToolStripMenuItem();
            назадToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            saldButton = new Button();
            mainWindowLabel = new Label();
            categoryBox = new ComboBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(224, 99);
            dateTimePicker2.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(132, 23);
            dateTimePicker2.TabIndex = 53;
            dateTimePicker2.Value = new DateTime(2023, 5, 20, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(224, 131);
            dateTimePicker1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(132, 23);
            dateTimePicker1.TabIndex = 52;
            dateTimePicker1.Value = new DateTime(2023, 5, 22, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(188, 137);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 51;
            label10.Text = "по";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(196, 105);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 50;
            label9.Text = "с";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, spravkaToolStripMenuItem, exsitToolStripMenuItem, назадToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(408, 24);
            menuStrip1.TabIndex = 49;
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
            // назадToolStripMenuItem
            // 
            назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            назадToolStripMenuItem.Size = new Size(51, 20);
            назадToolStripMenuItem.Text = "Назад";
            назадToolStripMenuItem.Click += назадToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(15, 98);
            label1.Name = "label1";
            label1.Size = new Size(175, 24);
            label1.TabIndex = 48;
            label1.Text = "Выберите период";
            // 
            // saldButton
            // 
            saldButton.BackColor = Color.DarkSeaGreen;
            saldButton.FlatStyle = FlatStyle.Flat;
            saldButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            saldButton.ForeColor = Color.Black;
            saldButton.Location = new Point(54, 196);
            saldButton.Name = "saldButton";
            saldButton.Size = new Size(302, 43);
            saldButton.TabIndex = 47;
            saldButton.Text = "Сформировать";
            saldButton.UseVisualStyleBackColor = false;
            saldButton.Click += saldButton_Click;
            // 
            // mainWindowLabel
            // 
            mainWindowLabel.AutoSize = true;
            mainWindowLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            mainWindowLabel.Location = new Point(69, 62);
            mainWindowLabel.Name = "mainWindowLabel";
            mainWindowLabel.Size = new Size(287, 31);
            mainWindowLabel.TabIndex = 46;
            mainWindowLabel.Text = "Оборотная ведомость";
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Location = new Point(224, 160);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(132, 23);
            categoryBox.TabIndex = 54;
            categoryBox.Text = "Все";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 163);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 55;
            label2.Text = "Выберите товары";
            // 
            // OborotWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 219, 173);
            ClientSize = new Size(408, 282);
            Controls.Add(label2);
            Controls.Add(categoryBox);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(saldButton);
            Controls.Add(mainWindowLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OborotWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OborotWindow";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private Label label9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem spravkaToolStripMenuItem;
        private ToolStripMenuItem exsitToolStripMenuItem;
        private ToolStripMenuItem назадToolStripMenuItem;
        private Label label1;
        private Button saldButton;
        private Label mainWindowLabel;
        private ComboBox categoryBox;
        private Label label2;
    }
}