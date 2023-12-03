using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A2SaladOrderingF23
{
    public partial class Form1 : Form
    {
        //order items to save the user's selection
        List<FoodItem> OrderItems = new List<FoodItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            //step 1: get the check box selections
            getMainFood();

            //step 2: get the radio button selections
            //to do....
            getSelectedSauce();

            //step 3: get the combo box selections            
            OrderItems.Add(fiSourceObject);
            //step 4: calculate total and list items in the listbox.
            calculateTotal();
        }

        private void calculateTotal()
        {
            decimal total = 0.0m;
            string displayString = "";
            string displayTotal = "";
            int cbNum = Int32.Parse(cbSource.Text);

            foreach (FoodItem fi in OrderItems)
            {
                total += fi.Total() + cbNum;
                string displayFood = string.Format("{0}", fi.Name);
                string displayPrice = string.Format("at {0:C}", fi.Price);
                displayTotal = string.Format("Totaling: {0:C}", total);

                // Concatenate the item information to the displayString
                displayString += displayFood + " " + displayPrice;
            }

            // Add the final displayString to lbDisplay
            lbDisplay.Items.Add(displayString);
            lbDisplay.Items.Add(displayTotal);

            // Update the total label
            label2.Text = string.Format("{0:C}", total);
        }

        public void getSelectedSauce()
        {
            string sauce = "";
            // loop to find the selected item in the sauce groupBox
            foreach (Control control in sauceCB.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    sauce = radioButton.Text;
                    break; // Exit the loop once a selected radio button is found
                }
            }
            lbDisplay.Items.Add($"Sauce Selected: {sauce}");
        }

        private void getMainFood()
        {
            //get the check box selection
            foreach (string s in clbMainFood.CheckedItems)
            {
                //lbDisplay.Items.Add(s);
                //parse the s and prepare the object of fooditem
                string[] foods = s.Split('$');
                FoodItem foodItemObject = new FoodItem();
                foodItemObject.Name = foods[0].Trim();
                foodItemObject.Price = decimal.Parse(foods[1].Trim());
                foodItemObject.Qty = 1;

                //insert items in the list OrderItems
                OrderItems.Add(foodItemObject);
            }
        }
        FoodItem fiSourceObject = new FoodItem();//data member
        private void cbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            //step 3: get the combo box selections
            int spoons = int.Parse(cbSource.SelectedItem.ToString());
            
            fiSourceObject.Qty = spoons;
            
        }
    }
}
