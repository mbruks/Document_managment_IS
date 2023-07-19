namespace ProbaDiplom
{
    partial class ProductWindow
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
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            spravkaToolStripMenuItem = new ToolStripMenuItem();
            exsitToolStripMenuItem = new ToolStripMenuItem();
            backToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            deleteButton = new Button();
            insertButton = new Button();
            safeButton = new Button();
            kolvoButton = new TextBox();
            costButton = new TextBox();
            nameButton = new TextBox();
            dgvDataNum = new DataGridView();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataNum).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(186, 219, 173);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(safeButton);
            panel1.Controls.Add(kolvoButton);
            panel1.Controls.Add(costButton);
            panel1.Controls.Add(nameButton);
            panel1.Controls.Add(dgvDataNum);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, spravkaToolStripMenuItem, exsitToolStripMenuItem, backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(699, 24);
            menuStrip1.TabIndex = 12;
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
            exsitToolStripMenuItem.Click += exsitToolStripMenuItem_Click_1;
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(51, 20);
            backToolStripMenuItem.Text = "Назад";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.ForeColor = Color.Black;
            label4.Location = new Point(263, 92);
            label4.Name = "label4";
            label4.Size = new Size(41, 18);
            label4.TabIndex = 11;
            label4.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(444, 95);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 10;
            label3.Text = "Количество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(46, 95);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 9;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(263, 32);
            label1.Name = "label1";
            label1.Size = new Size(197, 31);
            label1.TabIndex = 8;
            label1.Text = "Номенклатура";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.DarkSeaGreen;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.ForeColor = Color.Black;
            deleteButton.Location = new Point(484, 381);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(167, 36);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.DarkSeaGreen;
            insertButton.FlatStyle = FlatStyle.Popup;
            insertButton.ForeColor = Color.Black;
            insertButton.Location = new Point(46, 381);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(167, 36);
            insertButton.TabIndex = 6;
            insertButton.Text = "Обновить";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click_1;
            // 
            // safeButton
            // 
            safeButton.BackColor = Color.DarkSeaGreen;
            safeButton.FlatStyle = FlatStyle.Popup;
            safeButton.ForeColor = Color.Black;
            safeButton.Location = new Point(273, 381);
            safeButton.Name = "safeButton";
            safeButton.Size = new Size(167, 36);
            safeButton.TabIndex = 5;
            safeButton.Text = "Сохранить";
            safeButton.UseVisualStyleBackColor = false;
            safeButton.Click += safeButton_Click;
            // 
            // kolvoButton
            // 
            kolvoButton.Enabled = false;
            kolvoButton.Location = new Point(521, 82);
            kolvoButton.Multiline = true;
            kolvoButton.Name = "kolvoButton";
            kolvoButton.Size = new Size(130, 34);
            kolvoButton.TabIndex = 3;
            // 
            // costButton
            // 
            costButton.Enabled = false;
            costButton.Location = new Point(310, 82);
            costButton.Multiline = true;
            costButton.Name = "costButton";
            costButton.Size = new Size(130, 34);
            costButton.TabIndex = 2;
            // 
            // nameButton
            // 
            nameButton.Enabled = false;
            nameButton.Location = new Point(106, 82);
            nameButton.Multiline = true;
            nameButton.Name = "nameButton";
            nameButton.Size = new Size(130, 28);
            nameButton.TabIndex = 1;
            nameButton.TextChanged += nameButton_TextChanged;
            // 
            // dgvDataNum
            // 
            dgvDataNum.BackgroundColor = SystemColors.Control;
            dgvDataNum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataNum.Location = new Point(46, 137);
            dgvDataNum.Name = "dgvDataNum";
            dgvDataNum.RowTemplate.Height = 25;
            dgvDataNum.Size = new Size(605, 226);
            dgvDataNum.TabIndex = 0;
            dgvDataNum.CellClick += dgvDataNum_CellClick;
            dgvDataNum.CellContentClick += dgvData_CellContentClick;
            // 
            // ProductWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 450);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(186, 219, 173);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataNum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox kolvoButton;
        private TextBox costButton;
        private TextBox nameButton;
        private DataGridView dgvDataNum;
        private Button safeButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button deleteButton;
        private Button insertButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem spravkaToolStripMenuItem;
        private ToolStripMenuItem exsitToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}