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
    public partial class CategoryWindow : Form
    {
        public CategoryWindow()
        {
            InitializeComponent();
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

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Hide();
        }

        private void flower_Click(object sender, EventArgs e)
        {
            FlowerWindow floWin = new FlowerWindow();
            floWin.Show();
            this.Hide();
        }

        private void present_Click(object sender, EventArgs e)
        {
            PostcardsWindow postWin = new PostcardsWindow();
            postWin.Show();
            this.Hide();
        }

        private void packaging_Click(object sender, EventArgs e)
        {
            PackegWindow pacWin = new PackegWindow();
            pacWin.Show();
            this.Hide();
        }

        private void other_Click(object sender, EventArgs e)
        {
            OtherWindow otherWin = new OtherWindow();
            otherWin.Show();
            this.Hide();
        }
    }
}
