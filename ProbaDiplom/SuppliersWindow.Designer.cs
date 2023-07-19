namespace ProbaDiplom
{
    partial class SuppliersWindow
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
            label2 = new Label();
            label1 = new Label();
            deleteButtonPack = new Button();
            insertButtonPack = new Button();
            safeButtonPack = new Button();
            addressButton = new TextBox();
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
            // label4
            // 
            label4.ForeColor = Color.Black;
            label4.Location = new Point(449, 150);
            label4.Name = "label4";
            label4.Size = new Size(41, 18);
            label4.TabIndex = 62;
            label4.Text = "Адресс";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(431, 111);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 60;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(144, 41);
            label1.Name = "label1";
            label1.Size = new Size(174, 31);
            label1.TabIndex = 59;
            label1.Text = "Поставщики";
            // 
            // deleteButtonPack
            // 
            deleteButtonPack.BackColor = Color.DarkSeaGreen;
            deleteButtonPack.FlatStyle = FlatStyle.Popup;
            deleteButtonPack.ForeColor = Color.Black;
            deleteButtonPack.Location = new Point(295, 323);
            deleteButtonPack.Name = "deleteButtonPack";
            deleteButtonPack.Size = new Size(130, 36);
            deleteButtonPack.TabIndex = 58;
            deleteButtonPack.Text = "Удалить";
            deleteButtonPack.UseVisualStyleBackColor = false;
            deleteButtonPack.Click += deleteButtonPack_Click;
            // 
            // insertButtonPack
            // 
            insertButtonPack.BackColor = Color.DarkSeaGreen;
            insertButtonPack.FlatStyle = FlatStyle.Popup;
            insertButtonPack.ForeColor = Color.Black;
            insertButtonPack.Location = new Point(25, 323);
            insertButtonPack.Name = "insertButtonPack";
            insertButtonPack.Size = new Size(130, 36);
            insertButtonPack.TabIndex = 57;
            insertButtonPack.Text = "Обновить";
            insertButtonPack.UseVisualStyleBackColor = false;
            insertButtonPack.Click += insertButtonPack_Click;
            // 
            // safeButtonPack
            // 
            safeButtonPack.BackColor = Color.DarkSeaGreen;
            safeButtonPack.FlatStyle = FlatStyle.Popup;
            safeButtonPack.ForeColor = Color.Black;
            safeButtonPack.Location = new Point(161, 323);
            safeButtonPack.Name = "safeButtonPack";
            safeButtonPack.Size = new Size(130, 36);
            safeButtonPack.TabIndex = 56;
            safeButtonPack.Text = "Сохранить";
            safeButtonPack.UseVisualStyleBackColor = false;
            safeButtonPack.Click += safeButtonPack_Click;
            // 
            // addressButton
            // 
            addressButton.Enabled = false;
            addressButton.Location = new Point(496, 138);
            addressButton.Multiline = true;
            addressButton.Name = "addressButton";
            addressButton.Size = new Size(130, 30);
            addressButton.TabIndex = 54;
            // 
            // nameButton
            // 
            nameButton.Enabled = false;
            nameButton.Location = new Point(496, 96);
            nameButton.Multiline = true;
            nameButton.Name = "nameButton";
            nameButton.Size = new Size(130, 30);
            nameButton.TabIndex = 53;
            // 
            // dgvDataNum
            // 
            dgvDataNum.BackgroundColor = SystemColors.Control;
            dgvDataNum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataNum.Location = new Point(25, 91);
            dgvDataNum.Name = "dgvDataNum";
            dgvDataNum.RowTemplate.Height = 25;
            dgvDataNum.Size = new Size(400, 226);
            dgvDataNum.TabIndex = 52;
            dgvDataNum.CellClick += dgvDataNum_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, spravkaToolStripMenuItem, exsitToolStripMenuItem, backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(638, 24);
            menuStrip1.TabIndex = 65;
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
            // SuppliersWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 219, 173);
            ClientSize = new Size(638, 429);
            Controls.Add(menuStrip1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteButtonPack);
            Controls.Add(insertButtonPack);
            Controls.Add(safeButtonPack);
            Controls.Add(addressButton);
            Controls.Add(nameButton);
            Controls.Add(dgvDataNum);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuppliersWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuppliersWindow";
            Load += SuppliersWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataNum).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label2;
        private Label label1;
        private Button deleteButtonPack;
        private Button insertButtonPack;
        private Button safeButtonPack;
        private TextBox addressButton;
        private TextBox nameButton;
        private DataGridView dgvDataNum;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem spravkaToolStripMenuItem;
        private ToolStripMenuItem exsitToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}