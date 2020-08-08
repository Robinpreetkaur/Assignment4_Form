/*
   Author's name: Robinpreet Kaur 
   Author’s student number: 301100296
   Date last Modified: 7 Aug ,2020
   Program description: 
       Generate a program in C# of BMICalculator in metric and imperial Units in forms .
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_Form
{
    public partial class BMIcalculatorForm : Form
    {
        public BMIcalculatorForm()
        {
            InitializeComponent();
        }

        private void MatricradioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        

        private void BMIlabel_Click(object sender, EventArgs e)
        {

        }

        private void myHeight_Click(object sender, EventArgs e)
        {

        }

        private void myWeight_click(object sender, EventArgs e)
        {

        }

        private void BMIcalculatorForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// On clicking calculate BMI button it will calculate the BMI according to unit selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIbutton_click(object sender, EventArgs e)
        { 
        double weight = Convert.ToDouble(WeightTextBox.Text);
        double height = Convert.ToDouble(HeightTextBox.Text);
        double bmi = 0.0;

            if (MetricRadioButton.Checked)
            {
                
                bmi = weight / (height * height);  
            }

            else if (ImperialRadioButton.Checked)
            {
             

                bmi = (703 * weight) / (height* height);

            }

            BMIresultTextbox.Text = Math.Round(bmi,3).ToString();
            CalculateBMItextBox.Text = BmiType(bmi);

        }
        /// <summary>
        /// It will return BMIType (Weight Category) according to the BMI Value
        /// </summary>
        /// <param name="bmi"></param>
        /// <returns></returns>
        private static string BmiType(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 & bmi <= 24.9)
            {
                return "Normal";
            }
            else if (bmi >= 25  & bmi <= 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }


        /// <summary>
        /// Reset the form on clicking the Reset Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            BMIresultTextbox.Text = "";
            CalculateBMItextBox.Text = "";


            ImperialRadioButton.Checked = false;
            MetricRadioButton.Checked = false;


        }

        private void ImperialradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
