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

        private void ImpericalradioButton_CheckedChanged(object sender, EventArgs e)
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

        private void CalculateBMIbutton_click(object sender, EventArgs e)
        { 
        double weight = Convert.ToDouble(WeightTextBox.Text);
        double height = Convert.ToDouble(HeightTextBox.Text);
        double bmi = 0.0;

            if (MetricRadioButton.Checked)
            {
                bmi = weight / (height* height);  
            }

            else if(ImpericalRadioButton.Checked)
            {

                bmi = (730 * weight) / (height* height);

            }

            BMIresultTextbox.Text = bmi.ToString();
            //CalculateBMITextBox.Text = BmiType(bmi);

        }
    }
}
