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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exsitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void product_Click(object sender, EventArgs e)
        {
            ProductWindow prodWin = new ProductWindow();
            prodWin.Show();
            this.Hide();
        }

        private void order_Click(object sender, EventArgs e)
        {
            OrderWindow orderWin = new OrderWindow();
            orderWin.Show();
            this.Hide();
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            PurchaseWindow purWin = new PurchaseWindow();
            purWin.Show();
            this.Hide();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Hide();
        }

        private void references_Click_1(object sender, EventArgs e)
        {
            ReferencesWindow refWin = new ReferencesWindow();
            refWin.Show();
            this.Hide();
        }

        private void registr_Click(object sender, EventArgs e)
        {
            RegistrWindow regWin = new RegistrWindow();
            regWin.Show();
            this.Hide();
        }

        private void buttonLosses_Click(object sender, EventArgs e)
        {
            LossesWindow losWin = new LossesWindow();
            losWin.Show();
            this.Hide();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
