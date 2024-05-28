using System;
using System.Drawing;

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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnCharts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExpenseName
            // 
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseName.Location = new System.Drawing.Point(20, 20);
            this.lblExpenseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpenseName.Name = "lblExpenseName";
            this.lblExpenseName.Size = new System.Drawing.Size(182, 27);
            this.lblExpenseName.TabIndex = 0;
            this.lblExpenseName.Text = "Expense Name:";
            // 
            // txtExpenseName
            // 
            this.txtExpenseName.Location = new System.Drawing.Point(210, 15);
            this.txtExpenseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpenseName.Name = "txtExpenseName";
            this.txtExpenseName.Size = new System.Drawing.Size(298, 26);
            this.txtExpenseName.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(20, 60);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(102, 27);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(210, 55);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(298, 26);
            this.txtAmount.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(20, 100);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 27);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(210, 95);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(298, 26);
            this.dtpDate.TabIndex = 5;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpense.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.ForeColor = System.Drawing.Color.White;
            this.btnAddExpense.Location = new System.Drawing.Point(141, 152);
            this.btnAddExpense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(316, 52);
            this.btnAddExpense.TabIndex = 6;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click_1);
            this.btnAddExpense.MouseEnter += new System.EventHandler(this.btnAddExpense_MouseEnter);
            this.btnAddExpense.MouseLeave += new System.EventHandler(this.btnAddExpense_MouseLeave);
            // 
            // lvExpenses
            // 
            this.lvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvExpenses.FullRowSelect = true;
            this.lvExpenses.HideSelection = false;
            this.lvExpenses.Location = new System.Drawing.Point(18, 214);
            this.lvExpenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvExpenses.Name = "lvExpenses";
            this.lvExpenses.Size = new System.Drawing.Size(599, 230);
            this.lvExpenses.TabIndex = 7;
            this.lvExpenses.UseCompatibleStateImageBehavior = false;
            this.lvExpenses.View = System.Windows.Forms.View.Details;
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpenses.Location = new System.Drawing.Point(20, 478);
            this.lblTotalExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(247, 27);
            this.lblTotalExpenses.TabIndex = 8;
            this.lblTotalExpenses.Text = "Total Expenses: $0.00";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(18, 552);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(435, 45);
            this.btnDashboard.TabIndex = 10;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnCharts
            // 
            this.btnCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharts.ForeColor = System.Drawing.Color.White;
            this.btnCharts.Location = new System.Drawing.Point(462, 552);
            this.btnCharts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(435, 45);
            this.btnCharts.TabIndex = 11;
            this.btnCharts.Text = "Charts";
            this.btnCharts.UseVisualStyleBackColor = false;
            this.btnCharts.Click += new System.EventHandler(this.btnCharts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 692);
            this.Controls.Add(this.btnCharts);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblTotalExpenses);
            this.Controls.Add(this.lvExpenses);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtExpenseName);
            this.Controls.Add(this.lblExpenseName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Budget Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void btnAddExpense_MouseLeave(object sender, EventArgs e)
        {
            btnAddExpense.BackColor = Color.LightGray; // Change the button's background color
        }

        private void btnAddExpense_MouseEnter(object sender, EventArgs e)
        {
            btnAddExpense.BackColor = Color.LightGray; // Change the button's background color
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
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCharts;
    }
}