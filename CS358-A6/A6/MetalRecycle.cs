using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch14_Database_Example_1
{
    public partial class MetalRecycle : Form
    {
        public MetalRecycle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1. construct the transaction object
            //to-do

            //2. put this transaction object into the list of transactions.

            //3. calculate the sub-total/total


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1. save the transactions in to the database

            //2. print the receipt
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //1. launch the change price form
            (new ChangePrice()).ShowDialog();

            //2. load the newdatabase in to the combo box. so you get the new prices.
        }
    }
}
