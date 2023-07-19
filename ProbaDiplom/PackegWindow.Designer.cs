namespace ProbaDiplom
{
    partial class PackegWindow
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
            PackegComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            deleteButtonPack = new Button();
            insertButtonPack = new Button();
            safeButtonPack = new Button();
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
            label5.Location = new Point(613, 247);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 51;
            label5.Text = "Категория";
            // 
            // PackegComboBox
            // 
            PackegComboBox.FormattingEnabled = true;
            PackegComboBox.Location = new Point(693, 239);
            PackegComboBox.Name = "PackegComboBox";
            PackegComboBox.Size = new Size(130, 23);
            PackegComboBox.TabIndex = 50;
            // 
            // label4
            // 
            label4.ForeColor = Color.Black;
            label4.Location = new Point(644, 160);
            label4.Name = "label4";
            label4.Size = new Size(41, 18);
            label4.TabIndex = 49;
            label4.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(615, 208);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 48;
            label3.Text = "Количество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(628, 121);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 47;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(350, 40);
            label1.Name = "label1";
            label1.Size = new Size(127, 31);
            label1.TabIndex = 46;
            label1.Text = "Упаковка";
            // 
            // deleteButtonPack
            // 
            deleteButtonPack.BackColor = Color.DarkSeaGreen;
            deleteButtonPack.FlatStyle = FlatStyle.Popup;
            deleteButtonPack.ForeColor = Color.Black;
            deleteButtonPack.Location = new Point(426, 332);
            deleteButtonPack.Name = "deleteButtonPack";
            deleteButtonPack.Size = new Size(169, 36);
            deleteButtonPack.TabIndex = 45;
            deleteButtonPack.Text = "Удалить";
            deleteButtonPack.UseVisualStyleBackColor = false;
            deleteButtonPack.Click += deleteButtonPack_Click;
            // 
            // insertButtonPack
            // 
            insertButtonPack.BackColor = Color.DarkSeaGreen;
            insertButtonPack.FlatStyle = FlatStyle.Popup;
            insertButtonPack.ForeColor = Color.Black;
            insertButtonPack.Location = new Point(49, 332);
            insertButtonPack.Name = "insertButtonPack";
            insertButtonPack.Size = new Size(169, 36);
            insertButtonPack.TabIndex = 44;
            insertButtonPack.Text = "Обновить";
            insertButtonPack.UseVisualStyleBackColor = false;
            insertButtonPack.Click += insertButtonPack_Click;
            // 
            // safeButtonPack
            // 
            safeButtonPack.BackColor = Color.DarkSeaGreen;
            safeButtonPack.FlatStyle = FlatStyle.Popup;
            safeButtonPack.ForeColor = Color.Black;
            safeButtonPack.Location = new Point(238, 332);
            safeButtonPack.Name = "safeButtonPack";
            safeButtonPack.Size = new Size(169, 36);
            safeButtonPack.TabIndex = 43;
            safeButtonPack.Text = "Сохранить";
            safeButtonPack.UseVisualStyleBackColor = false;
            safeButtonPack.Click += safeButtonPack_Click;
            // 
            // kolvoButton
            // 
            kolvoButton.Enabled = false;
            kolvoButton.Location = new Point(693, 193);
            kolvoButton.Multiline = true;
            kolvoButton.Name = "kolvoButton";
            kolvoButton.Size = new Size(130, 30);
            kolvoButton.TabIndex = 42;
            // 
            // costButton
            // 
            costButton.Enabled = false;
            costButton.Location = new Point(693, 148);
            costButton.Multiline = true;
            costButton.Name = "costButton";
            costButton.Size = new Size(130, 30);
            costButton.TabIndex = 41;
            // 
            // nameButton
            // 
            nameButton.Enabled = false;
            nameButton.Location = new Point(693, 106);
            nameButton.Multiline = true;
            nameButton.Name = "nameButton";
            nameButton.Size = new Size(130, 30);
            nameButton.TabIndex = 40;
            // 
            // dgvDataNum
            // 
            dgvDataNum.BackgroundColor = SystemColors.Control;
            dgvDataNum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataNum.Location = new Point(49, 88);
            dgvDataNum.Name = "dgvDataNum";
            dgvDataNum.RowTemplate.Height = 25;
            dgvDataNum.Size = new Size(546, 226);
            dgvDataNum.TabIndex = 39;
            dgvDataNum.CellClick += dgvDataNum_CellClick;
            dgvDataNum.CellContentClick += dgvDataNum_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, spravkaToolStripMenuItem, exsitToolStripMenuItem, backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(874, 24);
            menuStrip1.TabIndex = 52;
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
            // PackegWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 219, 173);
            ClientSize = new Size(874, 401);
            Controls.Add(menuStrip1);
            Controls.Add(label5);
            Controls.Add(PackegComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteButtonPack);
            Controls.Add(insertButtonPack);
            Controls.Add(safeButtonPack);
            Controls.Add(kolvoButton);
            Controls.Add(costButton);
            Controls.Add(nameButton);
            Controls.Add(dgvDataNum);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PackegWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PackegWindow";
            Load += PackegWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataNum).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox PackegComboBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button deleteButtonPack;
        private Button insertButtonPack;
        private Button safeButtonPack;
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