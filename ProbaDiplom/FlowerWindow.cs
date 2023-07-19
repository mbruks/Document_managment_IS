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

namespace ProbaDiplom
{
    public partial class FlowerWindow : Form
    {
        private string connstring = String.Format("Server={0};Port={1};" +
        "User Id={2};Password={3};Database={4};",
        "localhost", 5432, "postgres",
        "root", "flowers_db");

        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;

        public FlowerWindow()
        {
            InitializeComponent();
        }

        private void insertButtonFlowers_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            nameButton.Enabled = kolvoButton.Enabled = costButton.Enabled = true;
            nameButton.Text = kolvoButton.Text = costButton.Text = null;
            nameButton.Select();
        }

        private void safeButtonFlowers_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0) // insert
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * from prod_insert(:_name, :_cost, :_kolvo, :_category)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_name", nameButton.Text);
                    cmd.Parameters.AddWithValue("_cost", int.Parse(costButton.Text));
                    cmd.Parameters.AddWithValue("_kolvo", int.Parse(kolvoButton.Text));
                    cmd.Parameters.AddWithValue("_category", FlowerComboBox.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Новый продукт добавлен");
                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка добавления!");
                    }

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Ошибка добавления. Error: " + ex.Message);
                }
            }
            else //update
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * from product_update(:_id_product, :_name, :_cost, :_kolvo, :_category)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_product", int.Parse(dgvDataNum.Rows[rowIndex].Cells["id_product"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_name", nameButton.Text);
                    cmd.Parameters.AddWithValue("_cost", int.Parse(costButton.Text));
                    cmd.Parameters.AddWithValue("_kolvo", int.Parse(kolvoButton.Text));
                    cmd.Parameters.AddWithValue("_category", FlowerComboBox.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Успешно!");
                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            result = 0;
            nameButton.Text = kolvoButton.Text = costButton.Text = null;
            nameButton.Enabled = kolvoButton.Enabled = costButton.Enabled = false;
        }

        private void deleteButtonFlowers_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Пожалйста, выберите товар для удаления!");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from st_delete(:id_product)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id_product", int.Parse(dgvDataNum.Rows[rowIndex].Cells["id_product"].Value.ToString()));
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

        private void dgvDataNum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                nameButton.Text = dgvDataNum.Rows[e.RowIndex].Cells["name"].Value.ToString();
                kolvoButton.Text = dgvDataNum.Rows[e.RowIndex].Cells["cost"].Value.ToString();
                costButton.Text = dgvDataNum.Rows[e.RowIndex].Cells["kolvo"].Value.ToString();
                FlowerComboBox.Text = dgvDataNum.Rows[e.RowIndex].Cells["category"].Value.ToString();
            }
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM public.product WHERE category = 'Цветы' order by id_product";
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
            CategoryWindow catWin = new CategoryWindow();
            catWin.Show();
            this.Hide();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Hide();
        }

        private void FlowerWindow_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();
            FlowerComboBox.Items.Add("Цветы");
        }

        private void dgvDataNum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
