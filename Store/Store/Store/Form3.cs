using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asha_Departmental_StoreDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.asha_Departmental_StoreDataSet.Employee);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Allview tt = new Allview();
            tt.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Allview tt = new Allview();
            tt.ShowDialog();
        }
    }
}
