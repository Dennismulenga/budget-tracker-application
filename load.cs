using BudgetTracker;
using DudgetTracker;
using System;
using System.Windows.Forms;

namespace loadingpage
{
    public partial class load : Form
    {
        public load()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top -= 1;
            if(label1.Top <= 200)
            {
                timer1.Stop();
                timer2.Start();
            }
     
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            label1.Top += 1;
            if (label1.Top >= 250)
            {

                timer1.Start();
                timer2.Stop();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if(panel2.Width>=458)
            {
                timer3.Stop();

                main form1 = new main();
                form1.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
