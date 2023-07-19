namespace ProbaDiplom
{
    partial class CategoryWindow
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
            other = new Button();
            present = new Button();
            packaging = new Button();
            flower = new Button();
            mainWindowLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, spravkaToolStripMenuItem, exsitToolStripMenuItem, backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(440, 24);
            menuStrip1.TabIndex = 8;
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
            // other
            // 
            other.BackColor = Color.DarkSeaGreen;
            other.FlatStyle = FlatStyle.Flat;
            other.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            other.Location = new Point(65, 305);
            other.Name = "other";
            other.Size = new Size(302, 43);
            other.TabIndex = 13;
            other.Text = "Другое";
            other.UseVisualStyleBackColor = false;
            other.Click += other_Click;
            // 
            // present
            // 
            present.BackColor = Color.DarkSeaGreen;
            present.FlatStyle = FlatStyle.Flat;
            present.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            present.Location = new Point(65, 256);
            present.Name = "present";
            present.Size = new Size(302, 43);
            present.TabIndex = 12;
            present.Text = "Открытки";
            present.UseVisualStyleBackColor = false;
            present.Click += present_Click;
            // 
            // packaging
            // 
            packaging.BackColor = Color.DarkSeaGreen;
            packaging.FlatStyle = FlatStyle.Flat;
            packaging.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            packaging.ForeColor = Color.Black;
            packaging.Location = new Point(65, 207);
            packaging.Name = "packaging";
            packaging.Size = new Size(302, 43);
            packaging.TabIndex = 11;
            packaging.Text = "Упаковка";
            packaging.UseVisualStyleBackColor = false;
            packaging.Click += packaging_Click;
            // 
            // flower
            // 
            flower.BackColor = Color.DarkSeaGreen;
            flower.BackgroundImageLayout = ImageLayout.None;
            flower.FlatStyle = FlatStyle.Flat;
            flower.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            flower.Location = new Point(65, 158);
            flower.Name = "flower";
            flower.Size = new Size(302, 43);
            flower.TabIndex = 10;
            flower.Text = "Цветы";
            flower.UseVisualStyleBackColor = false;
            flower.Click += flower_Click;
            // 
            // mainWindowLabel
            // 
            mainWindowLabel.AutoSize = true;
            mainWindowLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            mainWindowLabel.Location = new Point(90, 99);
            mainWindowLabel.Name = "mainWindowLabel";
            mainWindowLabel.Size = new Size(255, 31);
            mainWindowLabel.TabIndex = 9;
            mainWindowLabel.Text = "Категории товаров";
            // 
            // CategoryWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 219, 173);
            ClientSize = new Size(440, 450);
            Controls.Add(other);
            Controls.Add(present);
            Controls.Add(packaging);
            Controls.Add(flower);
            Controls.Add(mainWindowLabel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryWindow";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem spravkaToolStripMenuItem;
        private ToolStripMenuItem exsitToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private Button other;
        private Button present;
        private Button packaging;
        private Button flower;
        private Label mainWindowLabel;
    }
}