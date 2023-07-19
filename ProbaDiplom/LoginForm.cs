using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace ProbaDiplom
{
    public partial class LoginForm : Form
    {
        //Подключение к Классу Connect
        Connect connect = new Connect();
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            passwordField.PasswordChar = '*';
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Gray;
        }

        Point lastPoint;

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void enter_button_Click(object sender, EventArgs e)
        {

            var loginUser = loginField.Text;
            //var passUser = md5_sql_hash.hashPassword(passwordField.Text);
            var passUser = passwordField.Text;


            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"select id_employee, login, password" +
                $" from employee where login = '{loginUser}' and password = '{passUser}'";

            NpgsqlCommand command = new NpgsqlCommand(queryString, connect.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!");
                MainWindow mainWin = new MainWindow();
                this.Hide();
                mainWin.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунт не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            Location = new Point(700, 300);
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void registration_Click(object sender, EventArgs e)
        {
            RegistrationWindow regWin = new RegistrationWindow();
            this.Hide();
            regWin.ShowDialog();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void openPic_Click(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
