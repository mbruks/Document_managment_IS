namespace ProbaDiplom
{
    partial class FlowerWindow
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            deleteButtonFlowers = new Button();
            insertButtonFlowers = new Button();
            safeButtonFlowers = new Button();
            kolvoButton = new TextBox();
            costButton = new TextBox();
            nameButton = new TextBox();
            dgvDataNum = new DataGridView();
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            spravkaToolStripMenuItem = new ToolStripMenuItem();
            exsitToolStripMenuItem = new ToolStripMenuItem();
            backToolStripMenuItem = new ToolStripMenuItem();
            FlowerComboBox = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDataNum).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.ForeColor = Color.Black;
            label4.Location = new Point(673, 153);
            label4.Name = "label4";
            label4.Size = new Size(41, 18);
            label4.TabIndex = 22;
            label4.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(644, 201);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 21;
            label3.Text = "Количество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(657, 114);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 20;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(397, 36);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 19;
            label1.Text = "Цветы";
            // 
            // deleteButtonFlowers
            // 
            deleteButtonFlowers.BackColor = Color.DarkSeaGreen;
            deleteButtonFlowers.FlatStyle = FlatStyle.Popup;
            deleteButtonFlowers.ForeColor = Color.Black;
            deleteButtonFlowers.Location = new Point(429, 327);
            deleteButtonFlowers.Name = "deleteButtonFlowers";
            deleteButtonFlowers.Size = new Size(169, 36);
            deleteButtonFlowers.TabIndex = 18;
            deleteButtonFlowers.Text = "Удалить";
            deleteButtonFlowers.UseVisualStyleBackColor = false;
            deleteButtonFlowers.Click += deleteButtonFlowers_Click;
            // 
            // insertButtonFlowers
            // 
            insertButtonFlowers.BackColor = Color.DarkSeaGreen;
            insertButtonFlowers.FlatStyle = FlatStyle.Popup;
            insertButtonFlowers.ForeColor = Color.Black;
            insertButtonFlowers.Location = new Point(52, 327);
            insertButtonFlowers.Name = "insertButtonFlowers";
            insertButtonFlowers.Size = new Size(169, 36);
            insertButtonFlowers.TabIndex = 17;
            insertButtonFlowers.Text = "Обновить";
            insertButtonFlowers.UseVisualStyleBackColor = false;
            insertButtonFlowers.Click += insertButtonFlowers_Click;
            // 
            // safeButtonFlowers
            // 
            safeButtonFlowers.BackColor = Color.DarkSeaGreen;
            safeButtonFlowers.FlatStyle = FlatStyle.Popup;
            safeButtonFlowers.ForeColor = Color.Black;
            safeButtonFlowers.Location = new Point(241, 327);
            safeButtonFlowers.Name = "safeButtonFlowers";
            safeButtonFlowers.Size = new Size(169, 36);
            safeButtonFlowers.TabIndex = 16;
            safeButtonFlowers.Text = "Сохранить";
            safeButtonFlowers.UseVisualStyleBackColor = false;
            safeButtonFlowers.Click += safeButtonFlowers_Click;
            // 
            // kolvoButton
            // 
            kolvoButton.Enabled = false;
            kolvoButton.Location = new Point(722, 186);
            kolvoButton.Multiline = true;
            kolvoButton.Name = "kolvoButton";
            kolvoButton.Size = new Size(130, 30);
            kolvoButton.TabIndex = 15;
            // 
            // costButton
            // 
            costButton.Enabled = false;
            costButton.Location = new Point(722, 141);
            costButton.Multiline = true;
            costButton.Name = "costButton";
            costButton.Size = new Size(130, 30);
            costButton.TabIndex = 14;
            // 
            // nameButton
            // 
            nameButton.Enabled = false;
            nameButton.Location = new Point(722, 99);
            nameButton.Multiline = true;
            nameButton.Name = "nameButton";
            nameButton.Size = new Size(130, 30);
            nameButton.TabIndex = 13;
            // 
            // dgvDataNum
            // 
            dgvDataNum.BackgroundColor = SystemColors.Control;
            dgvDataNum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataNum.Location = new Point(52, 83);
            dgvDataNum.Name = "dgvDataNum";
            dgvDataNum.RowTemplate.Height = 25;
            dgvDataNum.Size = new Size(546, 226);
            dgvDataNum.TabIndex = 12;
            dgvDataNum.CellClick += dgvDataNum_CellClick;
            dgvDataNum.CellContentClick += dgvDataNum_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, spravkaToolStripMenuItem, exsitToolStripMenuItem, backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(908, 24);
            menuStrip1.TabIndex = 23;
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
            // FlowerComboBox
            // 
            FlowerComboBox.FormattingEnabled = true;
            FlowerComboBox.Location = new Point(722, 232);
            FlowerComboBox.Name = "FlowerComboBox";
            FlowerComboBox.Size = new Size(130, 23);
            FlowerComboBox.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(642, 240);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 25;
            label5.Text = "Категория";
            // 
            // FlowerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 219, 173);
            ClientSize = new Size(908, 399);
            Controls.Add(label5);
            Controls.Add(FlowerComboBox);
            Controls.Add(menuStrip1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteButtonFlowers);
            Controls.Add(insertButtonFlowers);
            Controls.Add(safeButtonFlowers);
            Controls.Add(kolvoButton);
            Controls.Add(costButton);
            Controls.Add(nameButton);
            Controls.Add(dgvDataNum);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlowerWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlowerWindow";
            Load += FlowerWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataNum).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button deleteButtonFlowers;
        private Button insertButtonFlowers;
        private Button safeButtonFlowers;
        private TextBox kolvoButton;
        private TextBox costButton;
        private TextBox nameButton;
        private DataGridView dgvDataNum;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem spravkaToolStripMenuItem;
        private ToolStripMenuItem exsitToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private ComboBox FlowerComboBox;
        private Label label5;
    }
}