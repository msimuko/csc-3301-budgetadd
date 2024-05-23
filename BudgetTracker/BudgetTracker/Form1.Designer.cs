namespace BudgetTracker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblExpenseName = new System.Windows.Forms.Label();
            this.txtExpenseName = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.lvExpenses = new System.Windows.Forms.ListView();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExpenseName
            // 
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.Location = new System.Drawing.Point(13, 13);
            this.lblExpenseName.Name = "lblExpenseName";
            this.lblExpenseName.Size = new System.Drawing.Size(164, 25);
            this.lblExpenseName.TabIndex = 0;
            this.lblExpenseName.Text = "Expense Name:";
            // 
            // txtExpenseName
            // 
            this.txtExpenseName.Location = new System.Drawing.Point(105, 10);
            this.txtExpenseName.Name = "txtExpenseName";
            this.txtExpenseName.Size = new System.Drawing.Size(200, 31);
            this.txtExpenseName.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(13, 39);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(91, 25);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(105, 36);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 31);
            this.txtAmount.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 65);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 25);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(105, 62);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 31);
            this.dtpDate.TabIndex = 5;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(94, 99);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(211, 34);
            this.btnAddExpense.TabIndex = 6;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // lvExpenses
            // 
            this.lvExpenses.HideSelection = false;
            this.lvExpenses.Location = new System.Drawing.Point(12, 139);
            this.lvExpenses.Name = "lvExpenses";
            this.lvExpenses.Size = new System.Drawing.Size(400, 150);
            this.lvExpenses.TabIndex = 7;
            this.lvExpenses.UseCompatibleStateImageBehavior = false;
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Location = new System.Drawing.Point(13, 311);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(227, 25);
            this.lblTotalExpenses.TabIndex = 8;
            this.lblTotalExpenses.Text = "Total Expenses: $0.00";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(514, 483);
            this.Controls.Add(this.lblTotalExpenses);
            this.Controls.Add(this.lvExpenses);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtExpenseName);
            this.Controls.Add(this.lblExpenseName);
            this.Name = "Form1";
            this.Text = "Budget Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblExpenseName;
        private System.Windows.Forms.TextBox txtExpenseName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.ListView lvExpenses;
        private System.Windows.Forms.Label lblTotalExpenses;
    }
}
