using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1_BFP_Calculator
{
    public partial class Form1 : Form
    {
        BMI bmiObject;
        BFP bfpObject;

        public Form1()
        {
            InitializeComponent();
            bfpObject = new BFP();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void calculateBFP(object sender, EventArgs e)
        {
            // Calculate BMI
            calculateBMI();
            showBMI();

            // calculate idealWeight
            int idealWeight = bmiObject.CalculateIdealWeight();
            tbIdealWeight.Text = "Ideal Weight: " + idealWeight.ToString();

            //calculate BFP
            calculateBFP();
        }

        void calculateBMI()
        {
            double weight = double.Parse(tbWeight.Text);
            int height_ft = int.Parse(tbHeightFt.Text);
            int height_in = int.Parse(tbHeightIn.Text);

            bmiObject = new BMI(weight, height_ft, height_in);

            bmiObject.Calculate();
        }
        void showBMI()
        {
            tbBMI.Text = "BMI: " + bmiObject.bmiValue.ToString();
        }
        
        void calculateBFP()
        {
            int age = int.Parse(tbAge.Text);
            double weight = double.Parse(tbWeight.Text);
            int height_ft = int.Parse(tbHeightFt.Text);
            int height_in = int.Parse(tbHeightIn.Text);

            double bfpResult = bfpObject.CalculateBFP(age, weight, height_ft, height_in);
            tbBFP.Text = "BFP: " + bfpResult.ToString() + "%";
        }
    }
}
