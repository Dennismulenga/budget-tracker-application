using BudgetTracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DudgetTracker
{
    public partial class create : Form
    {
        public create()
        {
            InitializeComponent();
        }

        private void cHARTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            charts chartForm = new charts();
            chartForm.Show();
            this.Hide();
        }

        private void cREATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main form1 = new main();
            form1.Show();
            this.Hide();
        }

        private void create_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            charts charts = new charts();
            charts.Show();
            Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
