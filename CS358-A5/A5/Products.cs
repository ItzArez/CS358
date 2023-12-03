using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5RecycleShop
{
    public class Products
    {
        //data members
        string sProductFileName;//private
        public string sErrorMessage = "";
        private StreamReader sReader;//private data members
        public List<Product> Items = new List<Product>();//list object is a property

        //Constructor
        public Products(string filename = @".\Products.txt")
        {
            this.sProductFileName = filename;
        }
        public void GetAllProducts()
        {
            //step 0. check the file exists.
            if (!File.Exists(sProductFileName))
            {
                sErrorMessage = "the file does not exits:" + sProductFileName ;
                return;
            }
            //step 1. read all products
            try
            {
                //initialize the stream reader object
                sReader = new StreamReader(sProductFileName);

                while (!sReader.EndOfStream)
                {
                    //read a line
                    string sLine = sReader.ReadLine();
                    //step 2. parse every product line into id, englishname, chinese name and price
                    Product productObject = parseProduct(sLine);
                    if (productObject == null) continue;
                    //step 3. add the product into the products list
                    Items.Add(productObject);
                }
                sReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void WriteProductsToFile()
        {
            try
            {
                // Use StreamWriter to write to the file.
                int id = 0;
                using (StreamWriter writer = new StreamWriter(sProductFileName))
                {
                    foreach (Product p in Items)
                    {
                        string s = string.Format("{0},{1},{2},{3:C}",id++, p.EnglishName,
                            p.ChineseName, p.Price);
                        writer.WriteLine(s);
                    }
                }
                
                Console.WriteLine($"Values written to {sProductFileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private Product parseProduct(string sLine)
        {
            //to-do
            if (sLine == null || sLine.Length <= 0)
                return null;
            string[] sections = sLine.Split(',');
            Product productObject = new Product();
            productObject.Id = int.Parse(sections[0]);
            productObject.EnglishName = sections[1];
            productObject.ChineseName = sections[2];
            string price = sections[3].Replace('$',' ').Trim();
            productObject.Price = decimal.Parse(price);

            return productObject;
        }
    }
}
