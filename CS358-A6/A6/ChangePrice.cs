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
    public partial class ChangePrice : Form
    {
        //data member/object of the class MetalRecycleShop
        DatabaseHelper dbHelper= new DatabaseHelper();
        int selectedProductId = 0;
        public ChangePrice()
        {
            InitializeComponent();
        }

        private void MetalRecycleShop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'metalRecycleDataSet1.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter1.Fill(this.metalRecycleDataSet1.Product);
            // TODO: This line of code loads data into the 'metalRecycleDataSet.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.metalRecycleDataSet.Product);

            //retrive the table and feed it to the DataGridView object.
            dbHelper.RetriveDataTable(@"SELECT * FROM Product");
            dataGridView1.DataSource = dbHelper.currentDataTable;//re

            comboBox1.DataSource = dbHelper.currentDataTable;
            comboBox1.DisplayMember = "EnglishName";
            comboBox1.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0) return;
            //1. find the index of the product
            int id = int.Parse(comboBox1.SelectedValue.ToString());
            selectedProductId = id;

            //2. get the product from the database
            string query = "select * from product where id='" + selectedProductId + "'";
            dbHelper.RetriveDataTable(query);

            if (dbHelper.currentDataTable == null)
            {
                MessageBox.Show("Not find the data" + query);
            }
            //3. display the data
            textBox1.Text = dbHelper.currentDataTable.Rows[0]["EnglishName"].ToString();
            textBox2.Text = dbHelper.currentDataTable.Rows[0]["ChineseName"].ToString();
            textBox3.Text = dbHelper.currentDataTable.Rows[0]["Price"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. construct the query command
            string query = "UPDATE product SET EnglishName='" + textBox1.Text 
                + "',ChineseName=N'" + textBox2.Text 
                + "',Price='"  + textBox3.Text.ToString() 
                + "' WHERE id='" + selectedProductId.ToString() + "' ";
            //2. update database
            dbHelper.update(query);

            //retrive the table and feed it to the DataGridView object.
            dbHelper.RetriveDataTable(@"SELECT * FROM Product");
            dataGridView1.DataSource = dbHelper.currentDataTable;//re
            comboBox1.DataSource = dbHelper.currentDataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1. construct the query command
            string query2 = $"insert into product values('{textBox1.Text}',N'{textBox2.Text}','{textBox3.Text.ToString()}')";
            //2. insert database
            dbHelper.insert(query2);

            //retrive the table and feed it to the DataGridView object.
            dbHelper.RetriveDataTable(@"SELECT * FROM Product");
            dataGridView1.DataSource = dbHelper.currentDataTable;//re
            comboBox1.DataSource = dbHelper.currentDataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1. construct the query command
            string query2 = $"delete product where id='{selectedProductId.ToString()}'";
            //2. delete database
            dbHelper.delete(query2);

            //retrive the table and feed it to the DataGridView object.
            dbHelper.RetriveDataTable(@"SELECT * FROM Product");
            dataGridView1.DataSource = dbHelper.currentDataTable;//re
            comboBox1.DataSource = dbHelper.currentDataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null || dataGridView1.CurrentCell.RowIndex < 0) return;
            //1. find the index of the product
            int rowID = dataGridView1.CurrentCell.RowIndex;
            selectedProductId = int.Parse(dataGridView1.Rows[rowID].Cells["Id"].Value.ToString());

            //2. get the product from the database
            string query = "select * from product where id='" + selectedProductId + "'";
            dbHelper.RetriveDataTable(query);

            if (dbHelper.currentDataTable == null)
            {
                MessageBox.Show("Not find the data" + query);
            }

            //3. display the data
            textBox1.Text = dbHelper.currentDataTable.Rows[0]["EnglishName"].ToString();
            textBox2.Text = dbHelper.currentDataTable.Rows[0]["ChineseName"].ToString();
            textBox3.Text = dbHelper.currentDataTable.Rows[0]["Price"].ToString();
        }
    }
}
