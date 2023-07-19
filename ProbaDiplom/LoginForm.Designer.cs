namespace ProbaDiplom
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            headerPanel = new Panel();
            closeButton = new Label();
            MainPanel = new Panel();
            passwordField = new TextBox();
            loginField = new TextBox();
            authorization = new Label();
            enter_button = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            headerPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.AutoScroll = true;
            headerPanel.BackColor = SystemColors.Control;
            headerPanel.Controls.Add(closeButton);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(540, 30);
            headerPanel.TabIndex = 0;
            headerPanel.MouseDown += headerPanel_MouseDown;
            headerPanel.MouseMove += headerPanel_MouseMove;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.Location = new Point(513, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(24, 25);
            closeButton.TabIndex = 7;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.BackColor = Color.FromArgb(186, 219, 173);
            MainPanel.Controls.Add(passwordField);
            MainPanel.Controls.Add(loginField);
            MainPanel.Controls.Add(authorization);
            MainPanel.Controls.Add(enter_button);
            MainPanel.Controls.Add(pictureBox3);
            MainPanel.Controls.Add(pictureBox2);
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 30);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(540, 470);
            MainPanel.TabIndex = 1;
            MainPanel.Paint += MainPanel_Paint;
            MainPanel.MouseDown += MainPanel_MouseDown;
            MainPanel.MouseMove += MainPanel_MouseMove;
            // 
            // passwordField
            // 
            passwordField.Cursor = Cursors.IBeam;
            passwordField.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordField.Location = new Point(127, 221);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(281, 29);
            passwordField.TabIndex = 6;
            passwordField.TextChanged += passwordField_TextChanged;
            // 
            // loginField
            // 
            loginField.Cursor = Cursors.IBeam;
            loginField.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginField.Location = new Point(127, 157);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(281, 29);
            loginField.TabIndex = 5;
            loginField.TextChanged += loginField_TextChanged;
            // 
            // authorization
            // 
            authorization.AutoSize = true;
            authorization.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            authorization.ForeColor = SystemColors.ControlText;
            authorization.Location = new Point(165, 99);
            authorization.Name = "authorization";
            authorization.Size = new Size(189, 33);
            authorization.TabIndex = 4;
            authorization.Text = "Авторизация";
            // 
            // enter_button
            // 
            enter_button.BackColor = Color.DarkSeaGreen;
            enter_button.BackgroundImageLayout = ImageLayout.Stretch;
            enter_button.FlatStyle = FlatStyle.Popup;
            enter_button.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            enter_button.Location = new Point(165, 271);
            enter_button.Name = "enter_button";
            enter_button.Size = new Size(189, 33);
            enter_button.TabIndex = 3;
            enter_button.Text = "Войти";
            enter_button.UseVisualStyleBackColor = false;
            enter_button.Click += enter_button_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(228, 340);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(80, 218);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 500);
            Controls.Add(MainPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Panel MainPanel;
        private TextBox textBox2;
        private TextBox loginField;
        private Label authorization;
        private Button enter_button;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox passwordField;
        private Label closeButton;
    }
}