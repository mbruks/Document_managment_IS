namespace ProbaDiplom
{
    partial class ReferencesWindow
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
            product = new Button();
            mainWindowLabel = new Label();
            contractor = new Button();
            staff = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, spravkaToolStripMenuItem, exsitToolStripMenuItem, backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(497, 24);
            menuStrip1.TabIndex = 7;
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
            // product
            // 
            product.BackColor = Color.DarkSeaGreen;
            product.BackgroundImageLayout = ImageLayout.None;
            product.FlatStyle = FlatStyle.Flat;
            product.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            product.Location = new Point(86, 125);
            product.Name = "product";
            product.Size = new Size(302, 43);
            product.TabIndex = 8;
            product.Text = "Номенклатура";
            product.UseVisualStyleBackColor = false;
            product.Click += product_Click;
            // 
            // mainWindowLabel
            // 
            mainWindowLabel.AutoSize = true;
            mainWindowLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            mainWindowLabel.Location = new Point(151, 64);
            mainWindowLabel.Name = "mainWindowLabel";
            mainWindowLabel.Size = new Size(173, 31);
            mainWindowLabel.TabIndex = 9;
            mainWindowLabel.Text = "Справочники";
            // 
            // contractor
            // 
            contractor.BackColor = Color.DarkSeaGreen;
            contractor.BackgroundImageLayout = ImageLayout.None;
            contractor.FlatStyle = FlatStyle.Flat;
            contractor.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            contractor.Location = new Point(86, 174);
            contractor.Name = "contractor";
            contractor.Size = new Size(302, 43);
            contractor.TabIndex = 11;
            contractor.Text = "Поставщики";
            contractor.UseVisualStyleBackColor = false;
            contractor.Click += contractor_Click;
            // 
            // staff
            // 
            staff.BackColor = Color.DarkSeaGreen;
            staff.BackgroundImageLayout = ImageLayout.None;
            staff.FlatStyle = FlatStyle.Flat;
            staff.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            staff.Location = new Point(86, 223);
            staff.Name = "staff";
            staff.Size = new Size(302, 43);
            staff.TabIndex = 12;
            staff.Text = "Пользователи";
            staff.UseVisualStyleBackColor = false;
            staff.Click += staff_Click;
            // 
            // ReferencesWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 219, 173);
            ClientSize = new Size(497, 312);
            Controls.Add(staff);
            Controls.Add(contractor);
            Controls.Add(mainWindowLabel);
            Controls.Add(product);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReferencesWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeWindow";
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
        private Button product;
        private Label mainWindowLabel;
        private Button contractor;
        private Button staff;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}