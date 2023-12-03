using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5RecycleShop
{
    public partial class ChangePrice : Form
    {
        Products products;
        Product selectedProduct;
        public ChangePrice(Products productLists)
        {
            this.products = productLists;
            InitializeComponent();
        }

        private void ChangePrice_Load(object sender, EventArgs e)
        {
            //load the products in to the combolist
            foreach(Product p in products.Items)
            {
                cbProducts.Items.Add(p.EnglishName + ":$" + p.Price);
            }
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //identify the selected item.
            Product p = products.Items[cbProducts.SelectedIndex];
            this.selectedProduct = p;

            //get the name of the product
            tbEnglishName.Text = p.EnglishName;

            //get the price of the product
            tbPrice.Text = string.Format("{0:C}",p.Price);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //step 1. get the user's input 
            string name = tbEnglishName.Text;
            decimal price = decimal.Parse(tbPrice.Text, 
                NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint 
                | NumberStyles.AllowCurrencySymbol);

            //step 2. update the products list
            if (this.selectedProduct == null) return;
            this.selectedProduct.EnglishName = name;
            this.selectedProduct.Price = price;

            //step 3. write the new product list back to the textfile.
            writeBackFile();

            //step 4. reload the file into memory and combobox
            products.GetAllProducts();
            

            //step 5. close the form
            this.Close();
        }

        private void writeBackFile()
        {
            //to-do 
            this.products.WriteProductsToFile();
        }
    }
}
