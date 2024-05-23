using System;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
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

            CalculateTotalExpenses();
            ClearForm();
        }

        private void CalculateTotalExpenses()
        {
            decimal total = 0;
            foreach (ListViewItem item in lvExpenses.Items)
            {
                total += decimal.Parse(item.SubItems[1].Text, System.Globalization.NumberStyles.Currency);
            }
            lblTotalExpenses.Text = $"Total Expenses: {total:C}";
        }

        private void ClearForm()
        {
            txtExpenseName.Clear();
            txtAmount.Clear();
            dtpDate.Value = DateTime.Now;
        }
    }
}
