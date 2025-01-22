using DudgetTracker;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace BudgetTracker
{
    public partial class main : Form
    {
        private charts chartsForm;
        private Chart chart1;
        //private string connectionString = "server=localhost;database=BudgetTrackerDB;user=root;password=DeNNis123;";

        public main()
        {
            InitializeComponent();
            InitializeListView();
            LoadExpenses();
        }
        public void SetChart(Chart chart)
        {
            this.chart1 = chart;
        }

        private void InitializeListView()
        {
            lvExpenses.Columns.Add("Expense Name", 150);
            lvExpenses.Columns.Add("Amount", 100);
            lvExpenses.Columns.Add("Date", 100);
            lvExpenses.View = View.Details;
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            string expenseName = txtExpenseName.Text;
            if (string.IsNullOrWhiteSpace(expenseName))
            {
                MessageBox.Show("Please enter an expense name.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            DateTime date = dtpDate.Value;

            string[] row = { expenseName, amount.ToString("C"), date.ToShortDateString() };
            ListViewItem listViewItem = new ListViewItem(row);
            lvExpenses.Items.Add(listViewItem);

            SaveExpenseToDatabase(expenseName, amount, date);
            CalculateTotalExpenses();
            ClearForm();
        }
        private void SaveExpenseToDatabase(string expenseName, decimal amount, DateTime date)
        {
            /*using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Expenses (ExpenseName, Amount, Date) VALUES (@ExpenseName, @Amount, @Date)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ExpenseName", expenseName);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.ExecuteNonQuery();
                }
            }*/
        }

        private void LoadExpenses()
        {
            lvExpenses.Items.Clear();

            /*using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ExpenseName, Amount, Date FROM Expenses";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string expenseName = reader.GetString("ExpenseName");
                        decimal amount = reader.GetDecimal("Amount");
                        DateTime date = reader.GetDateTime("Date");
                        string[] row = { expenseName, amount.ToString("C"), date.ToShortDateString() };
                        ListViewItem listViewItem = new ListViewItem(row);
                        lvExpenses.Items.Add(listViewItem);
                    }
                }
            }*/
            CalculateTotalExpenses();
        }


        private void CalculateTotalExpenses()
        {
            decimal total = 0;
            foreach (ListViewItem item in lvExpenses.Items)
            {
                total += decimal.Parse(((ListViewItem.ListViewSubItem)item.SubItems[1]).Text, System.Globalization.NumberStyles.Currency);

            }
            lblTotalExpenses.Text = $"Total Expenses: {total:C}";
        }

        private void ClearForm()
        {
            txtExpenseName.Clear();
            txtAmount.Clear();
            dtpDate.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ensure you have a valid series in your chart
            //if (chart.Series.Count == 0)
           // {
               // chart.Series.Add(new Series("Expenses"));
            //}

            // Clear existing points before adding new ones
            //chart.Series["Expenses"].Points.Clear();

            foreach (ListViewItem item in lvExpenses.Items)
            {
                string expenseName = item.SubItems[0].Text;
                decimal expenseAmount = decimal.Parse(item.SubItems[1].Text, System.Globalization.NumberStyles.Currency);
                //chart.Series["Expenses"].Points.AddXY(expenseName, expenseAmount);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddExpense_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void cHARTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the charts form
            chartsForm = new charts();

            // Ensure you have a valid series in your chart
            if (chartsForm.Chart1.Series.Count == 0)
            {
                chartsForm.Chart1.Series.Add(new Series("Expenses"));
            }

            // Clear existing points before adding new ones
            chartsForm.Chart1.Series["Expenses"].Points.Clear();

            // Iterate through expenses and add them to the chart in the charts form
            foreach (ListViewItem item in lvExpenses.Items)
            {
                string expenseName = item.SubItems[0].Text;
                decimal expenseAmount = decimal.Parse(item.SubItems[1].Text, System.Globalization.NumberStyles.Currency);
                chartsForm.Chart1.Series["Expenses"].Points.AddXY(expenseName, expenseAmount);
            }

            // Show the charts form
            chartsForm.Show();
            this.Hide(); // Hide the main form

            /*charts charts = new charts();

           // Ensure you have a valid series in your chart
            if (chart1.Series.Count == 0)
            {
                chart1.Series.Add(new Series("Expenses"));
            }

            // Clear existing points before adding new ones
            chart1.Series["Expenses"].Points.Clear();

            foreach (ListViewItem item in lvExpenses.Items)
            {
                string expenseName = item.SubItems[0].Text;
                decimal expenseAmount = decimal.Parse(item.SubItems[1].Text, System.Globalization.NumberStyles.Currency);
                chart1.Series["Expenses"].Points.AddXY(expenseName, expenseAmount);
            }

            charts chartForm = new charts();
            chartForm.Show();
            this.Hide();*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string expenseName = txtExpenseName.Text;
            if (string.IsNullOrWhiteSpace(expenseName))
            {
                MessageBox.Show("Please enter an expense name.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            DateTime date = dtpDate.Value;

            string[] row = { expenseName, amount.ToString("C"), date.ToShortDateString() };
            ListViewItem listViewItem = new ListViewItem(row);
            lvExpenses.Items.Add(listViewItem);

            CalculateTotalExpenses();
            ClearForm();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.modelDataSet.items);
            // TODO: This line of code loads data into the 'modelDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.modelDataSet.items);

        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void itemsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void lvExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cREATEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            create create = new create();
            create.Show();
            this.Hide();
        }

        private void lblExpenseName_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTotalExpenses_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
