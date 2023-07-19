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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ProbaDiplom
{
    public partial class SuppliersWindow : Form
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

        public SuppliersWindow()
        {
            InitializeComponent();
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM suppliers order by id_suppliers";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvDataNum.DataSource = null; // reset datagridiew
                dgvDataNum.DataSource = dt;
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

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferencesWindow refWin = new ReferencesWindow();
            refWin.Show();
            this.Hide();
        }

        private void SuppliersWindow_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();
        }

        private void dgvDataNum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                nameButton.Text = dgvDataNum.Rows[e.RowIndex].Cells["name"].Value.ToString();
                addressButton.Text = dgvDataNum.Rows[e.RowIndex].Cells["address"].Value.ToString();
            }
        }

        private void safeButtonPack_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0) // insert
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * from sup_insert(:_name, :_address)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_name", nameButton.Text);
                    cmd.Parameters.AddWithValue("_address", addressButton.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Новый продукт успешно добавлен!");
                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка!");
                    }

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else //update
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * from sup_update(:_id_suppliers, :_name, :_address)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_suppliers", int.Parse(dgvDataNum.Rows[rowIndex].Cells["id_suppliers"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_name", nameButton.Text);
                    cmd.Parameters.AddWithValue("_address", addressButton.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Успешно!");
                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка!");
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            result = 0;
            nameButton.Text = addressButton.Text = null;
            nameButton.Enabled = addressButton.Enabled = false;
        }

        private void insertButtonPack_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            nameButton.Enabled = addressButton.Enabled = true;
            nameButton.Text = addressButton.Text = null;
            nameButton.Select();
        }

        private void deleteButtonPack_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Пожалуйста, выберите продукт для удаления!");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from sup_delete(:id_suppliers)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id_suppliers", int.Parse(dgvDataNum.Rows[rowIndex].Cells["id_suppliers"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Удаление прошло успешно!");
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Hide();
        }
    }
}
