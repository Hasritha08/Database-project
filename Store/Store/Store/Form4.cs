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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asha_Departmental_StoreDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.asha_Departmental_StoreDataSet.Product);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Allview ll= new Allview();
            ll.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
