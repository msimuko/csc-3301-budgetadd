﻿using BudgetTracker;
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
    public partial class charts : Form
    {
        public charts()
        {
            InitializeComponent();
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
    }
}