﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Store
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asha_Departmental_StoreDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.asha_Departmental_StoreDataSet.Sales);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Allview tt = new Allview();
            tt.ShowDialog();
        }
    }
}
