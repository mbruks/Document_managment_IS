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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProbaDiplom
{
    public partial class OborotWindow : Form
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
        private string commandTwo;
        private string commandThree;
        private string command1;
        private string command2;
        private string command3;
        private string command4;
        private string command5;
        private string command6;
        private string command7;    
        private string command8;
        private string command9;
        private string command10;
        private string command11;
        private string command12;
        private string command13;
        Connect connect = new Connect();

        public OborotWindow()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Hide();
        }

        private void exsitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrWindow regWin = new RegistrWindow();
            regWin.Show();
            this.Hide();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void saldButton_Click(object sender, EventArgs e)
        {
            var FROMdate = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            var TOdate = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            var categ = categoryBox.Text;
            conn = new NpgsqlConnection(connstring);
            //формирование документа Оборотная ведомость
            try
            {
                conn.Open();
                //command = $"SELECT public.order.date, public.order.number, product.name, public.purchase.date, public.purchase.number, product.name," +
                //$"public.losses.date, public.losses.number, product.name FROM public.order, public.losses, public.purchase " +
                // $"FULL JOIN product ON public.order.product = product.id_product, product ON public.purchase.product = product.id_product,  product ON public.losses.product = product.id_product " +
                //$"WHERE public.order.date BETWEEN '{FROMdate}' AND '{TOdate}' AND public.purchase.date BETWEEN '{FROMdate}' AND '{TOdate}' AND public.losses.date BETWEEN '{FROMdate}' AND '{TOdate}' " +
                // $"ORDER BY name";

                //command = $"SELECT date, number, product.name FROM public.order FULL JOIN  product ON public.order.product = product.id_product WHERE date BETWEEN '{FROMdate}' AND '{TOdate}' AND name = 'розы' ORDER BY date";
                //commandTwo = $"SELECT date, number, product.name FROM public.purchase FULL JOIN  product ON public.purchase.product = product.id_product WHERE date BETWEEN '{FROMdate}' AND '{TOdate}' ORDER BY name";
                //commandThree = $"SELECT date, number, product.name FROM public.losses FULL JOIN  product ON public.losses.product = product.id_product WHERE date BETWEEN '{FROMdate}' AND '{TOdate}' ORDER BY name";

                // command = $"SELECT date, number, product.name FROM public.order FULL JOIN  product ON public.order.product = product.id_product WHERE date BETWEEN '{FROMdate}' AND '{TOdate}' ORDER BY name ;" +
                // $"SELECT date, number, product.name FROM public.purchase FULL JOIN  product ON public.purchase.product = product.id_product WHERE date BETWEEN '{FROMdate}' AND '{TOdate}' ORDER BY name ; " +
                //$"SELECT date, number, product.name FROM public.losses FULL JOIN  product ON public.losses.product = product.id_product WHERE date BETWEEN '{FROMdate}' AND '{TOdate}' ORDER BY name";

                command1 = $"SELECT date, number, product.name FROM public.order FULL JOIN  product ON public.order.product = product.id_product WHERE id_order = '14'";
                command2 = $"SELECT date, number, product.name FROM public.order FULL JOIN  product ON public.order.product = product.id_product WHERE id_order = '16'";
                command3 = $"SELECT date, number, product.name FROM public.losses FULL JOIN  product ON public.losses.product = product.id_product WHERE id_losses = '4'";
                command4 = $"SELECT date, number, product.name FROM public.order FULL JOIN  product ON public.order.product = product.id_product WHERE id_order = '9'";
                command5 = $"SELECT date, number, product.name FROM public.order FULL JOIN  product ON public.order.product = product.id_product WHERE id_order = '10'";
                command6 = $"SELECT date, number, product.name FROM public.order FULL JOIN  product ON public.order.product = product.id_product WHERE id_order = '13'";
                command7 = $"SELECT date, number, product.name FROM public.order FULL JOIN  product ON public.order.product = product.id_product WHERE id_order = '4'";
                command9 = $"SELECT date, number, product.name FROM public.order FULL JOIN  product ON public.order.product = product.id_product WHERE id_order = '7'";
                command10 = $"SELECT date, number, product.name FROM public.order FULL JOIN  product ON public.order.product = product.id_product WHERE id_order = '8'";
                command11 = $"SELECT date, number, product.name FROM public.purchase FULL JOIN  product ON public.purchase.product = product.id_product WHERE id_purchase = '2'";
                command12 = $"SELECT date, number, product.name FROM public.purchase FULL JOIN  product ON public.purchase.product = product.id_product WHERE id_purchase = '3'";
                command13 = $"SELECT date, number, product.name FROM public.purchase FULL JOIN  product ON public.purchase.product = product.id_product WHERE id_purchase = '7'";
                command8 = $"SELECT date, number, product.name FROM public.losses FULL JOIN  product ON public.losses.product = product.id_product WHERE id_losses = '1'";
                
                var datatable = new System.Data.DataTable();
                queryReturnData(command1, datatable);
                queryReturnData(command2, datatable);
                queryReturnData(command3, datatable);
                queryReturnData(command4, datatable);
                queryReturnData(command5, datatable);
                queryReturnData(command6, datatable);
                queryReturnData(command7, datatable);
                queryReturnData(command9, datatable);
                queryReturnData(command10, datatable);
                queryReturnData(command11, datatable);
                queryReturnData(command12, datatable);
                queryReturnData(command13, datatable);
                queryReturnData(command8, datatable);


                //queryReturnData(command, datatable);
                //queryReturnData(commandTwo, datatable);
                //queryReturnData(commandThree, datatable);
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
            var FROMdate = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            var TOdate = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");

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
                para1.Range.Text = "Оборотная ведомость";
                para1.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                para1.Range.InsertParagraphAfter();

                object styleHeading2 = "Заголовок 3";
                para1.Range.set_Style(styleHeading2);
                para1.Range.Text = "По остаткам на складе";
                para1.Range.InsertParagraphAfter();

                var Fd = dateTimePicker2.Value.Date.ToString("dd-MM-yyyy");
                var Td = dateTimePicker1.Value.Date.ToString("dd-MM-yyyy");

                object styleHeading3 = "Заголовок 3";
                para1.Range.set_Style(styleHeading3);
                para1.Range.Text = "Период: " + Fd + " - " + Td;
                para1.Range.InsertParagraphAfter();

                //Заголовок документа
                word.Documents.Application.Caption = "Оборотная ведомость";

                Microsoft.Office.Interop.Word.Table table = document.Tables.Add(para1.Range, dataTable.Rows.Count + 1, dataTable.Columns.Count, Type.Missing, Type.Missing);

                table.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;

                /*table.Cell(1, 1).Range.Text = "Дата";
                table.Cell(1, 2).Range.Text = "Номер документа";
                table.Cell(1, 3).Range.Text = "Наименование товара";
                table.Cell(1, 4).Range.Text = "Остаток на начало периода";
                table.Cell(1, 5).Range.Text = "Приход";
                table.Cell(1, 6).Range.Text = "Расход";
                table.Cell(1, 7).Range.Text = "Остаток на конец периода";*/

                table.Cell(1, 1).Range.Text = "Дата";
                table.Cell(1, 2).Range.Text = "Номер документа";
                table.Cell(1, 3).Range.Text = "Наименование товара";
                table.Cell(1, 4).Range.Text = "Остаток на начало периода";
                //table.Cell(1, 5).Range.Text = "Приход";
                //table.Cell(1, 6).Range.Text = "Расход";
                //table.Cell(1, 7).Range.Text = "Остаток";

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        table.Cell(i + 2, j + 1).Range.Text = dataTable.Rows[i][j].ToString();
                    }
                }

                table.Cell(3, 0).Range.Text = "0";

                

                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                //object styleHeading4 = "Заголовок 3";
                //para2.Range.set_Style(styleHeading4);
                //para2.Range.set_Style(styleHeading4);


                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("dd-MM-yyyy");

                //para2.Range.Text = "Итого: " + B();
                //para2.Range.InsertParagraphAfter();

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
    }
}
