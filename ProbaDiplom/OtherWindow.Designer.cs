namespace ProbaDiplom
{
    partial class OtherWindow
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
            label5 = new Label();
            OtherComboBox = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvDataNum).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(631, 255);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 38;
            label5.Text = "Категория";
            // 
            // OtherComboBox
            // 
            OtherComboBox.FormattingEnabled = true;
            OtherComboBox.Location = new Point(711, 247);
            OtherComboBox.Name = "OtherComboBox";
            OtherComboBox.Size = new Size(130, 23);
            OtherComboBox.TabIndex = 37;
            // 
            // label4
            // 
            label4.ForeColor = Color.Black;
            label4.Location = new Point(662, 168);
            label4.Name = "label4";
            label4.Size = new Size(41, 18);
            label4.TabIndex = 36;
            label4.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(633, 216);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 35;
            label3.Text = "Количество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(646, 129);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 34;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(369, 46);
            label1.Name = "label1";
            label1.Size = new Size(196, 31);
            label1.TabIndex = 33;
            label1.Text = "Другие товары";
            // 
            // deleteButtonFlowers
            // 
            deleteButtonFlowers.BackColor = Color.DarkSeaGreen;
            deleteButtonFlowers.FlatStyle = FlatStyle.Popup;
            deleteButtonFlowers.ForeColor = Color.Black;
            deleteButtonFlowers.Location = new Point(418, 342);
            deleteButtonFlowers.Name = "deleteButtonFlowers";
            deleteButtonFlowers.Size = new Size(169, 36);
            deleteButtonFlowers.TabIndex = 32;
            deleteButtonFlowers.Text = "Удалить";
            deleteButtonFlowers.UseVisualStyleBackColor = false;
            deleteButtonFlowers.Click += deleteButtonFlowers_Click;
            // 
            // insertButtonFlowers
            // 
            insertButtonFlowers.BackColor = Color.DarkSeaGreen;
            insertButtonFlowers.FlatStyle = FlatStyle.Popup;
            insertButtonFlowers.ForeColor = Color.Black;
            insertButtonFlowers.Location = new Point(41, 342);
            insertButtonFlowers.Name = "insertButtonFlowers";
            insertButtonFlowers.Size = new Size(169, 36);
            insertButtonFlowers.TabIndex = 31;
            insertButtonFlowers.Text = "Обновить";
            insertButtonFlowers.UseVisualStyleBackColor = false;
            insertButtonFlowers.Click += insertButtonFlowers_Click;
            // 
            // safeButtonFlowers
            // 
            safeButtonFlowers.BackColor = Color.DarkSeaGreen;
            safeButtonFlowers.FlatStyle = FlatStyle.Popup;
            safeButtonFlowers.ForeColor = Color.Black;
            safeButtonFlowers.Location = new Point(230, 342);
            safeButtonFlowers.Name = "safeButtonFlowers";
            safeButtonFlowers.Size = new Size(169, 36);
            safeButtonFlowers.TabIndex = 30;
            safeButtonFlowers.Text = "Сохранить";
            safeButtonFlowers.UseVisualStyleBackColor = false;
            safeButtonFlowers.Click += safeButtonFlowers_Click;
            // 
            // kolvoButton
            // 
            kolvoButton.Enabled = false;
            kolvoButton.Location = new Point(711, 201);
            kolvoButton.Multiline = true;
            kolvoButton.Name = "kolvoButton";
            kolvoButton.Size = new Size(130, 30);
            kolvoButton.TabIndex = 29;
            // 
            // costButton
            // 
            costButton.Enabled = false;
            costButton.Location = new Point(711, 156);
            costButton.Multiline = true;
            costButton.Name = "costButton";
            costButton.Size = new Size(130, 30);
            costButton.TabIndex = 28;
            // 
            // nameButton
            // 
            nameButton.Enabled = false;
            nameButton.Location = new Point(711, 114);
            nameButton.Multiline = true;
            nameButton.Name = "nameButton";
            nameButton.Size = new Size(130, 30);
            nameButton.TabIndex = 27;
            // 
            // dgvDataNum
            // 
            dgvDataNum.BackgroundColor = SystemColors.Control;
            dgvDataNum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataNum.Location = new Point(41, 98);
            dgvDataNum.Name = "dgvDataNum";
            dgvDataNum.RowTemplate.Height = 25;
            dgvDataNum.Size = new Size(546, 226);
            dgvDataNum.TabIndex = 26;
            dgvDataNum.CellClick += dgvDataNum_CellClick;
            dgvDataNum.CellContentClick += dgvDataNum_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, spravkaToolStripMenuItem, exsitToolStripMenuItem, backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(921, 24);
            menuStrip1.TabIndex = 53;
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
            // OtherWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 219, 173);
            ClientSize = new Size(921, 425);
            Controls.Add(menuStrip1);
            Controls.Add(label5);
            Controls.Add(OtherComboBox);
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
            Name = "OtherWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OtherWindow";
            Load += OtherWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataNum).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox OtherComboBox;
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
    }
}