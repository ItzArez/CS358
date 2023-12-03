using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_BFP_Calculator
{
    internal class BMI
    {
        public const double BMI_CONST = 703;
        double dWeightLb;
        int iHeightFT;
        int iHeightIN;

        public double bmiValue { get; set; }
        public BMI(double weight, int height_ft, int height_in)

        {
            this.dWeightLb = weight;
            this.iHeightFT = height_ft;
            this.iHeightIN = height_in;
        }
        BMI(){}

        public double Calculate() {
            int height = this.iHeightFT * 12 + this.iHeightIN;
            bmiValue = (dWeightLb * BMI_CONST) / Math.Pow(height, 2.0);
            bmiValue = Math.Round(bmiValue, 2); 
            return bmiValue;
        }

        public int CalculateIdealWeight()
        {
            double idealBMI = 20;
            double height = this.iHeightFT * 12 + this.iHeightIN;
            int idealWeightLb = (int)((idealBMI * Math.Pow(height, 2)) / BMI_CONST);
            return idealWeightLb;
        }
    }
}
