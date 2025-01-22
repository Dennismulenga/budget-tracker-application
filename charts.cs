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
using System.Windows.Forms.DataVisualization.Charting;

namespace DudgetTracker
{
    public partial class charts : Form
    {
        public int mincome { get; internal set; }
        public string bname { get; internal set; }

        public Chart Chart1 { get; }

        public charts()
        {
            InitializeComponent();
            Chart1 = chart1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cHARTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cREATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main form1 = new main();
            form1.Show();
            this.Hide();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void cREATEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            create create = new create();
            create.Show();
            this.Hide();
        }

        public void chart1_Click(object sender, EventArgs e)
        {

        }

        internal void chart1_Click()
        {

        }

        private void charts_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
