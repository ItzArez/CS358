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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'metalRecycleDataSet3.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.metalRecycleDataSet3.Product);
            // TODO: This line of code loads data into the 'metalRecycleDataSet2.Product' table. You can move, or remove it, as needed.
            
            DatabaseHelper dbHelper = new DatabaseHelper();
            dbHelper.RetriveDataTable("select * from Product");
            dataGridView1.DataSource = dbHelper.currentDataTable;
            comboBox2.DataSource = dbHelper.currentDataTable;
            comboBox2.DisplayMember = "EnglishName";
            comboBox2.ValueMember = "EnglishName";
            //comboBox2.DataBind();
            comboBox2.Enabled = true;

            if (dbHelper.currentDataTable.Rows.Count > 0)
            {
                textBox1.Text = dbHelper.currentDataTable.Rows[0]["EnglishName"].ToString();
            }
        }
    }
}
