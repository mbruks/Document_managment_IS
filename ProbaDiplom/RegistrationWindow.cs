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
    public partial class RegistrationWindow : Form
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegistrationWindow_Load(object sender, EventArgs e)
        {

        }

        private void exsitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm logWin = new LoginForm();
            logWin.Show();
            this.Hide();
        }
    }
}
