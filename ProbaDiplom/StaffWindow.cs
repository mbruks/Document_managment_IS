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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ProbaDiplom
{
    public partial class StaffWindow : Form
    {
        private string connstring = String.Format("Server={0};Port={1};" +
        "User Id={2};Password={3};Database={4};",
        "localhost", 5432, "postgres",
        "root", "flowers_db");

        private NpgsqlConnection conn;
        private string sql;
        private string sql2;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;


        public StaffWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT id_employee, name, surname, phone_number, login, password, role FROM employee order by id_employee";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvDataUsers.DataSource = null; // reset datagridiew
                dgvDataUsers.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void exsitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferencesWindow refWin = new ReferencesWindow();
            refWin.Show();
            this.Hide();
        }

        private void StaffWindow_Load(object sender, EventArgs e)
        {
            Location = new System.Drawing.Point(500, 300);
            conn = new NpgsqlConnection(connstring);
            Select();
        }

        private void safeButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0) // insert
            {
                try
                {
                    conn.Open();
                    var roles = staffComboBox.Text;
                    sql = @"SELECT * from employee_insert(:_name, :_surname, :_phone_number, :_login, :_password, :_role)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_name", nameButton.Text);
                    cmd.Parameters.AddWithValue("_surname", surnameButton.Text);
                    cmd.Parameters.AddWithValue("_phone_number", phoneButton.Text);
                    cmd.Parameters.AddWithValue("_login", loginButton.Text);
                    cmd.Parameters.AddWithValue("_password", passwordButton.Text);
                    cmd.Parameters.AddWithValue("_role", staffComboBox.Text);
                    //cmd.Parameters.AddWithValue("_role", staffComboBox.SelectedValue);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Inserted new product seccessfully");
                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Inserted fail");
                    }

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
            }
            else //update
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT *  from emplo_update(:_id_employee, :_name, :_surname, :_phone_number, :_login, :_password, :_role)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_employee", int.Parse(dgvDataUsers.Rows[rowIndex].Cells["id_employee"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_name", nameButton.Text);
                    cmd.Parameters.AddWithValue("_surname", surnameButton.Text);
                    cmd.Parameters.AddWithValue("_phone_number", phoneButton.Text);
                    cmd.Parameters.AddWithValue("_login", loginButton.Text);
                    cmd.Parameters.AddWithValue("_password", passwordButton.Text);
                    cmd.Parameters.AddWithValue("_role", staffComboBox.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Update seccessfully");
                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Updated fail");
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Update fail. Error: " + ex.Message);
                }
            }
            result = 0;
            nameButton.Text = surnameButton.Text = phoneButton.Text = loginButton.Text = passwordButton.Text = null;
            nameButton.Enabled = surnameButton.Enabled = phoneButton.Enabled = loginButton.Enabled = passwordButton.Enabled = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Выберите сотрудника которого хотите удалить!");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from employee_delete(:_id_employee)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_employee", int.Parse(dgvDataUsers.Rows[rowIndex].Cells["id_employee"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Сотрудник удален!");
                    rowIndex = -1;
                    conn.Close();
                    Select();
                }
                else
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Произошла ошибка при удалении: " + ex.Message);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            nameButton.Enabled = surnameButton.Enabled = phoneButton.Enabled = loginButton.Enabled = passwordButton.Enabled = true;
            nameButton.Text = surnameButton.Text = phoneButton.Text = loginButton.Text = passwordButton.Text = null;
            nameButton.Select();

            staffComboBox.Items.Add("Пользователь");
            staffComboBox.Items.Add("Администратор");

            /*sql2 = @"SELECT * from roles";
            DataTable dt = new DataTable("roles");
            conn.Open();
            NpgsqlDataAdapter DA = new NpgsqlDataAdapter(sql2, conn);
            DA.Fill(dt);
            conn.Close();

            staffComboBox.DataSource = dt;
            staffComboBox.DisplayMember = "role";
            staffComboBox.ValueMember = "id_role";*/
        }



        private void dgvDataUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;

                nameButton.Text = dgvDataUsers.Rows[e.RowIndex].Cells["name"].Value.ToString();
                surnameButton.Text = dgvDataUsers.Rows[e.RowIndex].Cells["surname"].Value.ToString();
                phoneButton.Text = dgvDataUsers.Rows[e.RowIndex].Cells["phone_number"].Value.ToString();
                loginButton.Text = dgvDataUsers.Rows[e.RowIndex].Cells["login"].Value.ToString();
                passwordButton.Text = dgvDataUsers.Rows[e.RowIndex].Cells["password"].Value.ToString();
                staffComboBox.Text = dgvDataUsers.Rows[e.RowIndex].Cells["role"].Value.ToString();

            }
        }

        private void dgvDataUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void staffComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
