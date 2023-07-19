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
    public partial class LossesWindow : Form
    {
        private string connstring = String.Format("Server={0};Port={1};" +
        "User Id={2};Password={3};Database={4};",
        "localhost", 5432, "postgres",
        "root", "flowers_db");

        private NpgsqlConnection conn;
        private string sql;
        private string sql2;
        private NpgsqlCommand cmd;
        private System.Data.DataTable dt;
        private int rowIndex = -1;
        private string command;
        Connect connect = new Connect();

        public LossesWindow()
        {
            InitializeComponent();
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM public.losses ";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new System.Data.DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvDataOrders.DataSource = null; // reset datagridiew
                dgvDataOrders.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void LossesWindow_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();
        }

        private void dgvDataOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                numberButton.Text = dgvDataOrders.Rows[e.RowIndex].Cells["number"].Value.ToString();
                ProductcomboBox.Text = dgvDataOrders.Rows[e.RowIndex].Cells["product"].Value.ToString();
                KolvoButton.Text = dgvDataOrders.Rows[e.RowIndex].Cells["volume"].Value.ToString();
                PriceButton.Text = dgvDataOrders.Rows[e.RowIndex].Cells["cost_loss"].Value.ToString();
                all_priceButton.Text = dgvDataOrders.Rows[e.RowIndex].Cells["all_cost"].Value.ToString();
            }
        }

        private void dgvDataOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Hide();
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            numberButton.Enabled = ProductcomboBox.Enabled = KolvoButton.Enabled = PriceButton.Enabled = all_priceButton.Enabled = dateTimePicker.Enabled = true;
            numberButton.Text = ProductcomboBox.Text = KolvoButton.Text = PriceButton.Text = all_priceButton.Text = dateTimePicker.Text = null;
            numberButton.Select();

            sql2 = @"SELECT * from product";
            System.Data.DataTable dt = new System.Data.DataTable("product");
            conn.Open();
            NpgsqlDataAdapter DA = new NpgsqlDataAdapter(sql2, conn);
            DA.Fill(dt);
            conn.Close();

            ProductcomboBox.DataSource = dt;
            ProductcomboBox.DisplayMember = "name";
            ProductcomboBox.ValueMember = "id_product";
        }

        private void safeButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0) // insert
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * from losses_insert(:_number, :_product, :_date, :_volume, :_cost_loss, :_all_cost)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_number", numberButton.Text);
                    cmd.Parameters.AddWithValue("_product", ProductcomboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("_date", dateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("_volume", int.Parse(KolvoButton.Text));
                    cmd.Parameters.AddWithValue("_cost_loss", int.Parse(PriceButton.Text));
                    cmd.Parameters.AddWithValue("_all_cost", int.Parse(all_priceButton.Text));
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
                    sql = @"SELECT *  from losses_update(:_id_losses, :_number, :_product, :_date, :_volume, :_cost_losses, :_all_cost)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_losses", int.Parse(dgvDataOrders.Rows[rowIndex].Cells["id_losses"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_number", numberButton.Text);
                    cmd.Parameters.AddWithValue("_product", ProductcomboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("_date", dateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("_volume", int.Parse(KolvoButton.Text));
                    cmd.Parameters.AddWithValue("_cost_loss", int.Parse(PriceButton.Text));
                    cmd.Parameters.AddWithValue("_all_cost", int.Parse(all_priceButton.Text));
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
            numberButton.Text = ProductcomboBox.Text = KolvoButton.Text = PriceButton.Text = all_priceButton.Text = dateTimePicker.Text = null;
            numberButton.Enabled = ProductcomboBox.Enabled = KolvoButton.Enabled = PriceButton.Enabled = all_priceButton.Enabled = dateTimePicker.Enabled = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Выберите документ который хотите удалить!");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from losses_delete(:_id_losses)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_losses", int.Parse(dgvDataOrders.Rows[rowIndex].Cells["id_losses"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Документ удален!");
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

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var search = SearchTextBox.Text;

            try
            {
                conn.Open();
                sql = $"SELECT * FROM public.losses WHERE number = '{search}'";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new System.Data.DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvDataOrders.DataSource = null; // reset datagridiew
                dgvDataOrders.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        public int A()
        {
            var schet = NumberTextBox.Text;

            using (var conn = new NpgsqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT COUNT(*) FROM public.losses WHERE number = '{schet}'", conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    return count;
                }
            }
        }

        public int B()
        {
            var schet = NumberTextBox.Text;

            using (var conn = new NpgsqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT SUM(all_cost) FROM public.losses WHERE number = '{schet}'", conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count;
                }
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                var schet = NumberTextBox.Text;
                conn.Open();
                command = $"SELECT name, volume, cost_loss, all_cost FROM public.losses FULL JOIN product ON public.losses.product = product.id_product WHERE number = '{schet}'";

                var datatable = new System.Data.DataTable();
                queryReturnData(command, datatable);
                ExportToWord(datatable);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public System.Data.DataTable queryReturnData(string command, System.Data.DataTable dataTable)
        {
            NpgsqlConnection myCon = new NpgsqlConnection(connstring);
            myCon.Open();
            NpgsqlDataAdapter SDA = new NpgsqlDataAdapter(command, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            SDA.Fill(dataTable);
            return dataTable;
        }


        private void ExportToWord(System.Data.DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                object missing = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document document = word.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);


                //Добавление текста со стилем Заголовок 1
                //Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Заголовок 1";
                para1.Range.set_Style(styleHeading1);
                para1.Range.set_Style(styleHeading1);
                para1.Range.Text = "Накладная на списание товаров";
                para1.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                para1.Range.InsertParagraphAfter();

                object styleHeading2 = "Заголовок 3";
                para1.Range.set_Style(styleHeading2);
                para1.Range.Text = "Документ №" + NumberTextBox.Text;
                para1.Range.InsertParagraphAfter();


                //Заголовок документа
                word.Documents.Application.Caption = "Накладная на списание товаров";

                Microsoft.Office.Interop.Word.Table table = document.Tables.Add(para1.Range, dataTable.Rows.Count + 1, dataTable.Columns.Count, Type.Missing, Type.Missing);

                table.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;

                table.Cell(1, 1).Range.Text = "Название";
                table.Cell(1, 2).Range.Text = "Количество";
                table.Cell(1, 3).Range.Text = "Цена";
                table.Cell(1, 4).Range.Text = "Стоимость";

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        table.Cell(i + 2, j + 1).Range.Text = dataTable.Rows[i][j].ToString();
                    }
                }

                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading4 = "Заголовок 3";
                para2.Range.set_Style(styleHeading4);
                para2.Range.set_Style(styleHeading4);


                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("dd-MM-yyyy");

                para2.Range.Text = "Итого: " + B();
                para2.Range.InsertParagraphAfter();

                object styleHeading5 = "Заголовок 3";
                para2.Range.set_Style(styleHeading5);
                para2.Range.Text = "Дата оформления накладной: " + sqlFormattedDate;
                para2.Range.InsertParagraphAfter();

                word.Visible = true;

            }
            else
            {
                MessageBox.Show("No data to export!");
            }
        }

        private void SortedButton_Click(object sender, EventArgs e)
        {
            var FROMdate = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            var TOdate = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");

            try
            {
                conn.Open();
                sql = $"SELECT * FROM public.losses WHERE date BETWEEN '{FROMdate}' AND '{TOdate}'";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new System.Data.DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvDataOrders.DataSource = null; // reset datagridiew
                dgvDataOrders.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void ProductcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
