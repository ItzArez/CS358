using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1_BFP_Calculator
{
    internal class BFP
    {
        // BFP = 1.51 × BMI - 0.70 × Age + 1.4
        public int CalculateBFP(int age, double weight, int height_ft, int height_in)
        {
            // Create an instance of the BMI class
            BMI bmiObject = new BMI(weight, height_ft, height_in);

            // Calculate BMI
            double bmiValue = bmiObject.Calculate();

            // Calculate BFP using the formula
            int bfp = (int)(1.51 * bmiValue - 0.70 * age + 1.4);

            return bfp;
        }
    }
}