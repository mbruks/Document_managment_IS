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
    public partial class ReferencesWindow : Form
    {
        public ReferencesWindow()
        {
            InitializeComponent();
        }

        private void product_Click(object sender, EventArgs e)
        {
            CategoryWindow catWin = new CategoryWindow();
            catWin.Show();
            this.Hide();
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

        private void staff_Click(object sender, EventArgs e)
        {
            StaffWindow staffWin = new StaffWindow();
            staffWin.Show();
            this.Hide();
        }

        private void exsitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contractor_Click(object sender, EventArgs e)
        {
            SuppliersWindow suppWin = new SuppliersWindow();
            suppWin.Show();
            this.Hide();
        }
    }
}
