using Microsoft.EntityFrameworkCore.Update.Internal;
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
    public partial class ProductWindow : Form
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


        public ProductWindow()
        {
            InitializeComponent();
        }


        private void exsitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM public.product order by id_product";
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

        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void dgvDataNum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                nameButton.Text = dgvDataNum.Rows[e.RowIndex].Cells["name"].Value.ToString();
                kolvoButton.Text = dgvDataNum.Rows[e.RowIndex].Cells["cost"].Value.ToString();
                costButton.Text = dgvDataNum.Rows[e.RowIndex].Cells["kolvo"].Value.ToString();
            }
        }

        private void safeButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0) // insert
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * from prod_insert(:_name, :_cost, :_kolvo)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_name", nameButton.Text);
                    cmd.Parameters.AddWithValue("_cost", int.Parse(costButton.Text));
                    cmd.Parameters.AddWithValue("_kolvo", int.Parse(kolvoButton.Text));
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
                    MessageBox.Show("Inserted fail. Error: " + ex.Message);
                }
            }
            else //update
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * from product_update(:_id_product, :_name, :_cost, :_kolvo)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_product", int.Parse(dgvDataNum.Rows[rowIndex].Cells["id_product"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_name", nameButton.Text);
                    cmd.Parameters.AddWithValue("_cost", int.Parse(costButton.Text));
                    cmd.Parameters.AddWithValue("_kolvo", int.Parse(kolvoButton.Text));
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
            nameButton.Text = kolvoButton.Text = costButton.Text = null;
            nameButton.Enabled = kolvoButton.Enabled = costButton.Enabled = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Please choose product to delete");
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
                    MessageBox.Show("Delete product successfully");
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
                MessageBox.Show("Deleted fail. Error: " + ex.Message);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Please choose product to update");
                return;
            }
            nameButton.Enabled = kolvoButton.Enabled = costButton.Enabled = true;
        }

        private void insertButton_Click_1(object sender, EventArgs e)
        {
            rowIndex = -1;
            nameButton.Enabled = kolvoButton.Enabled = costButton.Enabled = true;
            nameButton.Text = kolvoButton.Text = costButton.Text = null;
            nameButton.Select();


        }

        private void nameButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void exsitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferencesWindow refWin = new ReferencesWindow();
            refWin.Show();
            this.Hide();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
