﻿namespace ProbaDiplom
{
    partial class OrderWindow
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
            updateButton = new Button();
            safeButton = new Button();
            deleteButton = new Button();
            label1 = new Label();
            numberButton = new TextBox();
            KolvoButton = new TextBox();
            PriceButton = new TextBox();
            all_priceButton = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ProductcomboBox = new ComboBox();
            dateTimePicker = new DateTimePicker();
            dgvDataOrders = new DataGridView();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            SortedButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label11 = new Label();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            OrderButton = new Button();
            NumberTextBox = new TextBox();
            label12 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataOrders).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, spravkaToolStripMenuItem, exsitToolStripMenuItem, backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(999, 24);
            menuStrip1.TabIndex = 13;
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
            // updateButton
            // 
            updateButton.BackColor = Color.DarkSeaGreen;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.ForeColor = Color.Black;
            updateButton.Location = new Point(71, 428);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(167, 36);
            updateButton.TabIndex = 15;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // safeButton
            // 
            safeButton.BackColor = Color.DarkSeaGreen;
            safeButton.FlatStyle = FlatStyle.Popup;
            safeButton.ForeColor = Color.Black;
            safeButton.Location = new Point(244, 428);
            safeButton.Name = "safeButton";
            safeButton.Size = new Size(167, 36);
            safeButton.TabIndex = 16;
            safeButton.Text = "Сохранить";
            safeButton.UseVisualStyleBackColor = false;
            safeButton.Click += safeButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.DarkSeaGreen;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.ForeColor = Color.Black;
            deleteButton.Location = new Point(417, 428);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(167, 36);
            deleteButton.TabIndex = 17;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(295, 43);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 18;
            label1.Text = "Заказы";
            // 
            // numberButton
            // 
            numberButton.Enabled = false;
            numberButton.Location = new Point(710, 156);
            numberButton.Multiline = true;
            numberButton.Name = "numberButton";
            numberButton.Size = new Size(201, 28);
            numberButton.TabIndex = 19;
            // 
            // KolvoButton
            // 
            KolvoButton.Enabled = false;
            KolvoButton.Location = new Point(710, 239);
            KolvoButton.Multiline = true;
            KolvoButton.Name = "KolvoButton";
            KolvoButton.Size = new Size(201, 28);
            KolvoButton.TabIndex = 21;
            // 
            // PriceButton
            // 
            PriceButton.Enabled = false;
            PriceButton.Location = new Point(710, 286);
            PriceButton.Multiline = true;
            PriceButton.Name = "PriceButton";
            PriceButton.Size = new Size(201, 28);
            PriceButton.TabIndex = 22;
            // 
            // all_priceButton
            // 
            all_priceButton.Enabled = false;
            all_priceButton.Location = new Point(710, 329);
            all_priceButton.Multiline = true;
            all_priceButton.Name = "all_priceButton";
            all_priceButton.Size = new Size(201, 28);
            all_priceButton.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(622, 169);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 24;
            label2.Text = "Номер заказа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(665, 213);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 25;
            label3.Text = "Товар";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(665, 299);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 26;
            label4.Text = "Цена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(632, 252);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 27;
            label5.Text = "Количество";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(637, 342);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 28;
            label6.Text = "Стоимость";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(672, 374);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 29;
            label7.Text = "Дата";
            // 
            // ProductcomboBox
            // 
            ProductcomboBox.FormattingEnabled = true;
            ProductcomboBox.Location = new Point(710, 205);
            ProductcomboBox.Name = "ProductcomboBox";
            ProductcomboBox.Size = new Size(201, 23);
            ProductcomboBox.TabIndex = 30;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "yyyy-MM-dd";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(710, 374);
            dateTimePicker.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(117, 23);
            dateTimePicker.TabIndex = 31;
            dateTimePicker.Value = new DateTime(2023, 5, 19, 0, 0, 0, 0);
            dateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dgvDataOrders
            // 
            dgvDataOrders.BackgroundColor = SystemColors.Control;
            dgvDataOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataOrders.Location = new Point(71, 132);
            dgvDataOrders.Name = "dgvDataOrders";
            dgvDataOrders.RowTemplate.Height = 25;
            dgvDataOrders.Size = new Size(513, 265);
            dgvDataOrders.TabIndex = 14;
            dgvDataOrders.CellClick += dgvDataOrders_CellClick;
            dgvDataOrders.CellContentClick += dgvDataOrders_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(722, 43);
            label8.Name = "label8";
            label8.Size = new Size(155, 20);
            label8.TabIndex = 32;
            label8.Text = "Сортировать по дате";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(798, 76);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 38;
            label10.Text = "по";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(653, 76);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 37;
            label9.Text = "с";
            label9.Click += label9_Click;
            // 
            // SortedButton
            // 
            SortedButton.BackColor = Color.DarkSeaGreen;
            SortedButton.FlatStyle = FlatStyle.Popup;
            SortedButton.ForeColor = Color.Black;
            SortedButton.Location = new Point(722, 102);
            SortedButton.Name = "SortedButton";
            SortedButton.Size = new Size(167, 39);
            SortedButton.TabIndex = 39;
            SortedButton.Text = "Сортировать";
            SortedButton.UseVisualStyleBackColor = false;
            SortedButton.Click += SortedButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(825, 73);
            dateTimePicker1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(108, 23);
            dateTimePicker1.TabIndex = 40;
            dateTimePicker1.Value = new DateTime(2023, 5, 22, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(672, 73);
            dateTimePicker2.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(108, 23);
            dateTimePicker2.TabIndex = 41;
            dateTimePicker2.Value = new DateTime(2023, 5, 20, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            label11.Location = new Point(71, 93);
            label11.Name = "label11";
            label11.Size = new Size(118, 20);
            label11.TabIndex = 42;
            label11.Text = "Найти заказ № ";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(195, 90);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(99, 23);
            SearchTextBox.TabIndex = 43;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.DarkSeaGreen;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.ForeColor = Color.Black;
            SearchButton.Location = new Point(309, 89);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 24);
            SearchButton.TabIndex = 44;
            SearchButton.Text = "Найти";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // OrderButton
            // 
            OrderButton.BackColor = Color.DarkSeaGreen;
            OrderButton.FlatStyle = FlatStyle.Popup;
            OrderButton.ForeColor = Color.Black;
            OrderButton.Location = new Point(622, 431);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(167, 30);
            OrderButton.TabIndex = 45;
            OrderButton.Text = "Сформировать чек";
            OrderButton.UseVisualStyleBackColor = false;
            OrderButton.Click += OrderButton_Click;
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(875, 434);
            NumberTextBox.Multiline = true;
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(99, 23);
            NumberTextBox.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            label12.Location = new Point(797, 435);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 47;
            label12.Text = "Заказ № ";
            // 
            // OrderWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 219, 173);
            ClientSize = new Size(999, 486);
            Controls.Add(label12);
            Controls.Add(NumberTextBox);
            Controls.Add(OrderButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(label11);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(SortedButton);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dateTimePicker);
            Controls.Add(ProductcomboBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(all_priceButton);
            Controls.Add(PriceButton);
            Controls.Add(KolvoButton);
            Controls.Add(numberButton);
            Controls.Add(label1);
            Controls.Add(deleteButton);
            Controls.Add(safeButton);
            Controls.Add(updateButton);
            Controls.Add(dgvDataOrders);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderWindow";
            Load += OrderWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem spravkaToolStripMenuItem;
        private ToolStripMenuItem exsitToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private Button updateButton;
        private Button safeButton;
        private Button deleteButton;
        private Label label1;
        private TextBox numberButton;
        private TextBox KolvoButton;
        private TextBox PriceButton;
        private TextBox all_priceButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox ProductcomboBox;
        private DateTimePicker dateTimePicker;
        private DataGridView dgvDataOrders;
        private Label label8;
        private Label label10;
        private Label label9;
        private Button SortedButton;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label11;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button OrderButton;
        private TextBox NumberTextBox;
        private Label label12;
    }
}