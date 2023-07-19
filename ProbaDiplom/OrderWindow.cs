using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System.Xml;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Reflection.Metadata;
using System.Reflection;
using System.Xml.Linq;
using System.CodeDom;
using System.Security.Cryptography;
using System.Drawing;
using static System.Collections.Specialized.BitVector32;
using Xceed.Words.NET;

namespace ProbaDiplom
{
    public partial class OrderWindow : Form
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

        public OrderWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM public.order ";
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

        private void OrderWindow_Load(object sender, EventArgs e)
        {
            Location = new System.Drawing.Point(500, 300);
            conn = new NpgsqlConnection(connstring);
            Select();
        }

        private void exsitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Hide();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Hide();
        }

        private void dgvDataOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                numberButton.Text = dgvDataOrders.Rows[e.RowIndex].Cells["number"].Value.ToString();
                ProductcomboBox.Text = dgvDataOrders.Rows[e.RowIndex].Cells["product"].Value.ToString();
                KolvoButton.Text = dgvDataOrders.Rows[e.RowIndex].Cells["volume"].Value.ToString();
                PriceButton.Text = dgvDataOrders.Rows[e.RowIndex].Cells["cost_order"].Value.ToString();
                all_priceButton.Text = dgvDataOrders.Rows[e.RowIndex].Cells["all_cost"].Value.ToString();
            }
        }

        private void dgvDataOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    sql = @"SELECT * from order_insert(:_number, :_product, :_volume, :_cost_order, :_all_cost, :_date)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_number", numberButton.Text);
                    cmd.Parameters.AddWithValue("_product", ProductcomboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("_volume", int.Parse(KolvoButton.Text));
                    cmd.Parameters.AddWithValue("_cost_order", int.Parse(PriceButton.Text));
                    cmd.Parameters.AddWithValue("_all_cost", int.Parse(all_priceButton.Text));
                    cmd.Parameters.AddWithValue("_date", dateTimePicker.Value.Date);
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
                    sql = @"SELECT *  from order_update(:_id_order, :_number, :_product, :_volume, :_cost_order, :_all_cost, :_date)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_order", int.Parse(dgvDataOrders.Rows[rowIndex].Cells["id_order"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_number", numberButton.Text);
                    cmd.Parameters.AddWithValue("_product", ProductcomboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("_volume", int.Parse(KolvoButton.Text));
                    cmd.Parameters.AddWithValue("_cost_order", int.Parse(PriceButton.Text));
                    cmd.Parameters.AddWithValue("_all_cost", int.Parse(all_priceButton.Text));
                    cmd.Parameters.AddWithValue("_date", dateTimePicker.Value.Date);
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
                MessageBox.Show("Выберите сотрудника которого хотите удалить!");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from order_delete(:_id_order)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_order", int.Parse(dgvDataOrders.Rows[rowIndex].Cells["id_order"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Заказ удален!");
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SortedButton_Click(object sender, EventArgs e)
        {
            var FROMdate = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            var TOdate = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");

            try
            {
                conn.Open();
                sql = $"SELECT * FROM public.order WHERE date BETWEEN '{FROMdate}' AND '{TOdate}'";
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var search = SearchTextBox.Text;

            try
            {
                conn.Open();
                sql = $"SELECT * FROM public.order WHERE number = '{search}'";
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
                using (var cmd = new NpgsqlCommand($"SELECT COUNT(*) FROM public.order WHERE number = '{schet}'", conn))
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
                using (var cmd = new NpgsqlCommand($"SELECT SUM(all_cost) FROM public.order WHERE number = '{schet}'", conn))
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
                //NpgsqlCommand command = new NpgsqlCommand("SELECT number, kolvo, cost, all_cost FROM public.order WHERE number = '{schet}'", conn);
                //NpgsqlDataReader dr = command.ExecuteReader();
                command = $"SELECT name, volume, cost_order, all_cost FROM public.order FULL JOIN product ON public.order.product=product.id_product WHERE number = '{schet}'";
                /* Microsoft.Office.Interop.Word.Application winword =
                     new Microsoft.Office.Interop.Word.Application();

                 winword.Visible = false;

                 //Заголовок документа
                 winword.Documents.Application.Caption = "Товарный чек";
                 object missing = System.Reflection.Missing.Value;

                 //Создание нового документа
                 Microsoft.Office.Interop.Word.Document document =
                     winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);*/

                var datatable = new System.Data.DataTable();
                queryReturnData(command, datatable);
                ExportToWord(datatable);

                /*//добавление новой страницы
                //winword.Selection.InsertNewPage();              

                //Добавление текста со стилем Заголовок 1
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Заголовок 1";
                para1.Range.set_Style(styleHeading1);
                para1.Range.set_Style(styleHeading1);

                para1.Range.Text = "Товарный чек";
                para1.Range.InsertParagraphAfter();

                object styleHeading2 = "Заголовок 3";
                para1.Range.set_Style(styleHeading2);
                para1.Range.Text = "Заказ №" + NumberTextBox.Text;
                para1.Range.InsertParagraphAfter();

                var n = A();
;                //Создание таблицы 5х5
                Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para1.Range, n, 4, ref missing, ref missing);

                firstTable.Borders.Enable = 1;

                foreach (Row row in firstTable.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        //Заголовок таблицы
                        document.Tables[1].Cell(1, 1).Range.Text = "Название";
                        document.Tables[1].Cell(1, 2).Range.Text = "Количество";
                        document.Tables[1].Cell(1, 3).Range.Text = "Цена";
                        document.Tables[1].Cell(1, 4).Range.Text = "Стоимость";
                        //cell.Range.Text = "Название";
                        cell.Range.Font.Bold = 1;
                        //Задаем шрифт и размер текста
                        cell.Range.Font.Name = "verdana";
                        cell.Range.Font.Size = 10;
                        cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                        //Выравнивание текста в заголовках столбцов по центру
                        cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                        while (dr.Read())
                        {
                            for (int i = 1; i < n ; i++)
                            {
                                //Добавляем в таблицу строку.
                                firstTable.Rows.Add(ref missing);
                                //Обычно создают только строку с заголовками и одну пустую для данных.
                                firstTable.Rows[i + 1].Cells[1].Range.Text = dr[0].ToString();
                                firstTable.Rows[i + 1].Cells[2].Range.Text = dr[1].ToString();
                                firstTable.Rows[i + 1].Cells[3].Range.Text = dr[2].ToString();
                                firstTable.Rows[i + 1].Cells[4].Range.Text = dr[3].ToString();
                                firstTable.Rows[i + 1].Cells[5].Range.Text = dr[4].ToString();
                            }

                            dr.Close();
                        }
                    

                    *//* //Значения ячеек
                     else
                     {
                         cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
                     }*//*
                }
                }*/
                //winword.Visible = true;
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
                //object missing = System.Reflection.Missing.Value;
                //word.Application.Documents.Add(Type.Missing);
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);


                //Добавление текста со стилем Заголовок 1
                //Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Заголовок 1";
                para1.Range.set_Style(styleHeading1);
                para1.Range.set_Style(styleHeading1);
                para1.Range.Text = "Товарный чек";
                para1.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                //para1.Range.Text.Alignment = StringAlignment.Center;
                para1.Range.InsertParagraphAfter();

                object styleHeading2 = "Заголовок 3";
                para1.Range.set_Style(styleHeading2);
                para1.Range.Text = "Заказ №" + NumberTextBox.Text;
                para1.Range.InsertParagraphAfter();


                //Заголовок документа
                word.Documents.Application.Caption = "Товарный чек";
                //object missing = System.Reflection.Missing.Value;



                /*//Создание нового документа
                Microsoft.Office.Interop.Word.Document document =
                    word.Documents.Add(ref missing, ref missing, ref missing, ref missing); */

                /*//Добавление текста со стилем Заголовок 1
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Заголовок 1";
                para1.Range.set_Style(styleHeading1);
                para1.Range.set_Style(styleHeading1);

                para1.Range.Text = "Товарный чек";
                para1.Range.InsertParagraphAfter();

                object styleHeading2 = "Заголовок 3";
                para1.Range.set_Style(styleHeading2);
                para1.Range.Text = "Заказ №" + NumberTextBox.Text;
                para1.Range.InsertParagraphAfter();*/



                //Microsoft.Office.Interop.Word.Document document = word.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                Microsoft.Office.Interop.Word.Table table = document.Tables.Add(para1.Range, dataTable.Rows.Count + 1, dataTable.Columns.Count, Type.Missing, Type.Missing);
                //Microsoft.Office.Interop.Word.Document document = word.Documents.Add(ref missing, ref missing, ref missing, ref missing); 

                table.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;

                table.Cell(1, 1).Range.Text = "Название";
                table.Cell(1, 2).Range.Text = "Количество";
                table.Cell(1, 3).Range.Text = "Цена";
                table.Cell(1, 4).Range.Text = "Стоимость";
                /*table.Cell(1, 1).Range.Text = dataTable.Columns[1].ColumnName;
                table.Cell(1, 2).Range.Text = dataTable.Columns[1].ColumnName;
                table.Cell(1, 3).Range.Text = dataTable.Columns[1].ColumnName;
                table.Cell(1, 4).Range.Text = dataTable.Columns[1].ColumnName;*/


                /* for (int i = 0; i < dataTable.Columns.Count; i++)
                 {
                     table.Cell(1, i + 1).Range.Text = dataTable.Columns[i].ColumnName;
                 }*/

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        table.Cell(i + 2, j + 1).Range.Text = dataTable.Rows[i][j].ToString();
                    }
                }

                /*var schet = NumberTextBox.Text;

                string queryString = $"SELECT SUM(all_cost) FROM public.order WHERE number = '{schet}'";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new System.Data.DataTable();
                dt.Load(cmd.ExecuteReader());



                int commentAuthor;
                string columnName = dt.Columns[0].Caption;
                var n = A();
                if (n == n)
                {
                    commentAuthor = dt.Rows[n].Field<int>("all_cost");
                    n = n - 1;
                }
                //int commentAuthor = dt.Rows[n].Field<int>("all_cost");

                //DateTime commentDate = dt.Rows[0].Field<DateTime>("comment_date");

                conn.Close();*/


                /*var schet = NumberTextBox.Text;
                string queryString = $"SELECT SUM(all_cost) FROM public.order WHERE number = '{schet}'";

                NpgsqlCommand command = new NpgsqlCommand(queryString, connect.getConnection());
                string col1;
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    col1 = ((IDataRecord)reader[0]).ToString();
                    
                }*/

                /*var schet = NumberTextBox.Text;
                string queryString = $"SELECT SUM(all_cost) FROM public.order WHERE number = '{schet}'";

                using (NpgsqlConnection connection = new NpgsqlConnection(connstring))
                {
                    NpgsqlCommand command = new NpgsqlCommand(queryString, connection);
                    connection.Open();
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0}, {1}",
                                reader[0], reader[1]));
                        }
                    }
                }*/
                //var schet = NumberTextBox.Text;
                // NpgsqlConnection connection = new NpgsqlConnection(connstring);
                //NpgsqlCommand cmd = conn.CreateCommand();
                //cmd.CommandText = $"SELECT SUM(all_cost) FROM public.order WHERE number = '{schet}'";
                //string sqlCommand = new NpgsqlCommand($"SELECT SUM(all_cost) FROM public.order WHERE number = '{schet}'", connstring);

                //sqlCommand = new SqlCommand("SELECT Passwrd from ...", connect);
                //label1.text = sqlCommand.ExecuteScalar().ToString();
                //int result = sqlCommand.ExecuteScalar().ToString(); ;
                //conn.Close();

                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading4 = "Заголовок 3";
                para2.Range.set_Style(styleHeading4);
                para2.Range.set_Style(styleHeading4);

                /*var schet = NumberTextBox.Text;
                var data_order = @"SELECT date FROM public.order WHERE number = '{schet}'";
                cmd = new NpgsqlCommand(data_order, conn);
                int result = cmd.Value.Date.ToString("yyyy-MM-dd");*/


                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("dd-MM-yyyy");

                para2.Range.Text = "Итого: " + B();
                para2.Range.InsertParagraphAfter();

                object styleHeading5 = "Заголовок 3";
                para2.Range.set_Style(styleHeading5);
                para2.Range.Text = "Дата оформления заказа: " + sqlFormattedDate;
                para2.Range.InsertParagraphAfter();

                word.Visible = true;

            }
            else
            {
                MessageBox.Show("No data to export!");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }
    }
}
