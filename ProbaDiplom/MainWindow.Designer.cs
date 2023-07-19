namespace ProbaDiplom
{
    partial class MainWindow
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
            mainWindowLabel = new Label();
            order = new Button();
            purchase = new Button();
            references = new Button();
            registr = new Button();
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            spravkaToolStripMenuItem = new ToolStripMenuItem();
            exsitToolStripMenuItem = new ToolStripMenuItem();
            buttonLosses = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mainWindowLabel
            // 
            mainWindowLabel.AutoSize = true;
            mainWindowLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            mainWindowLabel.Location = new Point(165, 49);
            mainWindowLabel.Name = "mainWindowLabel";
            mainWindowLabel.Size = new Size(183, 31);
            mainWindowLabel.TabIndex = 0;
            mainWindowLabel.Text = "Главное меню";
            // 
            // order
            // 
            order.BackColor = Color.DarkSeaGreen;
            order.BackgroundImageLayout = ImageLayout.None;
            order.FlatStyle = FlatStyle.Flat;
            order.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            order.Location = new Point(106, 111);
            order.Name = "order";
            order.Size = new Size(302, 43);
            order.TabIndex = 1;
            order.Text = "Продажа";
            order.UseVisualStyleBackColor = false;
            order.Click += order_Click;
            // 
            // purchase
            // 
            purchase.BackColor = Color.DarkSeaGreen;
            purchase.FlatStyle = FlatStyle.Flat;
            purchase.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            purchase.ForeColor = Color.Black;
            purchase.Location = new Point(106, 160);
            purchase.Name = "purchase";
            purchase.Size = new Size(302, 43);
            purchase.TabIndex = 2;
            purchase.Text = "Закупка";
            purchase.UseVisualStyleBackColor = false;
            purchase.Click += purchase_Click;
            // 
            // references
            // 
            references.BackColor = Color.DarkSeaGreen;
            references.FlatStyle = FlatStyle.Flat;
            references.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            references.Location = new Point(106, 209);
            references.Name = "references";
            references.Size = new Size(302, 43);
            references.TabIndex = 4;
            references.Text = "Справочники";
            references.UseVisualStyleBackColor = false;
            references.Click += references_Click_1;
            // 
            // registr
            // 
            registr.BackColor = Color.DarkSeaGreen;
            registr.FlatStyle = FlatStyle.Flat;
            registr.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            registr.Location = new Point(106, 258);
            registr.Name = "registr";
            registr.Size = new Size(302, 43);
            registr.TabIndex = 5;
            registr.Text = "Регистры";
            registr.UseVisualStyleBackColor = false;
            registr.Click += registr_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, spravkaToolStripMenuItem, exsitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(519, 24);
            menuStrip1.TabIndex = 6;
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
            // buttonLosses
            // 
            buttonLosses.BackColor = Color.DarkSeaGreen;
            buttonLosses.FlatStyle = FlatStyle.Flat;
            buttonLosses.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLosses.Location = new Point(106, 308);
            buttonLosses.Name = "buttonLosses";
            buttonLosses.Size = new Size(302, 43);
            buttonLosses.TabIndex = 8;
            buttonLosses.Text = "Списание на убытки";
            buttonLosses.UseVisualStyleBackColor = false;
            buttonLosses.Click += buttonLosses_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 219, 173);
            ClientSize = new Size(519, 388);
            Controls.Add(buttonLosses);
            Controls.Add(menuStrip1);
            Controls.Add(registr);
            Controls.Add(references);
            Controls.Add(purchase);
            Controls.Add(order);
            Controls.Add(mainWindowLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainWindowLabel;
        private Button order;
        private Button purchase;
        private Button references;
        private Button registr;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem spravkaToolStripMenuItem;
        private ToolStripMenuItem exsitToolStripMenuItem;
        private Button buttonLosses;
    }
}