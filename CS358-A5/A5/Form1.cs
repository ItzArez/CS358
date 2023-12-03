using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5RecycleShop
{
    public partial class Form1 : Form
    {
        public Products products = new Products();
        //Products productsObject = new Products();
        string sReceipt = "";
        decimal dTotal = 0.0m;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            products.GetAllProducts();
            loadComboBox();
        }

        private void loadComboBox()
        {
            comboBox1.Items.Clear();
            foreach (Product p in products.Items)
            {
                comboBox1.Items.Add(p.EnglishName + ":$" + p.Price);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNetWeight.Text = calcuateNetWeight();
            if (tbNetWeight.Text == "") return;

        }

        private string calcuateNetWeight()
        {
            string sNetweight = "";
            double dBefore = tbBefore.Text == "" ? 0.0 : double.Parse(tbBefore.Text);
            double dAfter = tbAfter.Text == ""? 0.0: double.Parse(tbAfter.Text);
            double dSubstract = tbSubstract.Text == "" ? 0.0 : double.Parse (tbSubstract.Text);

            double dNet = dBefore - dAfter - dSubstract;
            if (dNet >=0.0)
            {
                sNetweight = dNet.ToString();
                tbNetWeight.Text = sNetweight;
            }
            
            return sNetweight;
        }

        private void createReceipt(Product selectedProduct, double netweight)
        {
            sReceipt = string.Format("{0}\n\r\t unitprice:{1:C2}\n\r\t netweight:{2}\n\r\t sub:{3:C2}\n\r",
                selectedProduct.EnglishName,
                selectedProduct.Price,
                netweight,
                selectedProduct.Price * (decimal)netweight);
            sReceipt += "\n\r-----------total\t\t$" + dTotal;
            
            tbReceipt.Text = sReceipt;
            btTotal.Text = dTotal.ToString();
        }

        private void btCalcuate_Click(object sender, EventArgs e)
        {
            //to-do
            calcuateNetWeight();
            //createReceipt();
            Product selectedProduct = (Product)products.Items[comboBox1.SelectedIndex];
            double netweight = double.Parse(tbNetWeight.Text);
            decimal cost = selectedProduct.Price * (decimal)netweight;
            dTotal += cost;
            tbReceipt.Text += sReceipt;
            createReceipt(selectedProduct, netweight);

        }

        private void btChangePrice_Click(object sender, EventArgs e)
        {
            ChangePrice changePriceForm = new ChangePrice(products);
            changePriceForm.ShowDialog();//domodal 
            this.loadComboBox();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void tbAfter_TextChanged(object sender, EventArgs e)
        {
            calcuateNetWeight();
        }

        private void tbSubstract_TextChanged(object sender, EventArgs e)
        {
            calcuateNetWeight();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            lbSaveTransaction.Items.Add(sReceipt);
            tbReceipt.Text = ""; // reset the recipet box
            sReceipt = ""; // reset recipet
            dTotal = 0.0m; // reset the cost so you can start a new order
        }
    }
}
